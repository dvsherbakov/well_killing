
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Point = System.Drawing.Point;


//using blank.Annotations;

namespace blank
{
    public class CGeomethry
    {//Класс для хранения в конфиге параметры геометрии труб
        public int Index;
        public double Dout;
        public double W;
        public int Type;
    }

    public class CBedType
    {//Класс для хранения в конфиге параметров месторождений
        public int Index;
        public double K;
        public double M;
    }
    public class ConfData : object
    {//Класс конфигурационной информации
        public string LastPath;
        public string LastReportPath;
        public string LastFileName;
        public string TrenagerPath;
        public List<CGeomethry> Pipes;
        public List<CGeomethry> Columns;
        public List<CBedType> BedTypes;
        public List<CoastItem> Coast;
    }

    public class StoreData
    {
//Класс сохранения иноформации о расчете
        //Основное
        public string OilFiledName;
        public string WellNumber;
        public string ClusterName;
        public string ServiceCompany;
        public string Brigade;
        public string Master;
        //Колонна
        public int ColumnGeomethry;
        public string ColumnLenght;
        public int ColumnLenghtU;
        public string ColumnHeight;
        public int ColumnHeightU;
        public string AdaptorLenght;
        public int AdaptorLenghtU;
        //Хвостовик
        public int ColumnTail;
        public string ColumnTailLenght;
        public int ColumnTailLenghtU;
        public string ColumnTailHeight;
        public int ColumnTailHeightU;
        //Оборудование
        public int EquipmentType;
        //Нижняя подвеска
        public int LowerHanger;
        public string LowerHangerLenght;
        public int LowerHangerLenghtU;
        public string LowerHangerHeight;
        public int LowerHangerHeightU;
        //Верхняя подвеска
        public int PipeGeomethry;
        public string UpperHangerLenght;
        public int UpperHangerLenghtU;
        public string UpperHangerHeight;
        public int UpperHangerHeightU;
        //Циркуляционное отверстие
        public bool CirculationHolePresent;
        public string HolePositionByPipe;
        public int CirculationLenghtU;
        public string HolePositionVertical;
        public int CirculationHeightU;
        //Давление
        public string BedPressure;
        public int StratumPressureU;
        public string Orifice;
        public int OrificeU;
        public int GasFactor;
        public string SaturationPressure;
        public int SaturationPressureU;
        //Перфорация
        public string PerforationDistanceByPipe;
        public int UpPerforationLenghtU;
        public string PerforationDistanceByVertical;
        public int UpPerforationHeightU;
        public string BottomPerforationLenght;
        public int BottomPerforationLenghtU;
        public string BottomPerforationHeight;
        public int BottomPerforationHeightU;
        //Забой
        public string WellBottomDepth;
        public int CurrentStallU;
        public string FactitiousStall;
        public int FactitiousStallU;
        //Плотности
        public string OnAssayDensity;
        public int OnAssayDensityU;
        public string UsedDensity;
        public int UsedDensityU;
        //Данные насоса
        public int DoubleStep;
        public int PistonDiam;
        public string LevelingSpeed;
        public int LevelingSpeedU;
        public string PumpSupply;
        public int PumpSupplyU;
        public string PumpPressure;
        public int PumpPressureU;
        //Данные о притоке
        public string NktPressure;
        public int NktPressureU;
        public string AnnulusPressure;
        public int AnnulusPressureU;
        //Параметры жидкостей
        public string DensityBl;
        public int DensityUnitBl;
        public string DynViscosityBl;
        public int DynViscosityUnitBl;
        public string DynViscosityCl;
        public int DynViscosityUnitCl;
        //Данные скважины
        public int Unevenness;
        public int SafetyFactor;
        //Параметры пласта
        public string BedThickness;
        public int BedType;
        public int BedPressureUnit;
        //Размерности результативных параметров
        public int ResDensityPutFluidU;
        public int ResJamDensityU;
        public int ResInnerTimeU;
        public int ResOutPipeInningTimeU;
        public int ResClearingInningTimeU;
        public int ResNcdu;
        public int ResKcdu;
        public int ResReducing100U;
        //конфигурация скважины
        public List<CGeomElem> PipeConfList;
    }

    public class CGeomElem : object
    {
        public int Lenght;
        public int Height;
    }

    public class Geomrthey : object
    { //Объект для параметров трубы
        // private int Index { get; set; }
        public double Dout { get; private set; }//Внешний диаметр
        private double W { get; set; }//Толщина стенки? 
        public double Din { get; private set; }//Внутренний диаметр

        public Geomrthey(double pd, double pw)
        {
            //Index = pi;
            Dout = pd;
            W = pw;
            Din = pd - 2 * pw;
        }

        public Geomrthey(CGeomethry g)
        {
            //Index = g.Index;
            Dout = g.Dout;
            W = g.W;
            Din = Dout - 2 * W;
        }
        
        public string ReturnStr()
        {
            return string.Format("D={0} мм, S={1} мм", Dout, W);
        }

        public double ReturnW()
        {
            return W;
        }
    }

    public class Pipes : object
    {
        List<CGeomethry> columns;
        
        public Pipes()
        {
            columns = new List<CGeomethry>
            {
                new CGeomethry{Index = 0, Dout = 140, W = 7.8, Type = 1},
                new CGeomethry{Index = 1, Dout = 146, W=6.5, Type = 1},
                new CGeomethry{Index = 2, Dout = 146, W=7, Type = 1},
                new CGeomethry{Index = 3, Dout = 146, W=7.7, Type = 1},
                new CGeomethry{Index = 4, Dout = 146, W = 8.5, Type = 1},
                new CGeomethry{Index = 5, Dout = 146, W=9.5, Type = 1},
                new CGeomethry{Index = 6, Dout = 146, W = 10.7, Type = 1},
                new CGeomethry{Index = 7, Dout = 168, W = 7.3, Type = 1},
                new CGeomethry{Index = 8, Dout = 168, W = 8.0, Type = 1},
                new CGeomethry{Index = 9, Dout = 168, W = 8.9, Type = 1},
                new CGeomethry{Index = 10, Dout = 168, W = 10.6, Type = 1},
                new CGeomethry{Index = 11, Dout = 178, W = 8.2, Type = 1},
                new CGeomethry{Index = 12, Dout = 178, W = 9.3, Type = 1},
                new CGeomethry{Index = 13, Dout = 178, W = 10.04, Type = 1},
                new CGeomethry{Index = 14, Dout = 178, W = 10.5, Type = 1},
                new CGeomethry{Index = 15, Dout = 219, W = 8.8, Type = 1},
                new CGeomethry{Index = 16, Dout = 219, W = 10.2, Type = 1},
                new CGeomethry{Index = 17, Dout = 245, W = 11.1, Type = 1},
            
                new CGeomethry{Index = 18, Dout = 102, W = 6.5, Type = 2},
                new CGeomethry{Index = 19, Dout = 114, W = 6.4, Type = 2},
                new CGeomethry{Index = 20, Dout = 114, W = 7, Type = 2}, 
                new CGeomethry{Index = 21, Dout = 114, W = 7.4, Type = 2},

                new CGeomethry{Index = 22, Dout = 48, W = 4.0, Type = 3},
                new CGeomethry{Index = 23, Dout = 60, W = 5.0, Type = 3},
                new CGeomethry{Index = 24, Dout = 73, W = 5.5, Type = 3},
                new CGeomethry{Index = 25, Dout = 73, W = 6, Type = 3},
                new CGeomethry{Index = 26, Dout = 73, W = 7, Type = 3},
                new CGeomethry{Index = 27, Dout = 89, W = 6, Type = 3},
                new CGeomethry{Index = 28, Dout = 89, W = 6.5, Type = 3},
                new CGeomethry{Index = 29, Dout = 89, W = 7.34, Type = 3},
                new CGeomethry{Index = 30, Dout = 89, W = 8, Type = 3},
                new CGeomethry{Index = 31, Dout = 102, W = 6.5, Type = 3},
                new CGeomethry{Index = 32, Dout = 114, W = 7, Type = 3}
            };
        }

        public Dictionary<int, string> GetList(int type)
        {
            return columns.Where(x => x.Type == type).ToDictionary(itm => itm.Index, itm => string.Format("D={0} мм, S={1} мм", itm.Dout, itm.W));
        }

        public Geomrthey GetByIndex(int i)
        {
            var tmp = columns.First(x => x.Index == i);
            return new Geomrthey(tmp.Dout, tmp.W);
        }
    }

    public class ResItem : object
    {//Промежуточный результат прямого и обратного потока
        public readonly double P1;
        public readonly double P2;
        //private double z;

        public ResItem(double p1, double p2)
        {
            P1 = p1;
            P2 = p2;
            //this.z = z;
        }
    }

    public class ChartItem : object
    {
        public readonly double Ff;
        public readonly double Rf;
        public readonly double Vf;
        public readonly double Vr;
        public readonly double XStep;

        public ChartItem(double ff, double rf, double xStep, double vf, double vr)
        {
            Ff = ff;
            Rf = rf;
            XStep = xStep;
            Vf = vf;
            Vr = vr;
        }
    }

    public class CalcResult : object
    {
        public readonly List<ChartItem> CLst;

        public CalcResult()
        {
            CLst = new List<ChartItem>();
        }
    }

    public class BedType : object
    {//Параметры месторождения
        //private readonly int _index;
        public double K { get; private set; }
        public double M { get; private set; }

        public BedType(double pk, double pm)
        {
            // _index = idx;
            K = pk;
            M = pm;
        }

        public BedType(CBedType bed)
        {
            //_index = bed.Index;
            K = bed.K;
            M = bed.M;
        }
    }

    public class Unevenness : object
    {
        public readonly double K1;
        public readonly double K2;

        public Unevenness(double k1, double k2)
        {
            K1 = k1;
            K2 = k2;
        }
    }

    public class StaffProp
    {
        public readonly float Ro;
        public readonly float Mass;
        public readonly float Temp;
        public readonly int StaffType;

        public StaffProp(float ro, float mass, float unknown, int staffType)
        {
            Ro = ro;
            Mass = mass;
            Temp = unknown;
            StaffType = staffType;
        }

    }

    public class Catalog : object
    {
        private readonly Dictionary<int, string> _staff;
        public readonly List<StaffProp> StaffPropsList;

        public Catalog()
        {
            _staff = new Dictionary<int, string>
            {
                {1, "Хлористый натрий"},
                {2, "Хлористый калий"},
                {3, "Хлористый магний"},
                {4, "Хлористый кальций"},
                {5, "Нитрат кальция"}
            };
            StaffPropsList = new List<StaffProp>
            {
                new StaffProp(1.01F, 15, -0.9F, 1),     new StaffProp(1.01F, 18, -0.7F, 2),     new StaffProp(1.01F, 14, -0.7F, 3),     new StaffProp(1.01F, 13, -0.6F, 4),         
                new StaffProp(1.02F, 30, -1.8F, 1),     new StaffProp(1.02F, 35, -1.4F, 2),     new StaffProp(1.02F, 27, -1.4F, 3),     new StaffProp(1.02F, 26, -1.2F, 4),     new StaffProp(1.02F, 30, -0.8F, 5),
                new StaffProp(1.03F, 45, -2.6F, 1),     new StaffProp(1.03F, 50, -2.0F, 2),     new StaffProp(1.03F, 39, -2.2F, 3),     new StaffProp(1.03F, 37, -1.8F, 4),
                new StaffProp(1.04F, 59, -3.5F, 1),     new StaffProp(1.04F, 67, -2.8F, 2),     new StaffProp(1.04F, 52, -3.1F, 3),     new StaffProp(1.04F, 50, -2.4F, 4),     new StaffProp(1.04F, 53, -1.7F, 5),
                new StaffProp(1.05F, 75, -4.4F, 1),     new StaffProp(1.05F, 84, -3.5F, 2),     new StaffProp(1.05F, 65, -4.0F, 3),     new StaffProp(1.05F, 63, -3.0F, 4),
                new StaffProp(1.06F, 90, -5.4F, 1),     new StaffProp(1.06F, 101, -4.1F, 2),    new StaffProp(1.06F, 78, -5.0F, 3),     new StaffProp(1.06F, 76, -3.7F, 4),     new StaffProp(1.06F, 87, -2.7F, 5),
                new StaffProp(1.07F, 106, -6.4F, 1),    new StaffProp(1.07F, 118, -4.7F, 2),    new StaffProp(1.07F, 91, -6.0F, 3),     new StaffProp(1.07F, 90, -4.4F, 4),
                new StaffProp(1.08F, 123, -7.5F, 1),    new StaffProp(1.08F, 133, -5.2F, 2),    new StaffProp(1.08F, 104, -7.2F, 3),    new StaffProp(1.08F, 104, -5.2F, 4),    new StaffProp(1.08F, 113, -3.2F, 5),
                new StaffProp(1.09F, 140, -8.6F, 1),    new StaffProp(1.09F, 150, -5.9F, 2),    new StaffProp(1.09F, 117, -8.7F, 3),    new StaffProp(1.09F, 117, -6.1F, 4),
                new StaffProp(1.10F, 157, -9.8F, 1),    new StaffProp(1.10F, 168, -6.6F, 2),    new StaffProp(1.10F, 131, -10.3F, 3),   new StaffProp(1.10F, 130, -7.1F, 4),    new StaffProp(1.10F, 142, -4.0F, 5),
                new StaffProp(1.11F, 175, -11.0F, 1),   new StaffProp(1.11F, 185, -7.2F, 2),    new StaffProp(1.11F, 145, -12.3F, 3),   new StaffProp(1.11F, 144, -8.1F, 4),
                new StaffProp(1.12F, 193, -12.2F, 1),   new StaffProp(1.12F, 204, -7.8F, 2),    new StaffProp(1.12F, 160, -14.5F, 3),   new StaffProp(1.12F, 159, -9.1F, 4),    new StaffProp(1.12F, 170, -5.1F, 5),
                new StaffProp(1.13F, 212, -13.6F, 1),   new StaffProp(1.13F, 221, -8.4F, 2),    new StaffProp(1.13F, 175, -17.1F, 3),   new StaffProp(1.13F, 173, -10.2F, 4),
                new StaffProp(1.14F, 231, -15.1F, 1),   new StaffProp(1.14F, 237, -9.0F, 2),    new StaffProp(1.14F, 191, -19.9F, 3),   new StaffProp(1.14F, 188, -11.4F, 4),   new StaffProp(1.14F, 197, -6.0F, 5),
                new StaffProp(1.15F, 250, -16.0F, 1),   new StaffProp(1.15F, 253, -9.5F, 2),    new StaffProp(1.15F, 205, -22.9F, 3),   new StaffProp(1.15F, 202, -12.7F, 4),
                new StaffProp(1.16F, 269, -18.2F, 1),   new StaffProp(1.16F, 269, -10.0F, 2),   new StaffProp(1.16F, 220, -26.0F, 3),   new StaffProp(1.16F, 217, -14.2F, 4),   new StaffProp(1.16F, 227, -7.2F, 5),
                new StaffProp(1.17F, 290, -20.0F, 1),                                           new StaffProp(1.17F, 236, -29.1F, 3),   new StaffProp(1.17F, 233, -15.7F, 4),   
                                                                                                new StaffProp(1.18F, 252, -32.2F, 3),   new StaffProp(1.18F, 249, -17.4F, 4),   new StaffProp(1.18F, 253, -8.7F, 5),
                                                                                                                                        new StaffProp(1.19F, 265, -19.2F, 4),
                                                                                                                                        new StaffProp(1.20F, 280, -21.2F, 4),   new StaffProp(1.20F, 285, -10.1F, 5),
                                                                                                                                        new StaffProp(1.21F, 296, -23.3F, 4),
                                                                                                                                        new StaffProp(1.22F, 312, -25.7F, 4),   new StaffProp(1.22F, 317, -11.9F, 5),
                                                                                                                                        new StaffProp(1.23F, 329, -26.3F, 4),
                                                                                                                                        new StaffProp(1.24F, 346, -31.2F, 4),   new StaffProp(1.24F, 347, -13.6F, 5),
                                                                                                                                        new StaffProp(1.25F, 362, -34.6F, 4),
                                                                                                                                        new StaffProp(1.26F, 379, -38.6F, 4),   new StaffProp(1.26F, 380, -15.6F, 5),
                                                                                                                                        new StaffProp(1.27F, 397, -38.6F, 4),
                                                                                                                                        new StaffProp(1.28F, 416, -50.1F, 4),   new StaffProp(1.28F, 412, -16.8F, 5),
                                                                                                                                        new StaffProp(1.29F, 436, -53.5F, 4),
                                                                                                                                        new StaffProp(1.30F, 453, -57.0F, 4),   new StaffProp(1.30F, 443, -18.0F, 5),
                                                                                                                                                                                new StaffProp(1.32F, 457, -19.2F, 5),
                                                                                                                                                                                new StaffProp(1.34F, 503, -20.4F, 5),
                                                                                                                                                                                new StaffProp(1.36F, 536, -21.6F, 5),
                                                                                                                                                                                new StaffProp(1.38F, 560, -23.8F, 5),
                                                                                                                                                                                new StaffProp(1.40F, 595, -26.0F, 5),
                                                                                                                                                                                new StaffProp(1.42F, 620, -28.2F, 5)
            };
        }

        public string ReturnStaffName(int x)
        {
            return _staff.ContainsKey(x) ? _staff[x] : "";
        }
    }

    public class PumpChartItem
    {
        public readonly int Step;
        public readonly double Pressure;

        public PumpChartItem(int step, double pressure)
        {
            Step = step;
            Pressure = pressure;
        }
    }

    public class PlanItem : object
    {
        private readonly string _text;

        public PlanItem(string txt, int i)
        {
            _text = txt;
        }

        public string Text()
        {
            return _text;
        }

/*
        public int Id()
        {
            return _id;
        }
*/
    }

    public class PlanData : object
    {
        private readonly List<PlanItem> _lst;

        public PlanData()
        {
            _lst = new List<PlanItem>
            {
                new PlanItem(@"произвести стравливание скважины до жидкости и минимального давления", 1),
                new PlanItem(@"закрыть скважину до стабилизации давления", 2),
                new PlanItem(@"произвести замер Ризб на жидкости", 3),
                new PlanItem(@"сбить сливной клапан ЭЦН", 4),
                new PlanItem(@"произвести закачку тех воды", 5),
                new PlanItem(@"произвести повторный замер Ризб", 6),
                new PlanItem(@"произвести расчет плотности жидкости глушения по данным замера Ризб", 7),
                new PlanItem(@"произвести глушение скважины в НКТ расчетной плотностью в полном объеме", 8),
                new PlanItem(@"согласовать порядок проведения работ с супервайзерской службой Заказчика", 9),
                new PlanItem(@"согласовать плотность и объём жидкости глушения с геологической службой Заказчика", 10),
                new PlanItem(@"завести на скважину жидкость глушения", 11),
                new PlanItem(@"стравить давление в трубном и затрубном пространстве скважины", 12),
                new PlanItem(@"проверить исправность задвижек устьевой арматуры", 13),
                new PlanItem(@"установить лубрикатор со сбивным ломом", 14),
                new PlanItem(@"подбить нагнетательную линию насосного агрегата к лубрикатору", 15),
                new PlanItem(@"открыть трубную задвижку", 16),
                new PlanItem(@"убедиться в сбитии сливного клапана, установленного на НКТ", 17),
                new PlanItem(@"Перевести работу насосного агрегата «на себя» (на мерник)", 18),
                new PlanItem(@"отрегулировать подачу насосного агрегата", 19),
                new PlanItem(@"открыть затрубную и трубную задвижки", 20),
                new PlanItem(@"проверить наличие циркуляции в скважине", 21),
                new PlanItem(@"оставить скважину закрытой на тех. отстой", 22),
                new PlanItem(@"открыть трубные задвижки", 23),
                new PlanItem(@"произвести перерасчет плотности жидкости глушения", 24),
                new PlanItem(@"убедиться в появлении в затрубном пространстве жидкости глушения",25),
                new PlanItem(@"I цикл", 26),
                new PlanItem(@"II цикл", 27),
                new PlanItem(@"III цикл", 28),
                new PlanItem(@"IV цикл",29)
            };
        }

        public IEnumerable<PlanItem> GetList()
        {
            return _lst;
        }

/*
        public string GerItem(int id)
        {
            return _lst.Where(x => x.Id() == id).Select(i=>i.Text()).First();
        }
*/
    }

    public class PumpAdvancedPar
    {
        public readonly double Ining;

        public PumpAdvancedPar(double i)
        {
            Ining = i;
        }
    }

    public class PumpDataItem
    {
        public readonly int DoubleStep;
        private PumpAdvancedPar mm100;
        private PumpAdvancedPar mm115;
        private PumpAdvancedPar mm127;

        public PumpDataItem(int doubleStep, PumpAdvancedPar m100, PumpAdvancedPar m115, PumpAdvancedPar m127)
        {
            DoubleStep = doubleStep;
            mm100 = m100;
            mm115 = m115;
            mm127 = m127;
        }

        public PumpAdvancedPar RParam(int diam)
        {
            switch (diam)
            {
                case 100:
                    return mm100;
                case 0:
                    return mm100;
                case 115:
                    return mm115;
                case 1:
                    return mm115;
                case 2:
                    return mm127;
                case 127:
                    return mm127;
                default:
                    return mm100;
            }
        }
    }

    public class PumpData
    {
        private readonly List<PumpDataItem> _lst;

        public PumpData()
        {
            _lst = new List<PumpDataItem>
            {
                new PumpDataItem(2, new PumpAdvancedPar(0.8), new PumpAdvancedPar(1.1), new PumpAdvancedPar(1.3)),
                new PumpDataItem(4, new PumpAdvancedPar(1.5), new PumpAdvancedPar(2.1), new PumpAdvancedPar(2.6)),
                new PumpDataItem(6, new PumpAdvancedPar(2.3), new PumpAdvancedPar(3.2), new PumpAdvancedPar(3.9)),
                new PumpDataItem(8, new PumpAdvancedPar(3.1), new PumpAdvancedPar(4.2), new PumpAdvancedPar(5.2)),
                new PumpDataItem(10, new PumpAdvancedPar(3.9), new PumpAdvancedPar(5.3), new PumpAdvancedPar(6.6)),
                new PumpDataItem(12, new PumpAdvancedPar(4.6), new PumpAdvancedPar(6.3), new PumpAdvancedPar(7.9)),
                new PumpDataItem(14, new PumpAdvancedPar(5.4), new PumpAdvancedPar(7.4), new PumpAdvancedPar(9.2)),
                new PumpDataItem(16, new PumpAdvancedPar(6.2), new PumpAdvancedPar(8.4), new PumpAdvancedPar(10.5)),
                new PumpDataItem(18, new PumpAdvancedPar(6.9), new PumpAdvancedPar(9.5), new PumpAdvancedPar(11.8)),
                new PumpDataItem(20, new PumpAdvancedPar(7.7), new PumpAdvancedPar(10.5), new PumpAdvancedPar(13.1)),
                new PumpDataItem(22, new PumpAdvancedPar(8.5), new PumpAdvancedPar(11.6), new PumpAdvancedPar(14.4)), 
                new PumpDataItem(24, new PumpAdvancedPar(9.3), new PumpAdvancedPar(12.7), new PumpAdvancedPar(15.7)),
                new PumpDataItem(26, new PumpAdvancedPar(10.0), new PumpAdvancedPar(13.7), new PumpAdvancedPar(17.0)),
                new PumpDataItem(28, new PumpAdvancedPar(10.8), new PumpAdvancedPar(14.8), new PumpAdvancedPar(18.4)),
                new PumpDataItem(30, new PumpAdvancedPar(11.6), new PumpAdvancedPar(15.8), new PumpAdvancedPar(19.7)),
                new PumpDataItem(32, new PumpAdvancedPar(12.3), new PumpAdvancedPar(16.9), new PumpAdvancedPar(21.0)),
                new PumpDataItem(34, new PumpAdvancedPar(13.1), new PumpAdvancedPar(17.9), new PumpAdvancedPar(22.3)),
                new PumpDataItem(36, new PumpAdvancedPar(13.9), new PumpAdvancedPar(19.0), new PumpAdvancedPar(23.6)),
                new PumpDataItem(38, new PumpAdvancedPar(14.7), new PumpAdvancedPar(20.0), new PumpAdvancedPar(24.9)),
                new PumpDataItem(40, new PumpAdvancedPar(15.4), new PumpAdvancedPar(21.1), new PumpAdvancedPar(26.2)),
                new PumpDataItem(42, new PumpAdvancedPar(16.2), new PumpAdvancedPar(22.1), new PumpAdvancedPar(27.5)),
                new PumpDataItem(44, new PumpAdvancedPar(17.0), new PumpAdvancedPar(23.2), new PumpAdvancedPar(28.9)),
                new PumpDataItem(46, new PumpAdvancedPar(17.7), new PumpAdvancedPar(24.2), new PumpAdvancedPar(30.2)),
                new PumpDataItem(48, new PumpAdvancedPar(18.5), new PumpAdvancedPar(25.3), new PumpAdvancedPar(31.5)),
                new PumpDataItem(50, new PumpAdvancedPar(19.3), new PumpAdvancedPar(26.4), new PumpAdvancedPar(32.8)),
                new PumpDataItem(52, new PumpAdvancedPar(20.1), new PumpAdvancedPar(27.4), new PumpAdvancedPar(34.1)),
                new PumpDataItem(54, new PumpAdvancedPar(20.8), new PumpAdvancedPar(28.5), new PumpAdvancedPar(35.4)),
                new PumpDataItem(56, new PumpAdvancedPar(21.6), new PumpAdvancedPar(29.5), new PumpAdvancedPar(36.7)),
                new PumpDataItem(58, new PumpAdvancedPar(22.4), new PumpAdvancedPar(30.6), new PumpAdvancedPar(38.0)),
                new PumpDataItem(60, new PumpAdvancedPar(23.1), new PumpAdvancedPar(31.6), new PumpAdvancedPar(39.3)),
                new PumpDataItem(62, new PumpAdvancedPar(23.9), new PumpAdvancedPar(32.7), new PumpAdvancedPar(40.7)),
                new PumpDataItem(64, new PumpAdvancedPar(24.7), new PumpAdvancedPar(33.7), new PumpAdvancedPar(42.0)),
                new PumpDataItem(66, new PumpAdvancedPar(25.5), new PumpAdvancedPar(34.8), new PumpAdvancedPar(43.3)),
                new PumpDataItem(68, new PumpAdvancedPar(26.2), new PumpAdvancedPar(35.8), new PumpAdvancedPar(44.6)),
                new PumpDataItem(70, new PumpAdvancedPar(27.0), new PumpAdvancedPar(36.9), new PumpAdvancedPar(45.9)),
                new PumpDataItem(72, new PumpAdvancedPar(27.8), new PumpAdvancedPar(38.0), new PumpAdvancedPar(47.2)),
                new PumpDataItem(74, new PumpAdvancedPar(28.5), new PumpAdvancedPar(39.0), new PumpAdvancedPar(48.5)),
                new PumpDataItem(76, new PumpAdvancedPar(29.3), new PumpAdvancedPar(40.1), new PumpAdvancedPar(49.8)),
                new PumpDataItem(78, new PumpAdvancedPar(30.1), new PumpAdvancedPar(41.1), new PumpAdvancedPar(51.1)),
                new PumpDataItem(80, new PumpAdvancedPar(30.9), new PumpAdvancedPar(42.2), new PumpAdvancedPar(52.5)),
                new PumpDataItem(82, new PumpAdvancedPar(31.6), new PumpAdvancedPar(43.2), new PumpAdvancedPar(53.8)),
                new PumpDataItem(84, new PumpAdvancedPar(32.4), new PumpAdvancedPar(44.3), new PumpAdvancedPar(55.1)),
                new PumpDataItem(86, new PumpAdvancedPar(33.2), new PumpAdvancedPar(45.3), new PumpAdvancedPar(56.4)),
                new PumpDataItem(88, new PumpAdvancedPar(33.9), new PumpAdvancedPar(46.4), new PumpAdvancedPar(57.7)),
                new PumpDataItem(90, new PumpAdvancedPar(34.7), new PumpAdvancedPar(47.4), new PumpAdvancedPar(59.0)),
                new PumpDataItem(92, new PumpAdvancedPar(35.5), new PumpAdvancedPar(48.5), new PumpAdvancedPar(60.3)),
                new PumpDataItem(94, new PumpAdvancedPar(36.3), new PumpAdvancedPar(49.6), new PumpAdvancedPar(61.6)),
                new PumpDataItem(96, new PumpAdvancedPar(37.0), new PumpAdvancedPar(50.6), new PumpAdvancedPar(62.9)),
                new PumpDataItem(98, new PumpAdvancedPar(37.8), new PumpAdvancedPar(51.7), new PumpAdvancedPar(64.3)),
                new PumpDataItem(100, new PumpAdvancedPar(38.6), new PumpAdvancedPar(52.7), new PumpAdvancedPar(65.6))
            };
        }

        public IEnumerable<int> GetStepList()
        {
            var res = _lst.Select(x => x.DoubleStep);
            return res;
        }

        public PumpDataItem GetItem(int id)
        {
            return _lst[id];
        }
    }

    
    public class RLenght:object
    {
        private readonly double _len;
       // private int size;

        public RLenght(double len, int size)
        {
            _len = len;
            switch (size)
            {
                case 0:
                    _len = len / 1000;
                    break;
                case 1:
                    _len = len / 100;
                    break;
                case 2:
                   _len = len;
                    break;
                case 3:
                    _len = len * 1000;
                    break;
                default:
                    _len = len / 1000;
                    break;
            }

           // this.size = 2;
        }

        public double GetLenghtIn(int sz)
        {
            switch (sz)
            {
                case 0:
                    return _len*1000;
                case 1:
                    return _len*100;
                case 2:
                    return _len;
                case 3:
                    return _len/1000;
                default:
                    return _len;
            } 
        }   
    }

    public class RPressure : object
    {
        private readonly double _press;

        public RPressure(double press, int sz)
        {
            switch (sz)
            {
                case 0:
                    _press = press * 101325;
                    break;
                case 1:
                    _press = press;
                    break;
                default:
                    _press = press;
                    break;
            }
        }

        public double GetPressIn(int sz)
        {
            switch (sz)
            {
                case 0:
                    return _press/101325;
                case 1:
                    return _press;
                default:
                    return _press;
            }
        }
    }

    public class RDensity : object
    {
        private readonly double _density;

        public RDensity(double density, int sz)
        {
            if (sz == 0)
                _density = density*1000;
            else
                _density = density;
        }

        public double GetDensityIn(int sz)
        {
            if (sz == 0)
                return _density/1000;
            return _density;
        }
    }

    public class RViscosity : object
    {
        private readonly double _vis;

        public RViscosity(double vis)
        {
            _vis = vis;
        }

        public double GetViscosity(int sz)
        {
            if (sz == 1)
                return _vis/10;
            return _vis;
        }
    }

    public class CoastItem
    {
        public double Density;
        public float Coast;
    }

    public class CoastTable : object
    {
        readonly List<CoastItem> _lst;

        public CoastTable(object src)
        {
            _lst = new List<CoastItem>();
            var tb = (DataGridView) src;
            foreach (var row in tb.Rows.Cast<DataGridViewRow>().Where(row => (row.Cells[0].Value != null) && (row.Cells[1].Value != null)))
            {
                float c;
                double d;
                double.TryParse(row.Cells[0].Value.ToString(), out d);
                float.TryParse(row.Cells[1].Value.ToString(), out c);
                _lst.Add(new CoastItem{Coast = c, Density = d});
            }
        }

        public List<CoastItem> ReturnList()
        {
            return _lst;
        }
    }

    
    public class GeometheryElement : object
    {
        private readonly int _lenght;
        private int _height;
        private Point _coord;

        public GeometheryElement(int l, int h)
        {
            _lenght = l;
            _height = h;
        }

        public int Height()
        {
            return _height;
        }

        public int Lenght()
        {
            return _lenght;
        }
        public void SetHeight(int h)
        {
            _height = h;
        }
        public double GBais()
        {
            return Math.Sqrt(_lenght*_lenght - _height*_height);
        }


        public void SetPoint(int x, int y, double c)
        {
            try
            {
                _coord = new Point(Convert.ToInt32(x*c), Convert.ToInt32(y*c));
            }
            catch
            {
                // ignored
            }
        }

        public Point GetPoint()
        {
            return _coord;
        }

        public CGeomElem GetConfigItem()
        {
            var res = new CGeomElem
            {
                Lenght = _lenght,
                Height = _height
            };
            return res;
        }
    }

    public class CTube : object
    {
       // private readonly List<TubeElement> _tList;
        private readonly List<GeometheryElement> _gList;
        private int _height;
        private int _width;
        private int _startX;
        private Point[] _resPoints;

        private readonly List<Point> _lSide;
        private readonly List<Point> _rSide;
        private readonly List<GreedElement> _grd;

        private readonly List<Point> _lSideNkt;
        private readonly List<Point> _rSideNkt;

        private readonly List<GreedElement> _grdNkt; 
/*  
        private Point[] _scPoints;
*/
        //private int maxY;
        public CTube()
        {
            _gList = new List<GeometheryElement>();
           // _tList = new List<TubeElement>(); //ось труб
            _lSide = new List<Point>(); //Обс колонна, левая сторона
            _rSide = new List<Point>(); 
            _lSideNkt = new List<Point>(); // нкт левая стенка
            _rSideNkt = new List<Point>();
            _grd = new List<GreedElement>(); //обс колонна, решотка
            _grdNkt = new List<GreedElement>();
        }

        //public void AddT(TubeElement te)
        //{
        //    _tList.Add(te);
        //}

        public void AddG(GeometheryElement ge)
        {
            _gList.Add(ge);
        }

        public void Normalize(CalcRes calc)
        {
            
            _gList.Insert(0, new GeometheryElement(0, 0));
            
            var xCoef = Convert.ToDouble(_width-20)/_gList.Sum(dx => dx.GBais());
            var yCoef = Convert.ToDouble(_height-80)/_gList.Sum(dy => dy.Height());

            var coef = xCoef < yCoef ? xCoef : yCoef;
            var maxY = 0;
            var maxX = 0;
            foreach (var gx in _gList)
            {
                maxY = maxY + gx.Height();
                maxX = maxX + Convert.ToInt32(gx.GBais());
                gx.SetPoint(maxX, maxY, coef);
            }
            _startX =  Convert.ToInt32(Convert.ToDouble(_width)/0x2 - maxX*coef/0x2);
            //var startY = 0;

            var sp = new MElement();
            foreach (var gx in _gList)
            {
              sp.SrcList.Add(gx.GetPoint());  
            }
            sp.Normalize();
            
            while (_height-sp.RSrc().Length>_height/7)
            {
               sp.OneParce();
            }
            
            _resPoints = sp.RSrc();
            for (var it = 0; it < _resPoints.Length; it++)
            {
                var xp = _resPoints[it];
                _resPoints[it].X = xp.X +_startX;
                _resPoints[it].Y = xp.Y+20;
            }
            var ek = calc.DColumnLenght/(calc.DColumnLenght + calc.DTailLenght);
            var nk = calc.DUpperHanger/(calc.DColumnLenght + calc.DTailLenght);
            var lk = (calc.DUpperHanger + calc.DLowerHanger)/(calc.DColumnLenght + calc.DTailLenght);
            var ic = 10;
            var angle = 0.0;
            var diam = 30;
            var inDiam = 15;
            _lSide.Add(new Point(_resPoints[0].X + diam, _resPoints[0].Y));
            _rSide.Add(new Point(_resPoints[0].X - diam, _resPoints[0].Y));
            _grd.Add(new GreedElement(_resPoints[0], diam * 2, 90*Math.PI/180));
            _lSideNkt.Add(new Point(_resPoints[0].X + inDiam, _resPoints[0].Y));
            _rSideNkt.Add(new Point(_resPoints[0].X - inDiam, _resPoints[0].Y));
            _grdNkt.Add(new GreedElement(_resPoints[0], inDiam * 2, 90 * Math.PI / 180));
            while (ic < _resPoints.Length - 10)
            {

                diam = ic >= _resPoints.Length*ek ? 25 : 30;
                inDiam = ic >= _resPoints.Length*nk ? 10 : 15;
                try
                {
                    if (_resPoints[ic + 5].X - _resPoints[ic - 5].X == 0)
                        angle = 90*Math.PI/180;
                    else
                        angle = Math.Atan(Convert.ToDouble(_resPoints[ic - 9].Y - _resPoints[ic + 9].Y)/
                                          Convert.ToDouble(_resPoints[ic - 9].X - _resPoints[ic + 9].X));

                }
                catch (Exception)
                {
                    // ignored
                }
                var cPoint = _resPoints[ic];

                _lSide.Add(new Point(cPoint.X + Convert.ToInt32(diam*Math.Sin(angle)),
                    cPoint.Y - Convert.ToInt32(diam*Math.Cos(angle))));
                _rSide.Add(new Point(cPoint.X - Convert.ToInt32(diam*Math.Sin(angle)),
                    cPoint.Y + Convert.ToInt32(diam*Math.Cos(angle))));
                _grd.Add(new GreedElement(cPoint, diam*2, angle));

                if (ic <= _resPoints.Length*lk)
                {
                    _lSideNkt.Add(new Point(cPoint.X + Convert.ToInt32(inDiam*Math.Sin(angle)),
                        cPoint.Y - Convert.ToInt32(inDiam*Math.Cos(angle))));
                    _rSideNkt.Add(new Point(cPoint.X - Convert.ToInt32(inDiam*Math.Sin(angle)),
                        cPoint.Y + Convert.ToInt32(inDiam*Math.Cos(angle))));
                    _grdNkt.Add(new GreedElement(cPoint, inDiam*2, angle));
                }
                ic = ic + 10;
            }

            _lSide.Add(new Point(_resPoints[_resPoints.Length - 1].X + Convert.ToInt32(diam*Math.Sin(angle)),
                _resPoints[_resPoints.Length - 1].Y - Convert.ToInt32(diam*Math.Cos(angle))));
            _rSide.Add(new Point(_resPoints[_resPoints.Length - 1].X - Convert.ToInt32(diam*Math.Sin(angle)),
                _resPoints[_resPoints.Length - 1].Y + Convert.ToInt32(diam*Math.Cos(angle))));
            _grd.Add(new GreedElement(_resPoints[_resPoints.Length - 1], diam * 2, angle));

        }

        public Point[] Res()
        {
            return _resPoints;
        }

        public Point[] LeftSide()
        {
            return _lSide.ToArray();
        }

        public Point[] RightSide()
        {
            return _rSide.ToArray();
        }

        public Point[] LeftSideNkt()
        {
            return _lSideNkt.ToArray();
        }

        public Point[] RightSideNkt()
        {
            return _rSideNkt.ToArray();
        }
        public IEnumerable<GreedElement> RGreedElements()
        {
            return _grd;
        }
        public IEnumerable<GreedElement> RGreedNktElements()
        {
            return _grdNkt;
        }
        public void SetSize(int x, int y)
        {
            _width = x;
            _height = y;
        }

        public void ClearList()
        {
            _gList.Clear();
        }

        public int GetStartX()
        {
            return _startX;
        }
    }

    
    internal class MElement : object
    {
        public readonly List<Point> SrcList;
        private List<Point> _itpPoint;
        

        public MElement()
        {
            SrcList = new List<Point>();
            _itpPoint = new List<Point>();
            
        }

        public void Normalize()
        {
            foreach (var tx in SrcList)
            {
                _itpPoint.Add(new Point(Convert.ToInt32(tx.X), Convert.ToInt32(tx.Y)));
            }
        }

        private static Point MidlePoint(Point a, Point b)
        {
            return new Point(Convert.ToInt32((a.X + b.X) / 2), Convert.ToInt32((a.Y + b.Y) / 2));
        }

        public void OneParce()
        {
            var aPt = RSrc();
            var res = new List<Point>();
            for (var i = 0; i < aPt.Length; i++)
            {
                if (i == 0)
                    res.Add(aPt[i]);
                else
                {
                    res.Add(MidlePoint(aPt[i - 1], aPt[i]));
                    res.Add(aPt[i]);
                    if (i + 1 == aPt.Length)
                    {
                        res.Add(aPt[i]);
                    }
                }
            }
            _itpPoint = res;
            aPt = RSrc();
            res = new List<Point>();
            for (var i = 0; i < aPt.Length; i++)
            {
                if (i == 0)
                    res.Add(aPt[i]);
                else
                {
                    res.Add(MidlePoint(aPt[i - 1], aPt[i]));
                    if (i + 1 != aPt.Length) continue;
                    res.Add(aPt[i]);
                    res.Add(MidlePoint(aPt[i - 1], aPt[i]));
                }
            }
            _itpPoint = res;
        }

        public Point[] RSrc()
        {
            return _itpPoint.Distinct().ToArray();
        }

    }

    public class GreedElement : object
    {
        private readonly Point _posPoint;
        private readonly int _diam;
        private readonly double _angle;

        public GreedElement(Point posPoint, int diam, double angle)
        {
            _posPoint = posPoint;
            _diam = diam;
            _angle = angle;
        }

        public Point RPosition()
        {
            return _posPoint;
        }

        public int RDiam()
        {
            return _diam;
        }

        public double RAmgle()
        {
            return _angle/(Math.PI/180);
        }

        public double RAngleG()
        {
            return _angle;
        }
    }

    public class EquipmentType : object
    {
        private readonly Dictionary<int, string> _typeList;

        public EquipmentType()
        {
            _typeList = new Dictionary<int, string>
            {
                {0, "Воронка"},
                {1, "Пакер запакирован"},
                {2,"Пакер распакирован"},
                {3, "ЭЦН+Пакер"},
                {4, "ЭЦН"},
                {5, "Стингер"}
            };
        }

        public Dictionary<int, string> RListEquipment()
        {
            return _typeList;
        }

        public string REquipment(int code)
        {
            return _typeList[code];
        }
    }

    public class PlanBlank : object
    {
        public int EquipmentID;
        public RadioButton rbActualPressureY, rbActualPressureN;
        public int CurrentLine;
        public RadioButton rbExcessPressureY, rbExcessPressureN;
        public RadioButton rbMeasureAbleY, rbMeasureAbleN;
        public RadioButton rbTunnelPresentY, rbTunnelPresentN;
        public RadioButton rbCirculationPresentY, rbCirculationPresentN;
        public RadioButton rbClapanOpenedY, rbClaoanOpenedN;
        public RadioButton rbNZConnectY, rbNZConnectN;
        //public TextBox tbDesity;
        //public ComboBox cbDensityU;
        //public TextBox tbSurplusPressure;
        //public ComboBox cbSurplusPressure;
        public PlanBlank()
        {
            CurrentLine = 0;
        }

        // private bool 

    }

}