using System;
using System.Windows.Forms;

namespace InitiereWindowsForms
{
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            lbl.Text = txtTilu.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTilu.Text = "";
            txtTilu.Select();
        }
    }
}
