using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace blank
{
    public partial class fmBedConf : Form
    {
        

        public fmBedConf(Dictionary<string, CBedType> dict)
        {
            InitializeComponent();
            
            dgBedProp.Rows.Clear();
            foreach (var it in dict)
            {
                var nm = it.Key;
                var pn = it.Value;
                dgBedProp.Rows.Add(pn.Index, nm, pn.K, pn.M);
            }
        }

        private void fmBedConf_Deactivate(object sender, EventArgs e)
        {
            
            foreach (var it in dgBedProp.Rows)
            {
                var t = (DataGridViewRow)it;
                var index = (int)t.Cells[0].Value;
                double K=0.0;  double.TryParse(t.Cells[2].Value.ToString().Replace('.', ','), out K);
                double M = 0.0; double.TryParse(t.Cells[3].Value.ToString().Replace('.', ','), out M);
                MForm._conf.BedTypes[index].K = K;
                MForm._conf.BedTypes[index].M = M;
            }
            Close();
        }
    }
}
