using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class Form5 : Form
    {
        SqlConnection myConn = new SqlConnection();
        string idChildren, nameParent, nameChildren, dateChildren;

        public Form5(string idChildren, string nameParent, string nameChildren, string dateChildren)
        {
            this.idChildren = idChildren;
            this.nameParent = nameParent;
            this.nameChildren = nameChildren;
            this.dateChildren = dateChildren;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;

            // Запускаем процедуру выборки данных
            loadData1();

            // Устанавливаем значения полям
            textBox1.Text = idChildren;
            textBox2.Text = nameParent;
            textBox3.Text = nameChildren;
            textBox4.Text = dateChildren;
        }

        private void loadData1()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.Клиент where ФИО_клиента = @p1", myConn);

            // Создать параметр и передать в него значение текстового поля 
            myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
            myComm.Parameters["@p1"].Value = nameParent;
            SqlDataReader myReader = myComm.ExecuteReader();

            DataTable dtbl = new DataTable(); dtbl.Load(myReader);
            dataGridView1.DataSource = dtbl;
            myConn.Close();
        }
    }
}
