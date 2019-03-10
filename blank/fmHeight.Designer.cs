namespace blank
{
    partial class FmHeight
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
            this.tlHeight = new System.Windows.Forms.TableLayoutPanel();
            this.lbStraightCircuit = new System.Windows.Forms.Label();
            this.tbStraightCircuit = new System.Windows.Forms.TextBox();
            this.lbInclininedCircuit = new System.Windows.Forms.Label();
            this.tbInclininedCircuit = new System.Windows.Forms.TextBox();
            this.lbAverageInclined = new System.Windows.Forms.Label();
            this.tbAverageInclined = new System.Windows.Forms.TextBox();
            this.lbHeight = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tlHeight.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlHeight
            // 
            this.tlHeight.ColumnCount = 2;
            this.tlHeight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlHeight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlHeight.Controls.Add(this.lbStraightCircuit, 0, 0);
            this.tlHeight.Controls.Add(this.tbStraightCircuit, 1, 0);
            this.tlHeight.Controls.Add(this.lbInclininedCircuit, 0, 1);
            this.tlHeight.Controls.Add(this.tbInclininedCircuit, 1, 1);
            this.tlHeight.Controls.Add(this.lbAverageInclined, 0, 2);
            this.tlHeight.Controls.Add(this.tbAverageInclined, 1, 2);
            this.tlHeight.Controls.Add(this.lbHeight, 0, 3);
            this.tlHeight.Controls.Add(this.tbHeight, 1, 3);
            this.tlHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlHeight.Location = new System.Drawing.Point(0, 0);
            this.tlHeight.Name = "tlHeight";
            this.tlHeight.RowCount = 4;
            this.tlHeight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlHeight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlHeight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlHeight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlHeight.Size = new System.Drawing.Size(293, 121);
            this.tlHeight.TabIndex = 0;
            // 
            // lbStraightCircuit
            // 
            this.lbStraightCircuit.AutoSize = true;
            this.lbStraightCircuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStraightCircuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStraightCircuit.Location = new System.Drawing.Point(3, 0);
            this.lbStraightCircuit.Name = "lbStraightCircuit";
            this.lbStraightCircuit.Size = new System.Drawing.Size(199, 29);
            this.lbStraightCircuit.TabIndex = 0;
            this.lbStraightCircuit.Text = "Длинна прямого участка";
            this.lbStraightCircuit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbStraightCircuit
            // 
            this.tbStraightCircuit.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbStraightCircuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStraightCircuit.Location = new System.Drawing.Point(208, 3);
            this.tbStraightCircuit.Name = "tbStraightCircuit";
            this.tbStraightCircuit.Size = new System.Drawing.Size(82, 23);
            this.tbStraightCircuit.TabIndex = 1;
            this.tbStraightCircuit.TextChanged += new System.EventHandler(this.tbStraightCircuit_TextChanged);
            // 
            // lbInclininedCircuit
            // 
            this.lbInclininedCircuit.AutoSize = true;
            this.lbInclininedCircuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInclininedCircuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInclininedCircuit.Location = new System.Drawing.Point(3, 29);
            this.lbInclininedCircuit.Name = "lbInclininedCircuit";
            this.lbInclininedCircuit.Size = new System.Drawing.Size(199, 29);
            this.lbInclininedCircuit.TabIndex = 2;
            this.lbInclininedCircuit.Text = "Длинна наклонного участка";
            this.lbInclininedCircuit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbInclininedCircuit
            // 
            this.tbInclininedCircuit.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbInclininedCircuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInclininedCircuit.Location = new System.Drawing.Point(208, 32);
            this.tbInclininedCircuit.Name = "tbInclininedCircuit";
            this.tbInclininedCircuit.Size = new System.Drawing.Size(82, 23);
            this.tbInclininedCircuit.TabIndex = 3;
            this.tbInclininedCircuit.TextChanged += new System.EventHandler(this.tbInclininedCircuit_TextChanged);
            // 
            // lbAverageInclined
            // 
            this.lbAverageInclined.AutoSize = true;
            this.lbAverageInclined.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAverageInclined.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAverageInclined.Location = new System.Drawing.Point(3, 58);
            this.lbAverageInclined.Name = "lbAverageInclined";
            this.lbAverageInclined.Size = new System.Drawing.Size(199, 29);
            this.lbAverageInclined.TabIndex = 4;
            this.lbAverageInclined.Text = "Средний угол наклона";
            this.lbAverageInclined.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAverageInclined
            // 
            this.tbAverageInclined.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbAverageInclined.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAverageInclined.Location = new System.Drawing.Point(208, 61);
            this.tbAverageInclined.Name = "tbAverageInclined";
            this.tbAverageInclined.Size = new System.Drawing.Size(82, 23);
            this.tbAverageInclined.TabIndex = 5;
            this.tbAverageInclined.TextChanged += new System.EventHandler(this.tbAverageInclined_TextChanged);
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeight.Location = new System.Drawing.Point(3, 87);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(199, 34);
            this.lbHeight.TabIndex = 6;
            this.lbHeight.Text = "Глубина погружения";
            this.lbHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbHeight
            // 
            this.tbHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbHeight.Enabled = false;
            this.tbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHeight.Location = new System.Drawing.Point(208, 90);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(82, 23);
            this.tbHeight.TabIndex = 7;
            // 
            // FmHeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 121);
            this.Controls.Add(this.tlHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmHeight";
            this.Text = "Высота";
            this.Deactivate += new System.EventHandler(this.fmHeight_Deactivate);
            this.tlHeight.ResumeLayout(false);
            this.tlHeight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlHeight;
        private System.Windows.Forms.Label lbStraightCircuit;
        private System.Windows.Forms.TextBox tbStraightCircuit;
        private System.Windows.Forms.Label lbInclininedCircuit;
        private System.Windows.Forms.TextBox tbInclininedCircuit;
        private System.Windows.Forms.Label lbAverageInclined;
        private System.Windows.Forms.TextBox tbAverageInclined;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.TextBox tbHeight;
    }
}