using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Globalization;
using System.IO;
using System.Linq;
//using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
//using DocumentFormat.OpenXml.Office2010.CustomUI;
//using CheckBox = System.Windows.Forms.CheckBox;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;
using TreeNode = System.Windows.Forms.TreeNode;
using View = System.Windows.Forms.View;


namespace blank
{
    public partial class MForm : Form
    {
        private static ConfData _conf;
        private Catalog _cat;
        private static List<GeometheryElement> _pipeConf;
        private static Bitmap _bmShema;
        private static NumberFormatInfo _noSeparate;
        private static int _step;
        private PlanBlank pbPlan;
        public MForm()
        {
            _conf = LoadConfig();
            _noSeparate = new NumberFormatInfo {NumberGroupSeparator = string.Empty};
            InitializeComponent();
            pbPlan = new PlanBlank();
            InitConfig();
            _pipeConf = new List<GeometheryElement>();
            var lf = new FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\IGAutoSave.xml");
            if (lf.Exists)
                LoadFile(lf.FullName);
            else
            {
                lf = new FileInfo(_conf.LastFileName);
                if (lf.Exists)
                    LoadFile(lf.FullName);
            }
            
            _step = 0;
            tlpAlg.RowCount = 10;
            tlpAlg.ColumnCount = 2;
            tlpAlg.ColumnStyles[0].SizeType = SizeType.Percent; tlpAlg.ColumnStyles[0].Width = 60;
            tlpAlg.ColumnStyles[1].SizeType = SizeType.Percent; tlpAlg.ColumnStyles[1].Width = 38;
            //tlpAlg.ColumnStyles[2].SizeType = SizeType.Percent; tlpAlg.ColumnStyles[2].Width = 19;
            tlpAlg.Controls.Clear();
            tlpAlg.Controls.Add(new Label { Text = @"Установленное оборудование", AutoSize = true}, 0, 0);
            tlpAlg.Controls.Add(new Label { Text = cbEquipmentType.Text }, 1, 0);
            pbPlan.EquipmentID = cbEquipmentType.SelectedIndex;
            //var btNext = new Button {Text = @"Далее", AutoSize = true};
            btNext.Click += NextButtonClick;
            //tlpAlg.Controls.Add(btNext, 2, 0);
            pbPlan.CurrentLine = 1;
            tlpAlg.RowStyles[0].SizeType = SizeType.Absolute;
            tlpAlg.RowStyles[0].Height = 25;
        }

        private void PlanPageReset()
        {
            _step = 0;
            tlpAlg.RowCount = 10;
            tlpAlg.ColumnCount = 2;
            tlpAlg.ColumnStyles[0].SizeType = SizeType.Percent; tlpAlg.ColumnStyles[0].Width = 60;
            tlpAlg.ColumnStyles[1].SizeType = SizeType.Percent; tlpAlg.ColumnStyles[1].Width = 38;
            tlpAlg.Controls.Clear();
            tlpAlg.Controls.Add(new Label { Text = @"Установленное оборудование", AutoSize = true }, 0, 0);
            tlpAlg.Controls.Add(new Label { Text = cbEquipmentType.Text }, 1, 0);
            pbPlan.EquipmentID = cbEquipmentType.SelectedIndex;
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            var stepId = _step + pbPlan.EquipmentID*100;
            switch (stepId)
            {
                case 1:
                case 101:
                case 201:
                case 301:
                case 401:
                case 501:
                    for (var i = 0; i < tlpAlg.ColumnCount; i++)
                    {
                        var ctrl = tlpAlg.GetControlFromPosition(i, pbPlan.CurrentLine);
                        tlpAlg.Controls.Remove(ctrl);
                    }
                    pbPlan.CurrentLine--;
                    _step--;
                    break;
                default :
                    return;
            }

        }

        private void NextButtonClick(object sender, EventArgs eventArgs)
        {
            var stepId = _step + pbPlan.EquipmentID*100;

            if ((stepId == 0) || (stepId == 100) || (stepId == 200) || (stepId == 300) || (stepId == 400) ||
                (stepId == 500))
            {
                pbPlan.CurrentLine = 1;
                tlpAlg.Controls.Add(new Label {Text = @"Актуальное пластовое давление?", AutoSize = true}, 0, 1);
                pbPlan.rbActualPressureY = new RadioButton{Text =@"Да"};
                pbPlan.rbActualPressureN = new RadioButton{Text = @"Нет"};
                //pbPlan.cbActualPressure = new CheckBox {Text = "", AutoSize = true};
                var pn = new FlowLayoutPanel{AutoSize = true};
                pn.Controls.Add(pbPlan.rbActualPressureY);
                pn.Controls.Add(pbPlan.rbActualPressureN);
                tlpAlg.Controls.Add(pn, 1, 1);
                //tlpAlg.Controls.Add(pbPlan.rbActualPressureN, 2, 1);
                _step++;
                return;
            }
            if ((stepId == 1) || (stepId == 101) || (stepId == 201) || (stepId == 301) || (stepId == 401) ||
                (stepId == 501))
            {
                if (!pbPlan.rbActualPressureY.Checked && !pbPlan.rbActualPressureN.Checked) return;
                pbPlan.rbActualPressureY.Enabled = false;
                pbPlan.rbActualPressureN.Enabled = false;
                //pbPlan.cbActualPressure.Enabled = false;
                if (pbPlan.rbActualPressureY.Checked)
                {
                    _step = 10;
                    stepId = _step + pbPlan.EquipmentID*100;
                }
                else
                {
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label {Text = @"Избыточное давление на устье", AutoSize = true}, 0,
                        pbPlan.CurrentLine);
                    pbPlan.rbExcessPressureY = new RadioButton{Text = @"Да"};
                    pbPlan.rbExcessPressureN = new RadioButton { Text = @"Нет" };
                    var pn = new FlowLayoutPanel{AutoSize=true};
                    
                    //pbPlan.cbExcessPressure = new CheckBox {Text = "", AutoSize = true};
                    pn.Controls.Add(pbPlan.rbExcessPressureY);
                    pn.Controls.Add(pbPlan.rbExcessPressureN);
                    tlpAlg.Controls.Add(pn, 1, pbPlan.CurrentLine);
                    _step++;
                    return;
                }
            }
            if ((stepId == 2) || (stepId == 102) || (stepId == 202) || (stepId == 302) || (stepId == 402) ||
                (stepId == 502))
            {
                if (!pbPlan.rbExcessPressureY.Checked && !pbPlan.rbExcessPressureN.Checked) return;
                pbPlan.rbExcessPressureY.Enabled = false;
                pbPlan.rbExcessPressureN.Enabled = false;
               // pbPlan.cbExcessPressure.Enabled = false;
                if (!pbPlan.rbExcessPressureY.Checked)
                {
                    _step = 10;
                    stepId = _step + pbPlan.EquipmentID*100;
                }
                else
                {
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label {Text = @"Есть возможность измерить плотность ВСЖ?", AutoSize = true},
                        0, pbPlan.CurrentLine);
                    //pbPlan.cbMeashureAble = new CheckBox();
                    pbPlan.rbMeasureAbleY = new RadioButton{Text = @"Да"};
                    pbPlan.rbMeasureAbleN = new RadioButton { Text = @"Нет" };
                    var pn = new FlowLayoutPanel{AutoSize = true};
                    pn.Controls.Add(pbPlan.rbMeasureAbleY);
                    pn.Controls.Add(pbPlan.rbMeasureAbleN);
                    tlpAlg.Controls.Add(pn, 1, pbPlan.CurrentLine);
                    _step++;
                    return;
                }
            } //КОнец общей ветки, начниаем по отдельности по каждому инструменту
            //Воронка +пакер запакирован+стингер
            if ((stepId == 3) || (stepId == 103) || (stepId==503))
            {
                //pbPlan.cbMeashureAble.Enabled = false;
                if (!pbPlan.rbMeasureAbleY.Checked && !pbPlan.rbMeasureAbleN.Checked) return;
                pbPlan.rbMeasureAbleY.Enabled = false;
                pbPlan.rbMeasureAbleN.Enabled = false;

                if (pbPlan.rbMeasureAbleY.Checked)
                {
                    _step = 10;
                    stepId = _step + pbPlan.EquipmentID*100;
                }
                else
                {
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label {Text = @"Закачиваем в НКТ", AutoSize = true}, 0, pbPlan.CurrentLine);
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label {Text = @"Наличие прохода?", AutoSize = true}, 0, pbPlan.CurrentLine);
                    //pbPlan.cbTunnelPresentl = new CheckBox();
                    pbPlan.rbTunnelPresentY = new RadioButton{Text = @"Да"};
                    pbPlan.rbTunnelPresentN = new RadioButton{Text = @"Нет"};
                    var pn = new FlowLayoutPanel{AutoSize = true};
                    pn.Controls.Add(pbPlan.rbTunnelPresentY);
                    pn.Controls.Add(pbPlan.rbTunnelPresentN);
                    tlpAlg.Controls.Add(pn, 1, pbPlan.CurrentLine);
                    _step++;
                    return;
                }
            }
            if ((stepId == 4) || (stepId == 104) ||(stepId==504))
            {
                if (!pbPlan.rbTunnelPresentY.Checked && !pbPlan.rbTunnelPresentN.Checked) return;
                pbPlan.rbTunnelPresentY.Enabled = false;
                pbPlan.rbTunnelPresentN.Enabled = false; 
                //pbPlan.cbTunnelPresentl.Enabled = false;
                if (!pbPlan.rbTunnelPresentY.Checked)
                {
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label {Text = @"Применяем ВЦ", AutoSize = true}, 0, pbPlan.CurrentLine);
                }
                pbPlan.CurrentLine++;
                tlpAlg.Controls.Add(new Label {Text = @"Есть циркуляция?", AutoSize = true}, 0, pbPlan.CurrentLine);
                //pbPlan.cbCirculationPresent = new CheckBox();
                pbPlan.rbCirculationPresentY = new RadioButton{Text= @"Да"};
                pbPlan.rbCirculationPresentN = new RadioButton { Text = @"Нет" };
                var pn = new FlowLayoutPanel{AutoSize = true};
                pn.Controls.Add(pbPlan.rbCirculationPresentY);
                pn.Controls.Add(pbPlan.rbCirculationPresentN);
                tlpAlg.Controls.Add(pn, 1, pbPlan.CurrentLine);
                _step++;
                return;
            }
            if ((stepId == 5) || (stepId == 105)||(stepId==505))
            {
                if (!pbPlan.rbCirculationPresentY.Checked && !pbPlan.rbCirculationPresentN.Checked) return;
                //pbPlan.cbCirculationPresent.Enabled = false;
                pbPlan.rbCirculationPresentY.Enabled = false;
                pbPlan.rbCirculationPresentN.Enabled = false;
                pbPlan.CurrentLine++;
                tlpAlg.Controls.Add(
                    pbPlan.cbCirculationPresent.Checked
                        ? new Label {Text = @"Закачиваем на циркуляцию", AutoSize = true}
                        : new Label {Text = @"Закачиваем на поглощение", AutoSize = true}, 0, pbPlan.CurrentLine);
                _step=10;
                return;
            }
            //Пакер распакирован
            if (stepId == 203)
            {
                if (!pbPlan.rbMeasureAbleY.Checked && !pbPlan.rbMeasureAbleN.Checked) return;
                pbPlan.rbMeasureAbleY.Enabled = false;
                pbPlan.rbMeasureAbleN.Enabled = false;
                //pbPlan.cbMeashureAble.Enabled = false;
                if (pbPlan.cbMeashureAble.Checked)
                {
                    _step = 10;
                    stepId = _step + pbPlan.EquipmentID*100;
                }
                else
                {
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label {Text = @"Закачиваем в затруб", AutoSize = true}, 0,
                        pbPlan.CurrentLine);
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label {Text = @"Наличие прохода?", AutoSize = true}, 0, pbPlan.CurrentLine);
                    //pbPlan.cbTunnelPresentl = new CheckBox();
                    pbPlan.rbTunnelPresentY = new RadioButton { Text = @"Да" };
                    pbPlan.rbTunnelPresentN = new RadioButton { Text = @"Нет" };
                    var pn = new FlowLayoutPanel { AutoSize = true };
                    pn.Controls.Add(pbPlan.rbTunnelPresentY);
                    pn.Controls.Add(pbPlan.rbTunnelPresentN);
                    tlpAlg.Controls.Add(pn, 1, pbPlan.CurrentLine);
                    tlpAlg.Controls.Add(pbPlan.cbTunnelPresentl, 1, pbPlan.CurrentLine);
                    _step++;
                    return;
                }
            }
            if (stepId == 204)
            {
                if (!pbPlan.rbTunnelPresentY.Checked && !pbPlan.rbTunnelPresentN.Checked) return;
                pbPlan.rbTunnelPresentY.Enabled = false;
                pbPlan.rbTunnelPresentN.Enabled = false;
                //pbPlan.cbTunnelPresentl.Enabled = false;
                if (!pbPlan.cbTunnelPresentl.Checked)
                {
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label {Text = @"Применяем ВЦ", AutoSize = true}, 0, pbPlan.CurrentLine);
                }
                pbPlan.CurrentLine++;
                tlpAlg.Controls.Add(new Label {Text = @"Есть циркуляция?", AutoSize = true}, 0, pbPlan.CurrentLine);
                //pbPlan.cbCirculationPresent = new CheckBox();
                pbPlan.rbCirculationPresentY = new RadioButton { Text = @"Да" };
                pbPlan.rbCirculationPresentN = new RadioButton { Text = @"Нет" };
                var pn = new FlowLayoutPanel { AutoSize = true };
                pn.Controls.Add(pbPlan.rbCirculationPresentY);
                pn.Controls.Add(pbPlan.rbCirculationPresentN);
                tlpAlg.Controls.Add(pn, 1, pbPlan.CurrentLine);
                _step++;
                return;
            }
            if (stepId == 205)
            {
                if (!pbPlan.rbCirculationPresentY.Checked && !pbPlan.rbCirculationPresentN.Checked) return;
                pbPlan.rbCirculationPresentY.Enabled = false;
                pbPlan.rbCirculationPresentN.Enabled = false;
                pbPlan.CurrentLine++;
                tlpAlg.Controls.Add(
                    pbPlan.cbCirculationPresent.Checked
                        ? new Label {Text = @"Закачиваем на циркуляцию", AutoSize = true}
                        : new Label {Text = @"Закачиваем на поглощение", AutoSize = true}, 0, pbPlan.CurrentLine);
                _step=10;
                return;
            }
            //ЭЦН+пакер
            if ((stepId == 303)||(stepId==403)) //первый шаг одинаковый с ЭЦН
            {
                if (!pbPlan.rbMeasureAbleY.Checked && !pbPlan.rbMeasureAbleN.Checked) return;
                pbPlan.rbMeasureAbleY.Enabled = false;
                pbPlan.rbMeasureAbleN.Enabled = false;
                if (pbPlan.rbMeasureAbleY.Checked)
                {
                    _step = 10;
                    stepId = _step + pbPlan.EquipmentID*100;
                }
                else
                {
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label {Text = @"Открыт клапан?", AutoSize = true}, 0, pbPlan.CurrentLine);
                    //pbPlan.cbClapanOpened = new CheckBox();
                    pbPlan.rbClapanOpenedY = new RadioButton{Text = @"Да"};
                    pbPlan.rbClaoanOpenedN = new RadioButton { Text = @"Нет" };
                    var pn = new FlowLayoutPanel{AutoSize = true};
                    pn.Controls.Add(pbPlan.rbClapanOpenedY);
                    pn.Controls.Add(pbPlan.rbClaoanOpenedN);
                    tlpAlg.Controls.Add(pn, 1, pbPlan.CurrentLine);
                    _step++;
                    return;
                }
            }
            if (stepId == 304)
            {
                if (!pbPlan.rbClapanOpenedY.Checked && !pbPlan.rbClaoanOpenedN.Checked) return;
                if (pbPlan.rbClapanOpenedY.Checked)
                {
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label { Text = @"Закачиваем в НКТ", AutoSize = true }, 0, pbPlan.CurrentLine);
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label { Text = @"Наличие прохода?", AutoSize = true }, 0, pbPlan.CurrentLine);
                    //pbPlan.cbTunnelPresentl = new CheckBox();
                    pbPlan.rbTunnelPresentY = new RadioButton{Text = @"Да"};
                    pbPlan.rbTunnelPresentN = new RadioButton{Text= @"Нет"};
                    var pn1 = new FlowLayoutPanel{AutoSize = true};
                    pn1.Controls.Add(pbPlan.rbTunnelPresentY);
                    pn1.Controls.Add(pbPlan.rbTunnelPresentN);
                    tlpAlg.Controls.Add(pn1, 1, pbPlan.CurrentLine);
                    _step=_step+2;
                    return;
                }
                pbPlan.CurrentLine++;
                tlpAlg.Controls.Add(new Label { Text = @"Наличие прохода?", AutoSize = true }, 0, pbPlan.CurrentLine);
               // pbPlan.cbTunnelPresentl = new CheckBox();
                pbPlan.rbTunnelPresentY = new RadioButton { Text = @"Да" };
                pbPlan.rbTunnelPresentN = new RadioButton { Text = @"Нет" };
                var pn = new FlowLayoutPanel {AutoSize = true};
                pn.Controls.Add(pbPlan.rbTunnelPresentY);
                pn.Controls.Add(pbPlan.rbTunnelPresentN);
                tlpAlg.Controls.Add(pn, 1, pbPlan.CurrentLine);
                _step++;
                return;
            }
            if (stepId == 305)
            {
                if (!pbPlan.rbTunnelPresentY.Checked && !pbPlan.rbTunnelPresentN.Checked) return;
                if (!pbPlan.cbTunnelPresentl.Checked)
                {
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label { Text = @"Применяем ВЦ", AutoSize = true }, 0, pbPlan.CurrentLine);
                }
                pbPlan.CurrentLine++;
                tlpAlg.Controls.Add(new Label { Text = @"Есть циркуляция?", AutoSize = true }, 0, pbPlan.CurrentLine);
                //pbPlan.cbCirculationPresent = new CheckBox();
                pbPlan.rbCirculationPresentY = new RadioButton{Text = @"Да"};
                pbPlan.rbCirculationPresentY = new RadioButton{Text = @"Нет"};
                var pn = new FlowLayoutPanel{AutoSize = true};
                pn.Controls.Add(pbPlan.rbCirculationPresentY);
                pn.Controls.Add(pbPlan.rbCirculationPresentN);
                tlpAlg.Controls.Add(pn, 1, pbPlan.CurrentLine);
                _step++;
                return;
            }
            if (stepId == 306)
            {
                if (!pbPlan.rbCirculationPresentY.Checked && !pbPlan.rbCirculationPresentN.Checked) return;
                pbPlan.rbCirculationPresentY.Enabled = false;
                pbPlan.rbCirculationPresentN.Enabled = false;
                if (pbPlan.rbClapanOpenedY.Checked)
                {
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(
                        pbPlan.cbTunnelPresentl.Checked
                            ? new Label {Text = @"Закачиваем на циркуляцию", AutoSize = true}
                            : new Label {Text = @"Закачиваем на поглощение", AutoSize = true}, 0, pbPlan.CurrentLine);
                    _step++;
                    return;
                }
                pbPlan.CurrentLine++;
                tlpAlg.Controls.Add(
                    pbPlan.cbCirculationPresent.Checked
                        ? new Label { Text = @"Закачиваем на циркуляцию", AutoSize = true }
                        : new Label { Text = @"Закачиваем на поглощение", AutoSize = true }, 0, pbPlan.CurrentLine);
                _step++;
                return;
            }
            //ЭЦН
            if (stepId == 404)
            {
                if (!pbPlan.rbClapanOpenedY.Checked && !pbPlan.rbClaoanOpenedN.Checked) return;
                pbPlan.rbClapanOpenedY.Enabled = false;
                pbPlan.rbClaoanOpenedN.Enabled = false;
                pbPlan.CurrentLine++;
                //pbPlan.cbTunnelPresentl = new CheckBox();
                pbPlan.rbTunnelPresentY = new RadioButton {Text = @"Да"};
                pbPlan.rbTunnelPresentN = new RadioButton { Text = @"Нет"};
                var pn = new FlowLayoutPanel{AutoSize = true};
                pn.Controls.Add(pbPlan.rbTunnelPresentY);
                pn.Controls.Add(pbPlan.rbTunnelPresentN);
                tlpAlg.Controls.Add(new Label{Text=@"Наличие прохода", AutoSize = true}, 0, pbPlan.CurrentLine);
                tlpAlg.Controls.Add(pn, 1, pbPlan.CurrentLine);
                _step++;
                return;
            }
            if (stepId == 405)
            {
                if (!pbPlan.rbTunnelPresentY.Checked && !pbPlan.rbTunnelPresentN.Checked) return;
                pbPlan.rbTunnelPresentY.Enabled = false;
                pbPlan.rbTunnelPresentN.Enabled = false;
                if (pbPlan.rbCirculationPresentY.Checked && pbPlan.rbTunnelPresentY.Checked)
                {
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label{Text = @"Закачка на циркуляцию.", AutoSize = true}, 0, pbPlan.CurrentLine);
                    _step++;
                    return;
                }
                if ((pbPlan.cbClapanOpened.Checked && !pbPlan.cbTunnelPresentl.Checked) ||
                    !pbPlan.cbClapanOpened.Checked)
                {
                    pbPlan.CurrentLine++;
                    tlpAlg.Controls.Add(new Label { Text = @"Закачка на циркуляцию.", AutoSize = true }, 0, pbPlan.CurrentLine);
                    if (!pbPlan.cbTunnelPresentl.Checked)
                    {
                        pbPlan.CurrentLine++;
                        tlpAlg.Controls.Add(new Label { Text = @"Применение ВЦ.", AutoSize = true }, 0, pbPlan.CurrentLine);
                    }
                    pbPlan.CurrentLine++;
                    //pbPlan.cbCirculationPresent = new CheckBox();
                    pbPlan.rbCirculationPresentY = new RadioButton{Text = @"Да"};
                    pbPlan.rbCirculationPresentN = new RadioButton { Text = @"Нет" };
                    var pn = new FlowLayoutPanel {AutoSize = true};
                    pn.Controls.Add(pbPlan.rbCirculationPresentY);
                    pn.Controls.Add(pbPlan.rbCirculationPresentN);
                    tlpAlg.Controls.Add(new Label { Text = @"Есть циркуляция?", AutoSize = true }, 0, pbPlan.CurrentLine);
                    tlpAlg.Controls.Add(pn, 1, pbPlan.CurrentLine);
                    _step++;
                    return;
                }
            }
            if (stepId == 406)
            {
                if (!pbPlan.rbCirculationPresentY.Checked && !pbPlan.rbCirculationPresentN.Checked) return;
                pbPlan.cbCirculationPresent.Enabled = false;
                pbPlan.CurrentLine++;
                tlpAlg.Controls.Add(
                    pbPlan.cbCirculationPresent.Checked
                        ? new Label { Text = @"Закачиваем на циркуляцию", AutoSize = true }
                        : new Label { Text = @"Закачиваем на поглощение", AutoSize = true }, 0, pbPlan.CurrentLine);
                _step++;
                return;
            }
            //{
            //    pbPlan.CurrentLine++;
            //    tlpAlg.Controls.Add(
            //        pbPlan.cbClapanOpened.Checked
            //            ? new Label { Text = @"Закачка в НКТ", AutoSize = true }
            //            : new Label { Text = @"Закачка в затруб", AutoSize = true }, 0, pbPlan.CurrentLine);
            //    _step++;
            //    return;
            //}
    }

        private void InitConfig()
        {//Init некоторых видимых элементов
            var et = new EquipmentType();
            cbEquipmentType.Items.Clear();
            foreach  (var e in et.RListEquipment())
            {
                cbEquipmentType.Items.Add(e.Value);
            }
            cbColumnLenghtU.SelectedIndex = 2;
            cs_Column_Geometry.SelectedIndex = 8;
            cbColumnTailLenghtU.SelectedIndex = 2;

            if (_conf.Pipes.Any())
            {
                cs_Pipe_Geometry.Items.Clear();
                foreach (var g in _conf.Pipes)
                    cs_Pipe_Geometry.Items.Add(new Geomrthey(g).ReturnStr());
                //cs_Pipe_Geometry.Update();
            }
            if (_conf.Columns.Any())
            {
                cs_Column_Geometry.Items.Clear();
                foreach (var g in _conf.Columns)
                    cs_Column_Geometry.Items.Add(new Geomrthey(g).ReturnStr());
            }
            cs_Pipe_Geometry.SelectedIndex = 0;
            cs_Column_Geometry.SelectedIndex = 0;
            _cat = new Catalog();
            var lst = _cat.StaffPropsList.Select(x => x.Ro).Distinct();
            foreach (var st in lst)
                cbRoSel.Items.Add(st);
            cbRoSel.SelectedIndex = 1;
            tlPlan.Width = tcCntrl.Width + 10;
            tlPlan.Dock = DockStyle.Fill;
            
            tlIncomingData.Dock = DockStyle.Left;
            tlIncomingData.HorizontalScroll.Enabled = false;
            tlIncomingData.VerticalScroll.Enabled = true;

            SetBeforeHead();

            if (!_conf.Coast.Any()) return;
            foreach (var ci in _conf.Coast.OrderBy(x=>x.Density))
            {
                var rowId = dgCoastTable.Rows.Add();
                var row = dgCoastTable.Rows[rowId];
                row.Cells[0].Value = ci.Density;
                row.Cells[1].Value = ci.Coast;
            }
            
        }

        private void SetBeforeHead()
        {
            var lst = new PlanData();
            foreach (var ix in lst.GetList())
                lbBeforeHand.Items.Add(ix.Text());
            var root = new TreeNode("План работ");
            tvPlan.Nodes.Add(root);
            tvPlan.SelectedNode = root;

            lbBeforeHand.SelectedIndex = 1;
            //lbBeforeHand.AllowDrop = true;
            //lbBeforeHand.Drag
            var pd = new PumpData();
            foreach (var it in pd.GetStepList())
            {
                cbDoubleStep.Items.Add(it.ToString());
                //var i = 0;
            }
        }

        private static Geomrthey GetColumnGeomethry(int index)
        {//парамеры обсадной колонны из справочника
            return _conf.Columns.Any(x => x.Index.Equals(index)) ? new Geomrthey(_conf.Columns.First(x => x.Index.Equals(index))) : new Geomrthey(0, 0);
        }

        private static Geomrthey GetPipeGeomethry(int index)
        {//параметры трубы из справочника
            return _conf.Pipes.Any(x => x.Index.Equals(index)) ? new Geomrthey(_conf.Pipes.First(x => x.Index.Equals(index))) : new Geomrthey(0, 0);
        }

        private static BedType GetBedType(int idx)
        {//Параметры ХЗ, чего из справочника Тип пласа
            return _conf.BedTypes.Any(x => idx.Equals(x.Index)) ? new BedType(_conf.BedTypes.First(x => idx.Equals(x.Index))) : new BedType(0, 0);
        }


        private static void UpdateParametrs()
        {
            //Добавить нужный код
        }


        private Calculate GetCalculateData()
        {//Подготовка к расчету
            var pg = GetPipeGeomethry(cs_Pipe_Geometry.SelectedIndex);
            var cg = GetColumnGeomethry(cs_Column_Geometry.SelectedIndex);
            var uv = GetUnevenness(cs_Unevenness.SelectedIndex);
            var bt = GetBedType(cs_Bed_Type.SelectedIndex);
            //var ro = GetDensity(tbOnAssayDensity.Text, cbOnAssayDensityU.SelectedIndex);
            var rCalc = new Calculate
            {
                Ks = GetSafetyFactor(cs_Safety_Factor.SelectedIndex),
                DOutP = pg.Dout,
                DinP = pg.Din,
                DOutC = cg.Dout, 
                DinC = cg.Din,
                K1 = uv.K1,
                K2 = uv.K2,
                K = bt.K,
                M = bt.M
            };
            rCalc.SetWaterFlag(false);
            //double.TryParse(tbCurrentStall.Text, out rCalc.H);
            rCalc.H = GetLenght(tbCurrentStall.Text, cbCurrentStallU.SelectedIndex);
            //double.TryParse(e_Bed_Pressure.Text, out rCalc.P0);
            rCalc.P0 = GetPressure(e_Bed_Pressure.Text, cbStratumPressureU.SelectedIndex);
            //double.TryParse(e_Bed_Thickness.Text, out rCalc.Hb)
            rCalc.Hb = GetLenght(e_Bed_Thickness.Text, cbBedThicknessU.SelectedIndex);
            //double.TryParse(e_Perforation_Distance_By_Pipe.Text, out rCalc.Hpw);
            rCalc.Hpw = GetLenght(e_Perforation_Distance_By_Pipe.Text, cbUpPerforationLenghtU.SelectedIndex);
            //double.TryParse(e_Perforation_Distance_Vertical.Text, out rCalc.Hpv)
            rCalc.Hpv = GetLenght(e_Perforation_Distance_Vertical.Text, cbUpPerforationHeightU.SelectedIndex);
            //double.TryParse(e_Hole_Position_By_Pipe.Text, out rCalc.Hhw)
            rCalc.Hhw = GetLenght(e_Hole_Position_By_Pipe.Text, cbCirculationLenghtU.SelectedIndex);
            //double.TryParse(e_Hole_Position_Vertical.Text, out rCalc.Hhv);
            rCalc.Hhv = GetLenght(e_Hole_Position_Vertical.Text, cbCirculationHeightU.SelectedIndex);
            //double.TryParse(e_Density_BL.Text, out rCalc.Ro0);
            rCalc.Ro0 = GetDensity(tbOnAssayDensity.Text, cbOnAssayDensityU.SelectedIndex);
            //rCalc.Ro0 = cs_Density_Unit_BL.SelectedIndex != 0 ? rCalc.Ro0 / 1000 : rCalc.Ro0;
            //double.TryParse(e_Dyn_Viscosity_BL.Text, out rCalc.My0)
            rCalc.My0 = GetViscosity(e_Dyn_Viscosity_BL.Text, cs_Dyn_Viscosity_Unit_BL.SelectedIndex);
            //rCalc.My0 = cs_Dyn_Viscosity_Unit_BL.SelectedIndex != 0 ? rCalc.My0 / 0.101325 : rCalc.My0;
            //double.TryParse(e_Dyn_Viscosity_CL.Text, out rCalc.My)
            rCalc.My = GetViscosity(e_Dyn_Viscosity_CL.Text, cs_Dyn_Viscosity_Unit_CL.SelectedIndex);
            //rCalc.My = cs_Dyn_Viscosity_Unit_CL.SelectedIndex != 0 ? rCalc.My / 0.101325 : rCalc.My;
            rCalc.S1 = Math.PI*Math.Pow(rCalc.DinP/1000.0, 2)/4.0;
            rCalc.S2 = Math.PI * (Math.Pow(rCalc.DinC / 1000.0, 2) - Math.Pow(rCalc.DOutP / 1000.0, 2)) / 4.0;
            rCalc.ROd = (1.0 + 0.01*rCalc.Ks)*rCalc.P0/* * 101.325*//(9.81*rCalc.Hpv);
            //RO:=(1.0+0.01*KS)*P0*101.325/(9.81*Hhv)-RO0*(Hpv-Hhv)/Hhv; оригинальная формула
            rCalc.Ro = (rCalc.ROd * (rCalc.S2 * rCalc.Hhw + rCalc.S1 * rCalc.Hhw + Math.PI * Math.Pow(rCalc.DinC / 2000.0, 2) * (rCalc.H - rCalc.Hhw)) - rCalc.Ro0 * Math.PI * Math.Pow(rCalc.DinC / 2000.0,2) * (rCalc.H - rCalc.Hhw)) / (rCalc.S2 * rCalc.Hhw + rCalc.S1 * rCalc.Hhw);
            rCalc.N = 100;
            return rCalc;
        }

        private static Unevenness GetUnevenness(int index)
        {//Параметры шероховатости трубы, для старой-новой скважины
            var lst = new Dictionary<int, Unevenness>
            {
                {0, new Unevenness(0.05, 0.05)},
                {1, new Unevenness(0.00005, 0.00005)}
            };
            return lst.ContainsKey(index) ? lst[index] : new Unevenness(0, 0);
        }
        private static int GetSafetyFactor(int index)
        {
            //Насколько я понимаю, процент превышения пластового давления
            var a = new[] {3, 5, 7, 10};
            if ((index >= 0) && (index < 4))
                return a[index];
            return 0;
        }

        private static IEnumerable<CGeomethry> GeneratePipeList()
        {
            var pipes = new List<CGeomethry>
            {
                new CGeomethry {Index = 0, Dout = 48, W = 4},
                new CGeomethry {Index = 1, Dout = 60, W = 5},
                new CGeomethry {Index = 2, Dout = 73, W = 5},
                new CGeomethry {Index = 3, Dout = 73, W = 5.5},
                new CGeomethry {Index = 4, Dout = 73, W = 6},
                new CGeomethry {Index = 5, Dout = 73, W = 7},
                new CGeomethry {Index = 6, Dout = 89, W = 6},
                new CGeomethry {Index = 7, Dout = 89, W = 6.5},
                new CGeomethry {Index = 8, Dout = 89, W = 7.34},
                new CGeomethry {Index = 9, Dout = 89, W = 8},
                new CGeomethry {Index = 10, Dout = 102, W = 6.5},
                new CGeomethry {Index = 11, Dout = 114, W = 7}
            };
            return pipes;
        }
        private static IEnumerable<CGeomethry> GenerateColumnList()
        {
            var columns = new List<CGeomethry>
            {
                new CGeomethry {Index = 0, Dout = 140, W = 7.8},
                new CGeomethry {Index = 1, Dout = 146, W = 6.5},
                new CGeomethry {Index = 2, Dout = 146, W = 7},
                new CGeomethry {Index = 3, Dout = 146, W = 7.7},
                new CGeomethry {Index = 4, Dout = 146, W = 8.5},
                new CGeomethry {Index = 5, Dout = 146, W = 9.5},
                new CGeomethry {Index = 6, Dout = 146, W = 10.7},
                new CGeomethry {Index = 7, Dout = 168, W = 7.3},
                new CGeomethry {Index = 8, Dout = 168, W = 8},
                new CGeomethry {Index = 9, Dout = 168, W = 8.9},
                new CGeomethry {Index = 10, Dout = 168, W = 10.6},
                new CGeomethry {Index = 11, Dout = 178, W = 8.2},
                new CGeomethry {Index = 12, Dout = 178, W = 9.3},
                new CGeomethry {Index = 13, Dout = 178, W = 10.04},
                new CGeomethry {Index = 14, Dout = 178, W = 10.5},
                new CGeomethry {Index = 15, Dout = 219, W = 8.8},
                new CGeomethry {Index = 16, Dout = 219, W = 10.2},
                new CGeomethry {Index = 17, Dout = 245, W = 11.1}
            };
            return columns;
        }

        private static IEnumerable<CBedType> GenerateBedTypes()
        {
            var bt = new List<CBedType>
            {
                new CBedType {Index = 0, K = 0.17, M = 20},
                new CBedType {Index = 1, K = 0.1, M = 25},
                new CBedType {Index = 2, K = 0.155, M = 315},
                new CBedType {Index = 3, K = 0.171, M = 22},
                new CBedType {Index = 4, K = 0.171, M = 22},
                new CBedType {Index = 5, K = 0.07, M = 19},
                new CBedType {Index = 6, K = 0.2, M = 22},
                new CBedType {Index = 7, K = 0.05, M = 22},
                new CBedType {Index = 8, K = 0.57, M = 22},
                new CBedType {Index = 9, K = 0.057, M = 22},
                new CBedType {Index = 10, K = 0.2, M = 20},
                new CBedType {Index = 11, K = 0.13, M = 19}
            };
            return bt;
        }

        private  void SaveConfig()
        {//Config сохранение
            var cTable = new CoastTable(dgCoastTable);
            _conf.Coast = cTable.ReturnList();

            var writer = new XmlSerializer(typeof(ConfData));
            
            if (_conf.LastPath == null) _conf.LastPath = "";
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\IGconf.xml";
            var file = File.Create(path);
            writer.Serialize(file, _conf);
            file.Close();
            SaveFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\IGAutoSave.xml");
        }

        private static ConfData LoadConfig()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\IGconf.xml";
            if (!File.Exists(path)) return null;
            var reader = new XmlSerializer(typeof (ConfData));


            var file = File.Open(path, FileMode.Open);

            var cnt = (ConfData) reader.Deserialize(file);
            file.Close();

            foreach (var ci in GenerateColumnList().Where(ci => !cnt.Columns.Any(x => x.Index.Equals(ci.Index))))
                cnt.Columns.Add(ci);
            foreach (var pi in GeneratePipeList().Where(pi => !cnt.Pipes.Any(x => x.Index.Equals(pi.Index))))
                cnt.Pipes.Add(pi);
            foreach (var bi in GenerateBedTypes().Where(bi => !cnt.Pipes.Any(x => x.Index.Equals(bi.Index))))
                cnt.BedTypes.Add(bi);


            return cnt;
        }


        private List<double> GetMultyDataControl(int code)
        {
            var resControl = new Control();
            var resStringList = new List<String>();
            var resList = new List<double>();
            switch (code)
            {
                case  0:
                    return resList;
                case 1:
                  resControl = e_Perforation_Distance_By_Pipe;
                    break;
                case 2:
                     resControl = e_Perforation_Distance_Vertical;
                    break;
                case 3:
                    resControl = e_Hole_Position_By_Pipe;
                    break;
                case 4:
                    resControl = e_Hole_Position_Vertical;
                    break;
                case 5:
                    resControl = tbCurrentStall;
                    break;
                case 6:
                    resControl = e_Bed_Thickness;
                    break;
                case 7:
                     resControl = e_Bed_Pressure;
                    break;
                case 8:
                    resControl = e_Density_BL;
                    break;
                case 9:
                    resControl = e_Dyn_Viscosity_BL;
                    break;
                case 10:
                    if (code == 10) resControl = e_Dyn_Viscosity_CL;
                    break;
                default:
                    return resList;
            }
            if (resControl.Tag != null)
                resStringList = (List<String>) resControl.Tag;
            foreach (var nx in resStringList.Select(x => x.Replace('.', ',')))
            {
                double td;
                if (double.TryParse(nx, out td))
                    resList.Add(td);
            }
            return resList;
        }
        private void ShowResult()
        {
            UpdateParametrs();
            var data = GetCalculateData();
            var res = data.StartCalc();
            var calc = PrepareCalcData();

            tlpChart.Controls.Clear();
            //Насосный график
            var ds = calc.RChartTable().ToArray();
            var pumpChart = new Chart();
            pumpChart.Titles.Add(new Title("График прокачки", Docking.Top, new Font(FontFamily.Families.First().Name, 18, FontStyle.Regular), Color.Black));
            pumpChart.BorderWidth = 1;
            var pumpSeries = new Series
            {
                Name = "График прокачки",
                Color = Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line,
                MarkerStyle = MarkerStyle.Diamond,
                MarkerSize = 8
            };
            foreach (var it in ds)
                pumpSeries.Points.AddXY(it.Step, it.Pressure);
            var pumpMin = 0;
            try
            {
                pumpMin = (int)Math.Truncate(ds.Select(x => x.Pressure).Min() - (ds.Select(x => x.Pressure).Max() - ds.Select(x => x.Pressure).Min())/5);
            }
            catch (Exception)
            {
                //var tmn = e.Message;
            }
            
            var pumpArea = new ChartArea
            {
                AxisX =
                {
                    Title = "Число ходов",
                    Minimum = 1,
                    MajorGrid =
                    {
                        Interval = 5,
                        LineColor = Color.LightBlue
                    },
                    MinorGrid =
                    {
                        Enabled = true,
                        Interval = 1,
                        LineColor = Color.AntiqueWhite
                    }
                },
                AxisY =
                {
                    Title = "Давление, Атм",
                    Minimum = pumpMin,
                    MajorGrid =
                    {
                        Interval = 20,
                        LineColor = Color.LightSteelBlue
                    },
                    MinorGrid =
                    {
                        Enabled = true,
                        Interval = 5,
                        LineColor = Color.Gainsboro
                    }
                }
            };
            
            //pumpArea.AxisX.Interval = 100;

            pumpChart.ChartAreas.Add(pumpArea);
            pumpChart.Series.Add(pumpSeries);
            pumpChart.Dock = DockStyle.Fill;
            tlpChart.Controls.Add(pumpChart);
            //конец графика закачки

            
            //Графики прогнозируемые

            //---chart1
            var chart1 = BuildChart(1, res);
            tlpChart.Controls.Add(chart1);
            var chart2 = BuildChart(2, res);
            tlpChart.Controls.Add(chart2);
            var chart3 = BuildChart(3, res);
            tlpChart.Controls.Add(chart3);
            var chart4 = BuildChart(4, res);
            tlpChart.Controls.Add(chart4);

            var chCode = 0;
            var lst = GetMultyDataControl(chCode);
            if (lst.Count < 2) chCode = 0;
            if (chCode == 0)
            {
                data.SetWaterFlag(true);
                var resx = data.StartCalc();
                var wSeries1 = new Series
                {
                    Name = "Водный график",
                    Color = Color.Blue,
                    IsVisibleInLegend = false,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Line
                };
                foreach (
                    var x in
                        resx.CLst.Select(t => new {xStep = t.XStep, ff = t.Ff}).ToDictionary(t => t.xStep, t => t.ff))
                {
                    wSeries1.Points.AddXY(x.Key, x.Value);
                }
                chart1.Series.Add(wSeries1);
                //---
                var wSeries2 = new Series
                {
                    Name = "Водный график",
                    Color = Color.Blue,
                    IsVisibleInLegend = false,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Line
                };
                foreach (
                    var x in
                        resx.CLst.Select(t => new { xStep = t.XStep, ff = t.Rf }).ToDictionary(t => t.xStep, t => t.ff))
                {
                    wSeries2.Points.AddXY(x.Key, x.Value);
                }
                chart2.Series.Add(wSeries2);
                //--
                var wSeries3 = new Series
                {
                    Name = "Водный график",
                    Color = Color.Blue,
                    IsVisibleInLegend = false,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Line
                };
                foreach (
                    var x in
                        resx.CLst.Select(t => new { xStep = t.XStep, ff = t.Vf }).ToDictionary(t => t.xStep, t => t.ff))
                {
                    wSeries3.Points.AddXY(x.Key, x.Value);
                }
                chart3.Series.Add(wSeries3);
                //--
                var wSeries4 = new Series
                {
                    Name = "Водный график",
                    Color = Color.Blue,
                    IsVisibleInLegend = false,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Line
                };
                foreach (
                    var x in
                        resx.CLst.Select(t => new { xStep = t.XStep, ff = t.Vr }).ToDictionary(t => t.xStep, t => t.ff))
                {
                    wSeries4.Points.AddXY(x.Key, x.Value);
                }
                chart4.Series.Add(wSeries4);
            }
            else
            {
                var cLst = new List<Color>
                {
                    //Color.Blue,
                    Color.Red,
                    Color.Indigo,
                    Color.Goldenrod,
                    Color.Lime,
                    Color.SaddleBrown,
                    Color.Green
                };
                foreach (var bx in lst)
                {
                    switch (chCode)
                    {
                        case 1:
                            data.Hpw = bx;
                            break;
                        case 2:
                            data.Hpv = bx;
                            break;
                        case 3:
                            data.Hhw = bx;
                            break;
                        case 4:
                            data.Hhv = bx;
                            break;
                        case 5:
                            data.H = bx;
                            break;
                        case 6:
                            data.Hb = bx;
                            break;
                        case 7:
                            data.P0 = bx;
                            break;
                        case 8:
                            data.Ro0 = cs_Density_Unit_BL.SelectedIndex != 0 ? bx/1000 : bx;
                            break;
                        case 9:
                            data.My0 = cs_Dyn_Viscosity_Unit_BL.SelectedIndex != 0 ? bx/0.101325 : bx;
                            break;
                        case 10:
                            data.My = cs_Dyn_Viscosity_Unit_CL.SelectedIndex != 0 ? bx/0.101325 : bx;
                            break;
                    }
                    var resx = data.StartCalc();
                    var clr = cLst.Last();
                    cLst.Remove(clr);
                    var wSeries1 = new Series
                    {
                        Name = bx.ToString("N"),
                        Color = clr,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = true,
                        ChartType = SeriesChartType.Line
                    };
                    foreach (
                        var x in
                            resx.CLst.Select(t => new { xStep = t.XStep, ff = t.Ff }).ToDictionary(t => t.xStep, t => t.ff))
                    {
                        wSeries1.Points.AddXY(x.Key, x.Value);
                    }
                    chart1.Series.Add(wSeries1);
                    //---
                    var wSeries2 = new Series
                    {
                        Name = bx.ToString("N"),
                        Color = clr,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = true,
                        ChartType = SeriesChartType.Line
                    };
                    foreach (
                        var x in
                            resx.CLst.Select(t => new { xStep = t.XStep, ff = t.Rf }).ToDictionary(t => t.xStep, t => t.ff))
                    {
                        wSeries2.Points.AddXY(x.Key, x.Value);
                    }
                    chart2.Series.Add(wSeries2);
                    //--
                    var wSeries3 = new Series
                    {
                        Name = bx.ToString("N"),
                        Color = clr,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = true,
                        ChartType = SeriesChartType.Line
                    };
                    foreach (
                        var x in
                            resx.CLst.Select(t => new { xStep = t.XStep, ff = t.Vf }).ToDictionary(t => t.xStep, t => t.ff))
                    {
                        wSeries3.Points.AddXY(x.Key, x.Value);
                    }
                    chart3.Series.Add(wSeries3);
                    //--
                    var wSeries4 = new Series
                    {
                        Name = bx.ToString("N"),
                        Color = clr,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = true,
                        ChartType = SeriesChartType.Line
                    };
                    foreach (
                        var x in
                            resx.CLst.Select(t => new { xStep = t.XStep, ff = t.Vr }).ToDictionary(t => t.xStep, t => t.ff))
                    {
                        wSeries4.Points.AddXY(x.Key, x.Value);
                    }
                    chart4.Series.Add(wSeries4);
                }
            }

            //--Расчетная стоимость
            var cTable = new CoastTable(dgCoastTable);
            var tb = cTable.ReturnList();

            var coastChart = new Chart();
            coastChart.Titles.Add(new Title("Зависимость стоимости от плотности раствора", Docking.Top, new Font(FontFamily.Families.First().Name, 18, FontStyle.Regular), Color.Black));
            
            coastChart.BorderWidth = 1;
            var coastSeries = new Series
            {
                Name = "Произвольная плотность",
                Color = Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 4
            };
           
            foreach (var it in tb.Where(it => it.Density>=calc.RJamDensity()/1000))
            {
                coastSeries.Points.AddXY(it.Density, calc.RVolFuncJam(it.Density*1000)*it.Coast/1000);
            }
           
            var coastArea = new ChartArea
            {
                AxisX =
                {
                    Title = "Плотность раствора",
                    Minimum = 1,
                    MajorGrid =
                    {
                        //Interval = 5,
                        LineColor = Color.LightBlue
                    },
                    MinorGrid =
                    {
                        Enabled = true,
                        //Interval = 1,
                        LineColor = Color.AntiqueWhite
                    }
                },
                AxisY =
                {
                    Title = "Стоимость глушения (тыс.руб.)",
                    //Minimum = pumpMin,
                    MajorGrid =
                    {
                        //Interval = 20,
                        LineColor = Color.LightSteelBlue
                    },
                    MinorGrid =
                    {
                        Enabled = true,
                        //Interval = 5,
                        LineColor = Color.Gainsboro
                    }
                }
            };

            //pumpArea.AxisX.Interval = 100;

            coastChart.ChartAreas.Add(coastArea);
            coastChart.Series.Add(coastSeries);
            
            coastChart.Dock = DockStyle.Fill;
            tlpChart.Controls.Add(coastChart);

        }

        private static Chart BuildChart(int type, CalcResult res)
        {
            //
            var legend1 = new Legend { Name = "Legend1" };
            var chartArea1 = new ChartArea
            {
                AxisX =
                {
                    Minimum = 1,
                    MajorGrid =
                    {
                        LineColor = Color.LightBlue
                    },
                    MinorGrid =
                    {
                        Enabled = true,
                        LineColor = Color.AntiqueWhite
                    }
                },
                AxisY =
                {
                    MajorGrid =
                    {
                        LineColor = Color.LightSteelBlue
                    },
                    MinorGrid =
                    {
                        Enabled = true,
                        LineColor = Color.Gainsboro
                    }
                }
            };

            chartArea1.AxisX.LabelStyle.Format = "{F1}";
            //chartArea1.AxisX.Interval = 10;
            var series1 = new Series
            {
                Name = "Основной график",
                Color = Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };
            string xTitle, yTitle, sTitle;
            Dictionary<double, double> cd;
            switch (type)
            {
                case 1:
                    cd = res.CLst.Select(t => new {xStep = t.XStep, ff = t.Ff}).ToDictionary(t => t.xStep, t => t.ff);
                    xTitle = "Q л/с";
                    yTitle = "P, атм";
                    sTitle = "Избыточное давление. Прямая промывка";
                    break;
                case 2:
                    cd = res.CLst.Select(t => new { xStep = t.XStep, rf = t.Rf }).ToDictionary(t => t.xStep, t => t.rf);
                    xTitle = "Q л/с";
                    yTitle = "P, атм";
                    sTitle = "Избыточное давление. Обратная промывка";
                    break;
                case 3:
                    cd = res.CLst.Select(t => new { xStep = t.XStep, vf = t.Vf }).ToDictionary(t => t.xStep, t => t.vf);
                    xTitle = "Q л/с";
                    yTitle = "V, Л";
                    sTitle = "Объем ЖГ проникающий в пласт. Прямая промывка";
                    break;
                case 4:
                    cd = res.CLst.Select(t => new { xStep = t.XStep, vr = t.Vr }).ToDictionary(t => t.xStep, t => t.vr);
                    xTitle = "Q л/с";
                    yTitle = "V, Л";
                    sTitle = "Объем ЖГ проникающий в пласт. Обратная промывка";
                    break;
                default:
                    xTitle = " ";
                    yTitle = " ";
                    sTitle = " ";
                    cd = res.CLst.Select(t => new { xStep = t.XStep, vr = t.Vr }).ToDictionary(t => t.xStep, t => t.vr);
                    break;
            }

            foreach (var x in cd)
            {
                series1.Points.AddXY(x.Key, x.Value);
            }
            var cFf = new Chart
            {
                Visible = true,
                Dock = DockStyle.Fill,
                DataSource = res
            };
            cFf.Titles.Add(new Title(sTitle, Docking.Top, new Font(FontFamily.Families.First().Name, 18, FontStyle.Regular), Color.Black));
            
            chartArea1.AxisX.Title = xTitle;
            chartArea1.AxisY.Title = yTitle;
            cFf.ChartAreas.Add(chartArea1);
            cFf.Series.Add(series1);
            
            cFf.Legends.Add(legend1);
            //cFf.All
            return cFf;
        }

        private void SaveFile(string filename)
        {
            var pc = _pipeConf.Select(x => x.GetConfigItem()).ToList();
            var sd = new StoreData
            {
                //Описание
                OilFiledName = e_OilField_name.Text,
                WellNumber = e_Well_Number.Text,
                ClusterName = e_Cluster_Name.Text,
                ServiceCompany = tbServiceCompany.Text,
                Brigade = tbBrigade.Text,
                Master = tbMaster.Text,
                //Колонна
                ColumnGeomethry = cs_Column_Geometry.SelectedIndex,
                ColumnLenght = tbColumnLenght.Text,
                ColumnLenghtU = cbColumnLenghtU.SelectedIndex,
                ColumnHeight = tbColumnHeight.Text,
                ColumnHeightU = cbColumnHeightU.SelectedIndex,
                AdaptorLenght = tbAdaptorLenght.Text,
                AdaptorLenghtU = cbAdaptorLenght.SelectedIndex,
                //Хвостовик
                ColumnTail = cbColumnTail.SelectedIndex,
                ColumnTailLenght = tbColumnTailLenght.Text,
                ColumnTailLenghtU = cbColumnTailLenghtU.SelectedIndex,
                ColumnTailHeight = tbColumnTailHeight.Text,
                ColumnTailHeightU = cbColumnTailHeightU.SelectedIndex,
                //Оборудование
                EquipmentType = cbEquipmentType.SelectedIndex,
                //Нижняя подвеска
                LowerHanger = cbLowerHanger.SelectedIndex,
                LowerHangerLenght = tbLowerHangerLenght.Text,
                LowerHangerLenghtU = cbLowerHangerLenghtU.SelectedIndex,
                LowerHangerHeight = tbLowerHangerHeight.Text,
                LowerHangerHeightU = cbLowerHangerHeightU.SelectedIndex,
                //Верхняя подвеска
                PipeGeomethry = cs_Pipe_Geometry.SelectedIndex,
                UpperHangerLenght = tbUpperHangerLenght.Text,
                UpperHangerLenghtU = cbUpperHangerLenghtU.SelectedIndex,
                UpperHangerHeight = tbUpperHangerHeight.Text,
                UpperHangerHeightU = cbUpperHangerHeightU.SelectedIndex,
                //Циркуляционное отверстие
                CirculationHolePresent = cbCirculationHolePresent.Checked,
                HolePositionByPipe = e_Hole_Position_By_Pipe.Text,
                CirculationLenghtU = cbCirculationLenghtU.SelectedIndex,
                HolePositionVertical = e_Hole_Position_Vertical.Text,
                CirculationHeightU = cbCirculationHeightU.SelectedIndex,
                //Далвение
                BedPressure = e_Bed_Pressure.Text,
                StratumPressureU = cbStratumPressureU.SelectedIndex,
                Orifice = tbOrifice.Text,
                OrificeU = cbOrificeU.SelectedIndex,
                GasFactor = cbGasFactor.SelectedIndex,
                SaturationPressure = tbSaturationPressure.Text,
                SaturationPressureU = cbSaturationPressure.SelectedIndex,
                //Перфорация
                PerforationDistanceByPipe = e_Perforation_Distance_By_Pipe.Text,
                UpPerforationLenghtU = cbUpPerforationLenghtU.SelectedIndex,
                PerforationDistanceByVertical = e_Perforation_Distance_Vertical.Text,
                UpPerforationHeightU = cbUpPerforationHeightU.SelectedIndex,
                BottomPerforationLenght = tbBottomPerforationLenght.Text,
                BottomPerforationLenghtU = cbBottomPerforationLenghtU.SelectedIndex,
                BottomPerforationHeight = tbBottomPerforationHeight.Text,
                BottomPerforationHeightU = cbBottomPerforationHeightU.SelectedIndex,
                //Забой
                WellBottomDepth = tbCurrentStall.Text,
                CurrentStallU = cbCurrentStallU.SelectedIndex,
                FactitiousStall = tbFactitiousStall.Text,
                FactitiousStallU = cbFactitiousStallU.SelectedIndex,
                //Плотности
                OnAssayDensity = tbOnAssayDensity.Text,
                OnAssayDensityU = cbOnAssayDensityU.SelectedIndex,
                UsedDensity = tbUsedDensity.Text,
                UsedDensityU = cbUsedDensityU.SelectedIndex,
                //Данные насоса
                DoubleStep = cbDoubleStep.SelectedIndex,
                PistonDiam = cbPistonDiam.SelectedIndex,
                LevelingSpeed = tbLevelingSpeed.Text,
                LevelingSpeedU = cbLevelingSpeedU.SelectedIndex,
                PumpSupply = tbPumpSupply.Text,
                PumpSupplyU = cbPumpSupplyU.SelectedIndex,
                PumpPressure = tbPumpPressure.Text,
                PumpPressureU = cbPumpPressureU.SelectedIndex,
                //Данные о притоке
                NktPressure = tbNktPressure.Text,
                NktPressureU = cbNktPressureU.SelectedIndex,
                AnnulusPressure = tbAnnulusPressure.Text,
                AnnulusPressureU = cbAnnulusPressureU.SelectedIndex,
                //Параметры жидкостей
                DensityBl = e_Density_BL.Text,
                DensityUnitBl = cs_Density_Unit_BL.SelectedIndex,
                DynViscosityBl = e_Dyn_Viscosity_BL.Text,
                DynViscosityUnitBl = cs_Dyn_Viscosity_Unit_BL.SelectedIndex,
                DynViscosityCl = e_Dyn_Viscosity_CL.Text,
                DynViscosityUnitCl = cs_Dyn_Viscosity_Unit_CL.SelectedIndex,
                //Данные скважины
                Unevenness = cs_Unevenness.SelectedIndex,
                SafetyFactor = cs_Safety_Factor.SelectedIndex,
                //Параметры пласта
                BedThickness = e_Bed_Thickness.Text,
                BedType = cs_Bed_Type.SelectedIndex,
                BedPressureUnit = cbBedThicknessU.SelectedIndex,
                //Размерности результативных параметров
                ResDensityPutFluidU = cbResDensityPutFluidU.SelectedIndex,
                ResJamDensityU = cbResJamDensityU.SelectedIndex,
                ResInnerTimeU = cbResInnerTimeU.SelectedIndex,
                ResOutPipeInningTimeU = cbResOutPipeInningTimeU.SelectedIndex,
                ResClearingInningTimeU = cbResClearingInningTimeU.SelectedIndex,
                ResNcdu = cbResNCDU.SelectedIndex,
                ResKcdu = cbResKCDU.SelectedIndex,
                ResReducing100U = cbResReducing100U.SelectedIndex,
                //Конфигурация трубы
                PipeConfList = pc
            };

            var writer = new XmlSerializer(typeof(StoreData));
            var file = File.Create(filename);
            writer.Serialize(file, sd);
            file.Close();
        }


        private  void LoadFile(string filename)
        {
            var reader = new XmlSerializer(typeof(StoreData));
            if (!File.Exists(filename)) return;
            var file = File.Open(filename, FileMode.Open);
            var cnt = (StoreData)reader.Deserialize(file);
            file.Close();
            var fn = new FileInfo(filename);
            _conf.LastPath = fn.DirectoryName;
            //Описание
            e_OilField_name.Text = cnt.OilFiledName;
            e_Well_Number.Text = cnt.WellNumber;
            e_Cluster_Name.Text = cnt.ClusterName;
            tbServiceCompany.Text = cnt.ServiceCompany;
            tbBrigade.Text = cnt.Brigade;
            tbMaster.Text = cnt.Master;
            //Колонна
            cs_Column_Geometry.SelectedIndex = cnt.ColumnGeomethry;
            tbColumnLenght.Text = cnt.ColumnLenght;
            cbColumnLenghtU.SelectedIndex = cnt.ColumnLenghtU;
            tbColumnHeight.Text = cnt.ColumnHeight;
            cbColumnHeightU.SelectedIndex = cnt.ColumnHeightU; //cbColumnTailHeightU.Text = cbColumnTailHeightU.Items[cbColumn]
            tbAdaptorLenght.Text = cnt.AdaptorLenght;
            cbAdaptorLenght.SelectedIndex = cnt.AdaptorLenghtU;
            //Хвостовик
            cbColumnTail.SelectedIndex = cnt.ColumnTail;
            tbColumnTailLenght.Text = cnt.ColumnTailLenght;
            cbColumnTailLenghtU.SelectedIndex = cnt.ColumnTailLenghtU;
            tbColumnTailHeight.Text = cnt.ColumnTailHeight;
            cbColumnTailHeightU.SelectedIndex = cnt.ColumnTailHeightU;
            //Оборудование
            cbEquipmentType.SelectedIndex = cnt.EquipmentType;
            //Нижняя подвеска
            cbLowerHanger.SelectedIndex = cnt.LowerHanger;
            tbLowerHangerLenght.Text = cnt.LowerHangerLenght;
            cbLowerHangerLenghtU.SelectedIndex = cnt.LowerHangerLenghtU;
            tbLowerHangerHeight.Text = cnt.LowerHangerHeight;
            cbLowerHangerHeightU.SelectedIndex = cnt.LowerHangerHeightU;
            //Верхняя подвеска
            cs_Pipe_Geometry.SelectedIndex = cnt.PipeGeomethry;
            tbUpperHangerLenght.Text = cnt.UpperHangerLenght;
            cbUpperHangerLenghtU.SelectedIndex = cnt.UpperHangerLenghtU;
            tbUpperHangerHeight.Text = cnt.UpperHangerHeight;
            cbUpperHangerHeightU.SelectedIndex = cnt.UpperHangerHeightU;
            //Циркуляционное отверстие
            cbCirculationHolePresent.Checked = cnt.CirculationHolePresent;
            e_Hole_Position_By_Pipe.Text = cnt.HolePositionByPipe;
            cbCirculationLenghtU.SelectedIndex = cnt.CirculationLenghtU;
            e_Hole_Position_Vertical.Text = cnt.HolePositionVertical;
            cbCirculationHeightU.SelectedIndex = cnt.CirculationHeightU;
            //Давление
            e_Bed_Pressure.Text = cnt.BedPressure;
            cbStratumPressureU.SelectedIndex = cnt.StratumPressureU;
            tbOrifice.Text = cnt.Orifice;
            cbOrificeU.SelectedIndex = cnt.OrificeU;
            cbGasFactor.SelectedIndex = cnt.GasFactor;
            tbSaturationPressure.Text = cnt.SaturationPressure;
            cbSaturationPressure.SelectedIndex = cnt.SaturationPressureU;
            //Перфорация
            e_Perforation_Distance_By_Pipe.Text =  cnt.PerforationDistanceByPipe;
            cbUpPerforationLenghtU.SelectedIndex = cnt.UpPerforationLenghtU;
            e_Perforation_Distance_Vertical.Text = cnt.PerforationDistanceByVertical;
            cbUpPerforationHeightU.SelectedIndex = cnt.UpPerforationHeightU;
            tbBottomPerforationLenght.Text = cnt.BottomPerforationLenght;
            cbBottomPerforationLenghtU.SelectedIndex = cnt.BottomPerforationLenghtU;
            tbBottomPerforationHeight.Text = cnt.BottomPerforationHeight;
            cbBottomPerforationHeightU.SelectedIndex = cnt.BottomPerforationHeightU;
            //Забой
            tbCurrentStall.Text = cnt.WellBottomDepth;
            cbCurrentStallU.SelectedIndex = cnt.CurrentStallU;
            tbFactitiousStall.Text = cnt.FactitiousStall;
            cbFactitiousStallU.SelectedIndex = cnt.FactitiousStallU;
            //Плотности
            tbOnAssayDensity.Text = cnt.OnAssayDensity;
            cbOnAssayDensityU.SelectedIndex = cnt.OnAssayDensityU;
            tbUsedDensity.Text = cnt.UsedDensity;
            cbUsedDensityU.SelectedIndex = cnt.UsedDensityU;
            //Данные насоса
            cbDoubleStep.SelectedIndex = cnt.DoubleStep;
            cbPistonDiam.SelectedIndex = cnt.PistonDiam;
            tbLevelingSpeed.Text = cnt.LevelingSpeed;
            cbLevelingSpeedU.SelectedIndex = cnt.LevelingSpeedU;
            tbPumpSupply.Text = cnt.PumpSupply;
            cbPumpSupplyU.SelectedIndex = cnt.PumpSupplyU;
            tbPumpPressure.Text = cnt.PumpPressure;
            cbPumpPressureU.SelectedIndex = cnt.PumpPressureU;
            //Данные о притоке
            tbNktPressure.Text = cnt.NktPressure;
            cbNktPressureU.SelectedIndex = cnt.NktPressureU;
            tbAnnulusPressure.Text = cnt.AnnulusPressure;
            cbAnnulusPressureU.SelectedIndex = cnt.AnnulusPressureU;
            //Параметры жидкостей
            e_Density_BL.Text = cnt.DensityBl;
            cs_Density_Unit_BL.SelectedIndex = cnt.DensityUnitBl;
            e_Dyn_Viscosity_BL.Text = cnt.DynViscosityBl;
            cs_Dyn_Viscosity_Unit_BL.SelectedIndex = cnt.DynViscosityUnitBl;
            e_Dyn_Viscosity_CL.Text = cnt.DynViscosityCl;
            cs_Dyn_Viscosity_Unit_CL.SelectedIndex = cnt.DynViscosityUnitCl;
            //Данные скважины
            cs_Unevenness.SelectedIndex = cnt.Unevenness;
            cs_Safety_Factor.SelectedIndex = cnt.SafetyFactor;
            //Параметры пласта
            e_Bed_Thickness.Text = cnt.BedThickness;
            cs_Bed_Type.SelectedIndex = cnt.BedType;
            cbBedThicknessU.SelectedIndex = cnt.BedPressureUnit;
            //Размерности результативных параметров
            cbResDensityPutFluidU.SelectedIndex = cnt.ResDensityPutFluidU;
            cbResJamDensityU.SelectedIndex = cnt.ResJamDensityU;
            cbResInnerTimeU.SelectedIndex = cnt.ResInnerTimeU;
            cbResOutPipeInningTimeU.SelectedIndex = cnt.ResOutPipeInningTimeU;
            cbResClearingInningTimeU.SelectedIndex = cnt.ResClearingInningTimeU;
            cbResNCDU.SelectedIndex = cnt.ResNcdu;
            cbResKCDU.SelectedIndex = cnt.ResKcdu;
            cbResReducing100U.SelectedIndex = cnt.ResReducing100U;
            //Конфигурация трубы
           // _pipeConf = cnt.PipeConfList;
            foreach (var xi in cnt.PipeConfList)
                _pipeConf.Add(new GeometheryElement(xi.Lenght, xi.Height));
            //return cnt;
        }

        private void cbRoSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            float ro;
            if (!float.TryParse(cbRoSel.Text, out ro)) return;
            var ls = _cat.StaffPropsList.Where(x =>Math.Abs(x.Ro - ro) < 0.001);
            lvRo.Columns.Clear();
            lvRo.Items.Clear();
            
            lvRo.Columns.Add("Масса вещества, кг", 60);
            lvRo.Columns.Add("Температура замерзания, С", 80);
            lvRo.Columns.Add("Состав Вещества", 220);
            foreach (var xl in ls.Select(itm => new[] {itm.Mass.ToString("F1"), itm.Temp.ToString("F1"), _cat.ReturnStaffName(itm.StaffType)}))
                lvRo.Items.Add(new ListViewItem(xl));
            lvRo.View = View.Details;
            lvRo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private static double GetLenght(double matt, int unit)
        {
            switch (unit)
            {
                case 0:
                    matt = matt / 1000;
                    return matt;
                case 1:
                    matt = matt / 100;
                    return matt;
                case 2:
                    return matt;
                case 3:
                    matt = matt * 1000;
                    return matt;
                default:
                    matt = matt / 1000;
                    return matt;
            }
        }

        private static double GetLenght(string matt, int unit)
        {
            double res;
            matt = matt.Replace('.', ',');
            double.TryParse(matt, out res);
            switch (unit)
            {
                case 0:
                    res = res/1000;
                    return res;
                case 1:
                    res = res/100;
                    return res;
                case 2:
                    return res;
                case 3:
                    res = res*1000;
                    return res;
                default:
                    res = res / 1000;
                    return res;
            }
        }

        private static double GetDensity(string matt, int unit)
        {//тут надо с точками и запятыми разобраться
            double res;
            matt = matt.Replace('.', ',');
            double.TryParse(matt, out res);
            if (unit == 0)
                res = res*1000;
            return res;
        }

        private static string SetDensity(double dens, int unit)
        {
            var f = new NumberFormatInfo {NumberGroupSeparator = string.Empty};
            switch (unit)
            {
                case 0:
                    return (dens/1000).ToString("#.###", f);
                default:
                    return dens.ToString("#.###", f);
            }
        }

        private static double GetPressure(string matt, int unit)
        {
            double res;
            matt = matt.Replace('.', ',');
            double.TryParse(matt, out res);

            switch (unit)
            {
                case 0:
                    res = res * 101325;
                    return res;
                case 1:
                    return res;
                default:
                    return res;
            }
        }

        private static string  SetPressure(double pressure,  int unit)
        {
            string matt;
            switch (unit)
            {
                case 0:
                    matt = (pressure/101325).ToString("#.###", _noSeparate);
                    return matt;
                default:
                    matt = pressure.ToString("#.###");
                    return matt;
            }
        }

        private static double GetInning(string matt, int unit)
        {//Подача насоса М3/ход
            double res;
            matt = matt.Replace('.', ',');
            double.TryParse(matt, out res);
            switch (unit)
            {
                case 0:
                    res = res / 1000;
                    return res;
                case 1:
                    //res = res*60;
                    return res;
                default:
                    return res;
            }
        }

        private static double GetLevelingSpeed(string matt, int unit)
        {//Скорость подачи, ходов в с
            double  res;
            matt = matt.Replace('.', ',');
            double.TryParse(matt, out res);
            switch (unit)
            {
                case 0:
                    res = res / 60;
                    return res;
                case 1:
                    return res;
                default:
                    res = res/3600;
                    return res;
            }
        }

        private static string SetTime(double sTime, int unit)
        {
            string res;
            switch (unit)
            {
                
                case 1:
                    res = (sTime / 60).ToString("N1", _noSeparate);
                    return res;
                case 2:
                    res = (sTime / 3600).ToString("#.###", _noSeparate);
                    return res;
                default:
                    res = sTime.ToString("N0", _noSeparate);
                    return res;
            }
        }

        private static double GetViscosity(string vis, int unit)
        {
            double res;
            double.TryParse(vis, out res);
            switch (unit)
            {
                case 1:
                    res = res*10;
                    return res;
                default:
                    return res;
            }
        }

        private CalcRes PrepareCalcData()
        {
            //var di = GetInning(tbPumpSupply.Text, cbPumpSupplyU.SelectedIndex);
            var calc = new CalcRes
            {
                GColumn = GetColumnGeomethry(cs_Column_Geometry.SelectedIndex),
                DColumnLenght = GetLenght(tbColumnLenght.Text, cbColumnLenghtU.SelectedIndex),
                DColumnHeight = GetLenght(tbColumnHeight.Text, cbColumnHeightU.SelectedIndex),
                DAdaptorLenght = GetLenght(tbAdaptorLenght.Text, cbAdaptorLenght.SelectedIndex),
                GTail = GetColumnGeomethry(cbColumnTail.SelectedIndex),
                DTailLenght = GetLenght(tbColumnTailLenght.Text, cbColumnTailLenghtU.SelectedIndex),
                DTailHeight = GetLenght(tbColumnTailHeight.Text, cbColumnTailHeightU.SelectedIndex),
                SEquipment = cbEquipmentType.Text,
                GLowerHanger = GetPipeGeomethry(cbLowerHanger.SelectedIndex),
                DLowerHanger = GetLenght(tbLowerHangerLenght.Text, cbLowerHangerLenghtU.SelectedIndex),
                DLowerHangerHeight = GetLenght(tbLowerHangerHeight.Text, cbLowerHangerHeightU.SelectedIndex),
                GUpperHanger = GetPipeGeomethry(cs_Pipe_Geometry.SelectedIndex),
                DUpperHanger = GetLenght(tbUpperHangerLenght.Text, cbUpperHangerLenghtU.SelectedIndex),
                DUpperHangerHeight = GetLenght(tbUpperHangerHeight.Text, cbUpperHangerHeightU.SelectedIndex),
                DStratumPressure = GetPressure(e_Bed_Pressure.Text, cbStratumPressureU.SelectedIndex),
                DOrifice = GetPressure(tbOrifice.Text, cbOrificeU.SelectedIndex),
                SGasFactor = cbGasFactor.Text,
                DCirculationHole = GetLenght(e_Hole_Position_By_Pipe.Text, cbCirculationLenghtU.SelectedIndex),
                DCirculationHoleHeight = GetLenght(e_Hole_Position_Vertical.Text, cbCirculationHeightU.SelectedIndex),
                DSafetyFactor = GetSafetyFactor(cs_Safety_Factor.SelectedIndex),
                DUpPerforationLenht = GetLenght(e_Perforation_Distance_By_Pipe.Text, cbUpPerforationLenghtU.SelectedIndex),
                DUpPerforationHeight = GetLenght(e_Perforation_Distance_Vertical.Text, cbUpPerforationHeightU.SelectedIndex),
                DBottomPerforationLenght = GetLenght(tbBottomPerforationLenght.Text, cbBottomPerforationLenghtU.SelectedIndex),
                DBottomPerforationHeight = GetLenght(tbBottomPerforationHeight.Text, cbBottomPerforationHeightU.SelectedIndex),
                DCurrentStall = GetLenght(tbCurrentStall.Text, cbCurrentStallU.SelectedIndex),
                DFactitiousStall = GetLenght(tbFactitiousStall.Text, cbFactitiousStallU.SelectedIndex),
                DOnAssayDensity = GetDensity(tbOnAssayDensity.Text, cbOnAssayDensityU.SelectedIndex),
                DUsedDensity = GetDensity(tbUsedDensity.Text, cbUsedDensityU.SelectedIndex),
                DStratumFluidDensity = GetDensity(e_Density_BL.Text, cs_Density_Unit_BL.SelectedIndex),
                DPumpInning = GetInning(tbPumpSupply.Text, cbPumpSupplyU.SelectedIndex),
                DLevelingSpeed = GetLevelingSpeed(tbLevelingSpeed.Text, cbLevelingSpeedU.SelectedIndex),
                DPumpPressure = GetPressure(tbPumpPressure.Text, cbPumpPressureU.SelectedIndex),
                DNktPressure = GetPressure(tbNktPressure.Text, cbNktPressureU.SelectedIndex),
                DAnnulusPressure = GetPressure(tbAnnulusPressure.Text, cbAnnulusPressureU.SelectedIndex),
                OilFieldName = e_OilField_name.Text,
                WellNumber = e_Well_Number.Text,
                ClusterName = e_Cluster_Name.Text,
                ServiceCompany = tbServiceCompany.Text,
                Brigade = tbBrigade.Text,
                Master=tbMaster.Text
            };
            return calc;
        }
        private void tpPlan_Enter(object sender, EventArgs e)
        {
            var calc = PrepareCalcData();
            tbResColumnVol.Text = calc.RColumnVol().ToString("#.###", _noSeparate);
            tbResNKTVol.Text = calc.RnktVol().ToString("#.###", _noSeparate);
            tbResOutPipeVol.Text = calc.ROutPipeVol().ToString("#.###", _noSeparate);
            tbResUnderPumpVol.Text = calc.RUnderPumpVol().ToString("#.###", _noSeparate);
            tbResJamFluidVol.Text = calc.RJamFluidVol().ToString("#.###", _noSeparate);
            tbResJamFluidStockVol.Text = calc.RJamFluidStockVol().ToString("#.###", _noSeparate);
            tbResJamFluidFullVol.Text = calc.RJamFluidFullVol().ToString("#.###", _noSeparate);
            tbResDensityPutFluid.Text = SetDensity(calc.RDensityPutFluid(), cbResDensityPutFluidU.SelectedIndex);
            tbResDensityPutFluid.Tag = calc.RDensityPutFluid();
            tbResJamDensity.Text = SetDensity(calc.RJamDensity(),cbResJamDensityU.SelectedIndex);
            tbResJamDensity.Tag = calc.RJamDensity();
            tbResNktInningStep.Text = calc.RNktInnigStep().ToString("N0", _noSeparate);
            tbResInnerTime.Text = SetTime(calc.RNktInnerTime(), cbResInnerTimeU.SelectedIndex);
            tbResInnerTime.Tag = calc.RNktInnerTime();
            tbResOutPipeInningStep.Text = calc.ROutPipeInningStep().ToString("N0", _noSeparate);
            tbResOutPipeInningTime.Text = SetTime(calc.ROutPipeInnerTime(), cbResOutPipeInningTimeU.SelectedIndex);
            tbResOutPipeInningTime.Tag = calc.ROutPipeInnerTime();
            tbResClearingInningStep.Text = (calc.RNktInnigStep() + calc.ROutPipeInningStep()).ToString("N0", _noSeparate);
            tbResClearingInningTime.Text = SetTime(calc.RNktInnerTime() + calc.ROutPipeInnerTime(), cbResClearingInningTimeU.SelectedIndex);
            tbResClearingInningTime.Tag = calc.RNktInnerTime() + calc.ROutPipeInnerTime();
            tbResNCD.Text = SetPressure(calc.DPumpPressure + calc.DNktPressure, cbResNCDU.SelectedIndex);
            tbResNCD.Tag = calc.DPumpPressure + calc.DNktPressure;
            tbResKCD.Text = SetPressure(calc.RKcd(), cbResKCDU.SelectedIndex);
            tbResKCD.Tag = calc.RKcd();
            tbResReducing100.Text = SetPressure(calc.RReducePerStep(), cbResReducing100U.SelectedIndex);
            tbResReducing100.Tag = calc.RReducePerStep();
            tbCycles.Text = calc.RCiclesCount().ToString("D"); //Количество циклов
        }

        private static void ShowHeightForm(object sender, double lenght)
        {
            var fmHForm = new FmHeight((TextBox)sender, lenght)
            {
                Location = new Point
                {
                    X = ((TextBox) sender).PointToScreen(Point.Empty).X,
                    Y = ((TextBox) sender).PointToScreen(Point.Empty).Y
                }
            };
            fmHForm.Show();
        }
        
        private static void DrawGreed(GreedElement gE,  Graphics g, Pen penL)
        {
            var angle = 90-Math.Abs(gE.RAmgle());
            var r = new Rectangle(new Point(gE.RPosition().X - gE.RDiam() / 2 , gE.RPosition().Y - gE.RDiam() / 8), new Size(gE.RDiam(), gE.RDiam() / 4));
            var p = new GraphicsPath();
            p.AddArc(r, 0, -180);
            //p.AddArc(r, 0, 180);

            var rotateMatrix = new Matrix();
            rotateMatrix.RotateAt((float)angle * (-1), new PointF(gE.RPosition().X, gE.RPosition().Y));
            p.Transform(rotateMatrix);
            g.DrawPath(penL, p);
        }

        private Bitmap CreateBitmap(int maxX, int maxY)
        {
            var tb = new CTube();
            //Инициализация списка геометрии
            tb.SetSize(maxX, maxY);
            if (_pipeConf.Any())
            {
                tb.ClearList();
                foreach (var xi in _pipeConf.Where(xi => xi.Height() + xi.Lenght() > 0))
                    tb.AddG(xi);
            }
            else
                return null;

            var img = new Bitmap(maxX, maxY);
            var g = Graphics.FromImage(img);
            g.SmoothingMode = SmoothingMode.HighQuality;
            tb.Normalize(PrepareCalcData());
            //Получаем расчетные данные
            var calc = PrepareCalcData();
            //Шкала
            var height = calc.DTailHeight + calc.DColumnHeight;
            var aPos = new Dictionary<int, int>();
            var yCoef = Convert.ToDouble(maxY - 80) / height;

            var cMul =
                Convert.ToInt32(height / 8);

            for (var c = 1; c <= 8; c++)
            {
                var hd = Convert.ToInt32(c * cMul / 100) * 100;
                aPos[hd] = Convert.ToInt32(hd * yCoef);
            }

            //Ось
            int xAxis;
            if (tb.GetStartX() > 52)
                xAxis = tb.GetStartX() - 50;
            else xAxis = 2;
            g.DrawLine(new Pen(Color.LightBlue, 1), xAxis, 20, xAxis, maxY - 20);
            //Глубины
            var drawFont = new Font("Arial", 12);
            foreach (var pair in aPos)
            {
                g.DrawLine(new Pen(Color.LightBlue, 1), xAxis, pair.Value, maxX - 50, pair.Value);
                if (xAxis > 50)
                    g.DrawString(pair.Key.ToString("D"), drawFont, new SolidBrush(Color.LightBlue), xAxis - 50, pair.Value - 15);
                else
                {
                    g.DrawString(pair.Key.ToString("D"), drawFont, new SolidBrush(Color.LightBlue), maxX - 80, pair.Value - 15);
                }

            }
            //new Pen(Color.FromArgb(16, 213, 200), 1);
            var penL = new Pen(Color.BlueViolet, 1);
            //Рисуем колонну
            g.DrawLines(new Pen(Color.Coral, 1), tb.LeftSide());
            g.DrawLines(new Pen(Color.Coral, 1), tb.RightSide());
            foreach (var ex in tb.RGreedElements())
            {
                DrawGreed(ex, g, new Pen(Color.Coral, 1));
            }
            //Рисуем элемент
            try
            {
                g.DrawLines(new Pen(Color.Crimson, 1), tb.LeftSideNkt());
                g.DrawLines(new Pen(Color.Crimson, 1), tb.RightSideNkt());
            }
            catch (Exception)
            {
                // var tms = em.Message;
            }
            foreach (var ex in tb.RGreedNktElements())
            {
                DrawGreed(ex, g, new Pen(Color.Crimson, 1));
            }
            //Осевая линия
            g.DrawLines(penL, tb.Res());
            //Подписи
            drawFont = new Font("Arial", 16);
            var drawBrush = new SolidBrush(Color.Coral);


            var ek = calc.DColumnLenght / (calc.DColumnLenght + calc.DTailLenght);
            if (double.IsNaN(ek)) return null;
            var pos = Convert.ToInt32(ek * tb.RGreedElements().Count() - 1);
            var cur = tb.RGreedElements().ToList()[pos];
            var startPoint = tb.LeftSide()[pos];
            var endPoint = new Point(startPoint.X + 50, startPoint.Y);
            var pt = new GraphicsPath();
            pt.AddLine(startPoint, endPoint);
            var rotateMatrix = new Matrix();
            rotateMatrix.RotateAt((float)(90 - Math.Abs(cur.RAmgle())) * (-1), new Point(startPoint.X, startPoint.Y));
            pt.Transform(rotateMatrix);
            g.DrawPath(new Pen(Color.Coral, 1), pt);
            endPoint = new Point(startPoint.X + Convert.ToInt32(60 * Math.Sin(cur.RAngleG())),
                    startPoint.Y - Convert.ToInt32(60 * Math.Cos(cur.RAngleG())));
            g.DrawString(calc.DColumnLenght.ToString(CultureInfo.InvariantCulture), drawFont, drawBrush, endPoint);

            cur = tb.RGreedElements().Last();
            startPoint = tb.LeftSide().Last();
            endPoint = new Point(startPoint.X + 50, startPoint.Y);
            pt = new GraphicsPath();
            pt.AddLine(startPoint, endPoint);
            rotateMatrix = new Matrix();
            rotateMatrix.RotateAt((float)(90 - Math.Abs(cur.RAmgle())) * (-1), new Point(startPoint.X, startPoint.Y));
            pt.Transform(rotateMatrix);
            g.DrawPath(new Pen(Color.Coral, 1), pt);
            endPoint = new Point(startPoint.X + Convert.ToInt32(60 * Math.Sin(cur.RAngleG())),
                    startPoint.Y - Convert.ToInt32(60 * Math.Cos(cur.RAngleG())));
            g.DrawString((calc.DColumnLenght + calc.DTailLenght).ToString(CultureInfo.InvariantCulture), drawFont, drawBrush, endPoint);

            ek = calc.DUpperHanger / (calc.DColumnLenght + calc.DTailLenght);
            pos = Convert.ToInt32(ek * tb.RGreedElements().Count()) - 1;
            cur = tb.RGreedNktElements().ToList()[pos];
            startPoint = tb.LeftSideNkt()[pos];
            endPoint = new Point(startPoint.X + 50, startPoint.Y);
            pt = new GraphicsPath();
            pt.AddLine(startPoint, endPoint);
            rotateMatrix = new Matrix();
            rotateMatrix.RotateAt((float)(90 - Math.Abs(cur.RAmgle())) * (-1), new Point(startPoint.X, startPoint.Y));
            pt.Transform(rotateMatrix);
            g.DrawPath(new Pen(Color.Crimson, 1), pt);
            drawBrush = new SolidBrush(Color.Crimson);
            endPoint = new Point(startPoint.X + Convert.ToInt32(50 * Math.Sin(cur.RAngleG())),
                    startPoint.Y - Convert.ToInt32(50 * Math.Cos(cur.RAngleG())) - 10);
            g.DrawString((calc.DUpperHanger).ToString(CultureInfo.InvariantCulture), drawFont, drawBrush, endPoint);

            //ek = (calc.DUpperHanger + calc.DLowerHanger)/(calc.DColumnLenght + calc.DTailLenght);
            //pos = Convert.ToInt32(ek * tb.RGreedElements().Count()) - 1;
            cur = tb.RGreedNktElements().Last();
            startPoint = tb.RightSideNkt().Last();
            endPoint = new Point(startPoint.X - 50, startPoint.Y);
            pt = new GraphicsPath();
            pt.AddLine(startPoint, endPoint);
            rotateMatrix = new Matrix();
            rotateMatrix.RotateAt((float)(90 - Math.Abs(cur.RAmgle())) * (-1), new Point(startPoint.X, startPoint.Y));
            pt.Transform(rotateMatrix);
            g.DrawPath(new Pen(Color.Crimson, 1), pt);
            drawBrush = new SolidBrush(Color.Crimson);
            endPoint = new Point(startPoint.X - Convert.ToInt32(50 * Math.Sin(cur.RAngleG())),
                    startPoint.Y + Convert.ToInt32(50 * Math.Cos(cur.RAngleG())) - 10);
            g.DrawString((calc.DUpperHanger + calc.DLowerHanger).ToString(CultureInfo.InvariantCulture), drawFont, drawBrush, endPoint);
            //BmShema = img;
            return img;
        }
        private void DrawModel(PaintEventArgs e)
        {
            
            var maxX = e.ClipRectangle.Size.Width;
             
            var maxY = e.ClipRectangle.Size.Height;
             
            var gPanel = e.Graphics;
            var img = CreateBitmap(maxX, maxY);

            if (!(img==null)) gPanel.DrawImage(img,0,0);
            _bmShema = CreateBitmap(700, 500);
        }

        private static void ChangeLenght(object tBox, object cBox, int sz)
        {
            var tb = (TextBox) tBox;
            var cb = (ComboBox) cBox;
            var ln = tb.Tag == null ? new RLenght(GetLenght(tb.Text, cb.SelectedIndex), 2) : new RLenght(GetLenght((double)tb.Tag, cb.SelectedIndex), 2);
            tb.Text = ln.GetLenghtIn(sz).ToString("#.###", _noSeparate);
            tb.Tag = ln.GetLenghtIn(sz);
            cb.SelectedIndex = sz;
        }

        private void SetLenghtSize(int sz)
        {
            ChangeLenght(tbColumnLenght, cbColumnLenghtU, sz);
           //---глубина колонны
            ChangeLenght(tbColumnHeight, cbColumnLenghtU, sz);
            //---длинна адаптора
            ChangeLenght(tbAdaptorLenght, cbAdaptorLenght, sz);
            //---длинна хыостовика
            ChangeLenght(tbColumnTailLenght, cbColumnTailLenghtU, sz);
           //---глубина хвостовика
            ChangeLenght(tbColumnTailHeight, cbColumnTailHeightU, sz);
           //--длинна нижней подвески
            ChangeLenght(tbLowerHangerLenght, cbLowerHangerLenghtU, sz);
            //--глубина хвостовика
            ChangeLenght(tbLowerHangerHeight, cbLowerHangerHeightU, sz);
           //--длинна верхней подвески
            ChangeLenght(tbUpperHangerLenght, cbUpperHangerLenghtU, sz);
            //--глубина верхней подвески
            ChangeLenght(tbUpperHangerHeight, cbUpperHangerHeightU, sz);
           //--цирк отверстие, рссояние по трубе
            ChangeLenght(e_Hole_Position_By_Pipe, cbCirculationLenghtU, sz);
            //--цирк отверстие, глубина
            ChangeLenght(e_Hole_Position_Vertical, cbCirculationHeightU, sz);
            //--перфорация, верх по трубе
            ChangeLenght(e_Perforation_Distance_By_Pipe, cbUpPerforationLenghtU, sz);
          //--перфорация, верх глубина
            ChangeLenght(e_Perforation_Distance_Vertical, cbUpPerforationHeightU, sz);
           //--перфорация, низ по трубе
            ChangeLenght(tbBottomPerforationLenght, cbBottomPerforationLenghtU, sz);
           //--перфорация, низ глубина
            ChangeLenght(tbBottomPerforationHeight, cbBottomPerforationHeightU, sz);
            //--текущий забой
            ChangeLenght(tbCurrentStall, cbCurrentStallU, sz);
            //--искусственный забой
            ChangeLenght(tbFactitiousStall, cbFactitiousStallU, sz);
            //--мощность пласта
            ChangeLenght(e_Bed_Thickness, cbBedThicknessU, sz);
           // ln = new RLenght(GetLenght(e_Bed_Thickness.Text, cbBedThicknessU.SelectedIndex), 2);
            //e_Bed_Thickness.Text = ln.GetLenghtIn(sz).ToString("#.###", _noSeparate);
           // cbBedThicknessU.SelectedIndex = sz;
        }

        private void rbMeters_CheckedChanged(object sender, EventArgs e)
        {
           if (rbMeters.Checked)
                SetLenghtSize(2);
        }

        private void rbKm_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKm.Checked)
                SetLenghtSize(3);
        }


        private void SetPressureSize(int sz)
        {
            //--Давление насоса
            var ps = new RPressure(GetPressure(tbPumpPressure.Text, cbPumpPressureU.SelectedIndex), 1);
            tbPumpPressure.Text = ps.GetPressIn(sz).ToString("#.###", _noSeparate);
            cbPumpPressureU.SelectedIndex = sz;
            //--Давление в затрубном пространстве
            ps = new RPressure(GetPressure(tbAnnulusPressure.Text, cbAnnulusPressureU.SelectedIndex), 1);
            tbAnnulusPressure.Text = ps.GetPressIn(sz).ToString("#.###", _noSeparate);
            cbAnnulusPressureU.SelectedIndex = sz;
            //--Пластовое давление
            ps = new RPressure(GetPressure(e_Bed_Pressure.Text, cbStratumPressureU.SelectedIndex), 1);
            e_Bed_Pressure.Text = ps.GetPressIn(sz).ToString("#.###", _noSeparate);
            cbStratumPressureU.SelectedIndex = sz;
            //--на устье при испытании пород
            ps = new RPressure(GetPressure(tbOrifice.Text, cbOrificeU.SelectedIndex), 1);
            tbOrifice.Text = ps.GetPressIn(sz).ToString("#.###", _noSeparate);
            cbOrificeU.SelectedIndex = sz;
            //--избыточное давление
            ps = new RPressure(GetPressure(tbNktPressure.Text, cbNktPressureU.SelectedIndex), 1);
            tbNktPressure.Text = ps.GetPressIn(sz).ToString("#.###", _noSeparate);
            cbNktPressureU.SelectedIndex = sz;
            //--давление насыщения
            ps = new RPressure(GetPressure(tbSaturationPressure.Text, cbSaturationPressure.SelectedIndex), 1);
            tbSaturationPressure.Text = ps.GetPressIn(sz).ToString("#.###", _noSeparate);
            cbSaturationPressure.SelectedIndex = sz;
        }

        private void rbAtm_CheckedChanged(object sender, EventArgs e)
        {
           if (rbAtm.Checked)
               SetPressureSize(0);
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMpa.Checked)
                SetPressureSize(1);
        }

        private void SetDensitySize(int sz)
        {
            //--пластовый флюид
            var dn = new RDensity(GetDensity(tbOnAssayDensity.Text, cbOnAssayDensityU.SelectedIndex), 1);
            tbOnAssayDensity.Text = dn.GetDensityIn(sz).ToString("#.###", _noSeparate);
            cbOnAssayDensityU.SelectedIndex = sz;
            //--скважинная жидкость
            dn = new RDensity(GetDensity(tbUsedDensity.Text, cbUsedDensityU.SelectedIndex), 1);
            tbUsedDensity.Text = dn.GetDensityIn(sz).ToString("#.###", _noSeparate);
            cbUsedDensityU.SelectedIndex = sz;
            //--скважинная жидкость
            dn = new RDensity(GetDensity(e_Density_BL.Text, cs_Density_Unit_BL.SelectedIndex), 1);
            e_Density_BL.Text = dn.GetDensityIn(sz).ToString("#.###", _noSeparate);
            cs_Density_Unit_BL.SelectedIndex = sz;
        }

        private void rbKgm_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKgm.Checked)
                SetDensitySize(1);
        }

        private void rbGsm_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGsm.Checked)
                SetDensitySize(0);
        }

        private void SetVisconsitySize(int sz)
        {
            //-- Пластовая жидкость
            var vs = new RViscosity(GetViscosity(e_Dyn_Viscosity_BL.Text, cs_Dyn_Viscosity_Unit_BL.SelectedIndex));
            e_Dyn_Viscosity_BL.Text = vs.GetViscosity(sz).ToString("#.###", _noSeparate);
            cs_Dyn_Viscosity_Unit_BL.SelectedIndex = sz;
            //-- Жидкость глушения
            vs = new RViscosity(GetViscosity(e_Dyn_Viscosity_CL.Text, cs_Dyn_Viscosity_Unit_CL.SelectedIndex));
            e_Dyn_Viscosity_CL.Text = vs.GetViscosity(sz).ToString("#.###", _noSeparate);
            cs_Dyn_Viscosity_Unit_CL.SelectedIndex = sz;
        }

        private void rbMpaS_CheckedChanged(object sender, EventArgs e)
        {
           if (rbMpaS.Checked)
               SetVisconsitySize(0);
        }

        private void rbSPz_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSPz.Checked)
                SetVisconsitySize(1);
        }

        private void SetPumpData()
        {
            var pd = new PumpData();
            //int  Diam;
            var dItem = pd.GetItem(cbDoubleStep.SelectedIndex);
            var it = dItem.RParam(cbPistonDiam.SelectedIndex);
            tbPumpSupply.Text = it.Ining.ToString("#.###");
        }

        private static void ShowTubeGeometheryForm()
        {
            var fm = new PipeConf();
            fm.Show();
        }

        private void ciTubeConfiguration_Click(object sender, EventArgs e)
        {
            ShowTubeGeometheryForm();
        }

        public static void SetPipeConf(List<GeometheryElement> lst)
        {
            _pipeConf = lst;
        }

        public static IEnumerable<GeometheryElement> GetPipeConf()
        {
            return _pipeConf;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _conf.LastPath = _conf.LastPath ?? "..\\";
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
       
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void cs_Bed_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbBedType_Click(object sender, EventArgs e)
        {
            //ToDo add form change of bed type
        }
    }//End of MForm

   
}//end namespace
