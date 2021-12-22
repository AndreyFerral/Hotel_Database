using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class service_using_information : Form
    {
        SqlConnection myConn = new SqlConnection();
        string nameService, dateService, idАrrival, usageCount;

        public service_using_information(string nameService, string dateService, string idАrrival, string usageCount)
        {
            this.nameService = nameService;
            this.dateService = dateService;
            this.idАrrival = idАrrival;
            this.usageCount = usageCount;
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;

            // Запускаем процедуру выборки данных
            loadData1();
            loadData2();

            // Устанавливаем значения полям
            textBox1.Text = nameService;
            textBox2.Text = dateService;
            textBox3.Text = idАrrival;
            textBox4.Text = usageCount;
        }

        private void loadData1()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.View_UsageService WHERE Название = @p1", myConn);

            // Создать параметр и передать в него значение текстового поля 
            myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
            myComm.Parameters["@p1"].Value = nameService;

            SqlDataReader myReader = myComm.ExecuteReader();
            DataTable dtbl = new DataTable(); dtbl.Load(myReader);
            dataGridView1.DataSource = dtbl;
            myConn.Close();
        }

        private void loadData2()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.View_Arrival WHERE id_Заезд = @p1", myConn);

            // Создать параметр и передать в него значение текстового поля 
            myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
            myComm.Parameters["@p1"].Value = idАrrival;

            SqlDataReader myReader = myComm.ExecuteReader();
            DataTable dtbl = new DataTable(); dtbl.Load(myReader);
            dataGridView2.DataSource = dtbl;
            myConn.Close();
        }
    }
}
