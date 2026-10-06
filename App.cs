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
            Ex3 ex = new Ex3();

            ex.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ex4 form1 = new Ex4(student);

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
            Ex7 adapter = new Ex7();

            adapter.ShowDialog();
        }

        private void btnEx9_Click(object sender, EventArgs e)
        {
            Ex9 ex = new Ex9();

            ex.ShowDialog();
        }
    }
}
