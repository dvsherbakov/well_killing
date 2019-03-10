namespace blank
{
    partial class PipeConf
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
            this.dgPipeConf = new System.Windows.Forms.DataGridView();
            this.Lenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPipeConf)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPipeConf
            // 
            this.dgPipeConf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPipeConf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPipeConf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lenght,
            this.Height});
            this.dgPipeConf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPipeConf.Location = new System.Drawing.Point(0, 0);
            this.dgPipeConf.Name = "dgPipeConf";
            this.dgPipeConf.Size = new System.Drawing.Size(284, 261);
            this.dgPipeConf.TabIndex = 0;
            // 
            // Lenght
            // 
            this.Lenght.HeaderText = "Длинна участка";
            this.Lenght.Name = "Lenght";
            this.Lenght.Width = 120;
            // 
            // Height
            // 
            this.Height.HeaderText = "Глубина участка";
            this.Height.Name = "Height";
            this.Height.Width = 120;
            // 
            // PipeConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgPipeConf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PipeConf";
            this.Text = "PipeConf";
            this.Deactivate += new System.EventHandler(this.PipeConf_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.dgPipeConf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPipeConf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lenght;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Height;
    }
}