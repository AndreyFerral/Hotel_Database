using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class Form9 : Form
    {
        SqlConnection myConn = new SqlConnection();
        int indexSelectRow;
        string idService, dateService, idCkeckIn, countService;

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;

            // Заполняем объект типа ComboBox
            loadData1ComboBox();
            loadData2ComboBox();

            // Запускаем процедуру выборки данных
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Для того, чтобы не обновлялись значения, если нажатия происходит в одной строке
            if (e.RowIndex != indexSelectRow)
            {
                indexSelectRow = e.RowIndex;

                idService = dataGridView1[0, indexSelectRow].Value.ToString();
                dateService = dataGridView1[1, indexSelectRow].Value.ToString();
                idCkeckIn = dataGridView1[2, indexSelectRow].Value.ToString();
                countService = dataGridView1[3, indexSelectRow].Value.ToString();
            }
        }

        private void add_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void delete_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void update_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void info_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void back_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Close();
        }

        private void loadData1ComboBox()
        {
            myConn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select id_Дополнительные_услуги from dbo.Дополнительные_услуги", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            id_service.DisplayMember = "id_Дополнительные_услуги";
            id_service.DataSource = dtbl;

            myConn.Close();
        }

        private void loadData2ComboBox()
        {
            myConn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select id_Заезд from dbo.Заезд", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            id_check.DisplayMember = "id_Заезд";
            id_check.DataSource = dtbl;

            myConn.Close();
        }

        private void loadData()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.Пользование_дополнительными_услугами", myConn);

            SqlDataReader myReader = myComm.ExecuteReader();
            DataTable dtbl = new DataTable(); dtbl.Load(myReader);
            dataGridView1.DataSource = dtbl;
            myConn.Close();

            // Разрешаем нулевые значения (иначе событие DataError)
            dtbl.Columns[0].AllowDBNull = true;
            dtbl.Columns[1].AllowDBNull = true;
            dtbl.Columns[2].AllowDBNull = true;
            dtbl.Columns[3].AllowDBNull = true;

            // Устанавливаем значения по умолчанию переменным (первая строка)
            indexSelectRow = 0;

            // Если в таблице есть минимум одна запись
            if (dataGridView1.Rows.Count > 1)
            {
                idService = dataGridView1[0, indexSelectRow].Value.ToString();
                dateService = dataGridView1[1, indexSelectRow].Value.ToString();
                idCkeckIn = dataGridView1[2, indexSelectRow].Value.ToString();
                countService = dataGridView1[3, indexSelectRow].Value.ToString();
            }
        }
    }
}
