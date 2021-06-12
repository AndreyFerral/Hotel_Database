using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class arrive_information : Form
    {
        SqlConnection myConn = new SqlConnection();
        string idАrrival, nameStaff, idRoom, nameClient, idReservation,
             pricePerStay, priceForAddServe, fine, scheduledDateLeave,
             dateArrival, dateLeave, peopleNum;


        public arrive_information(string idАrrival, string nameStaff, string idRoom, string nameClient, string idReservation,
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
            loadDataStaff();
            loadDataRoom();
            loadDataClient();
            loadDataReservation();

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

        private void loadDataStaff()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.Сотрудники where ФИО_сотрудника = @p1", myConn);

            // Создать параметр и передать в него значение текстового поля 
            myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
            myComm.Parameters["@p1"].Value = nameStaff;
            SqlDataReader myReader = myComm.ExecuteReader();

            DataTable dtbl = new DataTable(); dtbl.Load(myReader);
            dataGridView2.DataSource = dtbl;
            myConn.Close();
        }

        private void loadDataReservation()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.View_Reservation where id_Бронирование = @p1", myConn);

            // Создать параметр и передать в него значение текстового поля 
            myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
            myComm.Parameters["@p1"].Value = idReservation;
            SqlDataReader myReader = myComm.ExecuteReader();

            DataTable dtbl = new DataTable(); dtbl.Load(myReader);
            dataGridView4.DataSource = dtbl;
            myConn.Close();
        }

        private void loadDataClient()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.Клиент where ФИО_клиента = @p1", myConn);

            // Создать параметр и передать в него значение текстового поля 
            myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
            myComm.Parameters["@p1"].Value = nameClient;
            SqlDataReader myReader = myComm.ExecuteReader();

            DataTable dtbl = new DataTable(); dtbl.Load(myReader);
            dataGridView3.DataSource = dtbl;
            myConn.Close();
        }

        private void loadDataRoom()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.View_Room where Номер_комнаты = @p1", myConn);

            // Создать параметр и передать в него значение текстового поля 
            myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
            myComm.Parameters["@p1"].Value = idRoom;
            SqlDataReader myReader = myComm.ExecuteReader();

            DataTable dtbl = new DataTable(); dtbl.Load(myReader);
            dataGridView1.DataSource = dtbl;
            myConn.Close();
        }
    }
}
