using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace blank
{
    partial class MForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MForm));
            this.cs_Safety_Factor = new System.Windows.Forms.ComboBox();
            this.cs_Unevenness = new System.Windows.Forms.ComboBox();
            this.cs_Dyn_Viscosity_Unit_CL = new System.Windows.Forms.ComboBox();
            this.e_Dyn_Viscosity_CL = new System.Windows.Forms.TextBox();
            this.cs_Dyn_Viscosity_Unit_BL = new System.Windows.Forms.ComboBox();
            this.e_Dyn_Viscosity_BL = new System.Windows.Forms.TextBox();
            this.cs_Density_Unit_BL = new System.Windows.Forms.ComboBox();
            this.e_Density_BL = new System.Windows.Forms.TextBox();
            this.cbStratumPressureU = new System.Windows.Forms.ComboBox();
            this.e_Bed_Pressure = new System.Windows.Forms.TextBox();
            this.lbStratumPressure = new System.Windows.Forms.Label();
            this.tbCurrentStall = new System.Windows.Forms.TextBox();
            this.lbCurrentStall = new System.Windows.Forms.Label();
            this.e_Hole_Position_Vertical = new System.Windows.Forms.TextBox();
            this.cmsPipe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ciTubeConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.ciCornerEncount = new System.Windows.Forms.ToolStripMenuItem();
            this.e_Hole_Position_By_Pipe = new System.Windows.Forms.TextBox();
            this.lbUpPerforationHeight = new System.Windows.Forms.Label();
            this.lbUpPerforationLenght = new System.Windows.Forms.Label();
            this.e_Perforation_Distance_Vertical = new System.Windows.Forms.TextBox();
            this.e_Perforation_Distance_By_Pipe = new System.Windows.Forms.TextBox();
            this.lbColumn = new System.Windows.Forms.Label();
            this.cs_Column_Geometry = new System.Windows.Forms.ComboBox();
            this.cs_Pipe_Geometry = new System.Windows.Forms.ComboBox();
            this.lbBush = new System.Windows.Forms.Label();
            this.lbHole = new System.Windows.Forms.Label();
            this.e_Cluster_Name = new System.Windows.Forms.TextBox();
            this.e_Well_Number = new System.Windows.Forms.TextBox();
            this.lbLocate = new System.Windows.Forms.Label();
            this.e_OilField_name = new System.Windows.Forms.TextBox();
            this.tcCntrl = new System.Windows.Forms.TabControl();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.pnShema = new System.Windows.Forms.Panel();
            this.tlIncomingData = new System.Windows.Forms.TableLayoutPanel();
            this.lbColumnType = new System.Windows.Forms.Label();
            this.lbColumnLenght = new System.Windows.Forms.Label();
            this.tbColumnLenght = new System.Windows.Forms.TextBox();
            this.cbColumnLenghtU = new System.Windows.Forms.ComboBox();
            this.lbColumnHeight = new System.Windows.Forms.Label();
            this.tbColumnHeight = new System.Windows.Forms.TextBox();
            this.cbColumnHeightU = new System.Windows.Forms.ComboBox();
            this.lbAdaptorLenght = new System.Windows.Forms.Label();
            this.tbAdaptorLenght = new System.Windows.Forms.TextBox();
            this.cbAdaptorLenght = new System.Windows.Forms.ComboBox();
            this.lbColumnTail = new System.Windows.Forms.Label();
            this.lbColumnTailType = new System.Windows.Forms.Label();
            this.cbColumnTail = new System.Windows.Forms.ComboBox();
            this.lbColumnTailLenght = new System.Windows.Forms.Label();
            this.tbColumnTailLenght = new System.Windows.Forms.TextBox();
            this.cbColumnTailLenghtU = new System.Windows.Forms.ComboBox();
            this.lbColumnTailHeight = new System.Windows.Forms.Label();
            this.tbColumnTailHeight = new System.Windows.Forms.TextBox();
            this.cbColumnTailHeightU = new System.Windows.Forms.ComboBox();
            this.lbEuipmentType = new System.Windows.Forms.Label();
            this.lbEquipmentType = new System.Windows.Forms.Label();
            this.cbEquipmentType = new System.Windows.Forms.ComboBox();
            this.lbLowerHanger = new System.Windows.Forms.Label();
            this.lbLoverHangerType = new System.Windows.Forms.Label();
            this.cbLowerHanger = new System.Windows.Forms.ComboBox();
            this.lbLowerHangerLenght = new System.Windows.Forms.Label();
            this.tbLowerHangerLenght = new System.Windows.Forms.TextBox();
            this.cbLowerHangerLenghtU = new System.Windows.Forms.ComboBox();
            this.lbLowerHangerHeight = new System.Windows.Forms.Label();
            this.tbLowerHangerHeight = new System.Windows.Forms.TextBox();
            this.cbLowerHangerHeightU = new System.Windows.Forms.ComboBox();
            this.lbUpperHanger = new System.Windows.Forms.Label();
            this.lbUpperHangerType = new System.Windows.Forms.Label();
            this.lbUpperHangerLenght = new System.Windows.Forms.Label();
            this.tbUpperHangerLenght = new System.Windows.Forms.TextBox();
            this.cbUpperHangerLenghtU = new System.Windows.Forms.ComboBox();
            this.lbUpperHangerHeight = new System.Windows.Forms.Label();
            this.tbUpperHangerHeight = new System.Windows.Forms.TextBox();
            this.cbUpperHangerHeightU = new System.Windows.Forms.ComboBox();
            this.lbCirculationHole = new System.Windows.Forms.Label();
            this.lbCirculationLenght = new System.Windows.Forms.Label();
            this.cbCirculationLenghtU = new System.Windows.Forms.ComboBox();
            this.lbCirculationHeight = new System.Windows.Forms.Label();
            this.cbCirculationHeightU = new System.Windows.Forms.ComboBox();
            this.lbPressure = new System.Windows.Forms.Label();
            this.lbOrifice = new System.Windows.Forms.Label();
            this.tbOrifice = new System.Windows.Forms.TextBox();
            this.cbOrificeU = new System.Windows.Forms.ComboBox();
            this.lbNktPressure = new System.Windows.Forms.Label();
            this.tbNktPressure = new System.Windows.Forms.TextBox();
            this.cbNktPressureU = new System.Windows.Forms.ComboBox();
            this.lbSaturatuonPressure = new System.Windows.Forms.Label();
            this.tbSaturationPressure = new System.Windows.Forms.TextBox();
            this.cbSaturationPressure = new System.Windows.Forms.ComboBox();
            this.lbPerforationInterval = new System.Windows.Forms.Label();
            this.cbUpPerforationLenghtU = new System.Windows.Forms.ComboBox();
            this.cbUpPerforationHeightU = new System.Windows.Forms.ComboBox();
            this.lbBottomPerforationLenght = new System.Windows.Forms.Label();
            this.tbBottomPerforationLenght = new System.Windows.Forms.TextBox();
            this.cbBottomPerforationLenghtU = new System.Windows.Forms.ComboBox();
            this.lbBottomPerforationHeight = new System.Windows.Forms.Label();
            this.tbBottomPerforationHeight = new System.Windows.Forms.TextBox();
            this.cbBottomPerforationHeightU = new System.Windows.Forms.ComboBox();
            this.lbStall = new System.Windows.Forms.Label();
            this.cbCurrentStallU = new System.Windows.Forms.ComboBox();
            this.lbFactitiousStall = new System.Windows.Forms.Label();
            this.tbFactitiousStall = new System.Windows.Forms.TextBox();
            this.cbFactitiousStallU = new System.Windows.Forms.ComboBox();
            this.lbDensity = new System.Windows.Forms.Label();
            this.lbOnAssayDensity = new System.Windows.Forms.Label();
            this.tbOnAssayDensity = new System.Windows.Forms.TextBox();
            this.cbOnAssayDensityU = new System.Windows.Forms.ComboBox();
            this.lbUsedDensity = new System.Windows.Forms.Label();
            this.tbUsedDensity = new System.Windows.Forms.TextBox();
            this.cbUsedDensityU = new System.Windows.Forms.ComboBox();
            this.lbPumpData = new System.Windows.Forms.Label();
            this.lbDoubleStep = new System.Windows.Forms.Label();
            this.cbDoubleStep = new System.Windows.Forms.ComboBox();
            this.lbPistonDiam = new System.Windows.Forms.Label();
            this.cbPistonDiam = new System.Windows.Forms.ComboBox();
            this.lbLevelingSpeed = new System.Windows.Forms.Label();
            this.tbLevelingSpeed = new System.Windows.Forms.TextBox();
            this.cbLevelingSpeedU = new System.Windows.Forms.ComboBox();
            this.lbPumpSupply = new System.Windows.Forms.Label();
            this.tbPumpSupply = new System.Windows.Forms.TextBox();
            this.cbPumpSupplyU = new System.Windows.Forms.ComboBox();
            this.lbPumpPressure = new System.Windows.Forms.Label();
            this.tbPumpPressure = new System.Windows.Forms.TextBox();
            this.cbPumpPressureU = new System.Windows.Forms.ComboBox();
            this.lbFluidParams = new System.Windows.Forms.Label();
            this.lbAnnulusPressure = new System.Windows.Forms.Label();
            this.tbAnnulusPressure = new System.Windows.Forms.TextBox();
            this.cbAnnulusPressureU = new System.Windows.Forms.ComboBox();
            this.lbDenistyBL = new System.Windows.Forms.Label();
            this.lbViscosityBL = new System.Windows.Forms.Label();
            this.lbViscosityCL = new System.Windows.Forms.Label();
            this.lbWellData = new System.Windows.Forms.Label();
            this.lbWhellType = new System.Windows.Forms.Label();
            this.lbSafetyFactor = new System.Windows.Forms.Label();
            this.lbBedParams = new System.Windows.Forms.Label();
            this.lbBedType = new System.Windows.Forms.Label();
            this.cs_Bed_Type = new System.Windows.Forms.ComboBox();
            this.lbBedThickness = new System.Windows.Forms.Label();
            this.e_Bed_Thickness = new System.Windows.Forms.TextBox();
            this.cbBedThicknessU = new System.Windows.Forms.ComboBox();
            this.lbGasFactor = new System.Windows.Forms.Label();
            this.cbGasFactor = new System.Windows.Forms.ComboBox();
            this.lbServiceCompany = new System.Windows.Forms.Label();
            this.lbBrigade = new System.Windows.Forms.Label();
            this.lbMaster = new System.Windows.Forms.Label();
            this.tbServiceCompany = new System.Windows.Forms.TextBox();
            this.tbBrigade = new System.Windows.Forms.TextBox();
            this.tbMaster = new System.Windows.Forms.TextBox();
            this.lbCirculationHolePresent = new System.Windows.Forms.Label();
            this.cbCirculationHolePresent = new System.Windows.Forms.CheckBox();
            this.tpPlan = new System.Windows.Forms.TabPage();
            this.tlPlan = new System.Windows.Forms.TableLayoutPanel();
            this.lbResNktInningStepU = new System.Windows.Forms.Label();
            this.cbResJamDensityU = new System.Windows.Forms.ComboBox();
            this.cbResDensityPutFluidU = new System.Windows.Forms.ComboBox();
            this.lbResJamFluidFullVolU = new System.Windows.Forms.Label();
            this.lbResJamFluidStockVolU = new System.Windows.Forms.Label();
            this.lbResJamFluidVolU = new System.Windows.Forms.Label();
            this.lbResUnderPumpVolU = new System.Windows.Forms.Label();
            this.lbResOutPipeVolU = new System.Windows.Forms.Label();
            this.lbResColumnTailVolU = new System.Windows.Forms.Label();
            this.lbResReducing100 = new System.Windows.Forms.Label();
            this.lbResOutPipeVol = new System.Windows.Forms.Label();
            this.lbResVolume = new System.Windows.Forms.Label();
            this.lbResColumnVol = new System.Windows.Forms.Label();
            this.tbResColumnVol = new System.Windows.Forms.TextBox();
            this.lbResColumnTailVol = new System.Windows.Forms.Label();
            this.tbResNKTVol = new System.Windows.Forms.TextBox();
            this.tbResOutPipeVol = new System.Windows.Forms.TextBox();
            this.lbResUnderPumpVol = new System.Windows.Forms.Label();
            this.tbResUnderPumpVol = new System.Windows.Forms.TextBox();
            this.lbResJamFluidVol = new System.Windows.Forms.Label();
            this.tbResJamFluidVol = new System.Windows.Forms.TextBox();
            this.lbResJamFluidStockVol = new System.Windows.Forms.Label();
            this.tbResJamFluidStockVol = new System.Windows.Forms.TextBox();
            this.lbResJamFluidFullVol = new System.Windows.Forms.Label();
            this.tbResJamFluidFullVol = new System.Windows.Forms.TextBox();
            this.lbDenisty = new System.Windows.Forms.Label();
            this.lbResDensityPutFluid = new System.Windows.Forms.Label();
            this.tbResDensityPutFluid = new System.Windows.Forms.TextBox();
            this.lbResJamDensity = new System.Windows.Forms.Label();
            this.tbResJamDensity = new System.Windows.Forms.TextBox();
            this.lbNKTPumpSpeed = new System.Windows.Forms.Label();
            this.lbResNktInningStep = new System.Windows.Forms.Label();
            this.tbResNktInningStep = new System.Windows.Forms.TextBox();
            this.lbResInnerTime = new System.Windows.Forms.Label();
            this.tbResInnerTime = new System.Windows.Forms.TextBox();
            this.lbROutPipePumpSpeed = new System.Windows.Forms.Label();
            this.lbResOutPipeInningStep = new System.Windows.Forms.Label();
            this.tbResOutPipeInningStep = new System.Windows.Forms.TextBox();
            this.lbResOutPipeInningTime = new System.Windows.Forms.Label();
            this.tbResOutPipeInningTime = new System.Windows.Forms.TextBox();
            this.lbResClearingFluidSpeed = new System.Windows.Forms.Label();
            this.lbResClearingInningStep = new System.Windows.Forms.Label();
            this.tbResClearingInningStep = new System.Windows.Forms.TextBox();
            this.lbResClearingInningTime = new System.Windows.Forms.Label();
            this.tbResClearingInningTime = new System.Windows.Forms.TextBox();
            this.lbAddedParam = new System.Windows.Forms.Label();
            this.lbResNCD = new System.Windows.Forms.Label();
            this.lbResKCD = new System.Windows.Forms.Label();
            this.tbResNCD = new System.Windows.Forms.TextBox();
            this.tbResKCD = new System.Windows.Forms.TextBox();
            this.tbResReducing100 = new System.Windows.Forms.TextBox();
            this.lbResColumnVolU = new System.Windows.Forms.Label();
            this.cbResInnerTimeU = new System.Windows.Forms.ComboBox();
            this.lbResOutPipeInningStepU = new System.Windows.Forms.Label();
            this.cbResOutPipeInningTimeU = new System.Windows.Forms.ComboBox();
            this.lbResClearingInningStepU = new System.Windows.Forms.Label();
            this.cbResClearingInningTimeU = new System.Windows.Forms.ComboBox();
            this.cbResNCDU = new System.Windows.Forms.ComboBox();
            this.cbResKCDU = new System.Windows.Forms.ComboBox();
            this.cbResReducing100U = new System.Windows.Forms.ComboBox();
            this.lbCycles = new System.Windows.Forms.Label();
            this.tbCycles = new System.Windows.Forms.TextBox();
            this.tpResult = new System.Windows.Forms.TabPage();
            this.tlpChart = new System.Windows.Forms.TableLayoutPanel();
            this.tpSchema = new System.Windows.Forms.TabPage();
            this.tpDir = new System.Windows.Forms.TabPage();
            this.tpTab = new System.Windows.Forms.TableLayoutPanel();
            this.tvPlan = new System.Windows.Forms.TreeView();
            this.tlpAlg = new System.Windows.Forms.TableLayoutPanel();
            this.pnPlanActions = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.tbExternalItem = new System.Windows.Forms.TextBox();
            this.lbBeforeHand = new System.Windows.Forms.ListBox();
            this.btSavePlan = new System.Windows.Forms.Button();
            this.btDeleteNode = new System.Windows.Forms.Button();
            this.btAddNode = new System.Windows.Forms.Button();
            this.tpPlotn = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbRoSel = new System.Windows.Forms.ComboBox();
            this.lvRo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dgCoastTable = new System.Windows.Forms.DataGridView();
            this.Density = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpSetUp = new System.Windows.Forms.TabPage();
            this.gbFimension = new System.Windows.Forms.GroupBox();
            this.gbViscosity = new System.Windows.Forms.GroupBox();
            this.rbSPz = new System.Windows.Forms.RadioButton();
            this.rbMpaS = new System.Windows.Forms.RadioButton();
            this.gbDensity = new System.Windows.Forms.GroupBox();
            this.rbGsm = new System.Windows.Forms.RadioButton();
            this.rbKgm = new System.Windows.Forms.RadioButton();
            this.gbPressure = new System.Windows.Forms.GroupBox();
            this.rbMpa = new System.Windows.Forms.RadioButton();
            this.rbAtm = new System.Windows.Forms.RadioButton();
            this.gbDeep = new System.Windows.Forms.GroupBox();
            this.rbKm = new System.Windows.Forms.RadioButton();
            this.rbMeters = new System.Windows.Forms.RadioButton();
            this.gbSystemName = new System.Windows.Forms.GroupBox();
            this.rbSGS = new System.Windows.Forms.RadioButton();
            this.rbSI = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.extiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnGeometheryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPipe.SuspendLayout();
            this.tcCntrl.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.tlIncomingData.SuspendLayout();
            this.tpPlan.SuspendLayout();
            this.tlPlan.SuspendLayout();
            this.tpResult.SuspendLayout();
            this.tpDir.SuspendLayout();
            this.tpTab.SuspendLayout();
            this.pnPlanActions.SuspendLayout();
            this.tpPlotn.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCoastTable)).BeginInit();
            this.tpSetUp.SuspendLayout();
            this.gbFimension.SuspendLayout();
            this.gbViscosity.SuspendLayout();
            this.gbDensity.SuspendLayout();
            this.gbPressure.SuspendLayout();
            this.gbDeep.SuspendLayout();
            this.gbSystemName.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cs_Safety_Factor
            // 
            this.tlIncomingData.SetColumnSpan(this.cs_Safety_Factor, 2);
            this.cs_Safety_Factor.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cs_Safety_Factor.FormattingEnabled = true;
            this.cs_Safety_Factor.Items.AddRange(new object[] {
            "3%",
            "5%",
            "7%",
            "10%"});
            this.cs_Safety_Factor.Location = new System.Drawing.Point(205, 1632);
            this.cs_Safety_Factor.Name = "cs_Safety_Factor";
            this.cs_Safety_Factor.Size = new System.Drawing.Size(166, 24);
            this.cs_Safety_Factor.TabIndex = 35;
            this.cs_Safety_Factor.Leave += new System.EventHandler(this.cs_Safety_Factor_Leave);
            // 
            // cs_Unevenness
            // 
            this.tlIncomingData.SetColumnSpan(this.cs_Unevenness, 2);
            this.cs_Unevenness.Dock = System.Windows.Forms.DockStyle.Top;
            this.cs_Unevenness.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cs_Unevenness.FormattingEnabled = true;
            this.cs_Unevenness.ItemHeight = 16;
            this.cs_Unevenness.Items.AddRange(new object[] {
            "старая",
            "новая"});
            this.cs_Unevenness.Location = new System.Drawing.Point(205, 1602);
            this.cs_Unevenness.Name = "cs_Unevenness";
            this.cs_Unevenness.Size = new System.Drawing.Size(166, 24);
            this.cs_Unevenness.TabIndex = 34;
            this.cs_Unevenness.Text = "старая";
            this.cs_Unevenness.Leave += new System.EventHandler(this.cs_Unevenness_Leave);
            // 
            // cs_Dyn_Viscosity_Unit_CL
            // 
            this.cs_Dyn_Viscosity_Unit_CL.Dock = System.Windows.Forms.DockStyle.Top;
            this.cs_Dyn_Viscosity_Unit_CL.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cs_Dyn_Viscosity_Unit_CL.Items.AddRange(new object[] {
            "Па/с",
            "Пуаз"});
            this.cs_Dyn_Viscosity_Unit_CL.Location = new System.Drawing.Point(317, 1553);
            this.cs_Dyn_Viscosity_Unit_CL.Name = "cs_Dyn_Viscosity_Unit_CL";
            this.cs_Dyn_Viscosity_Unit_CL.Size = new System.Drawing.Size(54, 24);
            this.cs_Dyn_Viscosity_Unit_CL.TabIndex = 42;
            this.cs_Dyn_Viscosity_Unit_CL.Text = "Па/с";
            this.cs_Dyn_Viscosity_Unit_CL.Leave += new System.EventHandler(this.cs_Dyn_Viscosity_Unit_CL_Leave);
            // 
            // e_Dyn_Viscosity_CL
            // 
            this.e_Dyn_Viscosity_CL.Dock = System.Windows.Forms.DockStyle.Top;
            this.e_Dyn_Viscosity_CL.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_Dyn_Viscosity_CL.Location = new System.Drawing.Point(205, 1553);
            this.e_Dyn_Viscosity_CL.Name = "e_Dyn_Viscosity_CL";
            this.e_Dyn_Viscosity_CL.Size = new System.Drawing.Size(106, 23);
            this.e_Dyn_Viscosity_CL.TabIndex = 33;
            this.e_Dyn_Viscosity_CL.DoubleClick += new System.EventHandler(this.e_Dyn_Viscosity_CL_DoubleClick);
            this.e_Dyn_Viscosity_CL.Leave += new System.EventHandler(this.e_Dyn_Viscosity_CL_Leave);
            // 
            // cs_Dyn_Viscosity_Unit_BL
            // 
            this.cs_Dyn_Viscosity_Unit_BL.Dock = System.Windows.Forms.DockStyle.Top;
            this.cs_Dyn_Viscosity_Unit_BL.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cs_Dyn_Viscosity_Unit_BL.FormattingEnabled = true;
            this.cs_Dyn_Viscosity_Unit_BL.Items.AddRange(new object[] {
            "Па/с",
            "Пуаз"});
            this.cs_Dyn_Viscosity_Unit_BL.Location = new System.Drawing.Point(317, 1523);
            this.cs_Dyn_Viscosity_Unit_BL.Name = "cs_Dyn_Viscosity_Unit_BL";
            this.cs_Dyn_Viscosity_Unit_BL.Size = new System.Drawing.Size(54, 24);
            this.cs_Dyn_Viscosity_Unit_BL.TabIndex = 41;
            this.cs_Dyn_Viscosity_Unit_BL.Text = "Па/с";
            this.cs_Dyn_Viscosity_Unit_BL.Leave += new System.EventHandler(this.cs_Dyn_Viscosity_Unit_BL_Leave);
            // 
            // e_Dyn_Viscosity_BL
            // 
            this.e_Dyn_Viscosity_BL.Dock = System.Windows.Forms.DockStyle.Top;
            this.e_Dyn_Viscosity_BL.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_Dyn_Viscosity_BL.Location = new System.Drawing.Point(205, 1523);
            this.e_Dyn_Viscosity_BL.Name = "e_Dyn_Viscosity_BL";
            this.e_Dyn_Viscosity_BL.Size = new System.Drawing.Size(106, 22);
            this.e_Dyn_Viscosity_BL.TabIndex = 32;
            this.e_Dyn_Viscosity_BL.DoubleClick += new System.EventHandler(this.e_Dyn_Viscosity_BL_DoubleClick);
            this.e_Dyn_Viscosity_BL.Leave += new System.EventHandler(this.e_Dyn_Viscosity_BL_Leave);
            // 
            // cs_Density_Unit_BL
            // 
            this.cs_Density_Unit_BL.Dock = System.Windows.Forms.DockStyle.Top;
            this.cs_Density_Unit_BL.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cs_Density_Unit_BL.FormattingEnabled = true;
            this.cs_Density_Unit_BL.Items.AddRange(new object[] {
            "г/см3",
            "кг/м3"});
            this.cs_Density_Unit_BL.Location = new System.Drawing.Point(317, 1493);
            this.cs_Density_Unit_BL.Name = "cs_Density_Unit_BL";
            this.cs_Density_Unit_BL.Size = new System.Drawing.Size(54, 24);
            this.cs_Density_Unit_BL.TabIndex = 40;
            this.cs_Density_Unit_BL.Text = "кг/м3";
            this.cs_Density_Unit_BL.Leave += new System.EventHandler(this.cs_Density_Unit_BL_Leave);
            // 
            // e_Density_BL
            // 
            this.e_Density_BL.Dock = System.Windows.Forms.DockStyle.Top;
            this.e_Density_BL.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_Density_BL.Location = new System.Drawing.Point(205, 1493);
            this.e_Density_BL.Name = "e_Density_BL";
            this.e_Density_BL.Size = new System.Drawing.Size(106, 23);
            this.e_Density_BL.TabIndex = 31;
            this.e_Density_BL.DoubleClick += new System.EventHandler(this.e_Density_BL_DoubleClick);
            this.e_Density_BL.Leave += new System.EventHandler(this.e_Density_BL_Leave);
            // 
            // cbStratumPressureU
            // 
            this.cbStratumPressureU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbStratumPressureU.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStratumPressureU.FormattingEnabled = true;
            this.cbStratumPressureU.Items.AddRange(new object[] {
            "атм",
            "МПа"});
            this.cbStratumPressureU.Location = new System.Drawing.Point(317, 1783);
            this.cbStratumPressureU.Name = "cbStratumPressureU";
            this.cbStratumPressureU.Size = new System.Drawing.Size(54, 24);
            this.cbStratumPressureU.TabIndex = 46;
            this.cbStratumPressureU.Leave += new System.EventHandler(this.cs_Bed_Pressure_Unit_Leave);
            // 
            // e_Bed_Pressure
            // 
            this.e_Bed_Pressure.Dock = System.Windows.Forms.DockStyle.Top;
            this.e_Bed_Pressure.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_Bed_Pressure.Location = new System.Drawing.Point(205, 1783);
            this.e_Bed_Pressure.Name = "e_Bed_Pressure";
            this.e_Bed_Pressure.Size = new System.Drawing.Size(106, 23);
            this.e_Bed_Pressure.TabIndex = 16;
            this.e_Bed_Pressure.DoubleClick += new System.EventHandler(this.e_Bed_Pressure_DoubleClick);
            this.e_Bed_Pressure.Leave += new System.EventHandler(this.e_Bed_Pressure_Leave);
            // 
            // lbStratumPressure
            // 
            this.lbStratumPressure.AutoSize = true;
            this.lbStratumPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStratumPressure.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStratumPressure.Location = new System.Drawing.Point(3, 1780);
            this.lbStratumPressure.Name = "lbStratumPressure";
            this.lbStratumPressure.Size = new System.Drawing.Size(196, 30);
            this.lbStratumPressure.TabIndex = 17;
            this.lbStratumPressure.Text = "Пластовое давление";
            this.lbStratumPressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCurrentStall
            // 
            this.tbCurrentStall.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCurrentStall.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCurrentStall.Location = new System.Drawing.Point(205, 1128);
            this.tbCurrentStall.Name = "tbCurrentStall";
            this.tbCurrentStall.Size = new System.Drawing.Size(106, 23);
            this.tbCurrentStall.TabIndex = 22;
            this.tbCurrentStall.DoubleClick += new System.EventHandler(this.e_Well_Bottom_Depth_DoubleClick);
            this.tbCurrentStall.Leave += new System.EventHandler(this.e_Well_Bottom_Depth_Leave);
            // 
            // lbCurrentStall
            // 
            this.lbCurrentStall.AutoSize = true;
            this.lbCurrentStall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCurrentStall.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentStall.Location = new System.Drawing.Point(3, 1125);
            this.lbCurrentStall.Name = "lbCurrentStall";
            this.lbCurrentStall.Size = new System.Drawing.Size(196, 32);
            this.lbCurrentStall.TabIndex = 0;
            this.lbCurrentStall.Text = "Текущий";
            this.lbCurrentStall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // e_Hole_Position_Vertical
            // 
            this.e_Hole_Position_Vertical.ContextMenuStrip = this.cmsPipe;
            this.e_Hole_Position_Vertical.Dock = System.Windows.Forms.DockStyle.Top;
            this.e_Hole_Position_Vertical.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_Hole_Position_Vertical.Location = new System.Drawing.Point(205, 821);
            this.e_Hole_Position_Vertical.Name = "e_Hole_Position_Vertical";
            this.e_Hole_Position_Vertical.Size = new System.Drawing.Size(106, 22);
            this.e_Hole_Position_Vertical.TabIndex = 15;
            this.e_Hole_Position_Vertical.Leave += new System.EventHandler(this.e_Hole_Position_Vertical_Leave);
            this.e_Hole_Position_Vertical.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.e_Hole_Position_Vertical_MouseDoubleClick);
            // 
            // cmsPipe
            // 
            this.cmsPipe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciTubeConfiguration,
            this.ciCornerEncount});
            this.cmsPipe.Name = "cmsPipe";
            this.cmsPipe.Size = new System.Drawing.Size(193, 48);
            // 
            // ciTubeConfiguration
            // 
            this.ciTubeConfiguration.Name = "ciTubeConfiguration";
            this.ciTubeConfiguration.Size = new System.Drawing.Size(192, 22);
            this.ciTubeConfiguration.Text = "Конфигурация трубы";
            this.ciTubeConfiguration.Click += new System.EventHandler(this.ciTubeConfiguration_Click);
            // 
            // ciCornerEncount
            // 
            this.ciCornerEncount.Name = "ciCornerEncount";
            this.ciCornerEncount.Size = new System.Drawing.Size(192, 22);
            this.ciCornerEncount.Text = "Расчет наклона";
            // 
            // e_Hole_Position_By_Pipe
            // 
            this.e_Hole_Position_By_Pipe.ContextMenuStrip = this.cmsPipe;
            this.e_Hole_Position_By_Pipe.Dock = System.Windows.Forms.DockStyle.Top;
            this.e_Hole_Position_By_Pipe.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_Hole_Position_By_Pipe.Location = new System.Drawing.Point(205, 789);
            this.e_Hole_Position_By_Pipe.Name = "e_Hole_Position_By_Pipe";
            this.e_Hole_Position_By_Pipe.Size = new System.Drawing.Size(106, 22);
            this.e_Hole_Position_By_Pipe.TabIndex = 14;
            this.e_Hole_Position_By_Pipe.Leave += new System.EventHandler(this.e_Hole_Position_By_Pipe_Leave);
            this.e_Hole_Position_By_Pipe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.e_Hole_Position_By_Pipe_MouseDoubleClick);
            // 
            // lbUpPerforationHeight
            // 
            this.lbUpPerforationHeight.AutoSize = true;
            this.lbUpPerforationHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUpPerforationHeight.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUpPerforationHeight.Location = new System.Drawing.Point(3, 1010);
            this.lbUpPerforationHeight.Name = "lbUpPerforationHeight";
            this.lbUpPerforationHeight.Size = new System.Drawing.Size(196, 32);
            this.lbUpPerforationHeight.TabIndex = 7;
            this.lbUpPerforationHeight.Text = "Верх по вертикали";
            this.lbUpPerforationHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbUpPerforationLenght
            // 
            this.lbUpPerforationLenght.AutoSize = true;
            this.lbUpPerforationLenght.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUpPerforationLenght.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUpPerforationLenght.Location = new System.Drawing.Point(3, 978);
            this.lbUpPerforationLenght.Name = "lbUpPerforationLenght";
            this.lbUpPerforationLenght.Size = new System.Drawing.Size(196, 32);
            this.lbUpPerforationLenght.TabIndex = 6;
            this.lbUpPerforationLenght.Text = "Верх по трубе";
            this.lbUpPerforationLenght.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // e_Perforation_Distance_Vertical
            // 
            this.e_Perforation_Distance_Vertical.Dock = System.Windows.Forms.DockStyle.Top;
            this.e_Perforation_Distance_Vertical.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_Perforation_Distance_Vertical.Location = new System.Drawing.Point(205, 1013);
            this.e_Perforation_Distance_Vertical.Name = "e_Perforation_Distance_Vertical";
            this.e_Perforation_Distance_Vertical.Size = new System.Drawing.Size(106, 22);
            this.e_Perforation_Distance_Vertical.TabIndex = 19;
            this.e_Perforation_Distance_Vertical.DoubleClick += new System.EventHandler(this.e_Perforation_Distance_Vertical_DoubleClick);
            this.e_Perforation_Distance_Vertical.Leave += new System.EventHandler(this.e_Perforation_Distance_Vertical_Leave);
            // 
            // e_Perforation_Distance_By_Pipe
            // 
            this.e_Perforation_Distance_By_Pipe.Dock = System.Windows.Forms.DockStyle.Top;
            this.e_Perforation_Distance_By_Pipe.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_Perforation_Distance_By_Pipe.Location = new System.Drawing.Point(205, 981);
            this.e_Perforation_Distance_By_Pipe.Name = "e_Perforation_Distance_By_Pipe";
            this.e_Perforation_Distance_By_Pipe.Size = new System.Drawing.Size(106, 22);
            this.e_Perforation_Distance_By_Pipe.TabIndex = 18;
            this.e_Perforation_Distance_By_Pipe.DoubleClick += new System.EventHandler(this.e_Perforation_Distance_By_Pipe_DoubleClick);
            this.e_Perforation_Distance_By_Pipe.Leave += new System.EventHandler(this.e_Perforation_Distance_By_Pipe_Leave);
            // 
            // lbColumn
            // 
            this.lbColumn.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbColumn, 3);
            this.lbColumn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbColumn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbColumn.Location = new System.Drawing.Point(3, 180);
            this.lbColumn.Name = "lbColumn";
            this.lbColumn.Size = new System.Drawing.Size(368, 19);
            this.lbColumn.TabIndex = 3;
            this.lbColumn.Text = "Эксплуатационн колонна:";
            this.lbColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cs_Column_Geometry
            // 
            this.tlIncomingData.SetColumnSpan(this.cs_Column_Geometry, 2);
            this.cs_Column_Geometry.Dock = System.Windows.Forms.DockStyle.Top;
            this.cs_Column_Geometry.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cs_Column_Geometry.FormattingEnabled = true;
            this.cs_Column_Geometry.ItemHeight = 16;
            this.cs_Column_Geometry.Items.AddRange(new object[] {
            "D=140 мм, S=7.8 мм",
            "D=146 мм, S=6.5 мм",
            "D=146 мм, S=7.0 мм",
            "D=146 мм, S=7.7 мм",
            "D=146 мм, S=8.5 мм",
            "D=146 мм, S=9.5 мм",
            "D=146 мм, S=10.7 мм",
            "D=168 мм, S=7.3 мм",
            "D=168 мм, S=8.0 мм",
            "D=168 мм, S=8.9 мм",
            "D=168 мм, S=10.6 мм",
            "D=178 мм, S=8.2 мм",
            "D=178 мм, S=9.3 мм",
            "D=178 мм, S=10.04 мм",
            "D=178 мм, S=10.5 мм",
            "D=219 мм, S=8.8 мм",
            "D=219 мм, S=10.2 мм",
            "D=245 мм, S=11.1 мм"});
            this.cs_Column_Geometry.Location = new System.Drawing.Point(205, 202);
            this.cs_Column_Geometry.Name = "cs_Column_Geometry";
            this.cs_Column_Geometry.Size = new System.Drawing.Size(166, 24);
            this.cs_Column_Geometry.TabIndex = 3;
            this.cs_Column_Geometry.Text = "D=140 мм, S=7.8 мм";
            this.cs_Column_Geometry.Leave += new System.EventHandler(this.cs_Column_Geometry_Leave);
            // 
            // cs_Pipe_Geometry
            // 
            this.tlIncomingData.SetColumnSpan(this.cs_Pipe_Geometry, 2);
            this.cs_Pipe_Geometry.Dock = System.Windows.Forms.DockStyle.Top;
            this.cs_Pipe_Geometry.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cs_Pipe_Geometry.FormattingEnabled = true;
            this.cs_Pipe_Geometry.ItemHeight = 16;
            this.cs_Pipe_Geometry.Items.AddRange(new object[] {
            "d=48 мм, s=4.0 мм",
            "d=60 мм, s=5.0 мм",
            "d=73 мм, s=5.0 мм",
            "d=73 мм, s=5.5 мм",
            "d=73 мм, s=6.0 мм",
            "d=73 мм, s=7.0 мм",
            "d=89 мм, s=6.0 мм",
            "d=89 мм, s=6.5 мм",
            "d=89 мм, s=7.34 мм",
            "d=89 мм, s=8.0 мм",
            "d=102 мм, s=6.5 мм",
            "d=114 мм, s=7.0 мм"});
            this.cs_Pipe_Geometry.Location = new System.Drawing.Point(205, 632);
            this.cs_Pipe_Geometry.Name = "cs_Pipe_Geometry";
            this.cs_Pipe_Geometry.Size = new System.Drawing.Size(166, 24);
            this.cs_Pipe_Geometry.TabIndex = 13;
            this.cs_Pipe_Geometry.Text = "d=48 мм, s=4.0 мм";
            this.cs_Pipe_Geometry.Leave += new System.EventHandler(this.cs_Pipe_Geometry_Leave);
            // 
            // lbBush
            // 
            this.lbBush.AutoSize = true;
            this.lbBush.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBush.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBush.Location = new System.Drawing.Point(3, 56);
            this.lbBush.Name = "lbBush";
            this.lbBush.Size = new System.Drawing.Size(196, 28);
            this.lbBush.TabIndex = 5;
            this.lbBush.Text = "Куст";
            this.lbBush.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHole
            // 
            this.lbHole.AutoSize = true;
            this.lbHole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHole.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHole.Location = new System.Drawing.Point(3, 28);
            this.lbHole.Name = "lbHole";
            this.lbHole.Size = new System.Drawing.Size(196, 28);
            this.lbHole.TabIndex = 4;
            this.lbHole.Text = "Скважина";
            this.lbHole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // e_Cluster_Name
            // 
            this.tlIncomingData.SetColumnSpan(this.e_Cluster_Name, 2);
            this.e_Cluster_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.e_Cluster_Name.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_Cluster_Name.Location = new System.Drawing.Point(205, 59);
            this.e_Cluster_Name.Name = "e_Cluster_Name";
            this.e_Cluster_Name.Size = new System.Drawing.Size(166, 22);
            this.e_Cluster_Name.TabIndex = 2;
            // 
            // e_Well_Number
            // 
            this.tlIncomingData.SetColumnSpan(this.e_Well_Number, 2);
            this.e_Well_Number.Dock = System.Windows.Forms.DockStyle.Top;
            this.e_Well_Number.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_Well_Number.Location = new System.Drawing.Point(205, 31);
            this.e_Well_Number.Name = "e_Well_Number";
            this.e_Well_Number.Size = new System.Drawing.Size(166, 22);
            this.e_Well_Number.TabIndex = 1;
            // 
            // lbLocate
            // 
            this.lbLocate.AutoSize = true;
            this.lbLocate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLocate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLocate.Location = new System.Drawing.Point(3, 0);
            this.lbLocate.Name = "lbLocate";
            this.lbLocate.Size = new System.Drawing.Size(196, 28);
            this.lbLocate.TabIndex = 1;
            this.lbLocate.Text = "Месторождение";
            this.lbLocate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // e_OilField_name
            // 
            this.tlIncomingData.SetColumnSpan(this.e_OilField_name, 2);
            this.e_OilField_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.e_OilField_name.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_OilField_name.Location = new System.Drawing.Point(205, 3);
            this.e_OilField_name.Name = "e_OilField_name";
            this.e_OilField_name.Size = new System.Drawing.Size(166, 22);
            this.e_OilField_name.TabIndex = 0;
            // 
            // tcCntrl
            // 
            this.tcCntrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcCntrl.Controls.Add(this.tpInfo);
            this.tcCntrl.Controls.Add(this.tpPlan);
            this.tcCntrl.Controls.Add(this.tpResult);
            this.tcCntrl.Controls.Add(this.tpSchema);
            this.tcCntrl.Controls.Add(this.tpDir);
            this.tcCntrl.Controls.Add(this.tpPlotn);
            this.tcCntrl.Controls.Add(this.tpSetUp);
            this.tcCntrl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcCntrl.Location = new System.Drawing.Point(0, 27);
            this.tcCntrl.Name = "tcCntrl";
            this.tcCntrl.SelectedIndex = 0;
            this.tcCntrl.Size = new System.Drawing.Size(1301, 576);
            this.tcCntrl.TabIndex = 4;
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.pnShema);
            this.tpInfo.Controls.Add(this.tlIncomingData);
            this.tpInfo.Location = new System.Drawing.Point(4, 32);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(1293, 540);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Исходные данные";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // pnShema
            // 
            this.pnShema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnShema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnShema.Location = new System.Drawing.Point(417, 3);
            this.pnShema.Name = "pnShema";
            this.pnShema.Size = new System.Drawing.Size(873, 534);
            this.pnShema.TabIndex = 5;
            this.pnShema.Paint += new System.Windows.Forms.PaintEventHandler(this.pnShema_Paint);
            // 
            // tlIncomingData
            // 
            this.tlIncomingData.AutoScroll = true;
            this.tlIncomingData.AutoScrollMargin = new System.Drawing.Size(22, 16);
            this.tlIncomingData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlIncomingData.ColumnCount = 4;
            this.tlIncomingData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlIncomingData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.08514F));
            this.tlIncomingData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.91486F));
            this.tlIncomingData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlIncomingData.Controls.Add(this.lbLocate, 0, 0);
            this.tlIncomingData.Controls.Add(this.e_OilField_name, 1, 0);
            this.tlIncomingData.Controls.Add(this.lbHole, 0, 1);
            this.tlIncomingData.Controls.Add(this.e_Well_Number, 1, 1);
            this.tlIncomingData.Controls.Add(this.lbBush, 0, 2);
            this.tlIncomingData.Controls.Add(this.e_Cluster_Name, 1, 2);
            this.tlIncomingData.Controls.Add(this.lbColumn, 0, 6);
            this.tlIncomingData.Controls.Add(this.lbColumnType, 0, 7);
            this.tlIncomingData.Controls.Add(this.cs_Column_Geometry, 1, 7);
            this.tlIncomingData.Controls.Add(this.lbColumnLenght, 0, 8);
            this.tlIncomingData.Controls.Add(this.tbColumnLenght, 1, 8);
            this.tlIncomingData.Controls.Add(this.cbColumnLenghtU, 2, 8);
            this.tlIncomingData.Controls.Add(this.lbColumnHeight, 0, 9);
            this.tlIncomingData.Controls.Add(this.tbColumnHeight, 1, 9);
            this.tlIncomingData.Controls.Add(this.cbColumnHeightU, 2, 9);
            this.tlIncomingData.Controls.Add(this.lbAdaptorLenght, 0, 10);
            this.tlIncomingData.Controls.Add(this.tbAdaptorLenght, 1, 10);
            this.tlIncomingData.Controls.Add(this.cbAdaptorLenght, 2, 10);
            this.tlIncomingData.Controls.Add(this.lbColumnTail, 0, 11);
            this.tlIncomingData.Controls.Add(this.lbColumnTailType, 0, 12);
            this.tlIncomingData.Controls.Add(this.cbColumnTail, 1, 12);
            this.tlIncomingData.Controls.Add(this.lbColumnTailLenght, 0, 13);
            this.tlIncomingData.Controls.Add(this.tbColumnTailLenght, 1, 13);
            this.tlIncomingData.Controls.Add(this.cbColumnTailLenghtU, 2, 13);
            this.tlIncomingData.Controls.Add(this.lbColumnTailHeight, 0, 14);
            this.tlIncomingData.Controls.Add(this.tbColumnTailHeight, 1, 14);
            this.tlIncomingData.Controls.Add(this.cbColumnTailHeightU, 2, 14);
            this.tlIncomingData.Controls.Add(this.lbEuipmentType, 0, 15);
            this.tlIncomingData.Controls.Add(this.lbEquipmentType, 0, 16);
            this.tlIncomingData.Controls.Add(this.cbEquipmentType, 1, 16);
            this.tlIncomingData.Controls.Add(this.lbLowerHanger, 0, 17);
            this.tlIncomingData.Controls.Add(this.lbLoverHangerType, 0, 18);
            this.tlIncomingData.Controls.Add(this.cbLowerHanger, 1, 18);
            this.tlIncomingData.Controls.Add(this.lbLowerHangerLenght, 0, 19);
            this.tlIncomingData.Controls.Add(this.tbLowerHangerLenght, 1, 19);
            this.tlIncomingData.Controls.Add(this.cbLowerHangerLenghtU, 2, 19);
            this.tlIncomingData.Controls.Add(this.lbLowerHangerHeight, 0, 20);
            this.tlIncomingData.Controls.Add(this.tbLowerHangerHeight, 1, 20);
            this.tlIncomingData.Controls.Add(this.cbLowerHangerHeightU, 2, 20);
            this.tlIncomingData.Controls.Add(this.lbUpperHanger, 0, 21);
            this.tlIncomingData.Controls.Add(this.lbUpperHangerType, 0, 22);
            this.tlIncomingData.Controls.Add(this.cs_Pipe_Geometry, 1, 22);
            this.tlIncomingData.Controls.Add(this.lbUpperHangerLenght, 0, 23);
            this.tlIncomingData.Controls.Add(this.tbUpperHangerLenght, 1, 23);
            this.tlIncomingData.Controls.Add(this.cbUpperHangerLenghtU, 2, 23);
            this.tlIncomingData.Controls.Add(this.lbUpperHangerHeight, 0, 24);
            this.tlIncomingData.Controls.Add(this.tbUpperHangerHeight, 1, 24);
            this.tlIncomingData.Controls.Add(this.cbUpperHangerHeightU, 2, 24);
            this.tlIncomingData.Controls.Add(this.lbCirculationHole, 0, 25);
            this.tlIncomingData.Controls.Add(this.lbCirculationLenght, 0, 27);
            this.tlIncomingData.Controls.Add(this.e_Hole_Position_By_Pipe, 1, 27);
            this.tlIncomingData.Controls.Add(this.cbCirculationLenghtU, 2, 27);
            this.tlIncomingData.Controls.Add(this.lbCirculationHeight, 0, 28);
            this.tlIncomingData.Controls.Add(this.e_Hole_Position_Vertical, 1, 28);
            this.tlIncomingData.Controls.Add(this.cbCirculationHeightU, 2, 28);
            this.tlIncomingData.Controls.Add(this.lbPressure, 0, 29);
            this.tlIncomingData.Controls.Add(this.lbOrifice, 0, 30);
            this.tlIncomingData.Controls.Add(this.tbOrifice, 1, 30);
            this.tlIncomingData.Controls.Add(this.cbOrificeU, 2, 30);
            this.tlIncomingData.Controls.Add(this.lbNktPressure, 0, 31);
            this.tlIncomingData.Controls.Add(this.tbNktPressure, 1, 31);
            this.tlIncomingData.Controls.Add(this.cbNktPressureU, 2, 31);
            this.tlIncomingData.Controls.Add(this.lbSaturatuonPressure, 0, 32);
            this.tlIncomingData.Controls.Add(this.tbSaturationPressure, 1, 32);
            this.tlIncomingData.Controls.Add(this.cbSaturationPressure, 2, 32);
            this.tlIncomingData.Controls.Add(this.lbPerforationInterval, 0, 33);
            this.tlIncomingData.Controls.Add(this.lbUpPerforationLenght, 0, 34);
            this.tlIncomingData.Controls.Add(this.e_Perforation_Distance_By_Pipe, 1, 34);
            this.tlIncomingData.Controls.Add(this.cbUpPerforationLenghtU, 2, 34);
            this.tlIncomingData.Controls.Add(this.lbUpPerforationHeight, 0, 35);
            this.tlIncomingData.Controls.Add(this.e_Perforation_Distance_Vertical, 1, 35);
            this.tlIncomingData.Controls.Add(this.cbUpPerforationHeightU, 2, 35);
            this.tlIncomingData.Controls.Add(this.lbBottomPerforationLenght, 0, 36);
            this.tlIncomingData.Controls.Add(this.tbBottomPerforationLenght, 1, 36);
            this.tlIncomingData.Controls.Add(this.cbBottomPerforationLenghtU, 2, 36);
            this.tlIncomingData.Controls.Add(this.lbBottomPerforationHeight, 0, 37);
            this.tlIncomingData.Controls.Add(this.tbBottomPerforationHeight, 1, 37);
            this.tlIncomingData.Controls.Add(this.cbBottomPerforationHeightU, 2, 37);
            this.tlIncomingData.Controls.Add(this.lbStall, 0, 38);
            this.tlIncomingData.Controls.Add(this.lbCurrentStall, 0, 39);
            this.tlIncomingData.Controls.Add(this.tbCurrentStall, 1, 39);
            this.tlIncomingData.Controls.Add(this.cbCurrentStallU, 2, 39);
            this.tlIncomingData.Controls.Add(this.lbFactitiousStall, 0, 40);
            this.tlIncomingData.Controls.Add(this.tbFactitiousStall, 1, 40);
            this.tlIncomingData.Controls.Add(this.cbFactitiousStallU, 2, 40);
            this.tlIncomingData.Controls.Add(this.lbDensity, 0, 41);
            this.tlIncomingData.Controls.Add(this.lbOnAssayDensity, 0, 42);
            this.tlIncomingData.Controls.Add(this.tbOnAssayDensity, 1, 42);
            this.tlIncomingData.Controls.Add(this.cbOnAssayDensityU, 2, 42);
            this.tlIncomingData.Controls.Add(this.lbUsedDensity, 0, 43);
            this.tlIncomingData.Controls.Add(this.tbUsedDensity, 1, 43);
            this.tlIncomingData.Controls.Add(this.cbUsedDensityU, 2, 43);
            this.tlIncomingData.Controls.Add(this.lbPumpData, 0, 44);
            this.tlIncomingData.Controls.Add(this.lbDoubleStep, 0, 45);
            this.tlIncomingData.Controls.Add(this.cbDoubleStep, 1, 45);
            this.tlIncomingData.Controls.Add(this.lbPistonDiam, 0, 46);
            this.tlIncomingData.Controls.Add(this.cbPistonDiam, 1, 46);
            this.tlIncomingData.Controls.Add(this.lbLevelingSpeed, 0, 47);
            this.tlIncomingData.Controls.Add(this.tbLevelingSpeed, 1, 47);
            this.tlIncomingData.Controls.Add(this.cbLevelingSpeedU, 2, 47);
            this.tlIncomingData.Controls.Add(this.lbPumpSupply, 0, 48);
            this.tlIncomingData.Controls.Add(this.tbPumpSupply, 1, 48);
            this.tlIncomingData.Controls.Add(this.cbPumpSupplyU, 2, 48);
            this.tlIncomingData.Controls.Add(this.lbPumpPressure, 0, 49);
            this.tlIncomingData.Controls.Add(this.tbPumpPressure, 1, 49);
            this.tlIncomingData.Controls.Add(this.cbPumpPressureU, 2, 49);
            this.tlIncomingData.Controls.Add(this.lbFluidParams, 0, 50);
            this.tlIncomingData.Controls.Add(this.lbAnnulusPressure, 0, 51);
            this.tlIncomingData.Controls.Add(this.tbAnnulusPressure, 1, 51);
            this.tlIncomingData.Controls.Add(this.cbAnnulusPressureU, 2, 51);
            this.tlIncomingData.Controls.Add(this.lbDenistyBL, 0, 52);
            this.tlIncomingData.Controls.Add(this.e_Density_BL, 1, 52);
            this.tlIncomingData.Controls.Add(this.cs_Density_Unit_BL, 2, 52);
            this.tlIncomingData.Controls.Add(this.lbViscosityBL, 0, 53);
            this.tlIncomingData.Controls.Add(this.e_Dyn_Viscosity_BL, 1, 53);
            this.tlIncomingData.Controls.Add(this.cs_Dyn_Viscosity_Unit_BL, 2, 53);
            this.tlIncomingData.Controls.Add(this.lbViscosityCL, 0, 54);
            this.tlIncomingData.Controls.Add(this.e_Dyn_Viscosity_CL, 1, 54);
            this.tlIncomingData.Controls.Add(this.cs_Dyn_Viscosity_Unit_CL, 2, 54);
            this.tlIncomingData.Controls.Add(this.lbWellData, 0, 55);
            this.tlIncomingData.Controls.Add(this.lbWhellType, 0, 56);
            this.tlIncomingData.Controls.Add(this.cs_Unevenness, 1, 56);
            this.tlIncomingData.Controls.Add(this.lbSafetyFactor, 0, 57);
            this.tlIncomingData.Controls.Add(this.cs_Safety_Factor, 1, 57);
            this.tlIncomingData.Controls.Add(this.lbBedParams, 0, 58);
            this.tlIncomingData.Controls.Add(this.lbBedType, 0, 59);
            this.tlIncomingData.Controls.Add(this.cs_Bed_Type, 1, 59);
            this.tlIncomingData.Controls.Add(this.lbBedThickness, 0, 60);
            this.tlIncomingData.Controls.Add(this.e_Bed_Thickness, 1, 60);
            this.tlIncomingData.Controls.Add(this.cbBedThicknessU, 2, 60);
            this.tlIncomingData.Controls.Add(this.lbGasFactor, 0, 61);
            this.tlIncomingData.Controls.Add(this.cbGasFactor, 1, 61);
            this.tlIncomingData.Controls.Add(this.lbStratumPressure, 0, 62);
            this.tlIncomingData.Controls.Add(this.e_Bed_Pressure, 1, 62);
            this.tlIncomingData.Controls.Add(this.cbStratumPressureU, 2, 62);
            this.tlIncomingData.Controls.Add(this.lbServiceCompany, 0, 3);
            this.tlIncomingData.Controls.Add(this.lbBrigade, 0, 4);
            this.tlIncomingData.Controls.Add(this.lbMaster, 0, 5);
            this.tlIncomingData.Controls.Add(this.tbServiceCompany, 1, 3);
            this.tlIncomingData.Controls.Add(this.tbBrigade, 1, 4);
            this.tlIncomingData.Controls.Add(this.tbMaster, 1, 5);
            this.tlIncomingData.Controls.Add(this.lbCirculationHolePresent, 0, 26);
            this.tlIncomingData.Controls.Add(this.cbCirculationHolePresent, 1, 26);
            this.tlIncomingData.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlIncomingData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlIncomingData.Location = new System.Drawing.Point(3, 3);
            this.tlIncomingData.Name = "tlIncomingData";
            this.tlIncomingData.RowCount = 65;
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlIncomingData.Size = new System.Drawing.Size(414, 534);
            this.tlIncomingData.TabIndex = 4;
            // 
            // lbColumnType
            // 
            this.lbColumnType.AutoSize = true;
            this.lbColumnType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbColumnType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbColumnType.Location = new System.Drawing.Point(3, 199);
            this.lbColumnType.Name = "lbColumnType";
            this.lbColumnType.Size = new System.Drawing.Size(196, 30);
            this.lbColumnType.TabIndex = 6;
            this.lbColumnType.Text = "Тип";
            this.lbColumnType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbColumnLenght
            // 
            this.lbColumnLenght.AutoSize = true;
            this.lbColumnLenght.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbColumnLenght.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbColumnLenght.Location = new System.Drawing.Point(3, 229);
            this.lbColumnLenght.Name = "lbColumnLenght";
            this.lbColumnLenght.Size = new System.Drawing.Size(196, 32);
            this.lbColumnLenght.TabIndex = 7;
            this.lbColumnLenght.Text = "Длинна по трубе";
            this.lbColumnLenght.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbColumnLenght
            // 
            this.tbColumnLenght.ContextMenuStrip = this.cmsPipe;
            this.tbColumnLenght.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbColumnLenght.Location = new System.Drawing.Point(205, 232);
            this.tbColumnLenght.Name = "tbColumnLenght";
            this.tbColumnLenght.Size = new System.Drawing.Size(106, 26);
            this.tbColumnLenght.TabIndex = 4;
            this.tbColumnLenght.Leave += new System.EventHandler(this.tbColumnLenght_Leave);
            // 
            // cbColumnLenghtU
            // 
            this.cbColumnLenghtU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbColumnLenghtU.FormattingEnabled = true;
            this.cbColumnLenghtU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbColumnLenghtU.Location = new System.Drawing.Point(317, 232);
            this.cbColumnLenghtU.Name = "cbColumnLenghtU";
            this.cbColumnLenghtU.Size = new System.Drawing.Size(54, 26);
            this.cbColumnLenghtU.TabIndex = 38;
            // 
            // lbColumnHeight
            // 
            this.lbColumnHeight.AutoSize = true;
            this.lbColumnHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbColumnHeight.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbColumnHeight.Location = new System.Drawing.Point(3, 261);
            this.lbColumnHeight.Name = "lbColumnHeight";
            this.lbColumnHeight.Size = new System.Drawing.Size(196, 32);
            this.lbColumnHeight.TabIndex = 12;
            this.lbColumnHeight.Text = "Вертикальная глубина";
            this.lbColumnHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbColumnHeight
            // 
            this.tbColumnHeight.ContextMenuStrip = this.cmsPipe;
            this.tbColumnHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbColumnHeight.Location = new System.Drawing.Point(205, 264);
            this.tbColumnHeight.Name = "tbColumnHeight";
            this.tbColumnHeight.Size = new System.Drawing.Size(106, 26);
            this.tbColumnHeight.TabIndex = 5;
            this.tbColumnHeight.Leave += new System.EventHandler(this.tbColumnHeight_Leave);
            // 
            // cbColumnHeightU
            // 
            this.cbColumnHeightU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbColumnHeightU.FormattingEnabled = true;
            this.cbColumnHeightU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbColumnHeightU.Location = new System.Drawing.Point(317, 264);
            this.cbColumnHeightU.Name = "cbColumnHeightU";
            this.cbColumnHeightU.Size = new System.Drawing.Size(54, 26);
            this.cbColumnHeightU.TabIndex = 39;
            // 
            // lbAdaptorLenght
            // 
            this.lbAdaptorLenght.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAdaptorLenght.Location = new System.Drawing.Point(3, 293);
            this.lbAdaptorLenght.Name = "lbAdaptorLenght";
            this.lbAdaptorLenght.Size = new System.Drawing.Size(196, 40);
            this.lbAdaptorLenght.TabIndex = 0;
            this.lbAdaptorLenght.Text = "Глубина адаптора";
            this.lbAdaptorLenght.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAdaptorLenght
            // 
            this.tbAdaptorLenght.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbAdaptorLenght.Location = new System.Drawing.Point(205, 296);
            this.tbAdaptorLenght.Name = "tbAdaptorLenght";
            this.tbAdaptorLenght.Size = new System.Drawing.Size(106, 26);
            this.tbAdaptorLenght.TabIndex = 0;
            this.tbAdaptorLenght.Leave += new System.EventHandler(this.tbAdaptorLenght_Leave);
            // 
            // cbAdaptorLenght
            // 
            this.cbAdaptorLenght.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAdaptorLenght.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbAdaptorLenght.Location = new System.Drawing.Point(317, 296);
            this.cbAdaptorLenght.Name = "cbAdaptorLenght";
            this.cbAdaptorLenght.Size = new System.Drawing.Size(54, 26);
            this.cbAdaptorLenght.TabIndex = 0;
            // 
            // lbColumnTail
            // 
            this.lbColumnTail.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbColumnTail, 3);
            this.lbColumnTail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbColumnTail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbColumnTail.Location = new System.Drawing.Point(3, 333);
            this.lbColumnTail.Name = "lbColumnTail";
            this.lbColumnTail.Size = new System.Drawing.Size(368, 19);
            this.lbColumnTail.TabIndex = 13;
            this.lbColumnTail.Text = "\"Хвостовик эксплуатационной коонны\":";
            this.lbColumnTail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbColumnTailType
            // 
            this.lbColumnTailType.AutoSize = true;
            this.lbColumnTailType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbColumnTailType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbColumnTailType.Location = new System.Drawing.Point(3, 352);
            this.lbColumnTailType.Name = "lbColumnTailType";
            this.lbColumnTailType.Size = new System.Drawing.Size(196, 30);
            this.lbColumnTailType.TabIndex = 15;
            this.lbColumnTailType.Text = "Тип";
            this.lbColumnTailType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbColumnTail
            // 
            this.tlIncomingData.SetColumnSpan(this.cbColumnTail, 2);
            this.cbColumnTail.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbColumnTail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbColumnTail.FormattingEnabled = true;
            this.cbColumnTail.ItemHeight = 16;
            this.cbColumnTail.Items.AddRange(new object[] {
            "D=140 мм, S=7.8 мм",
            "D=146 мм, S=6.5 мм",
            "D=146 мм, S=7.0 мм",
            "D=146 мм, S=7.7 мм",
            "D=146 мм, S=8.5 мм",
            "D=146 мм, S=9.5 мм",
            "D=146 мм, S=10.7 мм",
            "D=168 мм, S=7.3 мм",
            "D=168 мм, S=8.0 мм",
            "D=168 мм, S=8.9 мм",
            "D=168 мм, S=10.6 мм",
            "D=178 мм, S=8.2 мм",
            "D=178 мм, S=9.3 мм",
            "D=178 мм, S=10.04 мм",
            "D=178 мм, S=10.5 мм",
            "D=219 мм, S=8.8 мм",
            "D=219 мм, S=10.2 мм",
            "D=245 мм, S=11.1 мм"});
            this.cbColumnTail.Location = new System.Drawing.Point(205, 355);
            this.cbColumnTail.Name = "cbColumnTail";
            this.cbColumnTail.Size = new System.Drawing.Size(166, 24);
            this.cbColumnTail.TabIndex = 6;
            this.cbColumnTail.Text = "D=140 мм, S=7.8 мм";
            // 
            // lbColumnTailLenght
            // 
            this.lbColumnTailLenght.AutoSize = true;
            this.lbColumnTailLenght.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbColumnTailLenght.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbColumnTailLenght.Location = new System.Drawing.Point(3, 382);
            this.lbColumnTailLenght.Name = "lbColumnTailLenght";
            this.lbColumnTailLenght.Size = new System.Drawing.Size(196, 32);
            this.lbColumnTailLenght.TabIndex = 16;
            this.lbColumnTailLenght.Text = "Длинна по трубе";
            this.lbColumnTailLenght.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbColumnTailLenght
            // 
            this.tbColumnTailLenght.ContextMenuStrip = this.cmsPipe;
            this.tbColumnTailLenght.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbColumnTailLenght.Location = new System.Drawing.Point(205, 385);
            this.tbColumnTailLenght.Name = "tbColumnTailLenght";
            this.tbColumnTailLenght.Size = new System.Drawing.Size(106, 26);
            this.tbColumnTailLenght.TabIndex = 7;
            this.tbColumnTailLenght.Leave += new System.EventHandler(this.tbColumnTailLenght_Leave);
            // 
            // cbColumnTailLenghtU
            // 
            this.cbColumnTailLenghtU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbColumnTailLenghtU.FormattingEnabled = true;
            this.cbColumnTailLenghtU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbColumnTailLenghtU.Location = new System.Drawing.Point(317, 385);
            this.cbColumnTailLenghtU.Name = "cbColumnTailLenghtU";
            this.cbColumnTailLenghtU.Size = new System.Drawing.Size(54, 26);
            this.cbColumnTailLenghtU.TabIndex = 40;
            // 
            // lbColumnTailHeight
            // 
            this.lbColumnTailHeight.AutoSize = true;
            this.lbColumnTailHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbColumnTailHeight.Location = new System.Drawing.Point(3, 414);
            this.lbColumnTailHeight.Name = "lbColumnTailHeight";
            this.lbColumnTailHeight.Size = new System.Drawing.Size(196, 32);
            this.lbColumnTailHeight.TabIndex = 19;
            this.lbColumnTailHeight.Text = "Вертикальная глубина";
            this.lbColumnTailHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbColumnTailHeight
            // 
            this.tbColumnTailHeight.ContextMenuStrip = this.cmsPipe;
            this.tbColumnTailHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbColumnTailHeight.Location = new System.Drawing.Point(205, 417);
            this.tbColumnTailHeight.Name = "tbColumnTailHeight";
            this.tbColumnTailHeight.Size = new System.Drawing.Size(106, 26);
            this.tbColumnTailHeight.TabIndex = 8;
            this.tbColumnTailHeight.Leave += new System.EventHandler(this.tbColumnTailHeight_Leave);
            // 
            // cbColumnTailHeightU
            // 
            this.cbColumnTailHeightU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbColumnTailHeightU.FormattingEnabled = true;
            this.cbColumnTailHeightU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbColumnTailHeightU.Location = new System.Drawing.Point(317, 417);
            this.cbColumnTailHeightU.Name = "cbColumnTailHeightU";
            this.cbColumnTailHeightU.Size = new System.Drawing.Size(54, 26);
            this.cbColumnTailHeightU.TabIndex = 41;
            // 
            // lbEuipmentType
            // 
            this.lbEuipmentType.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbEuipmentType, 3);
            this.lbEuipmentType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEuipmentType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEuipmentType.Location = new System.Drawing.Point(3, 446);
            this.lbEuipmentType.Name = "lbEuipmentType";
            this.lbEuipmentType.Size = new System.Drawing.Size(368, 19);
            this.lbEuipmentType.TabIndex = 22;
            this.lbEuipmentType.Text = "Тип оборудования:";
            this.lbEuipmentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEquipmentType
            // 
            this.lbEquipmentType.AutoSize = true;
            this.lbEquipmentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEquipmentType.Location = new System.Drawing.Point(3, 465);
            this.lbEquipmentType.Name = "lbEquipmentType";
            this.lbEquipmentType.Size = new System.Drawing.Size(196, 32);
            this.lbEquipmentType.TabIndex = 23;
            this.lbEquipmentType.Text = "Спущенное оборудование";
            this.lbEquipmentType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbEquipmentType
            // 
            this.tlIncomingData.SetColumnSpan(this.cbEquipmentType, 2);
            this.cbEquipmentType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbEquipmentType.FormattingEnabled = true;
            this.cbEquipmentType.Items.AddRange(new object[] {
            "ЭЦН",
            "Воронка",
            "Пакер",
            "Пакер распакирован"});
            this.cbEquipmentType.Location = new System.Drawing.Point(205, 468);
            this.cbEquipmentType.Name = "cbEquipmentType";
            this.cbEquipmentType.Size = new System.Drawing.Size(166, 26);
            this.cbEquipmentType.TabIndex = 9;
            this.cbEquipmentType.SelectedIndexChanged += new System.EventHandler(this.cbEquipmentType_SelectedIndexChanged);
            // 
            // lbLowerHanger
            // 
            this.lbLowerHanger.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbLowerHanger, 3);
            this.lbLowerHanger.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLowerHanger.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLowerHanger.Location = new System.Drawing.Point(3, 497);
            this.lbLowerHanger.Name = "lbLowerHanger";
            this.lbLowerHanger.Size = new System.Drawing.Size(368, 19);
            this.lbLowerHanger.TabIndex = 25;
            this.lbLowerHanger.Text = "Нижняя подвеска НКТ:";
            this.lbLowerHanger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLoverHangerType
            // 
            this.lbLoverHangerType.AutoSize = true;
            this.lbLoverHangerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLoverHangerType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLoverHangerType.Location = new System.Drawing.Point(3, 516);
            this.lbLoverHangerType.Name = "lbLoverHangerType";
            this.lbLoverHangerType.Size = new System.Drawing.Size(196, 30);
            this.lbLoverHangerType.TabIndex = 26;
            this.lbLoverHangerType.Text = "Тип";
            this.lbLoverHangerType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbLowerHanger
            // 
            this.tlIncomingData.SetColumnSpan(this.cbLowerHanger, 2);
            this.cbLowerHanger.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbLowerHanger.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbLowerHanger.FormattingEnabled = true;
            this.cbLowerHanger.ItemHeight = 16;
            this.cbLowerHanger.Items.AddRange(new object[] {
            "d=48 мм, s=4.0 мм",
            "d=60 мм, s=5.0 мм",
            "d=73 мм, s=5.0 мм",
            "d=73 мм, s=5.5 мм",
            "d=73 мм, s=6.0 мм",
            "d=73 мм, s=7.0 мм",
            "d=89 мм, s=6.0 мм",
            "d=89 мм, s=6.5 мм",
            "d=89 мм, s=7.34 мм",
            "d=89 мм, s=8.0 мм",
            "d=102 мм, s=6.5 мм",
            "d=114 мм, s=7.0 мм"});
            this.cbLowerHanger.Location = new System.Drawing.Point(205, 519);
            this.cbLowerHanger.Name = "cbLowerHanger";
            this.cbLowerHanger.Size = new System.Drawing.Size(166, 24);
            this.cbLowerHanger.TabIndex = 10;
            this.cbLowerHanger.Text = "d=48 мм, s=4.0 мм";
            // 
            // lbLowerHangerLenght
            // 
            this.lbLowerHangerLenght.AutoSize = true;
            this.lbLowerHangerLenght.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLowerHangerLenght.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLowerHangerLenght.Location = new System.Drawing.Point(3, 546);
            this.lbLowerHangerLenght.Name = "lbLowerHangerLenght";
            this.lbLowerHangerLenght.Size = new System.Drawing.Size(196, 32);
            this.lbLowerHangerLenght.TabIndex = 28;
            this.lbLowerHangerLenght.Text = "Длинна по трубе";
            this.lbLowerHangerLenght.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLowerHangerLenght
            // 
            this.tbLowerHangerLenght.ContextMenuStrip = this.cmsPipe;
            this.tbLowerHangerLenght.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLowerHangerLenght.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLowerHangerLenght.Location = new System.Drawing.Point(205, 549);
            this.tbLowerHangerLenght.Name = "tbLowerHangerLenght";
            this.tbLowerHangerLenght.Size = new System.Drawing.Size(106, 22);
            this.tbLowerHangerLenght.TabIndex = 11;
            this.tbLowerHangerLenght.Leave += new System.EventHandler(this.tbLowerHangerLenght_Leave);
            // 
            // cbLowerHangerLenghtU
            // 
            this.cbLowerHangerLenghtU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbLowerHangerLenghtU.FormattingEnabled = true;
            this.cbLowerHangerLenghtU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbLowerHangerLenghtU.Location = new System.Drawing.Point(317, 549);
            this.cbLowerHangerLenghtU.Name = "cbLowerHangerLenghtU";
            this.cbLowerHangerLenghtU.Size = new System.Drawing.Size(54, 26);
            this.cbLowerHangerLenghtU.TabIndex = 42;
            // 
            // lbLowerHangerHeight
            // 
            this.lbLowerHangerHeight.AutoSize = true;
            this.lbLowerHangerHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLowerHangerHeight.Location = new System.Drawing.Point(3, 578);
            this.lbLowerHangerHeight.Name = "lbLowerHangerHeight";
            this.lbLowerHangerHeight.Size = new System.Drawing.Size(196, 32);
            this.lbLowerHangerHeight.TabIndex = 30;
            this.lbLowerHangerHeight.Text = "Вертикальная глубина";
            this.lbLowerHangerHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLowerHangerHeight
            // 
            this.tbLowerHangerHeight.ContextMenuStrip = this.cmsPipe;
            this.tbLowerHangerHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLowerHangerHeight.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLowerHangerHeight.Location = new System.Drawing.Point(205, 581);
            this.tbLowerHangerHeight.Name = "tbLowerHangerHeight";
            this.tbLowerHangerHeight.Size = new System.Drawing.Size(106, 22);
            this.tbLowerHangerHeight.TabIndex = 12;
            this.tbLowerHangerHeight.Leave += new System.EventHandler(this.tbLowerHangerHeight_Leave);
            // 
            // cbLowerHangerHeightU
            // 
            this.cbLowerHangerHeightU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbLowerHangerHeightU.FormattingEnabled = true;
            this.cbLowerHangerHeightU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbLowerHangerHeightU.Location = new System.Drawing.Point(317, 581);
            this.cbLowerHangerHeightU.Name = "cbLowerHangerHeightU";
            this.cbLowerHangerHeightU.Size = new System.Drawing.Size(54, 26);
            this.cbLowerHangerHeightU.TabIndex = 43;
            // 
            // lbUpperHanger
            // 
            this.lbUpperHanger.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbUpperHanger, 3);
            this.lbUpperHanger.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbUpperHanger.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUpperHanger.Location = new System.Drawing.Point(3, 610);
            this.lbUpperHanger.Name = "lbUpperHanger";
            this.lbUpperHanger.Size = new System.Drawing.Size(368, 19);
            this.lbUpperHanger.TabIndex = 33;
            this.lbUpperHanger.Text = "Верхняя подвеска НКТ:";
            this.lbUpperHanger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUpperHangerType
            // 
            this.lbUpperHangerType.AutoSize = true;
            this.lbUpperHangerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUpperHangerType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUpperHangerType.Location = new System.Drawing.Point(3, 629);
            this.lbUpperHangerType.Name = "lbUpperHangerType";
            this.lbUpperHangerType.Size = new System.Drawing.Size(196, 30);
            this.lbUpperHangerType.TabIndex = 34;
            this.lbUpperHangerType.Text = "Тип";
            this.lbUpperHangerType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbUpperHangerLenght
            // 
            this.lbUpperHangerLenght.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUpperHangerLenght.Location = new System.Drawing.Point(3, 659);
            this.lbUpperHangerLenght.Name = "lbUpperHangerLenght";
            this.lbUpperHangerLenght.Size = new System.Drawing.Size(196, 40);
            this.lbUpperHangerLenght.TabIndex = 44;
            this.lbUpperHangerLenght.Text = "Длинна по трубе";
            this.lbUpperHangerLenght.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbUpperHangerLenght
            // 
            this.tbUpperHangerLenght.ContextMenuStrip = this.cmsPipe;
            this.tbUpperHangerLenght.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUpperHangerLenght.Location = new System.Drawing.Point(205, 662);
            this.tbUpperHangerLenght.Name = "tbUpperHangerLenght";
            this.tbUpperHangerLenght.Size = new System.Drawing.Size(106, 26);
            this.tbUpperHangerLenght.TabIndex = 45;
            this.tbUpperHangerLenght.Leave += new System.EventHandler(this.tbUpperHangerLenght_Leave);
            // 
            // cbUpperHangerLenghtU
            // 
            this.cbUpperHangerLenghtU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbUpperHangerLenghtU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbUpperHangerLenghtU.Location = new System.Drawing.Point(317, 662);
            this.cbUpperHangerLenghtU.Name = "cbUpperHangerLenghtU";
            this.cbUpperHangerLenghtU.Size = new System.Drawing.Size(54, 26);
            this.cbUpperHangerLenghtU.TabIndex = 46;
            // 
            // lbUpperHangerHeight
            // 
            this.lbUpperHangerHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUpperHangerHeight.Location = new System.Drawing.Point(3, 699);
            this.lbUpperHangerHeight.Name = "lbUpperHangerHeight";
            this.lbUpperHangerHeight.Size = new System.Drawing.Size(196, 40);
            this.lbUpperHangerHeight.TabIndex = 47;
            this.lbUpperHangerHeight.Text = "Вертикальная глубина";
            this.lbUpperHangerHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbUpperHangerHeight
            // 
            this.tbUpperHangerHeight.ContextMenuStrip = this.cmsPipe;
            this.tbUpperHangerHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUpperHangerHeight.Location = new System.Drawing.Point(205, 702);
            this.tbUpperHangerHeight.Name = "tbUpperHangerHeight";
            this.tbUpperHangerHeight.Size = new System.Drawing.Size(106, 26);
            this.tbUpperHangerHeight.TabIndex = 48;
            this.tbUpperHangerHeight.DoubleClick += new System.EventHandler(this.tbUpperHangerHeight_TextChanged);
            this.tbUpperHangerHeight.Leave += new System.EventHandler(this.tbUpperHangerHeight_Leave);
            // 
            // cbUpperHangerHeightU
            // 
            this.cbUpperHangerHeightU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbUpperHangerHeightU.Location = new System.Drawing.Point(317, 702);
            this.cbUpperHangerHeightU.Name = "cbUpperHangerHeightU";
            this.cbUpperHangerHeightU.Size = new System.Drawing.Size(54, 26);
            this.cbUpperHangerHeightU.TabIndex = 49;
            // 
            // lbCirculationHole
            // 
            this.lbCirculationHole.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbCirculationHole, 3);
            this.lbCirculationHole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCirculationHole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCirculationHole.Location = new System.Drawing.Point(3, 739);
            this.lbCirculationHole.Name = "lbCirculationHole";
            this.lbCirculationHole.Size = new System.Drawing.Size(368, 19);
            this.lbCirculationHole.TabIndex = 92;
            this.lbCirculationHole.Text = "Циркуляционное отверстие:";
            this.lbCirculationHole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCirculationLenght
            // 
            this.lbCirculationLenght.AutoSize = true;
            this.lbCirculationLenght.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCirculationLenght.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCirculationLenght.Location = new System.Drawing.Point(3, 786);
            this.lbCirculationLenght.Name = "lbCirculationLenght";
            this.lbCirculationLenght.Size = new System.Drawing.Size(196, 32);
            this.lbCirculationLenght.TabIndex = 36;
            this.lbCirculationLenght.Text = "Длинна по трубе";
            this.lbCirculationLenght.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCirculationLenghtU
            // 
            this.cbCirculationLenghtU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCirculationLenghtU.FormattingEnabled = true;
            this.cbCirculationLenghtU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbCirculationLenghtU.Location = new System.Drawing.Point(317, 789);
            this.cbCirculationLenghtU.Name = "cbCirculationLenghtU";
            this.cbCirculationLenghtU.Size = new System.Drawing.Size(54, 26);
            this.cbCirculationLenghtU.TabIndex = 44;
            // 
            // lbCirculationHeight
            // 
            this.lbCirculationHeight.AutoSize = true;
            this.lbCirculationHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCirculationHeight.Location = new System.Drawing.Point(3, 818);
            this.lbCirculationHeight.Name = "lbCirculationHeight";
            this.lbCirculationHeight.Size = new System.Drawing.Size(196, 32);
            this.lbCirculationHeight.TabIndex = 39;
            this.lbCirculationHeight.Text = "Вертикальная глубина";
            this.lbCirculationHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCirculationHeightU
            // 
            this.cbCirculationHeightU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCirculationHeightU.FormattingEnabled = true;
            this.cbCirculationHeightU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbCirculationHeightU.Location = new System.Drawing.Point(317, 821);
            this.cbCirculationHeightU.Name = "cbCirculationHeightU";
            this.cbCirculationHeightU.Size = new System.Drawing.Size(54, 26);
            this.cbCirculationHeightU.TabIndex = 45;
            // 
            // lbPressure
            // 
            this.lbPressure.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbPressure, 3);
            this.lbPressure.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPressure.Location = new System.Drawing.Point(3, 850);
            this.lbPressure.Name = "lbPressure";
            this.lbPressure.Size = new System.Drawing.Size(368, 19);
            this.lbPressure.TabIndex = 42;
            this.lbPressure.Text = "Давление:";
            this.lbPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOrifice
            // 
            this.lbOrifice.AutoSize = true;
            this.lbOrifice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOrifice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOrifice.Location = new System.Drawing.Point(3, 869);
            this.lbOrifice.Name = "lbOrifice";
            this.lbOrifice.Size = new System.Drawing.Size(196, 30);
            this.lbOrifice.TabIndex = 43;
            this.lbOrifice.Text = "На устье (при исп. пород)";
            this.lbOrifice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbOrifice
            // 
            this.tbOrifice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOrifice.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOrifice.Location = new System.Drawing.Point(205, 872);
            this.tbOrifice.Name = "tbOrifice";
            this.tbOrifice.Size = new System.Drawing.Size(106, 23);
            this.tbOrifice.TabIndex = 17;
            this.tbOrifice.Leave += new System.EventHandler(this.tbOrifice_Leave);
            // 
            // cbOrificeU
            // 
            this.cbOrificeU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbOrificeU.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbOrificeU.FormattingEnabled = true;
            this.cbOrificeU.Items.AddRange(new object[] {
            "атм",
            "МПа"});
            this.cbOrificeU.Location = new System.Drawing.Point(317, 872);
            this.cbOrificeU.Name = "cbOrificeU";
            this.cbOrificeU.Size = new System.Drawing.Size(54, 24);
            this.cbOrificeU.TabIndex = 47;
            // 
            // lbNktPressure
            // 
            this.lbNktPressure.AutoSize = true;
            this.lbNktPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNktPressure.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNktPressure.Location = new System.Drawing.Point(3, 899);
            this.lbNktPressure.Name = "lbNktPressure";
            this.lbNktPressure.Size = new System.Drawing.Size(196, 30);
            this.lbNktPressure.TabIndex = 78;
            this.lbNktPressure.Text = "Давление избыточное";
            this.lbNktPressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNktPressure
            // 
            this.tbNktPressure.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNktPressure.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNktPressure.Location = new System.Drawing.Point(205, 902);
            this.tbNktPressure.Name = "tbNktPressure";
            this.tbNktPressure.Size = new System.Drawing.Size(106, 23);
            this.tbNktPressure.TabIndex = 29;
            this.tbNktPressure.Leave += new System.EventHandler(this.tbNktPressure_Leave);
            // 
            // cbNktPressureU
            // 
            this.cbNktPressureU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbNktPressureU.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbNktPressureU.FormattingEnabled = true;
            this.cbNktPressureU.Items.AddRange(new object[] {
            "атм",
            "МПа"});
            this.cbNktPressureU.Location = new System.Drawing.Point(317, 902);
            this.cbNktPressureU.Name = "cbNktPressureU";
            this.cbNktPressureU.Size = new System.Drawing.Size(54, 24);
            this.cbNktPressureU.TabIndex = 38;
            this.cbNktPressureU.Text = "атм";
            // 
            // lbSaturatuonPressure
            // 
            this.lbSaturatuonPressure.AutoSize = true;
            this.lbSaturatuonPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSaturatuonPressure.Location = new System.Drawing.Point(3, 929);
            this.lbSaturatuonPressure.Name = "lbSaturatuonPressure";
            this.lbSaturatuonPressure.Size = new System.Drawing.Size(196, 30);
            this.lbSaturatuonPressure.TabIndex = 95;
            this.lbSaturatuonPressure.Text = "Давление насыщения";
            this.lbSaturatuonPressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSaturationPressure
            // 
            this.tbSaturationPressure.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSaturationPressure.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSaturationPressure.Location = new System.Drawing.Point(205, 932);
            this.tbSaturationPressure.Name = "tbSaturationPressure";
            this.tbSaturationPressure.Size = new System.Drawing.Size(106, 23);
            this.tbSaturationPressure.TabIndex = 96;
            this.tbSaturationPressure.Leave += new System.EventHandler(this.tbSaturationPressure_Leave);
            // 
            // cbSaturationPressure
            // 
            this.cbSaturationPressure.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSaturationPressure.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSaturationPressure.FormattingEnabled = true;
            this.cbSaturationPressure.Items.AddRange(new object[] {
            "атм",
            "МПа"});
            this.cbSaturationPressure.Location = new System.Drawing.Point(317, 932);
            this.cbSaturationPressure.Name = "cbSaturationPressure";
            this.cbSaturationPressure.Size = new System.Drawing.Size(54, 24);
            this.cbSaturationPressure.TabIndex = 97;
            this.cbSaturationPressure.Text = "атм";
            // 
            // lbPerforationInterval
            // 
            this.lbPerforationInterval.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbPerforationInterval, 3);
            this.lbPerforationInterval.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPerforationInterval.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPerforationInterval.Location = new System.Drawing.Point(3, 959);
            this.lbPerforationInterval.Name = "lbPerforationInterval";
            this.lbPerforationInterval.Size = new System.Drawing.Size(368, 19);
            this.lbPerforationInterval.TabIndex = 46;
            this.lbPerforationInterval.Text = "Интервал перфорации:";
            this.lbPerforationInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbUpPerforationLenghtU
            // 
            this.cbUpPerforationLenghtU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbUpPerforationLenghtU.FormattingEnabled = true;
            this.cbUpPerforationLenghtU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbUpPerforationLenghtU.Location = new System.Drawing.Point(317, 981);
            this.cbUpPerforationLenghtU.Name = "cbUpPerforationLenghtU";
            this.cbUpPerforationLenghtU.Size = new System.Drawing.Size(54, 26);
            this.cbUpPerforationLenghtU.TabIndex = 48;
            // 
            // cbUpPerforationHeightU
            // 
            this.cbUpPerforationHeightU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbUpPerforationHeightU.FormattingEnabled = true;
            this.cbUpPerforationHeightU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbUpPerforationHeightU.Location = new System.Drawing.Point(317, 1013);
            this.cbUpPerforationHeightU.Name = "cbUpPerforationHeightU";
            this.cbUpPerforationHeightU.Size = new System.Drawing.Size(54, 26);
            this.cbUpPerforationHeightU.TabIndex = 49;
            // 
            // lbBottomPerforationLenght
            // 
            this.lbBottomPerforationLenght.AutoSize = true;
            this.lbBottomPerforationLenght.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBottomPerforationLenght.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBottomPerforationLenght.Location = new System.Drawing.Point(3, 1042);
            this.lbBottomPerforationLenght.Name = "lbBottomPerforationLenght";
            this.lbBottomPerforationLenght.Size = new System.Drawing.Size(196, 32);
            this.lbBottomPerforationLenght.TabIndex = 49;
            this.lbBottomPerforationLenght.Text = "Низ по трубе";
            this.lbBottomPerforationLenght.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbBottomPerforationLenght
            // 
            this.tbBottomPerforationLenght.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBottomPerforationLenght.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBottomPerforationLenght.Location = new System.Drawing.Point(205, 1045);
            this.tbBottomPerforationLenght.Name = "tbBottomPerforationLenght";
            this.tbBottomPerforationLenght.Size = new System.Drawing.Size(106, 22);
            this.tbBottomPerforationLenght.TabIndex = 20;
            this.tbBottomPerforationLenght.Leave += new System.EventHandler(this.tbBottomPerforationLenght_Leave);
            // 
            // cbBottomPerforationLenghtU
            // 
            this.cbBottomPerforationLenghtU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbBottomPerforationLenghtU.FormattingEnabled = true;
            this.cbBottomPerforationLenghtU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbBottomPerforationLenghtU.Location = new System.Drawing.Point(317, 1045);
            this.cbBottomPerforationLenghtU.Name = "cbBottomPerforationLenghtU";
            this.cbBottomPerforationLenghtU.Size = new System.Drawing.Size(54, 26);
            this.cbBottomPerforationLenghtU.TabIndex = 50;
            // 
            // lbBottomPerforationHeight
            // 
            this.lbBottomPerforationHeight.AutoSize = true;
            this.lbBottomPerforationHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBottomPerforationHeight.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBottomPerforationHeight.Location = new System.Drawing.Point(3, 1074);
            this.lbBottomPerforationHeight.Name = "lbBottomPerforationHeight";
            this.lbBottomPerforationHeight.Size = new System.Drawing.Size(196, 32);
            this.lbBottomPerforationHeight.TabIndex = 52;
            this.lbBottomPerforationHeight.Text = "Низ по вертикали";
            this.lbBottomPerforationHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbBottomPerforationHeight
            // 
            this.tbBottomPerforationHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBottomPerforationHeight.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBottomPerforationHeight.Location = new System.Drawing.Point(205, 1077);
            this.tbBottomPerforationHeight.Name = "tbBottomPerforationHeight";
            this.tbBottomPerforationHeight.Size = new System.Drawing.Size(106, 22);
            this.tbBottomPerforationHeight.TabIndex = 21;
            this.tbBottomPerforationHeight.Leave += new System.EventHandler(this.tbBottomPerforationHeight_Leave);
            // 
            // cbBottomPerforationHeightU
            // 
            this.cbBottomPerforationHeightU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbBottomPerforationHeightU.FormattingEnabled = true;
            this.cbBottomPerforationHeightU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbBottomPerforationHeightU.Location = new System.Drawing.Point(317, 1077);
            this.cbBottomPerforationHeightU.Name = "cbBottomPerforationHeightU";
            this.cbBottomPerforationHeightU.Size = new System.Drawing.Size(54, 26);
            this.cbBottomPerforationHeightU.TabIndex = 51;
            // 
            // lbStall
            // 
            this.lbStall.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbStall, 3);
            this.lbStall.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStall.Location = new System.Drawing.Point(3, 1106);
            this.lbStall.Name = "lbStall";
            this.lbStall.Size = new System.Drawing.Size(368, 19);
            this.lbStall.TabIndex = 55;
            this.lbStall.Text = "Забой:";
            this.lbStall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCurrentStallU
            // 
            this.cbCurrentStallU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCurrentStallU.FormattingEnabled = true;
            this.cbCurrentStallU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbCurrentStallU.Location = new System.Drawing.Point(317, 1128);
            this.cbCurrentStallU.Name = "cbCurrentStallU";
            this.cbCurrentStallU.Size = new System.Drawing.Size(54, 26);
            this.cbCurrentStallU.TabIndex = 52;
            // 
            // lbFactitiousStall
            // 
            this.lbFactitiousStall.AutoSize = true;
            this.lbFactitiousStall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFactitiousStall.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFactitiousStall.Location = new System.Drawing.Point(3, 1157);
            this.lbFactitiousStall.Name = "lbFactitiousStall";
            this.lbFactitiousStall.Size = new System.Drawing.Size(196, 32);
            this.lbFactitiousStall.TabIndex = 57;
            this.lbFactitiousStall.Text = "Искусственный";
            this.lbFactitiousStall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFactitiousStall
            // 
            this.tbFactitiousStall.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFactitiousStall.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFactitiousStall.Location = new System.Drawing.Point(205, 1160);
            this.tbFactitiousStall.Name = "tbFactitiousStall";
            this.tbFactitiousStall.Size = new System.Drawing.Size(106, 23);
            this.tbFactitiousStall.TabIndex = 23;
            this.tbFactitiousStall.Leave += new System.EventHandler(this.tbFactitiousStall_Leave);
            // 
            // cbFactitiousStallU
            // 
            this.cbFactitiousStallU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbFactitiousStallU.FormattingEnabled = true;
            this.cbFactitiousStallU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbFactitiousStallU.Location = new System.Drawing.Point(317, 1160);
            this.cbFactitiousStallU.Name = "cbFactitiousStallU";
            this.cbFactitiousStallU.Size = new System.Drawing.Size(54, 26);
            this.cbFactitiousStallU.TabIndex = 53;
            // 
            // lbDensity
            // 
            this.lbDensity.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbDensity, 3);
            this.lbDensity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDensity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDensity.Location = new System.Drawing.Point(3, 1189);
            this.lbDensity.Name = "lbDensity";
            this.lbDensity.Size = new System.Drawing.Size(368, 19);
            this.lbDensity.TabIndex = 60;
            this.lbDensity.Text = "Плотности:";
            this.lbDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOnAssayDensity
            // 
            this.lbOnAssayDensity.AutoSize = true;
            this.lbOnAssayDensity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOnAssayDensity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOnAssayDensity.Location = new System.Drawing.Point(3, 1208);
            this.lbOnAssayDensity.Name = "lbOnAssayDensity";
            this.lbOnAssayDensity.Size = new System.Drawing.Size(196, 30);
            this.lbOnAssayDensity.TabIndex = 61;
            this.lbOnAssayDensity.Text = "Пластовый флюид";
            this.lbOnAssayDensity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbOnAssayDensity
            // 
            this.tbOnAssayDensity.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOnAssayDensity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOnAssayDensity.Location = new System.Drawing.Point(205, 1211);
            this.tbOnAssayDensity.Name = "tbOnAssayDensity";
            this.tbOnAssayDensity.Size = new System.Drawing.Size(106, 23);
            this.tbOnAssayDensity.TabIndex = 24;
            this.tbOnAssayDensity.Leave += new System.EventHandler(this.tbOnAssayDensity_Leave);
            // 
            // cbOnAssayDensityU
            // 
            this.cbOnAssayDensityU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbOnAssayDensityU.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbOnAssayDensityU.FormattingEnabled = true;
            this.cbOnAssayDensityU.Items.AddRange(new object[] {
            "г/см3",
            "кг/м3"});
            this.cbOnAssayDensityU.Location = new System.Drawing.Point(317, 1211);
            this.cbOnAssayDensityU.Name = "cbOnAssayDensityU";
            this.cbOnAssayDensityU.Size = new System.Drawing.Size(54, 24);
            this.cbOnAssayDensityU.TabIndex = 54;
            this.cbOnAssayDensityU.Text = "г/см3";
            // 
            // lbUsedDensity
            // 
            this.lbUsedDensity.AutoSize = true;
            this.lbUsedDensity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUsedDensity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUsedDensity.Location = new System.Drawing.Point(3, 1238);
            this.lbUsedDensity.Name = "lbUsedDensity";
            this.lbUsedDensity.Size = new System.Drawing.Size(196, 30);
            this.lbUsedDensity.TabIndex = 64;
            this.lbUsedDensity.Text = "Скважинная жидкость";
            this.lbUsedDensity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbUsedDensity
            // 
            this.tbUsedDensity.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUsedDensity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUsedDensity.Location = new System.Drawing.Point(205, 1241);
            this.tbUsedDensity.Name = "tbUsedDensity";
            this.tbUsedDensity.Size = new System.Drawing.Size(106, 23);
            this.tbUsedDensity.TabIndex = 25;
            this.tbUsedDensity.Leave += new System.EventHandler(this.tbUsedDensity_Leave);
            // 
            // cbUsedDensityU
            // 
            this.cbUsedDensityU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbUsedDensityU.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUsedDensityU.FormattingEnabled = true;
            this.cbUsedDensityU.Items.AddRange(new object[] {
            "г/см3",
            "кг/м3"});
            this.cbUsedDensityU.Location = new System.Drawing.Point(317, 1241);
            this.cbUsedDensityU.Name = "cbUsedDensityU";
            this.cbUsedDensityU.Size = new System.Drawing.Size(54, 24);
            this.cbUsedDensityU.TabIndex = 55;
            this.cbUsedDensityU.Text = "г/см3";
            // 
            // lbPumpData
            // 
            this.lbPumpData.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbPumpData, 3);
            this.lbPumpData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPumpData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPumpData.Location = new System.Drawing.Point(3, 1268);
            this.lbPumpData.Name = "lbPumpData";
            this.lbPumpData.Size = new System.Drawing.Size(368, 19);
            this.lbPumpData.TabIndex = 67;
            this.lbPumpData.Text = "Данные насоса:";
            this.lbPumpData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDoubleStep
            // 
            this.lbDoubleStep.AutoSize = true;
            this.lbDoubleStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDoubleStep.Location = new System.Drawing.Point(3, 1287);
            this.lbDoubleStep.Name = "lbDoubleStep";
            this.lbDoubleStep.Size = new System.Drawing.Size(196, 32);
            this.lbDoubleStep.TabIndex = 98;
            this.lbDoubleStep.Text = "Двойных ходов в мин.";
            this.lbDoubleStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbDoubleStep
            // 
            this.tlIncomingData.SetColumnSpan(this.cbDoubleStep, 2);
            this.cbDoubleStep.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDoubleStep.FormattingEnabled = true;
            this.cbDoubleStep.Location = new System.Drawing.Point(205, 1290);
            this.cbDoubleStep.Name = "cbDoubleStep";
            this.cbDoubleStep.Size = new System.Drawing.Size(166, 26);
            this.cbDoubleStep.TabIndex = 99;
            this.cbDoubleStep.SelectedIndexChanged += new System.EventHandler(this.cbDoubleStep_SelectedIndexChanged);
            // 
            // lbPistonDiam
            // 
            this.lbPistonDiam.AutoSize = true;
            this.lbPistonDiam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPistonDiam.Location = new System.Drawing.Point(3, 1319);
            this.lbPistonDiam.Name = "lbPistonDiam";
            this.lbPistonDiam.Size = new System.Drawing.Size(196, 32);
            this.lbPistonDiam.TabIndex = 101;
            this.lbPistonDiam.Text = "Диаметр поршня";
            this.lbPistonDiam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbPistonDiam
            // 
            this.tlIncomingData.SetColumnSpan(this.cbPistonDiam, 2);
            this.cbPistonDiam.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPistonDiam.FormattingEnabled = true;
            this.cbPistonDiam.Items.AddRange(new object[] {
            "100",
            "115",
            "127"});
            this.cbPistonDiam.Location = new System.Drawing.Point(205, 1322);
            this.cbPistonDiam.Name = "cbPistonDiam";
            this.cbPistonDiam.Size = new System.Drawing.Size(166, 26);
            this.cbPistonDiam.TabIndex = 100;
            // 
            // lbLevelingSpeed
            // 
            this.lbLevelingSpeed.AutoSize = true;
            this.lbLevelingSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLevelingSpeed.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLevelingSpeed.Location = new System.Drawing.Point(3, 1351);
            this.lbLevelingSpeed.Name = "lbLevelingSpeed";
            this.lbLevelingSpeed.Size = new System.Drawing.Size(196, 30);
            this.lbLevelingSpeed.TabIndex = 68;
            this.lbLevelingSpeed.Text = "Скорость прокачки";
            this.lbLevelingSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLevelingSpeed
            // 
            this.tbLevelingSpeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLevelingSpeed.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLevelingSpeed.Location = new System.Drawing.Point(205, 1354);
            this.tbLevelingSpeed.Name = "tbLevelingSpeed";
            this.tbLevelingSpeed.Size = new System.Drawing.Size(106, 23);
            this.tbLevelingSpeed.TabIndex = 26;
            // 
            // cbLevelingSpeedU
            // 
            this.cbLevelingSpeedU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbLevelingSpeedU.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbLevelingSpeedU.FormattingEnabled = true;
            this.cbLevelingSpeedU.Items.AddRange(new object[] {
            "ход/мин",
            "ход/с",
            "ход/час"});
            this.cbLevelingSpeedU.Location = new System.Drawing.Point(317, 1354);
            this.cbLevelingSpeedU.Name = "cbLevelingSpeedU";
            this.cbLevelingSpeedU.Size = new System.Drawing.Size(54, 24);
            this.cbLevelingSpeedU.TabIndex = 35;
            this.cbLevelingSpeedU.Text = "ход/мин";
            // 
            // lbPumpSupply
            // 
            this.lbPumpSupply.AutoSize = true;
            this.lbPumpSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPumpSupply.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPumpSupply.Location = new System.Drawing.Point(3, 1381);
            this.lbPumpSupply.Name = "lbPumpSupply";
            this.lbPumpSupply.Size = new System.Drawing.Size(196, 30);
            this.lbPumpSupply.TabIndex = 71;
            this.lbPumpSupply.Text = "Подача насоса";
            this.lbPumpSupply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPumpSupply
            // 
            this.tbPumpSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPumpSupply.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPumpSupply.Location = new System.Drawing.Point(205, 1384);
            this.tbPumpSupply.Name = "tbPumpSupply";
            this.tbPumpSupply.Size = new System.Drawing.Size(106, 23);
            this.tbPumpSupply.TabIndex = 27;
            // 
            // cbPumpSupplyU
            // 
            this.cbPumpSupplyU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPumpSupplyU.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPumpSupplyU.FormattingEnabled = true;
            this.cbPumpSupplyU.Items.AddRange(new object[] {
            "л/ход",
            "м3/ход"});
            this.cbPumpSupplyU.Location = new System.Drawing.Point(317, 1384);
            this.cbPumpSupplyU.Name = "cbPumpSupplyU";
            this.cbPumpSupplyU.Size = new System.Drawing.Size(54, 24);
            this.cbPumpSupplyU.TabIndex = 36;
            this.cbPumpSupplyU.Text = "л/ход";
            // 
            // lbPumpPressure
            // 
            this.lbPumpPressure.AutoSize = true;
            this.lbPumpPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPumpPressure.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPumpPressure.Location = new System.Drawing.Point(3, 1411);
            this.lbPumpPressure.Name = "lbPumpPressure";
            this.lbPumpPressure.Size = new System.Drawing.Size(196, 30);
            this.lbPumpPressure.TabIndex = 74;
            this.lbPumpPressure.Text = "Давление";
            this.lbPumpPressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPumpPressure
            // 
            this.tbPumpPressure.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPumpPressure.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPumpPressure.Location = new System.Drawing.Point(205, 1414);
            this.tbPumpPressure.Name = "tbPumpPressure";
            this.tbPumpPressure.Size = new System.Drawing.Size(106, 23);
            this.tbPumpPressure.TabIndex = 28;
            this.tbPumpPressure.Leave += new System.EventHandler(this.tbPumpPressure_Leave);
            // 
            // cbPumpPressureU
            // 
            this.cbPumpPressureU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPumpPressureU.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPumpPressureU.FormattingEnabled = true;
            this.cbPumpPressureU.Items.AddRange(new object[] {
            "атм",
            "МПа"});
            this.cbPumpPressureU.Location = new System.Drawing.Point(317, 1414);
            this.cbPumpPressureU.Name = "cbPumpPressureU";
            this.cbPumpPressureU.Size = new System.Drawing.Size(54, 24);
            this.cbPumpPressureU.TabIndex = 37;
            this.cbPumpPressureU.Text = "атм";
            // 
            // lbFluidParams
            // 
            this.lbFluidParams.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbFluidParams, 3);
            this.lbFluidParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFluidParams.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFluidParams.Location = new System.Drawing.Point(3, 1441);
            this.lbFluidParams.Name = "lbFluidParams";
            this.lbFluidParams.Size = new System.Drawing.Size(368, 19);
            this.lbFluidParams.TabIndex = 84;
            this.lbFluidParams.Text = "Параметры жидкостей:";
            this.lbFluidParams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAnnulusPressure
            // 
            this.lbAnnulusPressure.AutoSize = true;
            this.lbAnnulusPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAnnulusPressure.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAnnulusPressure.Location = new System.Drawing.Point(3, 1460);
            this.lbAnnulusPressure.Name = "lbAnnulusPressure";
            this.lbAnnulusPressure.Size = new System.Drawing.Size(196, 30);
            this.lbAnnulusPressure.TabIndex = 79;
            this.lbAnnulusPressure.Text = "Давление в затр. пр-ве";
            this.lbAnnulusPressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAnnulusPressure
            // 
            this.tbAnnulusPressure.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbAnnulusPressure.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAnnulusPressure.Location = new System.Drawing.Point(205, 1463);
            this.tbAnnulusPressure.Name = "tbAnnulusPressure";
            this.tbAnnulusPressure.Size = new System.Drawing.Size(106, 23);
            this.tbAnnulusPressure.TabIndex = 30;
            this.tbAnnulusPressure.Leave += new System.EventHandler(this.tbAnnulusPressure_Leave);
            // 
            // cbAnnulusPressureU
            // 
            this.cbAnnulusPressureU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAnnulusPressureU.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAnnulusPressureU.FormattingEnabled = true;
            this.cbAnnulusPressureU.Items.AddRange(new object[] {
            "атм",
            "МПа"});
            this.cbAnnulusPressureU.Location = new System.Drawing.Point(317, 1463);
            this.cbAnnulusPressureU.Name = "cbAnnulusPressureU";
            this.cbAnnulusPressureU.Size = new System.Drawing.Size(54, 24);
            this.cbAnnulusPressureU.TabIndex = 39;
            this.cbAnnulusPressureU.Text = "атм";
            // 
            // lbDenistyBL
            // 
            this.lbDenistyBL.AutoSize = true;
            this.lbDenistyBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDenistyBL.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDenistyBL.Location = new System.Drawing.Point(3, 1490);
            this.lbDenistyBL.Name = "lbDenistyBL";
            this.lbDenistyBL.Size = new System.Drawing.Size(196, 30);
            this.lbDenistyBL.TabIndex = 85;
            this.lbDenistyBL.Text = "Плотность ПЖ";
            this.lbDenistyBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbViscosityBL
            // 
            this.lbViscosityBL.AutoSize = true;
            this.lbViscosityBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbViscosityBL.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbViscosityBL.Location = new System.Drawing.Point(3, 1520);
            this.lbViscosityBL.Name = "lbViscosityBL";
            this.lbViscosityBL.Size = new System.Drawing.Size(196, 30);
            this.lbViscosityBL.TabIndex = 86;
            this.lbViscosityBL.Text = "Дин. вязкость ПЖ";
            this.lbViscosityBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbViscosityCL
            // 
            this.lbViscosityCL.AutoSize = true;
            this.lbViscosityCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbViscosityCL.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbViscosityCL.Location = new System.Drawing.Point(3, 1550);
            this.lbViscosityCL.Name = "lbViscosityCL";
            this.lbViscosityCL.Size = new System.Drawing.Size(196, 30);
            this.lbViscosityCL.TabIndex = 87;
            this.lbViscosityCL.Text = "Дин. вязкость ЖГ";
            this.lbViscosityCL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbWellData
            // 
            this.lbWellData.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbWellData, 3);
            this.lbWellData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWellData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWellData.Location = new System.Drawing.Point(3, 1580);
            this.lbWellData.Name = "lbWellData";
            this.lbWellData.Size = new System.Drawing.Size(368, 19);
            this.lbWellData.TabIndex = 88;
            this.lbWellData.Text = "Данные скважины:";
            this.lbWellData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWhellType
            // 
            this.lbWhellType.AutoSize = true;
            this.lbWhellType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWhellType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWhellType.Location = new System.Drawing.Point(3, 1599);
            this.lbWhellType.Name = "lbWhellType";
            this.lbWhellType.Size = new System.Drawing.Size(196, 30);
            this.lbWhellType.TabIndex = 89;
            this.lbWhellType.Text = "Тип скважины";
            this.lbWhellType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSafetyFactor
            // 
            this.lbSafetyFactor.AutoSize = true;
            this.lbSafetyFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSafetyFactor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSafetyFactor.Location = new System.Drawing.Point(3, 1629);
            this.lbSafetyFactor.Name = "lbSafetyFactor";
            this.lbSafetyFactor.Size = new System.Drawing.Size(196, 30);
            this.lbSafetyFactor.TabIndex = 90;
            this.lbSafetyFactor.Text = "Допуск";
            this.lbSafetyFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBedParams
            // 
            this.lbBedParams.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.lbBedParams, 3);
            this.lbBedParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBedParams.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBedParams.Location = new System.Drawing.Point(3, 1659);
            this.lbBedParams.Name = "lbBedParams";
            this.lbBedParams.Size = new System.Drawing.Size(368, 19);
            this.lbBedParams.TabIndex = 91;
            this.lbBedParams.Text = "Параметры пласта:";
            this.lbBedParams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBedType
            // 
            this.lbBedType.AutoSize = true;
            this.lbBedType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBedType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBedType.Location = new System.Drawing.Point(3, 1678);
            this.lbBedType.Name = "lbBedType";
            this.lbBedType.Size = new System.Drawing.Size(196, 30);
            this.lbBedType.TabIndex = 15;
            this.lbBedType.Text = "Тип пласта";
            this.lbBedType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbBedType.Click += new System.EventHandler(this.lbBedType_Click);
            // 
            // cs_Bed_Type
            // 
            this.tlIncomingData.SetColumnSpan(this.cs_Bed_Type, 2);
            this.cs_Bed_Type.Dock = System.Windows.Forms.DockStyle.Top;
            this.cs_Bed_Type.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cs_Bed_Type.FormattingEnabled = true;
            this.cs_Bed_Type.Items.AddRange(new object[] {
            "Ач",
            "БВ-8",
            "Ю1-1",
            "Правдинское АС10",
            "Правдинское АС11",
            "Петелинское АС4",
            "Вост.-Правдинск. БС\'",
            "Вост.-Правдинск. БС8",
            "Правдинское БС5",
            "Петелинское БС5",
            "Правдинское БС6",
            "Правдинское БС9"});
            this.cs_Bed_Type.Location = new System.Drawing.Point(205, 1681);
            this.cs_Bed_Type.Name = "cs_Bed_Type";
            this.cs_Bed_Type.Size = new System.Drawing.Size(166, 24);
            this.cs_Bed_Type.TabIndex = 36;
            this.cs_Bed_Type.SelectedIndexChanged += new System.EventHandler(this.cs_Bed_Type_SelectedIndexChanged);
            this.cs_Bed_Type.Leave += new System.EventHandler(this.cs_Bed_Type_Leave);
            // 
            // lbBedThickness
            // 
            this.lbBedThickness.AutoSize = true;
            this.lbBedThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBedThickness.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBedThickness.Location = new System.Drawing.Point(3, 1708);
            this.lbBedThickness.Name = "lbBedThickness";
            this.lbBedThickness.Size = new System.Drawing.Size(196, 32);
            this.lbBedThickness.TabIndex = 14;
            this.lbBedThickness.Text = "Мощность";
            this.lbBedThickness.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // e_Bed_Thickness
            // 
            this.e_Bed_Thickness.Dock = System.Windows.Forms.DockStyle.Top;
            this.e_Bed_Thickness.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_Bed_Thickness.Location = new System.Drawing.Point(205, 1711);
            this.e_Bed_Thickness.Name = "e_Bed_Thickness";
            this.e_Bed_Thickness.Size = new System.Drawing.Size(106, 22);
            this.e_Bed_Thickness.TabIndex = 37;
            this.e_Bed_Thickness.DoubleClick += new System.EventHandler(this.e_Bed_Thickness_DoubleClick);
            this.e_Bed_Thickness.Leave += new System.EventHandler(this.e_Bed_Thickness_Leave);
            // 
            // cbBedThicknessU
            // 
            this.cbBedThicknessU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbBedThicknessU.FormattingEnabled = true;
            this.cbBedThicknessU.Items.AddRange(new object[] {
            "мм",
            "см",
            "м",
            "км"});
            this.cbBedThicknessU.Location = new System.Drawing.Point(317, 1711);
            this.cbBedThicknessU.Name = "cbBedThicknessU";
            this.cbBedThicknessU.Size = new System.Drawing.Size(54, 26);
            this.cbBedThicknessU.TabIndex = 43;
            // 
            // lbGasFactor
            // 
            this.lbGasFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGasFactor.Location = new System.Drawing.Point(3, 1740);
            this.lbGasFactor.Name = "lbGasFactor";
            this.lbGasFactor.Size = new System.Drawing.Size(196, 40);
            this.lbGasFactor.TabIndex = 93;
            this.lbGasFactor.Text = "Газовый фактор";
            this.lbGasFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbGasFactor
            // 
            this.tlIncomingData.SetColumnSpan(this.cbGasFactor, 2);
            this.cbGasFactor.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbGasFactor.Items.AddRange(new object[] {
            "Низкий (менее 200 м3/м3)",
            "Высокий (более 200 м3/м3)"});
            this.cbGasFactor.Location = new System.Drawing.Point(205, 1743);
            this.cbGasFactor.Name = "cbGasFactor";
            this.cbGasFactor.Size = new System.Drawing.Size(166, 26);
            this.cbGasFactor.TabIndex = 94;
            this.cbGasFactor.Text = "Низкий (менее 200 м3/м3)";
            // 
            // lbServiceCompany
            // 
            this.lbServiceCompany.AutoSize = true;
            this.lbServiceCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbServiceCompany.Location = new System.Drawing.Point(3, 84);
            this.lbServiceCompany.Name = "lbServiceCompany";
            this.lbServiceCompany.Size = new System.Drawing.Size(196, 32);
            this.lbServiceCompany.TabIndex = 102;
            this.lbServiceCompany.Text = "Сервисная компания";
            this.lbServiceCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBrigade
            // 
            this.lbBrigade.AutoSize = true;
            this.lbBrigade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBrigade.Location = new System.Drawing.Point(3, 116);
            this.lbBrigade.Name = "lbBrigade";
            this.lbBrigade.Size = new System.Drawing.Size(196, 32);
            this.lbBrigade.TabIndex = 103;
            this.lbBrigade.Text = "Бригада";
            this.lbBrigade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMaster
            // 
            this.lbMaster.AutoSize = true;
            this.lbMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMaster.Location = new System.Drawing.Point(3, 148);
            this.lbMaster.Name = "lbMaster";
            this.lbMaster.Size = new System.Drawing.Size(196, 32);
            this.lbMaster.TabIndex = 104;
            this.lbMaster.Text = "Мастер";
            this.lbMaster.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbServiceCompany
            // 
            this.tlIncomingData.SetColumnSpan(this.tbServiceCompany, 2);
            this.tbServiceCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbServiceCompany.Location = new System.Drawing.Point(205, 87);
            this.tbServiceCompany.Name = "tbServiceCompany";
            this.tbServiceCompany.Size = new System.Drawing.Size(166, 26);
            this.tbServiceCompany.TabIndex = 105;
            // 
            // tbBrigade
            // 
            this.tlIncomingData.SetColumnSpan(this.tbBrigade, 2);
            this.tbBrigade.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBrigade.Location = new System.Drawing.Point(205, 119);
            this.tbBrigade.Name = "tbBrigade";
            this.tbBrigade.Size = new System.Drawing.Size(166, 26);
            this.tbBrigade.TabIndex = 106;
            // 
            // tbMaster
            // 
            this.tlIncomingData.SetColumnSpan(this.tbMaster, 2);
            this.tbMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMaster.Location = new System.Drawing.Point(205, 151);
            this.tbMaster.Name = "tbMaster";
            this.tbMaster.Size = new System.Drawing.Size(166, 26);
            this.tbMaster.TabIndex = 107;
            // 
            // lbCirculationHolePresent
            // 
            this.lbCirculationHolePresent.AutoSize = true;
            this.lbCirculationHolePresent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCirculationHolePresent.Location = new System.Drawing.Point(3, 758);
            this.lbCirculationHolePresent.Name = "lbCirculationHolePresent";
            this.lbCirculationHolePresent.Size = new System.Drawing.Size(196, 28);
            this.lbCirculationHolePresent.TabIndex = 108;
            this.lbCirculationHolePresent.Text = "Отверстие";
            this.lbCirculationHolePresent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCirculationHolePresent
            // 
            this.cbCirculationHolePresent.AutoSize = true;
            this.tlIncomingData.SetColumnSpan(this.cbCirculationHolePresent, 2);
            this.cbCirculationHolePresent.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCirculationHolePresent.Location = new System.Drawing.Point(205, 761);
            this.cbCirculationHolePresent.Name = "cbCirculationHolePresent";
            this.cbCirculationHolePresent.Size = new System.Drawing.Size(166, 22);
            this.cbCirculationHolePresent.TabIndex = 109;
            this.cbCirculationHolePresent.Text = "присутствует";
            this.cbCirculationHolePresent.UseVisualStyleBackColor = true;
            // 
            // tpPlan
            // 
            this.tpPlan.Controls.Add(this.tlPlan);
            this.tpPlan.Location = new System.Drawing.Point(4, 32);
            this.tpPlan.Name = "tpPlan";
            this.tpPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlan.Size = new System.Drawing.Size(1293, 540);
            this.tpPlan.TabIndex = 2;
            this.tpPlan.Text = "Результаты";
            this.tpPlan.UseVisualStyleBackColor = true;
            this.tpPlan.Enter += new System.EventHandler(this.tpPlan_Enter);
            // 
            // tlPlan
            // 
            this.tlPlan.AutoScroll = true;
            this.tlPlan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlPlan.ColumnCount = 3;
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPlan.Controls.Add(this.lbResNktInningStepU, 2, 12);
            this.tlPlan.Controls.Add(this.cbResJamDensityU, 2, 10);
            this.tlPlan.Controls.Add(this.cbResDensityPutFluidU, 2, 9);
            this.tlPlan.Controls.Add(this.lbResJamFluidFullVolU, 2, 7);
            this.tlPlan.Controls.Add(this.lbResJamFluidStockVolU, 2, 6);
            this.tlPlan.Controls.Add(this.lbResJamFluidVolU, 2, 5);
            this.tlPlan.Controls.Add(this.lbResUnderPumpVolU, 2, 4);
            this.tlPlan.Controls.Add(this.lbResOutPipeVolU, 2, 3);
            this.tlPlan.Controls.Add(this.lbResColumnTailVolU, 2, 2);
            this.tlPlan.Controls.Add(this.lbResReducing100, 0, 42);
            this.tlPlan.Controls.Add(this.lbResOutPipeVol, 0, 3);
            this.tlPlan.Controls.Add(this.lbResVolume, 0, 0);
            this.tlPlan.Controls.Add(this.lbResColumnVol, 0, 1);
            this.tlPlan.Controls.Add(this.tbResColumnVol, 1, 1);
            this.tlPlan.Controls.Add(this.lbResColumnTailVol, 0, 2);
            this.tlPlan.Controls.Add(this.tbResNKTVol, 1, 2);
            this.tlPlan.Controls.Add(this.tbResOutPipeVol, 1, 3);
            this.tlPlan.Controls.Add(this.lbResUnderPumpVol, 0, 4);
            this.tlPlan.Controls.Add(this.tbResUnderPumpVol, 1, 4);
            this.tlPlan.Controls.Add(this.lbResJamFluidVol, 0, 5);
            this.tlPlan.Controls.Add(this.tbResJamFluidVol, 1, 5);
            this.tlPlan.Controls.Add(this.lbResJamFluidStockVol, 0, 6);
            this.tlPlan.Controls.Add(this.tbResJamFluidStockVol, 1, 6);
            this.tlPlan.Controls.Add(this.lbResJamFluidFullVol, 0, 7);
            this.tlPlan.Controls.Add(this.tbResJamFluidFullVol, 1, 7);
            this.tlPlan.Controls.Add(this.lbDenisty, 0, 8);
            this.tlPlan.Controls.Add(this.lbResDensityPutFluid, 0, 9);
            this.tlPlan.Controls.Add(this.tbResDensityPutFluid, 1, 9);
            this.tlPlan.Controls.Add(this.lbResJamDensity, 0, 10);
            this.tlPlan.Controls.Add(this.tbResJamDensity, 1, 10);
            this.tlPlan.Controls.Add(this.lbNKTPumpSpeed, 0, 11);
            this.tlPlan.Controls.Add(this.lbResNktInningStep, 0, 12);
            this.tlPlan.Controls.Add(this.tbResNktInningStep, 1, 12);
            this.tlPlan.Controls.Add(this.lbResInnerTime, 0, 24);
            this.tlPlan.Controls.Add(this.tbResInnerTime, 1, 24);
            this.tlPlan.Controls.Add(this.lbROutPipePumpSpeed, 0, 33);
            this.tlPlan.Controls.Add(this.lbResOutPipeInningStep, 0, 34);
            this.tlPlan.Controls.Add(this.tbResOutPipeInningStep, 1, 34);
            this.tlPlan.Controls.Add(this.lbResOutPipeInningTime, 0, 35);
            this.tlPlan.Controls.Add(this.tbResOutPipeInningTime, 1, 35);
            this.tlPlan.Controls.Add(this.lbResClearingFluidSpeed, 0, 36);
            this.tlPlan.Controls.Add(this.lbResClearingInningStep, 0, 37);
            this.tlPlan.Controls.Add(this.tbResClearingInningStep, 1, 37);
            this.tlPlan.Controls.Add(this.lbResClearingInningTime, 0, 38);
            this.tlPlan.Controls.Add(this.tbResClearingInningTime, 1, 38);
            this.tlPlan.Controls.Add(this.lbAddedParam, 0, 39);
            this.tlPlan.Controls.Add(this.lbResNCD, 0, 40);
            this.tlPlan.Controls.Add(this.lbResKCD, 0, 41);
            this.tlPlan.Controls.Add(this.tbResNCD, 1, 40);
            this.tlPlan.Controls.Add(this.tbResKCD, 1, 41);
            this.tlPlan.Controls.Add(this.tbResReducing100, 1, 42);
            this.tlPlan.Controls.Add(this.lbResColumnVolU, 2, 1);
            this.tlPlan.Controls.Add(this.cbResInnerTimeU, 2, 24);
            this.tlPlan.Controls.Add(this.lbResOutPipeInningStepU, 2, 34);
            this.tlPlan.Controls.Add(this.cbResOutPipeInningTimeU, 2, 35);
            this.tlPlan.Controls.Add(this.lbResClearingInningStepU, 2, 37);
            this.tlPlan.Controls.Add(this.cbResClearingInningTimeU, 2, 38);
            this.tlPlan.Controls.Add(this.cbResNCDU, 2, 40);
            this.tlPlan.Controls.Add(this.cbResKCDU, 2, 41);
            this.tlPlan.Controls.Add(this.cbResReducing100U, 2, 42);
            this.tlPlan.Controls.Add(this.lbCycles, 0, 43);
            this.tlPlan.Controls.Add(this.tbCycles, 1, 43);
            this.tlPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPlan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlPlan.Location = new System.Drawing.Point(3, 3);
            this.tlPlan.Name = "tlPlan";
            this.tlPlan.RowCount = 45;
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPlan.Size = new System.Drawing.Size(1287, 534);
            this.tlPlan.TabIndex = 0;
            // 
            // lbResNktInningStepU
            // 
            this.lbResNktInningStepU.AutoSize = true;
            this.lbResNktInningStepU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResNktInningStepU.Location = new System.Drawing.Point(967, 345);
            this.lbResNktInningStepU.Name = "lbResNktInningStepU";
            this.lbResNktInningStepU.Size = new System.Drawing.Size(317, 32);
            this.lbResNktInningStepU.TabIndex = 57;
            this.lbResNktInningStepU.Text = "ход";
            this.lbResNktInningStepU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbResJamDensityU
            // 
            this.cbResJamDensityU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbResJamDensityU.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbResJamDensityU.FormattingEnabled = true;
            this.cbResJamDensityU.Items.AddRange(new object[] {
            "г/см3",
            "кг/м3"});
            this.cbResJamDensityU.Location = new System.Drawing.Point(967, 297);
            this.cbResJamDensityU.Name = "cbResJamDensityU";
            this.cbResJamDensityU.Size = new System.Drawing.Size(317, 24);
            this.cbResJamDensityU.TabIndex = 56;
            this.cbResJamDensityU.Text = "г/см3";
            this.cbResJamDensityU.SelectedIndexChanged += new System.EventHandler(this.cbResJamDensityU_SelectedIndexChanged);
            // 
            // cbResDensityPutFluidU
            // 
            this.cbResDensityPutFluidU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbResDensityPutFluidU.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbResDensityPutFluidU.FormattingEnabled = true;
            this.cbResDensityPutFluidU.Items.AddRange(new object[] {
            "г/см3",
            "кг/м3"});
            this.cbResDensityPutFluidU.Location = new System.Drawing.Point(967, 265);
            this.cbResDensityPutFluidU.Name = "cbResDensityPutFluidU";
            this.cbResDensityPutFluidU.Size = new System.Drawing.Size(317, 24);
            this.cbResDensityPutFluidU.TabIndex = 55;
            this.cbResDensityPutFluidU.Text = "г/см3";
            this.cbResDensityPutFluidU.SelectedIndexChanged += new System.EventHandler(this.cbResDensityPutFluidU_SelectedIndexChanged);
            // 
            // lbResJamFluidFullVolU
            // 
            this.lbResJamFluidFullVolU.AutoSize = true;
            this.lbResJamFluidFullVolU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResJamFluidFullVolU.Location = new System.Drawing.Point(967, 211);
            this.lbResJamFluidFullVolU.Name = "lbResJamFluidFullVolU";
            this.lbResJamFluidFullVolU.Size = new System.Drawing.Size(317, 32);
            this.lbResJamFluidFullVolU.TabIndex = 48;
            this.lbResJamFluidFullVolU.Text = "м3";
            this.lbResJamFluidFullVolU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResJamFluidStockVolU
            // 
            this.lbResJamFluidStockVolU.AutoSize = true;
            this.lbResJamFluidStockVolU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResJamFluidStockVolU.Location = new System.Drawing.Point(967, 179);
            this.lbResJamFluidStockVolU.Name = "lbResJamFluidStockVolU";
            this.lbResJamFluidStockVolU.Size = new System.Drawing.Size(317, 32);
            this.lbResJamFluidStockVolU.TabIndex = 47;
            this.lbResJamFluidStockVolU.Text = "м3";
            this.lbResJamFluidStockVolU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResJamFluidVolU
            // 
            this.lbResJamFluidVolU.AutoSize = true;
            this.lbResJamFluidVolU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResJamFluidVolU.Location = new System.Drawing.Point(967, 147);
            this.lbResJamFluidVolU.Name = "lbResJamFluidVolU";
            this.lbResJamFluidVolU.Size = new System.Drawing.Size(317, 32);
            this.lbResJamFluidVolU.TabIndex = 46;
            this.lbResJamFluidVolU.Text = "м3";
            this.lbResJamFluidVolU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResUnderPumpVolU
            // 
            this.lbResUnderPumpVolU.AutoSize = true;
            this.lbResUnderPumpVolU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResUnderPumpVolU.Location = new System.Drawing.Point(967, 115);
            this.lbResUnderPumpVolU.Name = "lbResUnderPumpVolU";
            this.lbResUnderPumpVolU.Size = new System.Drawing.Size(317, 32);
            this.lbResUnderPumpVolU.TabIndex = 45;
            this.lbResUnderPumpVolU.Text = "м3";
            this.lbResUnderPumpVolU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResOutPipeVolU
            // 
            this.lbResOutPipeVolU.AutoSize = true;
            this.lbResOutPipeVolU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResOutPipeVolU.Location = new System.Drawing.Point(967, 83);
            this.lbResOutPipeVolU.Name = "lbResOutPipeVolU";
            this.lbResOutPipeVolU.Size = new System.Drawing.Size(317, 32);
            this.lbResOutPipeVolU.TabIndex = 44;
            this.lbResOutPipeVolU.Text = "м3";
            this.lbResOutPipeVolU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResColumnTailVolU
            // 
            this.lbResColumnTailVolU.AutoSize = true;
            this.lbResColumnTailVolU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResColumnTailVolU.Location = new System.Drawing.Point(967, 51);
            this.lbResColumnTailVolU.Name = "lbResColumnTailVolU";
            this.lbResColumnTailVolU.Size = new System.Drawing.Size(317, 32);
            this.lbResColumnTailVolU.TabIndex = 43;
            this.lbResColumnTailVolU.Text = "м3";
            this.lbResColumnTailVolU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResReducing100
            // 
            this.lbResReducing100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResReducing100.Location = new System.Drawing.Point(3, 658);
            this.lbResReducing100.Name = "lbResReducing100";
            this.lbResReducing100.Size = new System.Drawing.Size(637, 32);
            this.lbResReducing100.TabIndex = 38;
            this.lbResReducing100.Text = "Понижение на 100 ходов";
            this.lbResReducing100.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbResOutPipeVol
            // 
            this.lbResOutPipeVol.AutoSize = true;
            this.lbResOutPipeVol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResOutPipeVol.Location = new System.Drawing.Point(3, 83);
            this.lbResOutPipeVol.Name = "lbResOutPipeVol";
            this.lbResOutPipeVol.Size = new System.Drawing.Size(637, 32);
            this.lbResOutPipeVol.TabIndex = 6;
            this.lbResOutPipeVol.Text = "Затруб";
            this.lbResOutPipeVol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbResVolume
            // 
            this.lbResVolume.AutoSize = true;
            this.tlPlan.SetColumnSpan(this.lbResVolume, 3);
            this.lbResVolume.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbResVolume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbResVolume.Location = new System.Drawing.Point(3, 0);
            this.lbResVolume.Name = "lbResVolume";
            this.lbResVolume.Size = new System.Drawing.Size(1281, 19);
            this.lbResVolume.TabIndex = 0;
            this.lbResVolume.Text = "Объемы:";
            this.lbResVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResColumnVol
            // 
            this.lbResColumnVol.AutoSize = true;
            this.lbResColumnVol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResColumnVol.Location = new System.Drawing.Point(3, 19);
            this.lbResColumnVol.Name = "lbResColumnVol";
            this.lbResColumnVol.Size = new System.Drawing.Size(637, 32);
            this.lbResColumnVol.TabIndex = 1;
            this.lbResColumnVol.Text = "Эксплуатационная колонна";
            this.lbResColumnVol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResColumnVol
            // 
            this.tbResColumnVol.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResColumnVol.Enabled = false;
            this.tbResColumnVol.Location = new System.Drawing.Point(646, 22);
            this.tbResColumnVol.Name = "tbResColumnVol";
            this.tbResColumnVol.Size = new System.Drawing.Size(315, 26);
            this.tbResColumnVol.TabIndex = 2;
            // 
            // lbResColumnTailVol
            // 
            this.lbResColumnTailVol.AutoSize = true;
            this.lbResColumnTailVol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResColumnTailVol.Location = new System.Drawing.Point(3, 51);
            this.lbResColumnTailVol.Name = "lbResColumnTailVol";
            this.lbResColumnTailVol.Size = new System.Drawing.Size(637, 32);
            this.lbResColumnTailVol.TabIndex = 3;
            this.lbResColumnTailVol.Text = "НКТ";
            this.lbResColumnTailVol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResNKTVol
            // 
            this.tbResNKTVol.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResNKTVol.Enabled = false;
            this.tbResNKTVol.Location = new System.Drawing.Point(646, 54);
            this.tbResNKTVol.Name = "tbResNKTVol";
            this.tbResNKTVol.Size = new System.Drawing.Size(315, 26);
            this.tbResNKTVol.TabIndex = 4;
            // 
            // tbResOutPipeVol
            // 
            this.tbResOutPipeVol.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResOutPipeVol.Enabled = false;
            this.tbResOutPipeVol.Location = new System.Drawing.Point(646, 86);
            this.tbResOutPipeVol.Name = "tbResOutPipeVol";
            this.tbResOutPipeVol.Size = new System.Drawing.Size(315, 26);
            this.tbResOutPipeVol.TabIndex = 5;
            // 
            // lbResUnderPumpVol
            // 
            this.lbResUnderPumpVol.AutoSize = true;
            this.lbResUnderPumpVol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResUnderPumpVol.Location = new System.Drawing.Point(3, 115);
            this.lbResUnderPumpVol.Name = "lbResUnderPumpVol";
            this.lbResUnderPumpVol.Size = new System.Drawing.Size(637, 32);
            this.lbResUnderPumpVol.TabIndex = 7;
            this.lbResUnderPumpVol.Text = "Под насосом";
            this.lbResUnderPumpVol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResUnderPumpVol
            // 
            this.tbResUnderPumpVol.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResUnderPumpVol.Enabled = false;
            this.tbResUnderPumpVol.Location = new System.Drawing.Point(646, 118);
            this.tbResUnderPumpVol.Name = "tbResUnderPumpVol";
            this.tbResUnderPumpVol.Size = new System.Drawing.Size(315, 26);
            this.tbResUnderPumpVol.TabIndex = 8;
            // 
            // lbResJamFluidVol
            // 
            this.lbResJamFluidVol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResJamFluidVol.Location = new System.Drawing.Point(3, 147);
            this.lbResJamFluidVol.Name = "lbResJamFluidVol";
            this.lbResJamFluidVol.Size = new System.Drawing.Size(637, 32);
            this.lbResJamFluidVol.TabIndex = 9;
            this.lbResJamFluidVol.Text = "Жидкость глушения";
            this.lbResJamFluidVol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResJamFluidVol
            // 
            this.tbResJamFluidVol.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResJamFluidVol.Enabled = false;
            this.tbResJamFluidVol.Location = new System.Drawing.Point(646, 150);
            this.tbResJamFluidVol.Name = "tbResJamFluidVol";
            this.tbResJamFluidVol.Size = new System.Drawing.Size(315, 26);
            this.tbResJamFluidVol.TabIndex = 10;
            // 
            // lbResJamFluidStockVol
            // 
            this.lbResJamFluidStockVol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResJamFluidStockVol.Location = new System.Drawing.Point(3, 179);
            this.lbResJamFluidStockVol.Name = "lbResJamFluidStockVol";
            this.lbResJamFluidStockVol.Size = new System.Drawing.Size(637, 32);
            this.lbResJamFluidStockVol.TabIndex = 11;
            this.lbResJamFluidStockVol.Text = "Запас жидкости глушения";
            this.lbResJamFluidStockVol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResJamFluidStockVol
            // 
            this.tbResJamFluidStockVol.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResJamFluidStockVol.Enabled = false;
            this.tbResJamFluidStockVol.Location = new System.Drawing.Point(646, 182);
            this.tbResJamFluidStockVol.Name = "tbResJamFluidStockVol";
            this.tbResJamFluidStockVol.Size = new System.Drawing.Size(315, 26);
            this.tbResJamFluidStockVol.TabIndex = 12;
            // 
            // lbResJamFluidFullVol
            // 
            this.lbResJamFluidFullVol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResJamFluidFullVol.Location = new System.Drawing.Point(3, 211);
            this.lbResJamFluidFullVol.Name = "lbResJamFluidFullVol";
            this.lbResJamFluidFullVol.Size = new System.Drawing.Size(637, 32);
            this.lbResJamFluidFullVol.TabIndex = 13;
            this.lbResJamFluidFullVol.Text = "Жидкость глушения с запасом";
            this.lbResJamFluidFullVol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResJamFluidFullVol
            // 
            this.tbResJamFluidFullVol.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResJamFluidFullVol.Enabled = false;
            this.tbResJamFluidFullVol.Location = new System.Drawing.Point(646, 214);
            this.tbResJamFluidFullVol.Name = "tbResJamFluidFullVol";
            this.tbResJamFluidFullVol.Size = new System.Drawing.Size(315, 26);
            this.tbResJamFluidFullVol.TabIndex = 14;
            // 
            // lbDenisty
            // 
            this.lbDenisty.AutoSize = true;
            this.tlPlan.SetColumnSpan(this.lbDenisty, 3);
            this.lbDenisty.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDenisty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDenisty.Location = new System.Drawing.Point(3, 243);
            this.lbDenisty.Name = "lbDenisty";
            this.lbDenisty.Size = new System.Drawing.Size(1281, 19);
            this.lbDenisty.TabIndex = 15;
            this.lbDenisty.Text = "Плотности:";
            this.lbDenisty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResDensityPutFluid
            // 
            this.lbResDensityPutFluid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResDensityPutFluid.Location = new System.Drawing.Point(3, 262);
            this.lbResDensityPutFluid.Name = "lbResDensityPutFluid";
            this.lbResDensityPutFluid.Size = new System.Drawing.Size(637, 32);
            this.lbResDensityPutFluid.TabIndex = 16;
            this.lbResDensityPutFluid.Text = "Жидкость долива";
            this.lbResDensityPutFluid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResDensityPutFluid
            // 
            this.tbResDensityPutFluid.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResDensityPutFluid.Enabled = false;
            this.tbResDensityPutFluid.Location = new System.Drawing.Point(646, 265);
            this.tbResDensityPutFluid.Name = "tbResDensityPutFluid";
            this.tbResDensityPutFluid.Size = new System.Drawing.Size(315, 26);
            this.tbResDensityPutFluid.TabIndex = 17;
            // 
            // lbResJamDensity
            // 
            this.lbResJamDensity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResJamDensity.Location = new System.Drawing.Point(3, 294);
            this.lbResJamDensity.Name = "lbResJamDensity";
            this.lbResJamDensity.Size = new System.Drawing.Size(637, 32);
            this.lbResJamDensity.TabIndex = 18;
            this.lbResJamDensity.Text = "Жидкость глушения";
            this.lbResJamDensity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResJamDensity
            // 
            this.tbResJamDensity.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResJamDensity.Enabled = false;
            this.tbResJamDensity.Location = new System.Drawing.Point(646, 297);
            this.tbResJamDensity.Name = "tbResJamDensity";
            this.tbResJamDensity.Size = new System.Drawing.Size(315, 26);
            this.tbResJamDensity.TabIndex = 19;
            // 
            // lbNKTPumpSpeed
            // 
            this.lbNKTPumpSpeed.AutoSize = true;
            this.tlPlan.SetColumnSpan(this.lbNKTPumpSpeed, 3);
            this.lbNKTPumpSpeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNKTPumpSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNKTPumpSpeed.Location = new System.Drawing.Point(3, 326);
            this.lbNKTPumpSpeed.Name = "lbNKTPumpSpeed";
            this.lbNKTPumpSpeed.Size = new System.Drawing.Size(1281, 19);
            this.lbNKTPumpSpeed.TabIndex = 20;
            this.lbNKTPumpSpeed.Text = "Скорость прокачки НКТ:";
            this.lbNKTPumpSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResNktInningStep
            // 
            this.lbResNktInningStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResNktInningStep.Location = new System.Drawing.Point(3, 345);
            this.lbResNktInningStep.Name = "lbResNktInningStep";
            this.lbResNktInningStep.Size = new System.Drawing.Size(637, 32);
            this.lbResNktInningStep.TabIndex = 21;
            this.lbResNktInningStep.Text = "Число ходов насоса";
            this.lbResNktInningStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResNktInningStep
            // 
            this.tbResNktInningStep.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResNktInningStep.Enabled = false;
            this.tbResNktInningStep.Location = new System.Drawing.Point(646, 348);
            this.tbResNktInningStep.Name = "tbResNktInningStep";
            this.tbResNktInningStep.Size = new System.Drawing.Size(315, 26);
            this.tbResNktInningStep.TabIndex = 22;
            // 
            // lbResInnerTime
            // 
            this.lbResInnerTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResInnerTime.Location = new System.Drawing.Point(3, 377);
            this.lbResInnerTime.Name = "lbResInnerTime";
            this.lbResInnerTime.Size = new System.Drawing.Size(637, 32);
            this.lbResInnerTime.TabIndex = 23;
            this.lbResInnerTime.Text = "Время прокачки";
            this.lbResInnerTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResInnerTime
            // 
            this.tbResInnerTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResInnerTime.Enabled = false;
            this.tbResInnerTime.Location = new System.Drawing.Point(646, 380);
            this.tbResInnerTime.Name = "tbResInnerTime";
            this.tbResInnerTime.Size = new System.Drawing.Size(315, 26);
            this.tbResInnerTime.TabIndex = 24;
            // 
            // lbROutPipePumpSpeed
            // 
            this.lbROutPipePumpSpeed.AutoSize = true;
            this.tlPlan.SetColumnSpan(this.lbROutPipePumpSpeed, 3);
            this.lbROutPipePumpSpeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbROutPipePumpSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbROutPipePumpSpeed.Location = new System.Drawing.Point(3, 409);
            this.lbROutPipePumpSpeed.Name = "lbROutPipePumpSpeed";
            this.lbROutPipePumpSpeed.Size = new System.Drawing.Size(1281, 19);
            this.lbROutPipePumpSpeed.TabIndex = 25;
            this.lbROutPipePumpSpeed.Text = "Скорость прокачки эксплуатационной колонны:";
            this.lbROutPipePumpSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResOutPipeInningStep
            // 
            this.lbResOutPipeInningStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResOutPipeInningStep.Location = new System.Drawing.Point(3, 428);
            this.lbResOutPipeInningStep.Name = "lbResOutPipeInningStep";
            this.lbResOutPipeInningStep.Size = new System.Drawing.Size(637, 32);
            this.lbResOutPipeInningStep.TabIndex = 26;
            this.lbResOutPipeInningStep.Text = "Число ходов насоса";
            this.lbResOutPipeInningStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResOutPipeInningStep
            // 
            this.tbResOutPipeInningStep.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResOutPipeInningStep.Enabled = false;
            this.tbResOutPipeInningStep.Location = new System.Drawing.Point(646, 431);
            this.tbResOutPipeInningStep.Name = "tbResOutPipeInningStep";
            this.tbResOutPipeInningStep.Size = new System.Drawing.Size(315, 26);
            this.tbResOutPipeInningStep.TabIndex = 27;
            // 
            // lbResOutPipeInningTime
            // 
            this.lbResOutPipeInningTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResOutPipeInningTime.Location = new System.Drawing.Point(3, 460);
            this.lbResOutPipeInningTime.Name = "lbResOutPipeInningTime";
            this.lbResOutPipeInningTime.Size = new System.Drawing.Size(637, 32);
            this.lbResOutPipeInningTime.TabIndex = 28;
            this.lbResOutPipeInningTime.Text = "Время прокачки, с";
            this.lbResOutPipeInningTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResOutPipeInningTime
            // 
            this.tbResOutPipeInningTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResOutPipeInningTime.Enabled = false;
            this.tbResOutPipeInningTime.Location = new System.Drawing.Point(646, 463);
            this.tbResOutPipeInningTime.Name = "tbResOutPipeInningTime";
            this.tbResOutPipeInningTime.Size = new System.Drawing.Size(315, 26);
            this.tbResOutPipeInningTime.TabIndex = 29;
            // 
            // lbResClearingFluidSpeed
            // 
            this.lbResClearingFluidSpeed.AutoSize = true;
            this.tlPlan.SetColumnSpan(this.lbResClearingFluidSpeed, 3);
            this.lbResClearingFluidSpeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbResClearingFluidSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbResClearingFluidSpeed.Location = new System.Drawing.Point(3, 492);
            this.lbResClearingFluidSpeed.Name = "lbResClearingFluidSpeed";
            this.lbResClearingFluidSpeed.Size = new System.Drawing.Size(1281, 19);
            this.lbResClearingFluidSpeed.TabIndex = 30;
            this.lbResClearingFluidSpeed.Text = "Скорость прокачки промывающей жидкости:";
            this.lbResClearingFluidSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResClearingInningStep
            // 
            this.lbResClearingInningStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResClearingInningStep.Location = new System.Drawing.Point(3, 511);
            this.lbResClearingInningStep.Name = "lbResClearingInningStep";
            this.lbResClearingInningStep.Size = new System.Drawing.Size(637, 32);
            this.lbResClearingInningStep.TabIndex = 31;
            this.lbResClearingInningStep.Text = "Число ходов насоса";
            this.lbResClearingInningStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResClearingInningStep
            // 
            this.tbResClearingInningStep.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResClearingInningStep.Enabled = false;
            this.tbResClearingInningStep.Location = new System.Drawing.Point(646, 514);
            this.tbResClearingInningStep.Name = "tbResClearingInningStep";
            this.tbResClearingInningStep.Size = new System.Drawing.Size(315, 26);
            this.tbResClearingInningStep.TabIndex = 32;
            // 
            // lbResClearingInningTime
            // 
            this.lbResClearingInningTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResClearingInningTime.Location = new System.Drawing.Point(3, 543);
            this.lbResClearingInningTime.Name = "lbResClearingInningTime";
            this.lbResClearingInningTime.Size = new System.Drawing.Size(637, 32);
            this.lbResClearingInningTime.TabIndex = 33;
            this.lbResClearingInningTime.Text = "Время прокачки, с";
            this.lbResClearingInningTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResClearingInningTime
            // 
            this.tbResClearingInningTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResClearingInningTime.Enabled = false;
            this.tbResClearingInningTime.Location = new System.Drawing.Point(646, 546);
            this.tbResClearingInningTime.Name = "tbResClearingInningTime";
            this.tbResClearingInningTime.Size = new System.Drawing.Size(315, 26);
            this.tbResClearingInningTime.TabIndex = 34;
            // 
            // lbAddedParam
            // 
            this.lbAddedParam.AutoSize = true;
            this.tlPlan.SetColumnSpan(this.lbAddedParam, 3);
            this.lbAddedParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAddedParam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddedParam.Location = new System.Drawing.Point(3, 575);
            this.lbAddedParam.Name = "lbAddedParam";
            this.lbAddedParam.Size = new System.Drawing.Size(1281, 19);
            this.lbAddedParam.TabIndex = 35;
            this.lbAddedParam.Text = "Дополнительные параметры:";
            this.lbAddedParam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResNCD
            // 
            this.lbResNCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResNCD.Location = new System.Drawing.Point(3, 594);
            this.lbResNCD.Name = "lbResNCD";
            this.lbResNCD.Size = new System.Drawing.Size(637, 32);
            this.lbResNCD.TabIndex = 36;
            this.lbResNCD.Text = "НЦД";
            this.lbResNCD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbResKCD
            // 
            this.lbResKCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResKCD.Location = new System.Drawing.Point(3, 626);
            this.lbResKCD.Name = "lbResKCD";
            this.lbResKCD.Size = new System.Drawing.Size(637, 32);
            this.lbResKCD.TabIndex = 37;
            this.lbResKCD.Text = "КЦД";
            this.lbResKCD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbResNCD
            // 
            this.tbResNCD.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResNCD.Enabled = false;
            this.tbResNCD.Location = new System.Drawing.Point(646, 597);
            this.tbResNCD.Name = "tbResNCD";
            this.tbResNCD.Size = new System.Drawing.Size(315, 26);
            this.tbResNCD.TabIndex = 39;
            // 
            // tbResKCD
            // 
            this.tbResKCD.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResKCD.Enabled = false;
            this.tbResKCD.Location = new System.Drawing.Point(646, 629);
            this.tbResKCD.Name = "tbResKCD";
            this.tbResKCD.Size = new System.Drawing.Size(315, 26);
            this.tbResKCD.TabIndex = 40;
            // 
            // tbResReducing100
            // 
            this.tbResReducing100.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbResReducing100.Enabled = false;
            this.tbResReducing100.Location = new System.Drawing.Point(646, 661);
            this.tbResReducing100.Name = "tbResReducing100";
            this.tbResReducing100.Size = new System.Drawing.Size(315, 26);
            this.tbResReducing100.TabIndex = 41;
            // 
            // lbResColumnVolU
            // 
            this.lbResColumnVolU.AutoSize = true;
            this.lbResColumnVolU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResColumnVolU.Location = new System.Drawing.Point(967, 19);
            this.lbResColumnVolU.Name = "lbResColumnVolU";
            this.lbResColumnVolU.Size = new System.Drawing.Size(317, 32);
            this.lbResColumnVolU.TabIndex = 42;
            this.lbResColumnVolU.Text = "м3";
            this.lbResColumnVolU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbResInnerTimeU
            // 
            this.cbResInnerTimeU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbResInnerTimeU.FormattingEnabled = true;
            this.cbResInnerTimeU.Items.AddRange(new object[] {
            "с",
            "мин",
            "час"});
            this.cbResInnerTimeU.Location = new System.Drawing.Point(967, 380);
            this.cbResInnerTimeU.Name = "cbResInnerTimeU";
            this.cbResInnerTimeU.Size = new System.Drawing.Size(317, 26);
            this.cbResInnerTimeU.TabIndex = 58;
            this.cbResInnerTimeU.Text = "с";
            this.cbResInnerTimeU.SelectedIndexChanged += new System.EventHandler(this.cbResInnerTimeU_SelectedIndexChanged);
            // 
            // lbResOutPipeInningStepU
            // 
            this.lbResOutPipeInningStepU.AutoSize = true;
            this.lbResOutPipeInningStepU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResOutPipeInningStepU.Location = new System.Drawing.Point(967, 428);
            this.lbResOutPipeInningStepU.Name = "lbResOutPipeInningStepU";
            this.lbResOutPipeInningStepU.Size = new System.Drawing.Size(317, 32);
            this.lbResOutPipeInningStepU.TabIndex = 59;
            this.lbResOutPipeInningStepU.Text = "ход";
            this.lbResOutPipeInningStepU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbResOutPipeInningTimeU
            // 
            this.cbResOutPipeInningTimeU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbResOutPipeInningTimeU.FormattingEnabled = true;
            this.cbResOutPipeInningTimeU.Items.AddRange(new object[] {
            "с",
            "мин",
            "час"});
            this.cbResOutPipeInningTimeU.Location = new System.Drawing.Point(967, 463);
            this.cbResOutPipeInningTimeU.Name = "cbResOutPipeInningTimeU";
            this.cbResOutPipeInningTimeU.Size = new System.Drawing.Size(317, 26);
            this.cbResOutPipeInningTimeU.TabIndex = 60;
            this.cbResOutPipeInningTimeU.Text = "c";
            this.cbResOutPipeInningTimeU.SelectedIndexChanged += new System.EventHandler(this.cbResOutPipeInningTimeU_SelectedIndexChanged);
            // 
            // lbResClearingInningStepU
            // 
            this.lbResClearingInningStepU.AutoSize = true;
            this.lbResClearingInningStepU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResClearingInningStepU.Location = new System.Drawing.Point(967, 511);
            this.lbResClearingInningStepU.Name = "lbResClearingInningStepU";
            this.lbResClearingInningStepU.Size = new System.Drawing.Size(317, 32);
            this.lbResClearingInningStepU.TabIndex = 61;
            this.lbResClearingInningStepU.Text = "ход";
            this.lbResClearingInningStepU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbResClearingInningTimeU
            // 
            this.cbResClearingInningTimeU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbResClearingInningTimeU.FormattingEnabled = true;
            this.cbResClearingInningTimeU.Items.AddRange(new object[] {
            "с",
            "мин",
            "час"});
            this.cbResClearingInningTimeU.Location = new System.Drawing.Point(967, 546);
            this.cbResClearingInningTimeU.Name = "cbResClearingInningTimeU";
            this.cbResClearingInningTimeU.Size = new System.Drawing.Size(317, 26);
            this.cbResClearingInningTimeU.TabIndex = 62;
            this.cbResClearingInningTimeU.Text = "c";
            this.cbResClearingInningTimeU.SelectedIndexChanged += new System.EventHandler(this.cbResClearingInningTimeU_SelectedIndexChanged);
            // 
            // cbResNCDU
            // 
            this.cbResNCDU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbResNCDU.FormattingEnabled = true;
            this.cbResNCDU.Items.AddRange(new object[] {
            "атм",
            "МПа"});
            this.cbResNCDU.Location = new System.Drawing.Point(967, 597);
            this.cbResNCDU.Name = "cbResNCDU";
            this.cbResNCDU.Size = new System.Drawing.Size(317, 26);
            this.cbResNCDU.TabIndex = 63;
            this.cbResNCDU.Text = "атм";
            this.cbResNCDU.SelectedIndexChanged += new System.EventHandler(this.cbResNCDU_SelectedIndexChanged);
            // 
            // cbResKCDU
            // 
            this.cbResKCDU.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbResKCDU.FormattingEnabled = true;
            this.cbResKCDU.Items.AddRange(new object[] {
            "атм",
            "МПа"});
            this.cbResKCDU.Location = new System.Drawing.Point(967, 629);
            this.cbResKCDU.Name = "cbResKCDU";
            this.cbResKCDU.Size = new System.Drawing.Size(317, 26);
            this.cbResKCDU.TabIndex = 64;
            this.cbResKCDU.Text = "атм";
            this.cbResKCDU.SelectedIndexChanged += new System.EventHandler(this.cbResKCDU_SelectedIndexChanged);
            // 
            // cbResReducing100U
            // 
            this.cbResReducing100U.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbResReducing100U.FormattingEnabled = true;
            this.cbResReducing100U.Items.AddRange(new object[] {
            "атм",
            "МПа"});
            this.cbResReducing100U.Location = new System.Drawing.Point(967, 661);
            this.cbResReducing100U.Name = "cbResReducing100U";
            this.cbResReducing100U.Size = new System.Drawing.Size(317, 26);
            this.cbResReducing100U.TabIndex = 65;
            this.cbResReducing100U.Text = "атм";
            this.cbResReducing100U.SelectedIndexChanged += new System.EventHandler(this.cbResReducing100U_SelectedIndexChanged);
            // 
            // lbCycles
            // 
            this.lbCycles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCycles.Location = new System.Drawing.Point(3, 690);
            this.lbCycles.Name = "lbCycles";
            this.lbCycles.Size = new System.Drawing.Size(637, 32);
            this.lbCycles.TabIndex = 66;
            this.lbCycles.Text = "Количество циклов";
            this.lbCycles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCycles
            // 
            this.tbCycles.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCycles.Enabled = false;
            this.tbCycles.Location = new System.Drawing.Point(646, 693);
            this.tbCycles.Name = "tbCycles";
            this.tbCycles.Size = new System.Drawing.Size(315, 26);
            this.tbCycles.TabIndex = 67;
            // 
            // tpResult
            // 
            this.tpResult.Controls.Add(this.tlpChart);
            this.tpResult.Location = new System.Drawing.Point(4, 32);
            this.tpResult.Name = "tpResult";
            this.tpResult.Padding = new System.Windows.Forms.Padding(3);
            this.tpResult.Size = new System.Drawing.Size(1293, 540);
            this.tpResult.TabIndex = 1;
            this.tpResult.Text = "Графики";
            this.tpResult.UseVisualStyleBackColor = true;
            this.tpResult.Enter += new System.EventHandler(this.tpResult_Enter);
            // 
            // tlpChart
            // 
            this.tlpChart.AutoScroll = true;
            this.tlpChart.ColumnCount = 1;
            this.tlpChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChart.Location = new System.Drawing.Point(3, 3);
            this.tlpChart.Name = "tlpChart";
            this.tlpChart.RowCount = 6;
            this.tlpChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tlpChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tlpChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tlpChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tlpChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tlpChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tlpChart.Size = new System.Drawing.Size(1287, 534);
            this.tlpChart.TabIndex = 2;
            // 
            // tpSchema
            // 
            this.tpSchema.Location = new System.Drawing.Point(4, 32);
            this.tpSchema.Name = "tpSchema";
            this.tpSchema.Padding = new System.Windows.Forms.Padding(3);
            this.tpSchema.Size = new System.Drawing.Size(1293, 540);
            this.tpSchema.TabIndex = 5;
            this.tpSchema.Text = "Схема";
            this.tpSchema.UseVisualStyleBackColor = true;
            this.tpSchema.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage1_Paint);
            // 
            // tpDir
            // 
            this.tpDir.Controls.Add(this.tpTab);
            this.tpDir.Controls.Add(this.pnPlanActions);
            this.tpDir.Location = new System.Drawing.Point(4, 32);
            this.tpDir.Name = "tpDir";
            this.tpDir.Size = new System.Drawing.Size(1293, 540);
            this.tpDir.TabIndex = 4;
            this.tpDir.Text = "План работ";
            this.tpDir.UseVisualStyleBackColor = true;
            // 
            // tpTab
            // 
            this.tpTab.ColumnCount = 2;
            this.tpTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tpTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tpTab.Controls.Add(this.tvPlan, 0, 0);
            this.tpTab.Controls.Add(this.tlpAlg, 1, 0);
            this.tpTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpTab.Location = new System.Drawing.Point(0, 0);
            this.tpTab.Name = "tpTab";
            this.tpTab.RowCount = 1;
            this.tpTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpTab.Size = new System.Drawing.Size(1100, 540);
            this.tpTab.TabIndex = 2;
            // 
            // tvPlan
            // 
            this.tvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvPlan.Location = new System.Drawing.Point(3, 3);
            this.tvPlan.Name = "tvPlan";
            this.tvPlan.Size = new System.Drawing.Size(308, 534);
            this.tvPlan.TabIndex = 0;
            // 
            // tlpAlg
            // 
            this.tlpAlg.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpAlg.ColumnCount = 3;
            this.tlpAlg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAlg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAlg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAlg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAlg.Location = new System.Drawing.Point(317, 3);
            this.tlpAlg.Name = "tlpAlg";
            this.tlpAlg.RowCount = 1;
            this.tlpAlg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAlg.Size = new System.Drawing.Size(780, 534);
            this.tlpAlg.TabIndex = 1;
            // 
            // pnPlanActions
            // 
            this.pnPlanActions.Controls.Add(this.flowLayoutPanel1);
            this.pnPlanActions.Controls.Add(this.btNext);
            this.pnPlanActions.Controls.Add(this.btPrev);
            this.pnPlanActions.Controls.Add(this.tbExternalItem);
            this.pnPlanActions.Controls.Add(this.lbBeforeHand);
            this.pnPlanActions.Controls.Add(this.btSavePlan);
            this.pnPlanActions.Controls.Add(this.btDeleteNode);
            this.pnPlanActions.Controls.Add(this.btAddNode);
            this.pnPlanActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPlanActions.Location = new System.Drawing.Point(1100, 0);
            this.pnPlanActions.Name = "pnPlanActions";
            this.pnPlanActions.Size = new System.Drawing.Size(193, 540);
            this.pnPlanActions.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 102);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(26, 12);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(145, 32);
            this.btNext.TabIndex = 6;
            this.btNext.Text = "Далее";
            this.btNext.UseVisualStyleBackColor = true;
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(26, 50);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(145, 32);
            this.btPrev.TabIndex = 5;
            this.btPrev.Text = "Вернуться";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // tbExternalItem
            // 
            this.tbExternalItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExternalItem.Location = new System.Drawing.Point(7, 470);
            this.tbExternalItem.Name = "tbExternalItem";
            this.tbExternalItem.Size = new System.Drawing.Size(0, 30);
            this.tbExternalItem.TabIndex = 4;
            // 
            // lbBeforeHand
            // 
            this.lbBeforeHand.AllowDrop = true;
            this.lbBeforeHand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBeforeHand.FormattingEnabled = true;
            this.lbBeforeHand.ItemHeight = 23;
            this.lbBeforeHand.Location = new System.Drawing.Point(7, 89);
            this.lbBeforeHand.Name = "lbBeforeHand";
            this.lbBeforeHand.Size = new System.Drawing.Size(0, 4);
            this.lbBeforeHand.TabIndex = 3;
            // 
            // btSavePlan
            // 
            this.btSavePlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSavePlan.Location = new System.Drawing.Point(26, 500);
            this.btSavePlan.Name = "btSavePlan";
            this.btSavePlan.Size = new System.Drawing.Size(145, 32);
            this.btSavePlan.TabIndex = 2;
            this.btSavePlan.Text = "Сохранить";
            this.btSavePlan.UseVisualStyleBackColor = true;
            this.btSavePlan.Click += new System.EventHandler(this.btSavePlan_Click);
            // 
            // btDeleteNode
            // 
            this.btDeleteNode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteNode.Location = new System.Drawing.Point(7, 44);
            this.btDeleteNode.Name = "btDeleteNode";
            this.btDeleteNode.Size = new System.Drawing.Size(0, 0);
            this.btDeleteNode.TabIndex = 1;
            this.btDeleteNode.Text = "Удалить запись";
            this.btDeleteNode.UseVisualStyleBackColor = true;
            this.btDeleteNode.Click += new System.EventHandler(this.btDeleteNode_Click);
            // 
            // btAddNode
            // 
            this.btAddNode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddNode.Location = new System.Drawing.Point(7, 4);
            this.btAddNode.Name = "btAddNode";
            this.btAddNode.Size = new System.Drawing.Size(0, 0);
            this.btAddNode.TabIndex = 0;
            this.btAddNode.Text = "Добавить запись";
            this.btAddNode.UseVisualStyleBackColor = true;
            this.btAddNode.Click += new System.EventHandler(this.btAddNode_Click);
            // 
            // tpPlotn
            // 
            this.tpPlotn.Controls.Add(this.tableLayoutPanel1);
            this.tpPlotn.Location = new System.Drawing.Point(4, 32);
            this.tpPlotn.Name = "tpPlotn";
            this.tpPlotn.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlotn.Size = new System.Drawing.Size(1293, 540);
            this.tpPlotn.TabIndex = 3;
            this.tpPlotn.Text = "Плотность";
            this.tpPlotn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.cbRoSel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lvRo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label28, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label29, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgCoastTable, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1287, 534);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbRoSel
            // 
            this.cbRoSel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbRoSel.FormattingEnabled = true;
            this.cbRoSel.Location = new System.Drawing.Point(3, 43);
            this.cbRoSel.Name = "cbRoSel";
            this.cbRoSel.Size = new System.Drawing.Size(315, 25);
            this.cbRoSel.TabIndex = 0;
            this.cbRoSel.SelectedIndexChanged += new System.EventHandler(this.cbRoSel_SelectedIndexChanged);
            // 
            // lvRo
            // 
            this.lvRo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvRo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvRo.GridLines = true;
            this.lvRo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvRo.Location = new System.Drawing.Point(324, 43);
            this.lvRo.Name = "lvRo";
            this.lvRo.Size = new System.Drawing.Size(960, 129);
            this.lvRo.TabIndex = 1;
            this.lvRo.UseCompatibleStateImageBehavior = false;
            this.lvRo.View = System.Windows.Forms.View.List;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Top;
            this.label28.Location = new System.Drawing.Point(3, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(315, 17);
            this.label28.TabIndex = 2;
            this.label28.Text = "Требуемая плотность раствора (выбрать)";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Top;
            this.label29.Location = new System.Drawing.Point(324, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(960, 17);
            this.label29.TabIndex = 3;
            this.label29.Text = "Масса соли, необходимая для достижения указанной плотности";
            // 
            // dgCoastTable
            // 
            this.dgCoastTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCoastTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Density,
            this.Coast});
            this.dgCoastTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCoastTable.Location = new System.Drawing.Point(324, 178);
            this.dgCoastTable.Name = "dgCoastTable";
            this.dgCoastTable.Size = new System.Drawing.Size(960, 390);
            this.dgCoastTable.TabIndex = 4;
            this.dgCoastTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCoastTable_CellContentClick);
            // 
            // Density
            // 
            this.Density.HeaderText = "Плотность раствора";
            this.Density.Name = "Density";
            // 
            // Coast
            // 
            this.Coast.HeaderText = "Стоимость кубометра";
            this.Coast.Name = "Coast";
            // 
            // tpSetUp
            // 
            this.tpSetUp.Controls.Add(this.gbFimension);
            this.tpSetUp.Location = new System.Drawing.Point(4, 32);
            this.tpSetUp.Name = "tpSetUp";
            this.tpSetUp.Size = new System.Drawing.Size(1293, 540);
            this.tpSetUp.TabIndex = 6;
            this.tpSetUp.Text = "Установки";
            this.tpSetUp.UseVisualStyleBackColor = true;
            // 
            // gbFimension
            // 
            this.gbFimension.Controls.Add(this.gbViscosity);
            this.gbFimension.Controls.Add(this.gbDensity);
            this.gbFimension.Controls.Add(this.gbPressure);
            this.gbFimension.Controls.Add(this.gbDeep);
            this.gbFimension.Controls.Add(this.gbSystemName);
            this.gbFimension.Location = new System.Drawing.Point(8, 3);
            this.gbFimension.Name = "gbFimension";
            this.gbFimension.Size = new System.Drawing.Size(207, 398);
            this.gbFimension.TabIndex = 0;
            this.gbFimension.TabStop = false;
            this.gbFimension.Text = "Размерности";
            // 
            // gbViscosity
            // 
            this.gbViscosity.Controls.Add(this.rbSPz);
            this.gbViscosity.Controls.Add(this.rbMpaS);
            this.gbViscosity.Location = new System.Drawing.Point(7, 316);
            this.gbViscosity.Name = "gbViscosity";
            this.gbViscosity.Size = new System.Drawing.Size(194, 71);
            this.gbViscosity.TabIndex = 4;
            this.gbViscosity.TabStop = false;
            this.gbViscosity.Text = "Вязкости";
            // 
            // rbSPz
            // 
            this.rbSPz.AutoSize = true;
            this.rbSPz.Location = new System.Drawing.Point(7, 44);
            this.rbSPz.Name = "rbSPz";
            this.rbSPz.Size = new System.Drawing.Size(48, 27);
            this.rbSPz.TabIndex = 1;
            this.rbSPz.TabStop = true;
            this.rbSPz.Text = "Пз";
            this.rbSPz.UseVisualStyleBackColor = true;
            this.rbSPz.CheckedChanged += new System.EventHandler(this.rbSPz_CheckedChanged);
            // 
            // rbMpaS
            // 
            this.rbMpaS.AutoSize = true;
            this.rbMpaS.Location = new System.Drawing.Point(7, 20);
            this.rbMpaS.Name = "rbMpaS";
            this.rbMpaS.Size = new System.Drawing.Size(64, 27);
            this.rbMpaS.TabIndex = 0;
            this.rbMpaS.TabStop = true;
            this.rbMpaS.Text = "Па/с";
            this.rbMpaS.UseVisualStyleBackColor = true;
            this.rbMpaS.CheckedChanged += new System.EventHandler(this.rbMpaS_CheckedChanged);
            // 
            // gbDensity
            // 
            this.gbDensity.Controls.Add(this.rbGsm);
            this.gbDensity.Controls.Add(this.rbKgm);
            this.gbDensity.Location = new System.Drawing.Point(7, 242);
            this.gbDensity.Name = "gbDensity";
            this.gbDensity.Size = new System.Drawing.Size(194, 71);
            this.gbDensity.TabIndex = 3;
            this.gbDensity.TabStop = false;
            this.gbDensity.Text = "Плотности";
            // 
            // rbGsm
            // 
            this.rbGsm.AutoSize = true;
            this.rbGsm.Location = new System.Drawing.Point(8, 44);
            this.rbGsm.Name = "rbGsm";
            this.rbGsm.Size = new System.Drawing.Size(73, 27);
            this.rbGsm.TabIndex = 1;
            this.rbGsm.TabStop = true;
            this.rbGsm.Text = "г/см3";
            this.rbGsm.UseVisualStyleBackColor = true;
            this.rbGsm.CheckedChanged += new System.EventHandler(this.rbGsm_CheckedChanged);
            // 
            // rbKgm
            // 
            this.rbKgm.AutoSize = true;
            this.rbKgm.Location = new System.Drawing.Point(8, 20);
            this.rbKgm.Name = "rbKgm";
            this.rbKgm.Size = new System.Drawing.Size(74, 27);
            this.rbKgm.TabIndex = 0;
            this.rbKgm.TabStop = true;
            this.rbKgm.Text = "кг/м3";
            this.rbKgm.UseVisualStyleBackColor = true;
            this.rbKgm.CheckedChanged += new System.EventHandler(this.rbKgm_CheckedChanged);
            // 
            // gbPressure
            // 
            this.gbPressure.Controls.Add(this.rbMpa);
            this.gbPressure.Controls.Add(this.rbAtm);
            this.gbPressure.Location = new System.Drawing.Point(7, 168);
            this.gbPressure.Name = "gbPressure";
            this.gbPressure.Size = new System.Drawing.Size(194, 71);
            this.gbPressure.TabIndex = 2;
            this.gbPressure.TabStop = false;
            this.gbPressure.Text = "Давление";
            // 
            // rbMpa
            // 
            this.rbMpa.AutoSize = true;
            this.rbMpa.Location = new System.Drawing.Point(6, 44);
            this.rbMpa.Name = "rbMpa";
            this.rbMpa.Size = new System.Drawing.Size(65, 27);
            this.rbMpa.TabIndex = 1;
            this.rbMpa.TabStop = true;
            this.rbMpa.Text = "МПа";
            this.rbMpa.UseVisualStyleBackColor = true;
            this.rbMpa.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbAtm
            // 
            this.rbAtm.AutoSize = true;
            this.rbAtm.Location = new System.Drawing.Point(7, 20);
            this.rbAtm.Name = "rbAtm";
            this.rbAtm.Size = new System.Drawing.Size(58, 27);
            this.rbAtm.TabIndex = 0;
            this.rbAtm.TabStop = true;
            this.rbAtm.Text = "Атм";
            this.rbAtm.UseVisualStyleBackColor = true;
            this.rbAtm.CheckedChanged += new System.EventHandler(this.rbAtm_CheckedChanged);
            // 
            // gbDeep
            // 
            this.gbDeep.Controls.Add(this.rbKm);
            this.gbDeep.Controls.Add(this.rbMeters);
            this.gbDeep.Location = new System.Drawing.Point(7, 94);
            this.gbDeep.Name = "gbDeep";
            this.gbDeep.Size = new System.Drawing.Size(194, 71);
            this.gbDeep.TabIndex = 1;
            this.gbDeep.TabStop = false;
            this.gbDeep.Text = "Глубина";
            // 
            // rbKm
            // 
            this.rbKm.AutoSize = true;
            this.rbKm.Location = new System.Drawing.Point(6, 44);
            this.rbKm.Name = "rbKm";
            this.rbKm.Size = new System.Drawing.Size(120, 27);
            this.rbKm.TabIndex = 1;
            this.rbKm.TabStop = true;
            this.rbKm.Text = "Километры";
            this.rbKm.UseVisualStyleBackColor = true;
            this.rbKm.CheckedChanged += new System.EventHandler(this.rbKm_CheckedChanged);
            // 
            // rbMeters
            // 
            this.rbMeters.AutoSize = true;
            this.rbMeters.Location = new System.Drawing.Point(7, 20);
            this.rbMeters.Name = "rbMeters";
            this.rbMeters.Size = new System.Drawing.Size(83, 27);
            this.rbMeters.TabIndex = 0;
            this.rbMeters.TabStop = true;
            this.rbMeters.Text = "Метры";
            this.rbMeters.UseVisualStyleBackColor = true;
            this.rbMeters.CheckedChanged += new System.EventHandler(this.rbMeters_CheckedChanged);
            // 
            // gbSystemName
            // 
            this.gbSystemName.Controls.Add(this.rbSGS);
            this.gbSystemName.Controls.Add(this.rbSI);
            this.gbSystemName.Location = new System.Drawing.Point(7, 20);
            this.gbSystemName.Name = "gbSystemName";
            this.gbSystemName.Size = new System.Drawing.Size(194, 68);
            this.gbSystemName.TabIndex = 0;
            this.gbSystemName.TabStop = false;
            this.gbSystemName.Text = "Система измерения";
            // 
            // rbSGS
            // 
            this.rbSGS.AutoSize = true;
            this.rbSGS.Location = new System.Drawing.Point(6, 43);
            this.rbSGS.Name = "rbSGS";
            this.rbSGS.Size = new System.Drawing.Size(55, 27);
            this.rbSGS.TabIndex = 1;
            this.rbSGS.TabStop = true;
            this.rbSGS.Text = "СГС";
            this.rbSGS.UseVisualStyleBackColor = true;
            this.rbSGS.CheckedChanged += new System.EventHandler(this.rbSGS_CheckedChanged);
            // 
            // rbSI
            // 
            this.rbSI.AutoSize = true;
            this.rbSI.Location = new System.Drawing.Point(6, 20);
            this.rbSI.Name = "rbSI";
            this.rbSI.Size = new System.Drawing.Size(50, 27);
            this.rbSI.TabIndex = 0;
            this.rbSI.TabStop = true;
            this.rbSI.Text = "СИ";
            this.rbSI.UseVisualStyleBackColor = true;
            this.rbSI.CheckedChanged += new System.EventHandler(this.rbSI_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1301, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.extiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newToolStripMenuItem.Text = "Новый";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // extiToolStripMenuItem
            // 
            this.extiToolStripMenuItem.Name = "extiToolStripMenuItem";
            this.extiToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.extiToolStripMenuItem.Text = "Выход";
            this.extiToolStripMenuItem.Click += new System.EventHandler(this.extiToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.columnGeometheryToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.dataToolStripMenuItem.Text = "Данные";
            // 
            // columnGeometheryToolStripMenuItem
            // 
            this.columnGeometheryToolStripMenuItem.Name = "columnGeometheryToolStripMenuItem";
            this.columnGeometheryToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.columnGeometheryToolStripMenuItem.Text = "Конфигурация колонны";
            this.columnGeometheryToolStripMenuItem.Click += new System.EventHandler(this.columnGeometheryToolStripMenuItem_Click);
            // 
            // MForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 603);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tcCntrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MForm";
            this.Text = "Моделирование глушения скважины";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mForm_FormClosing);
            this.Resize += new System.EventHandler(this.MForm_Resize);
            this.cmsPipe.ResumeLayout(false);
            this.tcCntrl.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.tlIncomingData.ResumeLayout(false);
            this.tlIncomingData.PerformLayout();
            this.tpPlan.ResumeLayout(false);
            this.tlPlan.ResumeLayout(false);
            this.tlPlan.PerformLayout();
            this.tpResult.ResumeLayout(false);
            this.tpDir.ResumeLayout(false);
            this.tpTab.ResumeLayout(false);
            this.pnPlanActions.ResumeLayout(false);
            this.pnPlanActions.PerformLayout();
            this.tpPlotn.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCoastTable)).EndInit();
            this.tpSetUp.ResumeLayout(false);
            this.gbFimension.ResumeLayout(false);
            this.gbViscosity.ResumeLayout(false);
            this.gbViscosity.PerformLayout();
            this.gbDensity.ResumeLayout(false);
            this.gbDensity.PerformLayout();
            this.gbPressure.ResumeLayout(false);
            this.gbPressure.PerformLayout();
            this.gbDeep.ResumeLayout(false);
            this.gbDeep.PerformLayout();
            this.gbSystemName.ResumeLayout(false);
            this.gbSystemName.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBush;
        private System.Windows.Forms.Label lbHole;
        private System.Windows.Forms.TextBox e_Cluster_Name;
        private System.Windows.Forms.TextBox e_Well_Number;
        private System.Windows.Forms.Label lbLocate;
        private System.Windows.Forms.TextBox e_OilField_name;
        private System.Windows.Forms.Label lbColumn;
        private System.Windows.Forms.ComboBox cs_Column_Geometry;
        private System.Windows.Forms.ComboBox cs_Pipe_Geometry;
        private System.Windows.Forms.Label lbCurrentStall;
        private System.Windows.Forms.TextBox e_Hole_Position_Vertical;
        private System.Windows.Forms.TextBox e_Hole_Position_By_Pipe;
        private System.Windows.Forms.Label lbUpPerforationHeight;
        private System.Windows.Forms.Label lbUpPerforationLenght;
        private System.Windows.Forms.TextBox e_Perforation_Distance_Vertical;
        private System.Windows.Forms.TextBox e_Perforation_Distance_By_Pipe;
        private System.Windows.Forms.TextBox tbCurrentStall;
        private System.Windows.Forms.ComboBox cs_Safety_Factor;
        private System.Windows.Forms.ComboBox cs_Unevenness;
        private System.Windows.Forms.ComboBox cs_Dyn_Viscosity_Unit_CL;
        private System.Windows.Forms.TextBox e_Dyn_Viscosity_CL;
        private System.Windows.Forms.ComboBox cs_Dyn_Viscosity_Unit_BL;
        private System.Windows.Forms.TextBox e_Dyn_Viscosity_BL;
        private System.Windows.Forms.ComboBox cs_Density_Unit_BL;
        private System.Windows.Forms.TextBox e_Density_BL;
        private System.Windows.Forms.ComboBox cbStratumPressureU;
        private System.Windows.Forms.TextBox e_Bed_Pressure;
        private System.Windows.Forms.Label lbStratumPressure;
        private System.Windows.Forms.TabControl tcCntrl;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.TabPage tpResult;
        private System.Windows.Forms.TabPage tpPlan;
        private System.Windows.Forms.TableLayoutPanel tlpChart;
        private System.Windows.Forms.TabPage tpPlotn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbRoSel;
        private System.Windows.Forms.ListView lvRo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TableLayoutPanel tlPlan;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TabPage tpDir;
        private System.Windows.Forms.TabPage tpSchema;
        private System.Windows.Forms.TableLayoutPanel tlIncomingData;
        private System.Windows.Forms.ComboBox cbColumnTailHeightU;
        private System.Windows.Forms.TextBox tbColumnTailHeight;
        private System.Windows.Forms.ComboBox cbColumnTailLenghtU;
        private System.Windows.Forms.TextBox tbColumnTailLenght;
        private System.Windows.Forms.Label lbColumnTailLenght;
        private System.Windows.Forms.Label lbColumnTailType;
        private System.Windows.Forms.ComboBox cbColumnTail;
        private System.Windows.Forms.Label lbColumnType;
        private System.Windows.Forms.Label lbColumnLenght;
        private System.Windows.Forms.TextBox tbColumnLenght;
        private System.Windows.Forms.ComboBox cbColumnLenghtU;
        private System.Windows.Forms.TextBox tbColumnHeight;
        private System.Windows.Forms.ComboBox cbColumnHeightU;
        private System.Windows.Forms.Label lbColumnHeight;
        private System.Windows.Forms.Label lbAdaptorLenght;
        private System.Windows.Forms.TextBox tbAdaptorLenght;
        private System.Windows.Forms.ComboBox cbAdaptorLenght;
        private System.Windows.Forms.Label lbColumnTail;
        private System.Windows.Forms.Label lbColumnTailHeight;
        private System.Windows.Forms.Label lbEuipmentType;
        private System.Windows.Forms.Label lbEquipmentType;
        private System.Windows.Forms.ComboBox cbEquipmentType;
        private System.Windows.Forms.Label lbLowerHanger;
        private System.Windows.Forms.ComboBox cbLowerHangerLenghtU;
        private System.Windows.Forms.Label lbLowerHangerLenght;
        private System.Windows.Forms.ComboBox cbLowerHanger;
        private System.Windows.Forms.Label lbLoverHangerType;
        private System.Windows.Forms.ComboBox cbCirculationHeightU;
        private System.Windows.Forms.Label lbCirculationHeight;
        private System.Windows.Forms.ComboBox cbCirculationLenghtU;
        private System.Windows.Forms.Label lbCirculationLenght;
        private System.Windows.Forms.Label lbUpperHangerType;
        private System.Windows.Forms.ComboBox cbLowerHangerHeightU;
        private System.Windows.Forms.Label lbLowerHangerHeight;
        private System.Windows.Forms.Label lbUpperHanger;
        private System.Windows.Forms.Label lbCirculationHole;

        private System.Windows.Forms.Label lbUpperHangerLenght;
        private System.Windows.Forms.TextBox tbUpperHangerLenght;
        private System.Windows.Forms.ComboBox cbUpperHangerLenghtU;
        private System.Windows.Forms.Label lbUpperHangerHeight;
        private System.Windows.Forms.TextBox tbUpperHangerHeight;
        private System.Windows.Forms.ComboBox cbUpperHangerHeightU;

        private System.Windows.Forms.TextBox tbLowerHangerLenght;
        private System.Windows.Forms.TextBox tbLowerHangerHeight;
        private System.Windows.Forms.Label lbPressure;
        private System.Windows.Forms.ComboBox cbOrificeU;
        private System.Windows.Forms.TextBox tbOrifice;
        private System.Windows.Forms.Label lbOrifice;
        private System.Windows.Forms.Label lbGasFactor;
        private System.Windows.Forms.ComboBox cbGasFactor;
        private System.Windows.Forms.Label lbPerforationInterval;
        private System.Windows.Forms.ComboBox cbUpPerforationLenghtU;
        private System.Windows.Forms.ComboBox cbUpPerforationHeightU;
        private System.Windows.Forms.ComboBox cbBottomPerforationLenghtU;
        private System.Windows.Forms.TextBox tbBottomPerforationLenght;
        private System.Windows.Forms.Label lbBottomPerforationLenght;
        private System.Windows.Forms.Label lbBottomPerforationHeight;
        private System.Windows.Forms.TextBox tbBottomPerforationHeight;
        private System.Windows.Forms.ComboBox cbBottomPerforationHeightU;
        private System.Windows.Forms.Label lbStall;
        private System.Windows.Forms.ComboBox cbCurrentStallU;
        private System.Windows.Forms.ComboBox cbFactitiousStallU;
        private System.Windows.Forms.TextBox tbFactitiousStall;
        private System.Windows.Forms.Label lbFactitiousStall;
        private System.Windows.Forms.Label lbDensity;
        private System.Windows.Forms.Label lbOnAssayDensity;
        private System.Windows.Forms.TextBox tbOnAssayDensity;
        private System.Windows.Forms.ComboBox cbOnAssayDensityU;
        private System.Windows.Forms.Label lbUsedDensity;
        private System.Windows.Forms.TextBox tbUsedDensity;
        private System.Windows.Forms.ComboBox cbUsedDensityU;
        private System.Windows.Forms.Label lbPumpData;
        private System.Windows.Forms.Label lbLevelingSpeed;
        private System.Windows.Forms.TextBox tbLevelingSpeed;
        private System.Windows.Forms.ComboBox cbLevelingSpeedU;
        private System.Windows.Forms.Label lbPumpSupply;
        private System.Windows.Forms.TextBox tbPumpSupply;
        private System.Windows.Forms.ComboBox cbPumpSupplyU;
        private System.Windows.Forms.Label lbPumpPressure;
        private System.Windows.Forms.TextBox tbPumpPressure;
        private System.Windows.Forms.ComboBox cbPumpPressureU;
        private System.Windows.Forms.Label lbNktPressure;
        private System.Windows.Forms.Label lbAnnulusPressure;
        private System.Windows.Forms.TextBox tbNktPressure;
        private System.Windows.Forms.TextBox tbAnnulusPressure;
        private System.Windows.Forms.ComboBox cbNktPressureU;
        private System.Windows.Forms.ComboBox cbAnnulusPressureU;
        private System.Windows.Forms.Label lbFluidParams;
        private System.Windows.Forms.Label lbDenistyBL;
        private System.Windows.Forms.Label lbViscosityCL;
        private System.Windows.Forms.Label lbViscosityBL;
        private System.Windows.Forms.Label lbWellData;
        private System.Windows.Forms.Label lbSafetyFactor;
        private System.Windows.Forms.Label lbWhellType;
        private System.Windows.Forms.Label lbResVolume;
        private System.Windows.Forms.Label lbResColumnVol;
        private System.Windows.Forms.TextBox tbResColumnVol;
        private System.Windows.Forms.Label lbResColumnTailVol;
        private System.Windows.Forms.TextBox tbResNKTVol;
        private System.Windows.Forms.ComboBox cbBedThicknessU;
        private System.Windows.Forms.Label lbBedParams;
        private System.Windows.Forms.Label lbBedThickness;
        private System.Windows.Forms.ComboBox cs_Bed_Type;
        private System.Windows.Forms.TextBox e_Bed_Thickness;
        private System.Windows.Forms.Label lbBedType;
        private System.Windows.Forms.Label lbResOutPipeVol;
        private System.Windows.Forms.TextBox tbResOutPipeVol;
        private System.Windows.Forms.Label lbResUnderPumpVol;
        private System.Windows.Forms.TextBox tbResUnderPumpVol;
        private System.Windows.Forms.Label lbResJamFluidVol;
        private System.Windows.Forms.TextBox tbResJamFluidVol;
        private System.Windows.Forms.Label lbResJamFluidStockVol;
        private System.Windows.Forms.TextBox tbResJamFluidStockVol;
        private System.Windows.Forms.Label lbResJamFluidFullVol;
        private System.Windows.Forms.TextBox tbResJamFluidFullVol;
        private System.Windows.Forms.Label lbDenisty;
        private System.Windows.Forms.Label lbResDensityPutFluid;
        private System.Windows.Forms.TextBox tbResDensityPutFluid;
        private System.Windows.Forms.Label lbResJamDensity;
        private System.Windows.Forms.TextBox tbResJamDensity;
        private System.Windows.Forms.Label lbNKTPumpSpeed;
        private System.Windows.Forms.Label lbResNktInningStep;
        private System.Windows.Forms.TextBox tbResNktInningStep;
        private System.Windows.Forms.Label lbResInnerTime;
        private System.Windows.Forms.TextBox tbResInnerTime;
        private System.Windows.Forms.Label lbROutPipePumpSpeed;
        private System.Windows.Forms.Label lbResOutPipeInningStep;
        private System.Windows.Forms.TextBox tbResOutPipeInningStep;
        private System.Windows.Forms.Label lbResOutPipeInningTime;
        private System.Windows.Forms.TextBox tbResOutPipeInningTime;
        private System.Windows.Forms.Label lbResClearingFluidSpeed;
        private System.Windows.Forms.Label lbResClearingInningStep;
        private System.Windows.Forms.TextBox tbResClearingInningStep;
        private System.Windows.Forms.Label lbResClearingInningTime;
        private System.Windows.Forms.TextBox tbResClearingInningTime;
        private System.Windows.Forms.Label lbResReducing100;
        private System.Windows.Forms.Label lbAddedParam;
        private System.Windows.Forms.Label lbResNCD;
        private System.Windows.Forms.Label lbResKCD;
        private System.Windows.Forms.TextBox tbResNCD;
        private System.Windows.Forms.TextBox tbResKCD;
        private System.Windows.Forms.TextBox tbResReducing100;
        private System.Windows.Forms.ComboBox cbResJamDensityU;
        private System.Windows.Forms.ComboBox cbResDensityPutFluidU;
        private System.Windows.Forms.Label lbResJamFluidFullVolU;
        private System.Windows.Forms.Label lbResJamFluidStockVolU;
        private System.Windows.Forms.Label lbResJamFluidVolU;
        private System.Windows.Forms.Label lbResUnderPumpVolU;
        private System.Windows.Forms.Label lbResOutPipeVolU;
        private System.Windows.Forms.Label lbResColumnTailVolU;
        private System.Windows.Forms.Label lbResColumnVolU;
        private System.Windows.Forms.Label lbResNktInningStepU;
        private System.Windows.Forms.ComboBox cbResInnerTimeU;
        private System.Windows.Forms.Label lbResOutPipeInningStepU;
        private System.Windows.Forms.ComboBox cbResOutPipeInningTimeU;
        private System.Windows.Forms.Label lbResClearingInningStepU;
        private System.Windows.Forms.ComboBox cbResClearingInningTimeU;
        private System.Windows.Forms.ComboBox cbResNCDU;
        private System.Windows.Forms.ComboBox cbResKCDU;
        private System.Windows.Forms.ComboBox cbResReducing100U;
        private System.Windows.Forms.Panel pnPlanActions;
        private System.Windows.Forms.Button btSavePlan;
        private System.Windows.Forms.Button btDeleteNode;
        private System.Windows.Forms.Button btAddNode;
        private System.Windows.Forms.TextBox tbExternalItem;
        private System.Windows.Forms.ListBox lbBeforeHand;
        private System.Windows.Forms.ComboBox cbSaturationPressure;
        private System.Windows.Forms.TextBox tbSaturationPressure;
        private System.Windows.Forms.Label lbSaturatuonPressure;
        private System.Windows.Forms.Label lbDoubleStep;
        private System.Windows.Forms.ComboBox cbDoubleStep;
        private System.Windows.Forms.ComboBox cbPistonDiam;
        private System.Windows.Forms.Label lbPistonDiam;
        private System.Windows.Forms.Label lbServiceCompany;
        private System.Windows.Forms.Label lbBrigade;
        private System.Windows.Forms.Label lbMaster;
        private System.Windows.Forms.TextBox tbServiceCompany;
        private System.Windows.Forms.TextBox tbBrigade;
        private System.Windows.Forms.TextBox tbMaster;
        private System.Windows.Forms.Label lbCirculationHolePresent;
        private System.Windows.Forms.CheckBox cbCirculationHolePresent;
        private System.Windows.Forms.TabPage tpSetUp;
        private System.Windows.Forms.GroupBox gbFimension;
        private System.Windows.Forms.GroupBox gbPressure;
        private System.Windows.Forms.RadioButton rbMpa;
        private System.Windows.Forms.RadioButton rbAtm;
        private System.Windows.Forms.GroupBox gbDeep;
        private System.Windows.Forms.RadioButton rbKm;
        private System.Windows.Forms.RadioButton rbMeters;
        private System.Windows.Forms.GroupBox gbSystemName;
        private System.Windows.Forms.RadioButton rbSGS;
        private System.Windows.Forms.RadioButton rbSI;
        private System.Windows.Forms.GroupBox gbDensity;
        private System.Windows.Forms.RadioButton rbGsm;
        private System.Windows.Forms.RadioButton rbKgm;
        private System.Windows.Forms.GroupBox gbViscosity;
        private System.Windows.Forms.RadioButton rbSPz;
        private System.Windows.Forms.RadioButton rbMpaS;
        private System.Windows.Forms.Label lbCycles;
        private System.Windows.Forms.TextBox tbCycles;
        private System.Windows.Forms.DataGridView dgCoastTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Density;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coast;
        private System.Windows.Forms.ContextMenuStrip cmsPipe;
        private System.Windows.Forms.ToolStripMenuItem ciTubeConfiguration;
        private System.Windows.Forms.ToolStripMenuItem ciCornerEncount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem extiToolStripMenuItem;
        private System.Windows.Forms.Panel pnShema;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnGeometheryToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tpTab;
        private System.Windows.Forms.TreeView tvPlan;
        private System.Windows.Forms.TableLayoutPanel tlpAlg;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

