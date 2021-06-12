using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class client_list : Form
    {
        SqlConnection myConn = new SqlConnection();
        int indexSelectRow;
        string idClient, passportClient, nameClient, dateClient, numberClient, countChildren;

        public client_list()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;

            // Запускаем процедуру выборки данных
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Для того, чтобы не обновлялись значения, если нажатия происходит в одной строке
            if (e.RowIndex != indexSelectRow && e.RowIndex != -1)
            {
                indexSelectRow = e.RowIndex;

                idClient = dataGridView1[0, indexSelectRow].Value.ToString();
                passportClient = dataGridView1[1, indexSelectRow].Value.ToString();
                nameClient = dataGridView1[2, indexSelectRow].Value.ToString();
                dateClient = dataGridView1[3, indexSelectRow].Value.ToString();
                numberClient = dataGridView1[4, indexSelectRow].Value.ToString();
                countChildren = dataGridView1[5, indexSelectRow].Value.ToString();
            }
        }

        private void add_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Берем значения для добавления из предпоследней строчки (последняя - пустая)
                indexSelectRow = dataGridView1.Rows.Count - 2;
                idClient = dataGridView1[0, indexSelectRow].Value.ToString();
                passportClient = dataGridView1[1, indexSelectRow].Value.ToString();
                nameClient = dataGridView1[2, indexSelectRow].Value.ToString();
                dateClient = dataGridView1[3, indexSelectRow].Value.ToString();
                numberClient = dataGridView1[4, indexSelectRow].Value.ToString();
                countChildren = dataGridView1[5, indexSelectRow].Value.ToString();

                myConn.Open();
                if (passportClient.Trim() == "" || nameClient.Trim() == "" ||
                    dateClient.Trim() == "" || numberClient.Trim() == "" ||
                    countChildren.Trim() == "") throw new Exception();

                // Создать команду для добавления
                SqlCommand myComm = new SqlCommand("execute add_client @p1, @p2, @p3, @p4, @p5", myConn);

                // Создать параметр и передать в него значение текстового поля 
                myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p1"].Value = passportClient;

                myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p2"].Value = nameClient;

                myComm.Parameters.Add("@p3", SqlDbType.Date);
                myComm.Parameters["@p3"].Value = dateClient;

                myComm.Parameters.Add("@p4", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p4"].Value = numberClient;

                myComm.Parameters.Add("@p5", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p5"].Value = countChildren;

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

        private void delete_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Данная информация будет удалена. Продолжить?", "Внимание!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    myConn.Open();
                    if (idClient == "") throw new Exception();

                    // Создать команду для удаления
                    SqlCommand myComm = new SqlCommand("execute delete_client @p1", myConn);

                    // Создать параметр и передать в него значение текстового поля 
                    myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 10);
                    myComm.Parameters["@p1"].Value = idClient;

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

        private void update_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();

                // Присваиваем переменным обновленные значения
                idClient = dataGridView1[0, indexSelectRow].Value.ToString();
                passportClient = dataGridView1[1, indexSelectRow].Value.ToString();
                nameClient = dataGridView1[2, indexSelectRow].Value.ToString();
                dateClient = dataGridView1[3, indexSelectRow].Value.ToString();
                numberClient = dataGridView1[4, indexSelectRow].Value.ToString();
                countChildren = dataGridView1[5, indexSelectRow].Value.ToString();

                if (idClient.Trim() == "") throw new Exception();

                // Создать команду для изменения
                SqlCommand myComm = new SqlCommand("execute update_client @p1, @p2, @p3, @p4, @p5, @p6", myConn);

                // Создать параметр и передать в него значение текстового поля 
                myComm.Parameters.Add("@p1", SqlDbType.Int);
                myComm.Parameters["@p1"].Value = idClient;

                myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p2"].Value = passportClient;

                myComm.Parameters.Add("@p3", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p3"].Value = nameClient;

                myComm.Parameters.Add("@p4", SqlDbType.Date);
                myComm.Parameters["@p4"].Value = dateClient;

                myComm.Parameters.Add("@p5", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p5"].Value = numberClient;

                myComm.Parameters.Add("@p6", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p6"].Value = countChildren;

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

        private void info_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (idClient.Trim() == "") throw new Exception();

                client_information form7 = new client_information(idClient, passportClient, nameClient, dateClient, numberClient, countChildren);
                form7.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка. Возможное решение:\n\n " +
                                "1. Возможно вы пытаетесь посмотреть информацию о несуществующих данных.", "Внимание!");
            }
        }

        private void back_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            menu form2 = new menu();
            form2.ShowDialog();
            Close();
        }

        private void loadData()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.Клиент", myConn);

            SqlDataReader myReader = myComm.ExecuteReader();
            DataTable dtbl = new DataTable(); dtbl.Load(myReader);
            dataGridView1.DataSource = dtbl;
            myConn.Close();

            // Разрешаем нулевые значения (иначе событие DataError)
            dtbl.Columns[0].AllowDBNull = true;
            dtbl.Columns[1].AllowDBNull = true;
            dtbl.Columns[2].AllowDBNull = true;
            dtbl.Columns[3].AllowDBNull = true;
            dtbl.Columns[4].AllowDBNull = true;
            dtbl.Columns[5].AllowDBNull = true;

            // Отключаем подстановку номеров 
            dtbl.Columns[0].AutoIncrement = false;

            // Устанавливаем значения по умолчанию переменным (первая строка)
            indexSelectRow = 0;
            idClient = dataGridView1[0, indexSelectRow].Value.ToString();
            passportClient = dataGridView1[1, indexSelectRow].Value.ToString();
            nameClient = dataGridView1[2, indexSelectRow].Value.ToString();
            dateClient = dataGridView1[3, indexSelectRow].Value.ToString();
            numberClient = dataGridView1[4, indexSelectRow].Value.ToString();
            countChildren = dataGridView1[5, indexSelectRow].Value.ToString();
        }
    }
}
