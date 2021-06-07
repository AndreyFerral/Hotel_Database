using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class Form12 : Form
    {
        SqlConnection myConn = new SqlConnection();
        string idАrrival, nameStaff, idRoom, nameClient, idReservation,
             pricePerStay, priceForAddServe, fine, scheduledDateLeave,
             dateArrival, dateLeave, peopleNum;

        public Form12(string idАrrival, string nameStaff, string idRoom, string nameClient, string idReservation,
             string pricePerStay, string priceForAddServe, string fine, string scheduledDateLeave,
             string dateArrival, string dateLeave, string peopleNum)
        {
            this.idАrrival = idАrrival;
            this.nameStaff = nameStaff;
            this.idRoom = idRoom;
            this.nameClient = nameClient;
            this.idReservation = idReservation;
            this.pricePerStay = pricePerStay;
            this.priceForAddServe = priceForAddServe;
            this.fine = fine;
            this.scheduledDateLeave = scheduledDateLeave;
            this.dateArrival = dateArrival;
            this.dateLeave = dateLeave;
            this.peopleNum = peopleNum;

            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;

            // Запускаем процедуру выборки данных
            //loadData1();
            //loadData2();

            // Устанавливаем значения полям
            textBox1.Text = idАrrival;
            textBox2.Text = nameStaff;
            textBox3.Text = idRoom;
            textBox4.Text = nameClient;
            textBox5.Text = idReservation;
            textBox6.Text = pricePerStay;
            textBox7.Text = priceForAddServe;
            textBox8.Text = fine;
            textBox9.Text = scheduledDateLeave;
            textBox10.Text = dateArrival;
            textBox11.Text = dateLeave;
            textBox12.Text = peopleNum;
        }
    }
}
