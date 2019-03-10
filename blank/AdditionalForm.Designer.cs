namespace blank
{
    partial class AdditionalForm
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
            this.dgValues = new System.Windows.Forms.DataGridView();
            this.values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgValues)).BeginInit();
            this.SuspendLayout();
            // 
            // dgValues
            // 
            this.dgValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.values});
            this.dgValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgValues.Location = new System.Drawing.Point(0, 0);
            this.dgValues.Name = "dgValues";
            this.dgValues.Size = new System.Drawing.Size(144, 110);
            this.dgValues.TabIndex = 0;
            this.dgValues.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgValues_RowsAdded);
            // 
            // values
            // 
            this.values.HeaderText = "Данные";
            this.values.Name = "values";
            // 
            // AdditionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 110);
            this.Controls.Add(this.dgValues);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdditionalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Дополнительно";
            this.Deactivate += new System.EventHandler(this.AdditionalForm_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.dgValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn values;
    }
}