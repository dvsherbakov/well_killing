using System;
using System.Collections.Generic;
using System.Linq;



namespace blank
{
    public class Calculate : object
    {//Основной расчет и параметры для него
        public double DinP;     //внутренний диаметр насосно-компрессорной трубы (НКТ) выбирается с панели
        public double DOutP;    //наружный диаметр насосно-компрессорной трубы (НКТ) выбирается с панели
        public double DinC;    //внутренний диаметр обсадной колонны выбирается с панели
        public double DOutC;    //внешний диаметр обсадной колонны выбирается с панели
        public double H;     //глубина 
        public double Hb;    //мощность пласта предположительно вводиться с панели
        public double Hhw;   //расстояние до циркуляционного отверстия по стволу
        public double Hhv;   //расстояние до циркуляционного отверстия по вертикали
        public double Hpw;   //расстояние до перфорации по стволу
        public double Hpv;   //расстояние до перфорации по вертикали
        public double K1;    //коэффициент шероховатости НКТ, Вводиться с панели
        public double K2;    //коэффициент шероховатости обсадной колонны Вводиться с панели
        public double K;     //проницаемость породы пласта - нигде не фигурирует?
        public double M;     //пористотсь породы пласта - нигде не фигурирует?
        public double Ks;    //коэфициент безопасности (по регламенту) выбирается с панели в процентах, использовать KS*0.01
        private double _lam10; //коэффициент потерь на трение в НКТ для нефти
        private double _lam20; //коэффициент потерь на трение в обсадной колонне для нефти
        private double _lam1;  //коэффициент потерь на трение в НКТ для раствора
        private double _lam2;  //коэффициент потерь на трение в обсадной колонне для раствора
        public double My0;   //динамическая вязкость пластовой жидкости (нефти)
        public double My;    //динамическая вязкость раствора
        public double P0;    //пластовое давление
        double _re10;  //число Рейнольдса для нефти в НКТ
        double _re20;  //число Рейнольдса для нефти в затрубном пространстве
        double _re1;   //число Рейнольдса для раствора в НКТ
        double _re2;   //число Рейнольдса для раствора в затрубном пространстве
        public double Ro0;   //плотность пластовой жидкости (нефти) вводиться с панели
        public double ROd;   //плотность жидкости долива
        public double Ro;    //плотность раствора
        public double S1;    //площадь сечения НКТ
        public double S2;    //площадь сечения затрубного пространства
        private double _tim1;  //время движения фронта вытеснения в НКТ
        private double _tim2;  //общее время движения фронта вытеснения
        private double _v1;    //скорость движения жидкости в НКТ
        private double _v2;    //скорость движения жидкости в затрубном пространстве
        public int N;     //число шагов по времени
        //int QN;    //число шагов по расходу
        //int _max;
       // private readonly double _waterPerent;//Процент воды в скважине
       // private readonly double _roOilAvg;//Средняя плотность нефти
       // private readonly double _roWater;//Плотность пластовой воды
        private bool _isWater; //Флаг, определяет что глушить водой в любом случае;

       public void SetWaterFlag(bool f)
        {
            _isWater = f;
        }

        private double RroD()
        { //Формула 1; Плотность жидкости долива
            ROd = (1.0 + 0.01 * Ks) * P0 / (9.81 * Hpv);
            //((P0 * 101.325) * (1 + (0.01*Ks))) / (9.81 * H);          
            return ROd;
        }

        private double RroG()
        {
            //плотность раствора
            Ro = (RroD() * (RSqOp() * Hhw + RSqNkt() * Hhw + Math.PI * Math.Pow(DinC / 2000.0, 2) * (H - Hhw)) -
                  Ro0 * Math.PI * Math.Pow(DinC / 2000.0, 2) * (H - Hhw)) / (RSqOp() * Hhw + RSqNkt() * Hhw);
            //(.ROd * (.S2 * Hhw +  S1 *    Hhw + Math.PI * Math.Pow(.DinC/2000.0, 2) * (H - Hhw)) - Ro0 * Math.PI * Math.Pow(DinC/2000.0, 2)*(H - Hhw)) / (rCalc.S2 * rCalc.Hhw + rCalc.S1 * rCalc.Hhw);
            return _isWater ? 1.0 : Ro;
        }

        private double RSqNkt()
        {
            //Площадь сечения НКТ Пи*(Д/2)^2; Д - перевести в метры 1м=1000мм
            S1 = Math.PI * Math.Pow(DinP / 1000, 2) / 4.0;
            return S1;
        }

/*
        public double RVnkt()
        {//Объем НКТ
            return H * RSqNkt();
        }
*/
        private double RSqOp()
        {
            //Площадь сечения затрубного пространства
            S2 = Math.PI * (Math.Pow(DinC / 1000.0, 2) - Math.Pow(DOutP / 1000.0, 2)) / 4.0;
            return S2;
        }

/*
        public double RVoutPipe()
        {//Объем затруба
            return H * RSqOp();
        }
*/

/*
        public double RvUnderAgregate()
        {//объем скважины под насосом
            return (H - Hhw) * RSqOp();
        }
*/
        private double RVnkt(double q)
        {//Скорость в НКТ V1; q - скорость расхода жидкости
            _v1 = q * 0.001 / RSqNkt();
            return _v1;
        }

        private double RvOp(double q)
        {//Скорость в затрубе V2
            _v2 = q * 0.001 / RSqOp();
            return _v2;
        }

        private double RRe10(double q)
        {
            //число Рейнольдса для ПЖ в НКТ RE10 Формула (14)
            _re10 = (Ro0 * RVnkt(q) * DinP * 1000.0) / My0;
            return _re10;
        }

        private double RRe20(double q)
        {
            //число Рейнольдса для ПЖ в затрубном пространстве. Формула (17)
            _re20 = (Ro0 * RvOp(q) * (DinC - DOutP) * 1000.0) / My0;
            return _re20;
        }

        private double RRe1(double q)
        {
            // Формула (12) число Рейнольдса для ЖГ в НКТ
            _re1 = RroG() * RVnkt(q) * DinP * 1000 / My;
            return _re1;
        }

        private double RRe2(double q)
        {
            //Формула (21) число Рейнольдса для раствора в затрубном пространстве
            _re2 = RroG() * RvOp(q) * (DinC - DOutP) * 1000 / My;
            return _re2;
        }

        private double RLam10(double q)
        {
            //Формула (13) коэффициент гидравлического сопротивления в НКТ для пластовой жидкости (ПЖ)
            _lam10 = 0.11 * Math.Sqrt(Math.Sqrt(K1 / DinP + 68.5 / RRe10(q)));
            return _lam10;
        }

        private double RLam20(double q)
        {
            //Формула (16) коэффициент гидравлического сопротивления в обсадной колонне для ПЖ
            _lam20 = 0.11 * Math.Sqrt(Math.Sqrt(K2 / (DinC - DOutP) + 68.5 / RRe20(q)));
            return _lam20;
        }

        private double RLam1(double q)
        {
            //Формула (11) коэффициент гидравлического сопротивления в НКТ для жидкости глушения (ЖГ)
            _lam1 = 0.11 * Math.Sqrt(Math.Sqrt(K1 / DinP + 68.5 / RRe1(q)));
            return _lam1;
        }

        private double RLam2(double q)
        {
            //Формула 10 коэффициент гидравлического сопротивления в обсадной колонне для ЖГ
            _lam2 = 0.11 * Math.Sqrt(Math.Sqrt(K2 / (DinC - DOutP) + 68.5 / RRe2(q)));
            return _lam2;
        }

        private double RTim1(double q)
        {
            //Формула (6) время движения фронта вытеснения в НКТ (до забоя)
            _tim1 = Hhw * RSqNkt() * 1000.0 / q;
            return _tim1;
        }

        private double RTim2(double q)
        {
            //Формула (9) общее время движения фронта вытеснения (конец прокачки ЖГ)
            _tim2 = RTim1(q) + Hhw * RSqOp() * 1000.0 / q;
            return _tim2;
        }

/*
        public double RPressureZb()
        {
            return P0 * Ks * 0.01 + P0;
        }
*/

/*
        public int RCycleCount()
        {
            return (int)Math.Round((Hpv - Hhv)/Hhv, 0) + 1;
        }
*/

/*
        public double RRoFluidOvg()
        {
            return _roOilAvg*(100 - _waterPerent)/100 + _roWater*_waterPerent/100;
        }
*/
        private IEnumerable<ResItem> ForwardFlow(double q)
        {//Прямой поток
            if (N == 0) N = 100;

            // _max = 0;
            var ls = new List<ResItem>();

            for (var i = 1; i <= N; i++)
            {
                var tim = (i - 1) * RTim2(q) / N;

                if (tim <= RTim1(q))
                {
                    var tz = RVnkt(q) * tim;
                    if (tz < 0) tz = 0;
                    var tp1 = Math.Pow(RVnkt(q), 2) * 10 * (RLam1(q) * RroG() * tz + RLam10(q) * (Hhw - tz) * Ro0) / (2 * DinP * 1.01325);
                    var tp2 = Math.Pow(RvOp(q), 2) * RLam20(q) * Hhw * Ro0 * 10 / (2 * (DinC - DOutP) * 1.01325);
                    if ((tp1>=0)&&(tp2>=0)) 
                        ls.Add(new ResItem(tp1, tp2));
                }
                else
                {
                    var tz = Hhw - RvOp(q) * (tim - RTim1(q));
                    if (tz < 0) tz = 0;
                    var tp1 = Math.Pow(RVnkt(q), 2) * RLam1(q) * Hhw * RroG() * 10 / (2 * DinP * 1.01325);
                    var tp2 = Math.Pow(RvOp(q), 2) * 10 * (RLam2(q) * (Hhw - tz) * RroG() + RLam20(q) * Ro0 * tz) / (2 * (DinC - DOutP) * 1.01325);
                    if ((tp1 >= 0) && (tp2 >= 0))
                        ls.Add(new ResItem(tp1, tp2));
                }
                if (tim > RTim2(q))
                    break;
                //_max=i;
            }

            return ls;
        }

        private IEnumerable<ResItem> Reverse_Flow(double q)
        {//Обратный поток
            var ls = new List<ResItem>();
            //_max = 0;

            for (var i = 1; i <= N; i++)
            {
                var tim = (i - 1) * RTim2(q) / N;

                if (tim <= RTim1(q))
                {
                    var tz = RvOp(q) * tim;
                    if (tz < 0) tz = 0;
                    var tp1 = Math.Pow(RVnkt(q), 2) * RLam10(q) * Hhw * Ro0 * 10.0 / (2 * DinP * 1.01325);
                    var tp2 = Math.Pow(RvOp(q), 2) * 10.0 * (RLam2(q) * RroG() * tz + RLam20(q) * (Hhw - tz) * Ro0) / (2 * (DinC - DOutP) * 1.01325);
                    //p3[i] = p1[i] + p2[i];
                    if ((tp1 >= 0) && (tp2 >= 0)) 
                        ls.Add(new ResItem(tp1, tp2)); 
                }
                else
                {
                    var tz = Hhw - RVnkt(q) * (tim - RTim1(q));
                    if (tz < 0) tz = 0;
                    var tp1 = Math.Pow(RVnkt(q), 2) * 10 * (RLam1(q) * (Hhw - tz) * RroG() + RLam10(q) * Ro0 * tz) / (2 * DinP * 1.01325);
                    var tp2 = Math.Pow(RvOp(q), 2) * RLam2(q) * Hhw * RroG() * 10 / (2 * (DinC - DOutP) * 1.01325);
                    //p3[i] = p1[i] + p2[i];
                    if ((tp1 >= 0) && (tp2 >= 0)) 
                        ls.Add(new ResItem(tp1, tp2));
                }
                if (tim > RTim2(q)) break;
                //_max=i;
            }
            return ls;
        }

        public CalcResult StartCalc()
        {
            //Q - скорость прокачки(насколькоя понимаю), переменная, максимум 12.1 л.с, откуда такое число - не знаю
            //QN = 0;
            //var res = new List<ResItem>();
            var qqList = new CalcResult();
            for (double q = 1; q <= 12.1; q=q + 0.1)
            {
                //QN++;
                //qqList.Add(q);

                var pAvgF = ForwardFlow(q);
                var pAvgR = Reverse_Flow(q);
                var p2 = pAvgF.Select(x => x.P2).Average();
                var p1 = pAvgR.Select(x => x.P1).Average();
               
                var d2 = Math.Sqrt((RTim2(q) - RTim1(q)) * p2 * (K / 1000) / (M * My));
                var d1 = Math.Sqrt((RTim2(q) - RTim1(q)) * p1 * (K / 1000) / (M * My));

                var vf = Math.PI * Hb * M * (Math.Pow(DOutC / 2 + d2 / 100, 2) - Math.Pow(DOutC / 2, 2));
                var vr = Math.PI * Hb * M * (Math.Pow(DOutC / 2 + d1 / 100, 2) - Math.Pow(DOutC / 2, 2));
               
                // res.Add(new ResItem(p1,p2));
                qqList.CLst.Add(new ChartItem(p1, p2, q, vf, vr));
            }
            return qqList;
        }
    }//Calculate

    public class CalcRes : object
    {
        public Geomrthey GColumn;
        public double DColumnLenght;
        public double DColumnHeight;
        public double DAdaptorLenght;
        public Geomrthey GTail;
        public double DTailLenght;
        public double DTailHeight;
        public string SEquipment;
        public Geomrthey GLowerHanger;
        public double DLowerHanger;
        public double DLowerHangerHeight;
        public Geomrthey GUpperHanger;
        public double DUpperHanger;
        public double DUpperHangerHeight;
        public double DStratumPressure;
        public double DOrifice;
        public string SGasFactor;
        public double DCirculationHole;
        public double DCirculationHoleHeight;
        public double DSafetyFactor;
        public double DUpPerforationLenht;
        public double DUpPerforationHeight;
        public double DBottomPerforationLenght;
        public double DBottomPerforationHeight;
        public double DCurrentStall;
        public double DFactitiousStall;
        public double DOnAssayDensity;
        public double DUsedDensity;
        public double DStratumFluidDensity;
        public double DPumpInning;
        public double DLevelingSpeed;
        public double DPumpPressure;
        public double DNktPressure;
        public double DAnnulusPressure;
        public string OilFieldName;
        public string WellNumber;
        public string ClusterName;
        public string ServiceCompany;
        public string Brigade;
        public string Master;

        private static double Volume(double diam, double len)
        {
            return Math.PI*(Math.Pow(diam, 2)/4)*len;
        }
        private void Normalize()
        {
            if (DCirculationHole > DUpperHanger + DLowerHanger)
                DCirculationHole = DUpperHanger + DLowerHanger;
            if (DCurrentStall < DCirculationHole) DCirculationHole = DCurrentStall;
            if (!(DCurrentStall < DColumnLenght + DTailLenght)) return;
            if (DCurrentStall < DColumnLenght)
            {
                DColumnLenght = DCurrentStall;
                DTailLenght = 0;
            }
            else
            {
                DTailLenght = DCurrentStall - DColumnLenght;
            }
        }

        private int SelectVar()
        {//Выбор варианта расположения труб и отверстия (есть рисунок отображающий 8 вариантов)
            if (DColumnLenght > DUpperHanger + DLowerHanger)
                return DUpperHanger > DCirculationHole ? 1 : 2;
            if ((DUpperHanger < DColumnLenght) && (DColumnLenght < DUpperHanger + DLowerHanger))
                if (DUpperHanger > DCirculationHole) return 3;
                else if (DCirculationHole > DColumnLenght) return 5;
                else if (DCirculationHole > DUpperHanger) return 4;
            if (!(DUpperHanger > DColumnLenght)) return -1;
            if (DCirculationHole < DColumnLenght) return 6;
            return DCirculationHole < DUpperHanger ? 7 : 8;
        }

        public double ROutPipeVol()
        {//Объем затруба (до циркуляционного отверстия)
            double res;
            Normalize();
            var x = SelectVar();
            switch (x)
            {
                case 1:
                case 3:
                case 6:
                    res = Volume(GColumn.Din / 1000, DCirculationHole) - Volume(GUpperHanger.Dout / 1000, DCirculationHole);
                    return res;
                case 2:
                case 4:
                    res = Volume(GColumn.Din / 1000, DCirculationHole) - Volume(GUpperHanger.Dout / 1000, DUpperHanger) -
                          Volume(GLowerHanger.Dout / 1000, DCirculationHole - DUpperHanger);
                    return res;
                case 5:
                case 8:
                    res = Volume(GColumn.Din / 1000, DColumnLenght) + Volume(GTail.Din / 1000, DCirculationHole - DColumnLenght)
                          - Volume(GUpperHanger.Dout / 1000, DUpperHanger)
                          - Volume(GLowerHanger.Dout / 1000, DCirculationHole - DUpperHanger);
                    return res;
                case 7:
                    res = Volume(GColumn.Din / 1000, DColumnLenght) + Volume(GTail.Din / 1000, DCirculationHole - DColumnLenght)
                          - Volume(GUpperHanger.Dout / 1000, DCirculationHole);
                    return res;
                default:
                    res = Volume(GColumn.Din / 1000, DColumnLenght) + Volume(GTail.Din / 1000, DTailLenght)
                          - Volume(GUpperHanger.Dout / 1000, DUpperHanger)
                          - Volume(GLowerHanger.Dout / 1000, DLowerHanger);
                    return res;

            }
        }

        public double RUnderPumpVol()
        {//Объем под насосом
            var res = RColumnVol() - RnktVol() - ROutPipeVol();
            return res;
        }

        private double RFreeVol(double h)
        {//Произвольный объем
            if (DUpPerforationLenht < DColumnLenght)
            {
                return Volume(GColumn.Din/1000, h);
            }
            return Volume(GColumn.Din, DColumnLenght) + Volume(GTail.Din, DUpPerforationLenht - DColumnLenght);
        }

        public double RVolFuncJam(double j)
        {//Объем с произвольной 
            var relPress = RJamDensity()*9.80665*DUpPerforationHeight;
            var h = relPress/(9.80665*j);
            return RFreeVol(h);
        }

        public double RJamFluidVol()
        {
            double res;
            var x = SelectVar();
            switch (x)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 6:
                    res = Volume(GColumn.Din / 1000, DUpPerforationLenht);
                    return res;
                case 5:
                case 7:
                case 8:
                    res = Volume(GColumn.Din/1000, DColumnLenght) +
                          Volume(GTail.Din / 1000, DColumnLenght+DTailLenght-DUpPerforationLenht);
                    return res;
                default :
                    return RColumnVol();
            }
        }

        public double RJamFluidStockVol()
        {
            return RJamFluidVol()*0.1;
        }

        public double RJamFluidFullVol()
        {
            return RJamFluidVol()*1.1;
        }

        public double RColumnVol()
        {//Объем колонны
            double res;
            if ((DCurrentStall <= 0) || (DCurrentStall >= DColumnLenght + DTailLenght))
            {
                res = Math.PI*Math.Pow(GColumn.Din/1000/2, 2)*DColumnLenght +
                      Math.PI*Math.Pow(GTail.Din/1000/2, 2)*DTailLenght;
                return res;
            }
            if (DCurrentStall < DColumnLenght)
            {
                res = Math.PI*Math.Pow(GColumn.Din/1000/2, 2)*DCurrentStall;
                return res;
            }
            res = Math.PI * Math.Pow(GColumn.Din / 1000 / 2, 2) * DColumnLenght +
                      Math.PI * Math.Pow(GTail.Din / 1000 / 2, 2) * DTailLenght;
            return res;
        }

        public double RnktVol()
        {//Объем НКТ
            double res;
            if ((DCirculationHole <= 0) || (DCirculationHole > DLowerHanger + DUpperHanger))
            {
                res = Math.PI*Math.Pow(GUpperHanger.Din/1000/2, 2)*DUpperHanger +
                      Math.PI*Math.Pow(GLowerHanger.Din/1000/2, 2)*DLowerHanger;
                return res;
            }
            if (DCirculationHole < DUpperHanger)
            {
                res = Math.PI*Math.Pow(GUpperHanger.Din/1000/2, 2)*DCirculationHole;
                return res;
            }

            res = Math.PI*Math.Pow(GUpperHanger.Din/1000/2, 2)*DUpperHanger +
                  Math.PI*Math.Pow(GLowerHanger.Din/1000/2, 2)*(DCirculationHole - DUpperHanger);
            return res;
        }

        public double RDensityPutFluid()
        {
            //Плотность жидкости долива
            var res = (1 + 0.01*DSafetyFactor)*(DStratumPressure/(9.80665*DUpPerforationHeight));
            return res > 1000 ? res : 1000;
        }

        public double RJamDensity()
        {//Плотность жидкости глушения
            //(rCalc.ROd * (rCalc.S2 * rCalc.Hhw + rCalc.S1 * rCalc.Hhw + Math.PI * Math.Pow(rCalc.DinC / 2000.0, 2) * (rCalc.H - rCalc.Hhw)) - rCalc.Ro0 * Math.PI * Math.Pow(rCalc.DinC / 2000.0,2) * (rCalc.H - rCalc.Hhw)) / (rCalc.S2 * rCalc.Hhw + rCalc.S1 * rCalc.Hhw)
            var res = (RDensityPutFluid()*(RUnderPumpVol() + (ROutPipeVol() + RnktVol())) - DStratumFluidDensity*RUnderPumpVol())/(ROutPipeVol() + RnktVol());
            return res > 1000 ? res : 1000;
        }

        public int RCiclesCount()
        {
            //Количество циклов
            // return (int)Math.Ceiling(RColumnVol()/RUnderPumpVol());
            return (int) Math.Ceiling(DCirculationHoleHeight/DUpPerforationHeight);
        }
        public int RNktInnigStep()
        {//Число ходов насоса, прокачка НКТ
            var res = (int) Math.Ceiling(RnktVol()/DPumpInning);
            return res;
        }

        public int RNktInnerTime()
        {//Время прокачки НКТ, С
            var res = (int) Math.Ceiling(RNktInnigStep()/DLevelingSpeed);
            return res;
        }

        public int ROutPipeInningStep()
        {
            var res = (int) Math.Ceiling(ROutPipeVol()/DPumpInning);
            return res;
        }

        public int ROutPipeInnerTime()
        {
            var res = (int)Math.Ceiling(ROutPipeInningStep() / DLevelingSpeed);
            return res;
        }

        public double RKcd()
        {
            var res = RJamDensity()/DUsedDensity*DPumpPressure;
            return res;
        }

        public double RReducePerStep()
        {
            var res = (DPumpPressure + DNktPressure - RKcd())*100/RNktInnigStep();
            return res;
        }

        public IEnumerable<PumpChartItem> RChartTable()
        {
            var ncd = DPumpPressure + DNktPressure;
            var kcd = RKcd();
            var reduce = RReducePerStep();
            var stepLimit = RNktInnigStep()+ROutPipeInningStep();
            var currentStep = 0;
            var currentPressure=ncd;
            var res = new List<PumpChartItem>();

            while (currentStep*100 < stepLimit)
            {
                res.Add(new PumpChartItem(currentStep*100, currentPressure/101325));
                currentStep ++;
                currentPressure = ncd - currentStep*reduce;
                if (currentPressure < kcd)
                    currentPressure = kcd;

            }
            return res;
        }
    }

}