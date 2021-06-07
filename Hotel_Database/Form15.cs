using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class Form15 : Form
    {
        SqlConnection myConn = new SqlConnection();
        string idReservation, roomNumber, workerName, clientName,
            dateReservation, scheduledDateArrival, scheduledDateLeave,
            peopleNum, reservationType, reservaionPrice;

        public Form15(string idReservation, string roomNumber, string workerName, string clientName,
            string dateReservation, string scheduledDateArrival, string scheduledDateLeave,
            string peopleNum, string reservationType, string reservaionPrice)
        {
            this.idReservation = idReservation;
            this.roomNumber = roomNumber;
            this.workerName = workerName;
            this.clientName = clientName;
            this.dateReservation = dateReservation;
            this.scheduledDateArrival = scheduledDateArrival;
            this.scheduledDateLeave = scheduledDateLeave;
            this.peopleNum = peopleNum;
            this.reservationType = reservationType;
            this.reservaionPrice = reservaionPrice;
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;

            // Запускаем процедуру выборки данных
            loadDataStaff();
            loadDataRoom();
            loadDataClient();

            // Устанавливаем значения полям
            textBox1.Text = idReservation;
            textBox2.Text = roomNumber;
            textBox3.Text = workerName;
            textBox4.Text = clientName;
            textBox5.Text = dateReservation;
            textBox6.Text = scheduledDateArrival;
            textBox7.Text = scheduledDateLeave;
            textBox8.Text = peopleNum;
            textBox9.Text = reservationType;
            textBox10.Text = reservaionPrice;
        }
        private void loadDataClient()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.Клиент where ФИО_клиента = @p1", myConn);

            // Создать параметр и передать в него значение текстового поля 
            myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
            myComm.Parameters["@p1"].Value = clientName;
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
            myComm.Parameters["@p1"].Value = roomNumber;
            SqlDataReader myReader = myComm.ExecuteReader();

            DataTable dtbl = new DataTable(); dtbl.Load(myReader);
            dataGridView1.DataSource = dtbl;
            myConn.Close();
        }
        private void loadDataStaff()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.Сотрудники where ФИО_сотрудника = @p1", myConn);

            // Создать параметр и передать в него значение текстового поля 
            myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
            myComm.Parameters["@p1"].Value = workerName;
            SqlDataReader myReader = myComm.ExecuteReader();

            DataTable dtbl = new DataTable(); dtbl.Load(myReader);
            dataGridView2.DataSource = dtbl;
            myConn.Close();
        }

    }
}
