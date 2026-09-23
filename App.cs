using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace InitiereWindowsForms
{
    public partial class App : Form
    {
        Student student = new Student();
        public App()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl.Text = txtTilu.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTilu.Clear();
            lbl.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(student);

            form1.ShowDialog();

            Console.WriteLine(student.Varsta);
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {

            MessageBox.Show("ce mai faci");

        }

        private void tEstToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("mMeniu ba gagiule");
        }

        private void btnAdapter_Click(object sender, EventArgs e)
        {
            Adapter adapter = new Adapter();

            adapter.ShowDialog();
        }
    }
}
