using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace blank
{
    public partial class PipeConf : Form
    {
        private readonly List<GeometheryElement> _lst; 
        public PipeConf()
        {
            InitializeComponent();
            _lst = new List<GeometheryElement>();
            var lst = MForm.GetPipeConf();
            var gElems = lst as IList<GeometheryElement> ?? lst.ToList();
            if (!gElems.Any()) return;
            foreach (var itm in gElems)
            {
                var r = new DataGridViewRow();
                r.Cells.Add(new DataGridViewTextBoxCell());
                r.Cells[0].Value = itm.Lenght();
                r.Cells.Add(new DataGridViewTextBoxCell());
                r.Cells[1].Value = itm.Height();
                dgPipeConf.Rows.Add(r);
            }
        }

        private void PipeConf_Deactivate(object sender, EventArgs e)
        {
            foreach (var dr in dgPipeConf.Rows.Cast<DataGridViewRow>().Where(dr => (dr.Cells[0].Value != null) && dr.Cells[1].Value != null))
            {
                var hl = 0;
                var l = int.TryParse(dr.Cells[0].Value.ToString(), out var ln);
                l = l && int.TryParse(dr.Cells[1].Value.ToString(), out hl);
                if (l)
                    _lst.Add(ln > hl ? new GeometheryElement(ln, hl) : new GeometheryElement(hl, ln));
            }
            
            MForm.SetPipeConf(_lst);
            Close();
        }

        //public IEnumerable<GeometheryElement> RList()
        //{
        //    return _lst;
        //}
    }
}
