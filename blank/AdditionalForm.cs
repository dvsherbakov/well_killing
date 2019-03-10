using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace blank
{
    public partial class AdditionalForm : Form
    {
        private readonly TextBox _senderBox;

        public AdditionalForm(TextBox sender)
        {
            _senderBox = sender;
            var senderList = new List<string>();
            if (_senderBox.Tag != null)
                senderList = (List<string>) _senderBox.Tag;
                
            InitializeComponent();
            dgValues.RowHeadersVisible = false;
            dgValues.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgValues.AutoResizeColumns();
            
            if (senderList.Any())
                foreach (var s in senderList)
                {
                    var r = new DataGridViewRow();
                    r.Cells.Add(new DataGridViewTextBoxCell());
                    r.Cells[0].Value = s;
                    dgValues.Rows.Add(r);
                }
            else
            {
                var r = new DataGridViewRow();
                r.Cells.Add(new DataGridViewTextBoxCell());
                r.Cells[0].Value = _senderBox.Text;
                dgValues.Rows.Add(r);
            }
        }

        private void AdditionalForm_Deactivate(object sender, EventArgs e)
        {
            if (dgValues.Rows.Count > 0)
            {
                //var list = (from DataGridViewRow r in dgValues.Rows select r.Cells[0].Value.ToString()).ToList();
                var list = (from DataGridViewRow r in dgValues.Rows where r.Cells[0].Value != null select r.Cells[0].Value.ToString()).ToList();
                _senderBox.Tag = list;
                _senderBox.Text = dgValues.Rows[0].Cells[0].Value.ToString();
            }
            Close();
        }

        private void dgValues_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgValues.AutoResizeColumns();
        }
    }
}
