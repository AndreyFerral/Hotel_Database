using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class Form8 : Form
    {
        SqlConnection myConn = new SqlConnection();
        string idService, nameService, costService;
        string dateService, idАrrival, usageCount;
        int indexSelectRow;

        public Form8(string idService, string nameService, string costService)
        {
            this.idService = idService;
            this.nameService = nameService;
            this.costService = costService;
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                // Берем значения для добавления из предпоследней строчки (последняя - пустая)
                indexSelectRow = dataGridView1.Rows.Count - 2;
                dateService = dataGridView1[0, indexSelectRow].Value.ToString();
                idАrrival = dataGridView1[1, indexSelectRow].Value.ToString();
                usageCount = dataGridView1[2, indexSelectRow].Value.ToString();

                myConn.Open();
                if (nameService.Trim() == "" || dateService.Trim() == "" ||
                    idАrrival.Trim() == "" || usageCount.Trim() == "") throw new Exception();

                // Создать команду для добавления
                SqlCommand myComm = new SqlCommand("execute add_using_service @p1, @p2, @p3, @p4", myConn);

                // Создать параметр и передать в него значение текстового поля 
                myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p1"].Value = nameService;

                myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p2"].Value = idАrrival;

                myComm.Parameters.Add("@p3", SqlDbType.SmallDateTime);
                myComm.Parameters["@p3"].Value = dateService;

                myComm.Parameters.Add("@p4", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p4"].Value = usageCount;

                // Выполнить запрос на изменение без возвращения результата
                myComm.ExecuteNonQuery();
                myConn.Close();

                // Обновляем содержимое 
                loadData();
            }
            catch
            {
                myConn.Close();
                MessageBox.Show("Ошибка. Возможное решение:\n\n " +
                                " 1. Возможно вы пытаетесь добавить пустую строку.", "Внимание!");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Данная информация будет удалена. Продолжить?", "Внимание!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    myConn.Open();
                    if (nameService == "" || dateService == "") throw new Exception();

                    // Создать команду для удаления
                    SqlCommand myComm = new SqlCommand("execute delete_using_service @p1, @p2", myConn);

                    // Создать параметр и передать в него значение текстового поля 
                    myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p1"].Value = nameService;

                    myComm.Parameters.Add("@p2", SqlDbType.SmallDateTime);
                    myComm.Parameters["@p2"].Value = dateService;

                    // Выполнить запрос на удаление без возвращения результата
                    myComm.ExecuteReader();
                    myConn.Close();

                    // Обновляем содержимое 
                    loadData();
                }
            }
            catch
            {
                myConn.Close();
                MessageBox.Show("Ошибка. Возможное решение:\n\n " +
                                " 1. Возможно вы пытаетесь удалить пустую строку.", "Внимание!");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();

                // Проверка на последнюю строчку
                if (indexSelectRow >= dataGridView1.Rows.Count - 1) throw new Exception();

                // Запоминаем старые значение (составной ключ)
                string oldNameService = nameService;
                string oldDateService = dateService;

                // Присваиваем переменным обновленные значения
                dateService = dataGridView1[0, indexSelectRow].Value.ToString();
                idАrrival = dataGridView1[1, indexSelectRow].Value.ToString();
                usageCount = dataGridView1[2, indexSelectRow].Value.ToString();

                if (nameService.Trim() == "" || dateService.Trim() == "" ||
                    idАrrival.Trim() == "" || usageCount.Trim() == "") throw new Exception();

                // Создать команду для изменения
                SqlCommand myComm = new SqlCommand("execute update_using_service @p1, @p2, @p3, @p4, @p5, @p6", myConn);

                // Создать параметр и передать в него значение текстового поля 
                myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p1"].Value = nameService;

                myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p2"].Value = idАrrival;

                myComm.Parameters.Add("@p3", SqlDbType.SmallDateTime);
                myComm.Parameters["@p3"].Value = dateService;

                myComm.Parameters.Add("@p4", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p4"].Value = usageCount;

                myComm.Parameters.Add("@p5", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p5"].Value = oldNameService;

                myComm.Parameters.Add("@p6", SqlDbType.SmallDateTime);
                myComm.Parameters["@p6"].Value = oldDateService;

                // Выполнить запрос на изменение без возвращения результата
                myComm.ExecuteNonQuery();
                myConn.Close();

                // Обновляем содержимое 
                loadData();
            }
            catch
            {
                myConn.Close();
                MessageBox.Show("Ошибка. Возможное решение:\n\n " +
                                " 1. Возможно вы пытаетесь редактировать пустую строку.", "Внимание!");
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;

            // Заполняем объект типа ComboBox
            loadData2ComboBox();

            // Запускаем процедуру выборки данных
            loadData();

            // Устанавливаем значения полям
            textBox1.Text = idService;
            textBox2.Text = nameService;
            textBox3.Text = costService;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Для того, чтобы не обновлялись значения, если нажатия происходит в одной строке
            if (e.RowIndex != indexSelectRow && e.RowIndex != -1)
            {
                indexSelectRow = e.RowIndex;

                dateService = dataGridView1[0, indexSelectRow].Value.ToString();
                idАrrival = dataGridView1[1, indexSelectRow].Value.ToString();
                usageCount = dataGridView1[2, indexSelectRow].Value.ToString();
            }
        }

        private void loadData2ComboBox()
        {
            myConn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select id_Заезд from dbo.Заезд", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            id_arrival.DisplayMember = "id_Заезд";
            id_arrival.DataSource = dtbl;

            myConn.Close();
        }

        private void loadData()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select Дата_пользования, Заезд_id_Заезд, Количество_пользований from dbo.View_UsageService where Название = @p1", myConn);

            // Создать параметр и передать в него значение текстового поля 
            myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
            myComm.Parameters["@p1"].Value = nameService;

            SqlDataReader myReader = myComm.ExecuteReader();
            DataTable dtbl = new DataTable(); dtbl.Load(myReader);
            dataGridView1.DataSource = dtbl;
            myConn.Close();

            // Разрешаем нулевые значения (иначе событие DataError)
            dtbl.Columns[0].AllowDBNull = true;
            dtbl.Columns[1].AllowDBNull = true;
            dtbl.Columns[2].AllowDBNull = true;

            // Устанавливаем значения по умолчанию переменным (первая строка)
            indexSelectRow = 0;

            // Если в таблице есть минимум одна запись
            if (dataGridView1.Rows.Count > 1)
            {
                dateService = dataGridView1[0, indexSelectRow].Value.ToString();
                idАrrival = dataGridView1[1, indexSelectRow].Value.ToString();
                usageCount = dataGridView1[2, indexSelectRow].Value.ToString();
            }
        }
    }
}
