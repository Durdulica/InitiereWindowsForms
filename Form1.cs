using System;
using System.Drawing;
using System.Windows.Forms;

namespace InitiereWindowsForms
{
    public partial class Form1 : Form
    {
        Student student = new Student();
        Student aux = new Student();

        public Form1(Student student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                aux.Email = txtEmail.Text;
                txtEmail.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                txtEmail.BackColor = Color.Red;
                txtEmail.SelectAll();
                txtEmail.Focus();
            }
        }

        private void txtVarsta_Leave(object sender, EventArgs e)
        {
            try
            {
                int nr;
                Int32.TryParse(txtVarsta.Text,out nr);
                aux.Varsta = nr;
                txtVarsta.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txtVarsta.BackColor = Color.Red;
                txtVarsta.SelectAll();
                txtVarsta.Focus();
            }
        }

        private void btnClose_KeyPress(object sender, KeyPressEventArgs e)
        {
            Close();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            student = aux;
            Close();
        }
    }
}
