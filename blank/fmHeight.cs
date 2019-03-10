using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace blank
{
    public partial class FmHeight : Form
    {
        private readonly TextBox _sender;
        private readonly double _len;
        private double _height;
        public FmHeight(TextBox sender, double lenght)
        {
            InitializeComponent();
            _sender = sender;
            _len = lenght;

        }

        private void ReCount()
        {
            double straightCircuit = 0;
            double inclininedCircuit = 0;
            double averageInclined = 0;

            if (tbStraightCircuit.Text.Length > 0)
                double.TryParse(tbStraightCircuit.Text, out straightCircuit);
            if (tbInclininedCircuit.Text.Length > 0)
                double.TryParse(tbInclininedCircuit.Text, out inclininedCircuit);
            if (tbAverageInclined.Text.Length > 0)
                double.TryParse(tbAverageInclined.Text, out averageInclined);

            if (!(straightCircuit > 0) || !(inclininedCircuit > 0) || !(averageInclined > 0)) return;
            _height = Math.Round(straightCircuit + inclininedCircuit * Math.Cos(averageInclined * Math.PI / 180), 3);
            tbHeight.Text = _height.ToString(CultureInfo.CurrentCulture);
        }

        private void tbStraightCircuit_TextChanged(object sender, EventArgs e)
        {
            double straightCircuit=0;

            if (tbStraightCircuit.Text.Length > 0) 
                double.TryParse(tbStraightCircuit.Text, out straightCircuit);
            if (straightCircuit > 0)
                tbInclininedCircuit.Text = (_len - straightCircuit).ToString(CultureInfo.CurrentCulture);
            ReCount();
        }

        private void fmHeight_Deactivate(object sender, EventArgs e)
        {
            if (tbHeight.Text.Length > 0)
                _sender.Text = tbHeight.Text;
            Close();
        }

        private void tbInclininedCircuit_TextChanged(object sender, EventArgs e)
        {
            double inclininedCircuit = 0;

            if (tbInclininedCircuit.Text.Length > 0)
                double.TryParse(tbInclininedCircuit.Text, out inclininedCircuit);
            if (inclininedCircuit > 0)
                tbStraightCircuit.Text = (_len - inclininedCircuit).ToString(CultureInfo.CurrentCulture);
            ReCount();
        }

        private void tbAverageInclined_TextChanged(object sender, EventArgs e)
        {
            ReCount();
        }
    }
}
