namespace blank
{
    partial class fmBedConf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgBedProp = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBedProp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBedProp
            // 
            this.dgBedProp.AllowUserToAddRows = false;
            this.dgBedProp.AllowUserToDeleteRows = false;
            this.dgBedProp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBedProp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBedProp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.BedName,
            this.K,
            this.M});
            this.dgBedProp.Location = new System.Drawing.Point(13, 13);
            this.dgBedProp.Name = "dgBedProp";
            this.dgBedProp.Size = new System.Drawing.Size(375, 225);
            this.dgBedProp.TabIndex = 0;
            // 
            // Index
            // 
            this.Index.HeaderText = "Индекс";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 50;
            // 
            // BedName
            // 
            this.BedName.FillWeight = 130F;
            this.BedName.HeaderText = "Название участка";
            this.BedName.Name = "BedName";
            this.BedName.ReadOnly = true;
            this.BedName.Width = 130;
            // 
            // K
            // 
            this.K.FillWeight = 75F;
            this.K.HeaderText = "K";
            this.K.Name = "K";
            this.K.Width = 75;
            // 
            // M
            // 
            this.M.FillWeight = 75F;
            this.M.HeaderText = "M";
            this.M.Name = "M";
            this.M.Width = 75;
            // 
            // fmBedConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.dgBedProp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 50);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmBedConf";
            this.Text = "fmBedConf";
            this.Deactivate += new System.EventHandler(this.fmBedConf_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.dgBedProp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBedProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn K;
        private System.Windows.Forms.DataGridViewTextBoxColumn M;
    }
}