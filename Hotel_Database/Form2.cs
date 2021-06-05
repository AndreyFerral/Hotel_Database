using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idNumberPlacement = 1;

            Hide();
            Form3 form3 = new Form3(idNumberPlacement);
            form3.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idNumberComfort = 2;

            Hide();
            Form3 form3 = new Form3(idNumberComfort);
            form3.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idNumberService = 3;

            Hide();
            Form3 form3 = new Form3(idNumberService);
            form3.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idNumberStaff = 4;

            Hide();
            Form3 form3 = new Form3(idNumberStaff);
            form3.ShowDialog();
            Close();
        }
    }
}
