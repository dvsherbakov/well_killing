namespace blank
{
    public partial class MForm
    {

/*
        private void DrawCorner(PaintEventArgs e)
        {
            var penM = new Pen(Color.Brown, 1);
            var g = e.Graphics;
            var maxX = tpSchema.Size.Width;
            var maxY = tpSchema.Size.Height;
            int tubeWidth;

            if (maxX > maxY) tubeWidth = maxY / 10;
            else tubeWidth = maxX / 10;

            int border;
            if (maxX > maxY) border = (maxX - maxY + maxX / 4) / 2;
            else border = maxX / 10;
            var borderY = maxY / 15;
            var startX = border;
            var startY = borderY;
            var strongTubeLenght = maxY / 3;
            var r1HWidht = maxX - (startX + tubeWidth + border);
            var r1HHeight = maxY - (borderY * 2 + tubeWidth + strongTubeLenght + startY);
            var r1 = new Rectangle(startX + tubeWidth, startY + strongTubeLenght - r1HHeight, r1HWidht * 2, r1HHeight * 2);
            var r2HWidth = maxX - (startX + border);
            var r2HHeight = maxY - (borderY * 2 + strongTubeLenght + startY);
            var r2 = new Rectangle(startX, startY + strongTubeLenght - r2HHeight, r2HWidth * 2, r2HHeight * 2);//

            g.SmoothingMode = SmoothingMode.HighQuality;

            var gPath = new GraphicsPath();
            gPath.AddLine(new Point(startX, startY + strongTubeLenght), new Point(startX, startY));//
            gPath.AddLine(new Point(startX, startY), new Point(startX + tubeWidth, startY));
            gPath.AddLine(new Point(startX + tubeWidth, startY), new Point(startX + tubeWidth, startY + strongTubeLenght));
            gPath.AddArc(r1, 180, -90);
            gPath.AddLine(new Point(startX + tubeWidth + r1HWidht, startY + strongTubeLenght + r1HHeight), new Point(startX + tubeWidth + r1HWidht, startY + strongTubeLenght + r1HHeight + tubeWidth));
            gPath.AddArc(r2, 90, 90);

            g.DrawPath(penM, gPath);
        }
        */

        /*
        private static void ShowAddonForm(object sender)
        {
            var afForm = new AdditionalForm((TextBox)sender)
            {
                Location = new Point
                {
                    X = ((TextBox)sender).PointToScreen(Point.Empty).X,
                    Y = ((TextBox)sender).PointToScreen(Point.Empty).Y
                }
            };
            afForm.Show();
        }
*/
        /*
        private static List<string> GetTag(Control senderBox)
        {
            var senderList = new List<string>();
            if (senderBox.Tag != null)
                senderList = (List<string>)senderBox.Tag;
            else senderList.Add(senderBox.Text);
            return senderList;
        }
*/

/*
        private static void SetTag(Control textBox, IEnumerable<string> list)
        {
            var eList = list as string[] ?? list.ToArray();
            if (eList.Length > 1)
            {
                textBox.Tag = list;
                textBox.Text = eList.First();
            }
            else if (eList.Any())
                textBox.Text = eList.First();

        }
*/
        //private void btExec_Click(object sender, EventArgs e)
        //{
        //tcCntrl.SelectedIndex = 1;
        //ShowResult();
        //}

        /*
        private static void SetArrow(int centerX, int y, int rad, Graphics g, string tx)
        {//Рисование стрелки на схеме
            const int hight = 5;
            const int width = 10;
            const int corn = 2;

            var maxX = Convert.ToInt32(g.VisibleClipBounds.Width*0.8);

            var arPath = new GraphicsPath();

            Point[] left =
            {
                new Point(centerX - rad, y),
                new Point(centerX-rad-width, y-hight),
                new Point(centerX-rad-width+corn, y),
                new Point(centerX-rad-3*width, y),
                new Point(centerX-rad-width+corn, y),
                new Point(centerX-rad-width, y+hight)
            };

            Point[] right =
            {
                new Point(centerX+rad, y),
                new Point(centerX+rad+width, y-hight),
                new Point(centerX+rad+width-corn, y), 
                new Point(maxX, y), 
                new Point(centerX+rad+width-corn, y),
                new Point(centerX+rad+width, y+hight) 
            };
            var penM = new Pen(Color.Brown, 1);
            
            arPath.AddPolygon(left);
            arPath.AddPolygon(right);
            g.DrawPath(penM, arPath);

            var drawFont = new Font("Arial", 12);
            var drawBrush = new SolidBrush(Color.Brown);
            var drawFormat = new StringFormat();
            g.DrawString(tx, drawFont, drawBrush, maxX, y-6, drawFormat);
        }
*/

/*
        private void DrawTubes(PaintEventArgs e)
        {
            var calc = PrepareCalcData();
            var penM = new Pen(Color.Brown, 1);
            var g = e.Graphics;
            var maxX = tpSchema.Size.Width;
            var maxY = tpSchema.Size.Height;
            var columnLenght = Convert.ToInt32(maxY * 0.9 * (calc.DColumnLenght / (calc.DColumnLenght + calc.DTailLenght)));
            var tailLenght = Convert.ToInt32(maxY * 0.9) - columnLenght;
            var centerX = Convert.ToInt32(maxX / 2);
            var upHangL = Convert.ToInt32(maxY * 0.9 * (calc.DUpperHanger / (calc.DColumnLenght + calc.DTailLenght)));
            var lwHangL = Convert.ToInt32(maxY * 0.9 * (calc.DLowerHanger / (calc.DColumnLenght + calc.DTailLenght)));

            //if (maxX > maxY) 
            var tubeWidth = maxX / 5;
            //else tubeWidth = maxX / 10;
            if (tubeWidth < 70) tubeWidth = 70;
            var tubeTail = Convert.ToInt32(tubeWidth * 0.7);
            var upHungR = Convert.ToInt32(tubeTail * 0.5 * 0.8);
            var lwРangR = Convert.ToInt32(tubeTail * 0.5 * 0.5);
            //if (maxX > maxY) ;
            //else ;
            var borderY = maxY / 15;
            var startX = Convert.ToInt32(maxX / 2 - tubeWidth / 2);
            var startY = borderY;
            // var strongTubeLenght = maxY / 3;

            g.SmoothingMode = SmoothingMode.HighQuality;

            Point[] pgColumn =
            {
                new Point(startX, startY + columnLenght), 
                new Point(startX + (tubeWidth - tubeTail) / 2, startY + columnLenght),
                new Point(startX + (tubeWidth - tubeTail) / 2, startY + columnLenght + tailLenght),
                new Point(startX + tubeTail + (tubeWidth - tubeTail) / 2, startY + columnLenght + tailLenght),
                new Point(startX + tubeTail + (tubeWidth - tubeTail) / 2, startY + columnLenght),
                new Point(startX + tubeWidth, startY + columnLenght),
                new Point(startX + tubeWidth, startY),
                new Point(startX, startY),
                new Point(startX, startY + columnLenght)
            };

            Point[] pgHunger =
            {
                new Point(centerX-upHungR, startY),
                new Point(centerX+upHungR, startY),
                new Point(centerX+upHungR, startY+upHangL),
                new Point(centerX+lwРangR, startY+upHangL),
                new Point(centerX+lwРangR, startY+upHangL+lwHangL), 
                new Point(centerX-lwРangR, startY+upHangL+lwHangL),
                new Point(centerX-lwРangR, startY+upHangL),
                new Point(centerX-upHungR, startY+upHangL),
                new Point(centerX-upHungR, startY)
            };

            var gPath = new GraphicsPath();
            gPath.AddPolygon(pgColumn);
            gPath.AddPolygon(pgHunger);

            g.DrawPath(penM, gPath);
            //Длинна колонны
            SetArrow(centerX, startY + columnLenght, tubeWidth / 2, g, calc.DColumnLenght.ToString("N1", _noSeparate));
            //Длиинна хвостовика
            if (calc.DTailLenght - 10 > 0)
                SetArrow(centerX, startY + columnLenght + tailLenght, tubeTail / 2, g, (calc.DColumnLenght + calc.DTailLenght).ToString("N1", _noSeparate));
            //Верхняя подвеска
            SetArrow(centerX, startY + upHangL, upHungR, g, calc.DUpperHanger.ToString("N1", _noSeparate));
            //Нижняя подвеска
            if (calc.DLowerHanger - 10 > 0)
                SetArrow(centerX, startY + upHangL + lwHangL, lwРangR, g, (calc.DUpperHanger + calc.DLowerHanger).ToString("N1", _noSeparate));

        }
*/

        /*
        private Point[] CurvePoints()
        {
            var cy = Convert.ToDouble(_height)/Convert.ToDouble(_lst.Sum(x => x.RLen()))*0.9;
            var tmp = new List<TubeElement>();
            var smLen = 0;
            tmp.Add(new TubeElement(_startPos.X,_startPos.Y));
            foreach (var tx in _lst)
            {
                smLen = smLen + tx.RLen();
                tmp.Add(new TubeElement(_startPos.X+tx.RDiam(), Convert.ToInt32(cy*smLen)));
            }
            var res =  tmp.Select(ix => new Point(ix.RLen(), ix.RDiam())).ToArray();
            
            return res;
        }
*/


        /*
                public static void SetStartPos(int x, int y)
                {
                    new Point(x,y);
                }
        */

        //private void UpdateParametrs()
        //{
        //    SvgDocument sd;
        //    //SvgDocument sd = new SvgDocument();
        //    switch (cbEquipmentType.SelectedIndex)
        //    {
        //        case 0:
        //            sd = SvgDocument.Open("ecn.svg");
        //            break;
        //        case 1:
        //            sd = SvgDocument.Open("funnel.svg");
        //            break;
        //        case 2:
        //            sd = SvgDocument.Open("paker.svg");
        //            break;

        //        case 3:
        //            sd = SvgDocument.Open("unpaker.svg");
        //            break;
        //        default:
        //            sd = SvgDocument.Open("ecn.svg");

        //            break;

        //    }

        //    var image = sd.Draw();
        //   // pbChema.Image = image;

        //}

        /*
        private void button1_Click(object sender, EventArgs e)
        {//Сохранить параметры в файл
            _conf.LastPath= _conf.LastPath ?? "..\\";
            var sfd = new SaveFileDialog
            {
                Filter = @"XML файлы|*.xml",
                InitialDirectory = _conf.LastPath.Length < 5
                    ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                    : _conf.LastPath,
                RestoreDirectory = true
            };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            SaveFile(sfd.FileName);
            
            var fn = new FileInfo(sfd.FileName);
            _conf.LastPath = fn.DirectoryName;
            _conf.LastFileName = fn.FullName;
        }
*/
    
        /*
        private void button2_Click(object sender, EventArgs e)
        {//Загрузить внешний файл с параметрами
            
            var ofd = new OpenFileDialog
            {
                Filter = @"XML файлы|*.xml",
                InitialDirectory = _conf.LastPath.Length < 5
                    ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                    : _conf.LastPath,
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;
                LoadFile(ofd.FileName);
            UpdateParametrs();
        }
*/

        /*public class TubeElement : object
    {
        private readonly int _len;
        private readonly int _diam;

        public TubeElement(int l, int d)
        {
            _len = l;
            _diam = d;
        }

        public int RLen()
        {
            return _len;
        }

        public int RDiam()
        {
            return _diam;
        }
         * 
    }*/

        /* Переключатель в плане работ
            switch (_step + pbPlan.EquipmentID*100)
            {
                case 0:
                case 100:
                case 200:
                case 300:
                case 400:
                case 500:
                    tlpAlg.Controls.Add(new Label {Text = @"Актуальное давление", AutoSize = true}, 0, 1);
                    pbPlan.cbActualPressure = new CheckBox {Text = "", AutoSize = true};
                    tlpAlg.Controls.Add(pbPlan.cbActualPressure, 1, 1);
                    _step++;
                    return;
                case 1:
                case 101:
                case 201:
                case 301:
                case 401:
                case 501:
                    if (pbPlan.cbActualPressure.Checked)
                    {
                        _step = 10;
                       
                    }
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label {Text = @"Избыточное давление на устье", AutoSize = true}, 0,
                        pbPlan.CurrentLine);
                    pbPlan.cbExcessPressure = new CheckBox {Text = "", AutoSize = true};
                    tlpAlg.Controls.Add(pbPlan.cbExcessPressure, 1, pbPlan.CurrentLine);
                    _step++;
                    return;
                case 2:
                case 102:
                case 202:
                case 302:
                case 402:
                case 502:
                    if (!pbPlan.cbExcessPressure.Checked)
                    {
                        _step = 10;
                        return;
                    }
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label {Text = @"Есть возможность измерить плотность ВСЖ", AutoSize = true},
                        0, pbPlan.CurrentLine);
                    pbPlan.cbMeashureAble = new CheckBox();
                    tlpAlg.Controls.Add(pbPlan.cbMeashureAble, 1, pbPlan.CurrentLine);
                    _step++;
                    return;
                case 3:
                    if (pbPlan.cbMeashureAble.Checked)
                    {
                        _step = 10;
                        return;
                    }
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label {Text = @"Закачиваем в НКТ", AutoSize = true}, 0, pbPlan.CurrentLine);
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label {Text = @"Наличие прохода?", AutoSize = true}, 0 ,pbPlan.CurrentLine);
                    pbPlan.cbTunnelPresentl = new CheckBox();
                    tlpAlg.Controls.Add(pbPlan.cbTunnelPresentl, 1, pbPlan.CurrentLine);
                    _step++;
                    return;
                case 4:
                    if (!pbPlan.cbTunnelPresentl.Checked)
                    {
                        pbPlan.CurrentLine++;
                        tlpAlg.Controls.Add(new Label{Text = @"Применяем ВЦ", AutoSize = true}, 0, pbPlan.CurrentLine);
                    }
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label{Text = @"Есть циркуляция?", AutoSize = true}, 0, pbPlan.CurrentLine);
                    pbPlan.cbCirculationPresent = new CheckBox();
                    tlpAlg.Controls.Add(pbPlan.cbCirculationPresent, 1, pbPlan.CurrentLine);
                    _step++;
                    return;
                case 5:
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(
                        pbPlan.cbCirculationPresent.Checked
                            ? new Label {Text = @"Закачиваем на циркуляцию", AutoSize = true}
                            : new Label {Text = @"Закачиваем на поглощение", AutoSize = true}, 0, pbPlan.CurrentLine);
                    _step++;
                    return;
                case 10:
                    return;

            }
            */

    }
}