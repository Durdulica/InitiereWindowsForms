using System;
using System.Drawing;
using System.Windows.Forms;

namespace InitiereWindowsForms
{
    public partial class Ex9 : Form
    {
        public Ex9()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length == 0) 
            {
                txtBox.BackColor = Color.Red;
                txtBox.Select();
            }

            lstBox.Items.Add(txtBox.Text);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstBox.Items.Remove(txtBox.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }
    }
}
