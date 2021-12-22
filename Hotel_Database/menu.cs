using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idNumberPlacement = 1;

            Hide();
            universal form3 = new universal(idNumberPlacement);
            form3.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idNumberComfort = 2;

            Hide();
            universal form3 = new universal(idNumberComfort);
            form3.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idNumberService = 3;

            Hide();
            universal form3 = new universal(idNumberService);
            form3.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idNumberStaff = 4;

            Hide();
            universal form3 = new universal(idNumberStaff);
            form3.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            child_list form4 = new child_list();
            form4.ShowDialog();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            client_list form6 = new client_list();
            form6.ShowDialog();
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            service_using_list form9 = new service_using_list();
            form9.ShowDialog();
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            arrives_list form11 = new arrives_list();
            form11.ShowDialog();
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            room_list form13 = new room_list();
            form13.ShowDialog();
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hide();
            reservation_list form14 = new reservation_list();
            form14.ShowDialog();
            Close();
        }
    }
}
