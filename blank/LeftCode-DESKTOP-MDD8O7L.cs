using System;
using System.IO;
using System.Windows.Forms;


namespace blank
{
    public partial class MForm
    {

        private void MForm_Resize(object sender, EventArgs e)
        {
            if (Width < 400) Width = 1000;
            if (Height < 350) Height = 600;
        }

        private void btSavePlan_Click(object sender, EventArgs e)
        {
            //Сохранить план в ворде
            _conf.LastReportPath =
                _conf.LastReportPath ?? "..\\";


            var sfd = new SaveFileDialog
            {
                Filter = @"DOC файлы|*.doc*",
                InitialDirectory = _conf.LastReportPath.Length < 5
                    ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                    : _conf.LastReportPath,
                RestoreDirectory = true
            };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            var wfile = new GeneratedClass();
            wfile.CreatePackage(sfd.FileName, PrepareCalcData(), _bmShema);//Создаем схему размером 200х200

            var fn = new FileInfo(sfd.FileName);
            _conf.LastReportPath = fn.DirectoryName;
            MessageBox.Show(@"Операция завершена", @"Готово", MessageBoxButtons.OK);
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            DrawModel(e);
            //DrawTubes(e);
        }

        private static void SetTextBoxTag(object sender)
        {//установить Тэг в числовое значение введенное в тексте поля
            var src = (TextBox) sender;
            double matt;
            double.TryParse(src.Text, out matt);
            src.Tag = matt;
        }
        private void tbColumnHeight_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbColumnLenght_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbAdaptorLenght_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbColumnTailLenght_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbColumnTailHeight_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbLowerHangerLenght_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbLowerHangerHeight_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbUpperHangerLenght_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbUpperHangerHeight_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void e_Hole_Position_By_Pipe_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
            //UpdateParametrs();
        }

        private void e_Hole_Position_Vertical_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
            //UpdateParametrs();
        }

        private void tbOrifice_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbNktPressure_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbSaturationPressure_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void e_Perforation_Distance_By_Pipe_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
            //UpdateParametrs();
        }

        private void e_Perforation_Distance_Vertical_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
            //UpdateParametrs();
        }

        private void tbBottomPerforationLenght_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbBottomPerforationHeight_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void e_Well_Bottom_Depth_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
            //UpdateParametrs();
        }

        private void tbFactitiousStall_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbOnAssayDensity_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbUsedDensity_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbPumpPressure_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void tbAnnulusPressure_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
        }

        private void e_Density_BL_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
            //UpdateParametrs();
        }

        private void e_Dyn_Viscosity_BL_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
            //UpdateParametrs();
        }

        private void e_Dyn_Viscosity_CL_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
            //UpdateParametrs();
        }

        private void cs_Dyn_Viscosity_Unit_CL_Leave(object sender, EventArgs e)
        {
            //SetTextBoxTag(sender);
            //UpdateParametrs();
        }

        private void cs_Bed_Type_Leave(object sender, EventArgs e)
        {
            //
            //UpdateParametrs();
        }

        private void e_Bed_Thickness_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
            //UpdateParametrs();
        }

        private void e_Bed_Pressure_Leave(object sender, EventArgs e)
        {
            SetTextBoxTag(sender);
            //UpdateParametrs();
        }

        private void cs_Pipe_Geometry_Leave(object sender, EventArgs e)
        {
            //UpdateParametrs();
        }

        private void cs_Column_Geometry_Leave(object sender, EventArgs e)
        {
            //UpdateParametrs();
        }


        private void cs_Bed_Pressure_Unit_Leave(object sender, EventArgs e)
        {
            //UpdateParametrs();
        }

        private void cs_Unevenness_Leave(object sender, EventArgs e)
        {
            // UpdateParametrs();
        }

        private void cs_Safety_Factor_Leave(object sender, EventArgs e)
        {
            //UpdateParametrs();
        }

        private void cs_Density_Unit_BL_Leave(object sender, EventArgs e)
        {
            //UpdateParametrs();
        }

        private void cs_Dyn_Viscosity_Unit_BL_Leave(object sender, EventArgs e)
        {
            //UpdateParametrs();
        }

        private void mForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }

        private void cbEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateParametrs();
            PlanPageReset();
        }

        private void tpResult_Enter(object sender, EventArgs e)
        {
            ShowResult();
        }

        private void e_Perforation_Distance_By_Pipe_DoubleClick(object sender, EventArgs e)
        {
            //ShowAddonForm(sender);
        }

        private void e_Perforation_Distance_Vertical_DoubleClick(object sender, EventArgs e)
        {
            //ShowAddonForm(sender);
        }

        private void e_Hole_Position_By_Pipe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //ShowAddonForm(sender);
        }

        private void e_Hole_Position_Vertical_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //ShowAddonForm(sender);
        }

        private void e_Well_Bottom_Depth_DoubleClick(object sender, EventArgs e)
        {
            //ShowAddonForm(sender);
        }

        private void e_Bed_Thickness_DoubleClick(object sender, EventArgs e)
        {
            //ShowAddonForm(sender);
        }

        private void e_Bed_Pressure_DoubleClick(object sender, EventArgs e)
        {
            //ShowAddonForm(sender);
        }

        private void e_Density_BL_DoubleClick(object sender, EventArgs e)
        {
            //ShowAddonForm(sender);
        }

        private void e_Dyn_Viscosity_BL_DoubleClick(object sender, EventArgs e)
        {
            // ShowAddonForm(sender);
        }

        private void e_Dyn_Viscosity_CL_DoubleClick(object sender, EventArgs e)
        {
            //ShowAddonForm(sender);
        }

        private void cbResNCDU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbResNCD.Tag != null)
                tbResNCD.Text = SetPressure((double)tbResNCD.Tag, cbResNCDU.SelectedIndex);
        }

        private void cbResKCDU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbResKCD.Tag != null)
                tbResKCD.Text = SetPressure((double)tbResKCD.Tag, cbResKCDU.SelectedIndex);
        }

        private void cbResReducing100U_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbResReducing100.Tag != null)
                tbResReducing100.Text = SetPressure((double)tbResReducing100.Tag, cbResReducing100U.SelectedIndex);
        }

        private void cbResInnerTimeU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbResInnerTime.Tag != null)
                tbResInnerTime.Text = SetTime((int)tbResInnerTime.Tag, cbResInnerTimeU.SelectedIndex);
        }

        private void cbResOutPipeInningTimeU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbResOutPipeInningTime.Tag != null)
                tbResOutPipeInningTime.Text = SetTime((int)tbResOutPipeInningTime.Tag,
                    cbResOutPipeInningTimeU.SelectedIndex);
        }

        private void cbResClearingInningTimeU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbResClearingInningTime.Tag != null)
                tbResClearingInningTime.Text = SetTime((int)tbResClearingInningTime.Tag,
                    cbResClearingInningTimeU.SelectedIndex);
        }

        private void cbResDensityPutFluidU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbResDensityPutFluid.Tag != null)
                tbResDensityPutFluid.Text = SetDensity((double)tbResDensityPutFluid.Tag,
                    cbResDensityPutFluidU.SelectedIndex);
        }

        private void cbResJamDensityU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbResJamDensity.Tag != null)
                tbResJamDensity.Text = SetDensity((double)tbResJamDensity.Tag,
                    cbResJamDensityU.SelectedIndex);
        }

        private void dgCoastTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbSI_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbSI.Checked) return;
            SetLenghtSize(2);
            SetPressureSize(1);
            SetDensitySize(1);
            SetVisconsitySize(0);
        }

        private void rbSGS_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbSGS.Checked) return;
            SetLenghtSize(3);
            SetPressureSize(0);
            SetDensitySize(0);
            SetVisconsitySize(1);
        }

        private void cbDoubleStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPumpData();
        }

        private void btAddNode_Click(object sender, EventArgs e)
        {
            /*var di = tvPlan.SelectedNode;

            var si = lbBeforeHand.SelectedIndex;
            var node = tbExternalItem.Text.Length > 5 ? new TreeNode(tbExternalItem.Text) : new TreeNode(lbBeforeHand.Items[si] as string);
            if (tvPlan.Nodes.Count == 0)
            {
                tvPlan.Nodes.Add(node);
            }
            else
            {
                di = di ?? tvPlan.Nodes[0];
                di.Nodes.Add(node);
                di.Expand();
            }
            tbExternalItem.Text = "";*/
        }

        private void btDeleteNode_Click(object sender, EventArgs e)
        {
           // if (tvPlan.Nodes.Count == 0) return;
            //tvPlan.Nodes.Remove(tvPlan.SelectedNode);
        }

        private void tbUpperHangerHeight_TextChanged(object sender, EventArgs e)
        {
            ShowHeightForm(sender, GetLenght(tbUpperHangerLenght.Text, cbUpperHangerLenghtU.SelectedIndex));
        }

        private void extiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnShema_Paint(object sender, PaintEventArgs e)
        {
            DrawModel(e);
        }

        private void columnGeometheryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTubeGeometheryForm();
        }
    }

}