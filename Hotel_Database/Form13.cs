using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class Form13 : Form
    {
        SqlConnection myConn = new SqlConnection();
        int indexSelectRow;
        string idRoom, comfortName, placementName, price, state;

        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;

            // Заполняем объект типа ComboBox
            loadDataComboBox1();
            loadDataComboBox2();

            // Запускаем процедуру выборки данных
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Для того, чтобы не обновлялись значения, если нажатия происходит в одной строке
            if (e.RowIndex != indexSelectRow && e.RowIndex != -1)
            {
                indexSelectRow = e.RowIndex;

                idRoom = dataGridView1[0, indexSelectRow].Value.ToString();
                comfortName = dataGridView1[1, indexSelectRow].Value.ToString();
                placementName = dataGridView1[2, indexSelectRow].Value.ToString();
                price = dataGridView1[3, indexSelectRow].Value.ToString();
                state = dataGridView1[4, indexSelectRow].Value.ToString();
            }
        }

        private void add_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Берем значения для добавления из предпоследней строчки (последняя - пустая)
                indexSelectRow = dataGridView1.Rows.Count - 2;
                idRoom = dataGridView1[0, indexSelectRow].Value.ToString();
                comfortName = dataGridView1[1, indexSelectRow].Value.ToString();
                placementName = dataGridView1[2, indexSelectRow].Value.ToString();
                price = dataGridView1[3, indexSelectRow].Value.ToString();
                state = dataGridView1[4, indexSelectRow].Value.ToString();

                myConn.Open();
                if (comfortName.Trim() == "" || placementName.Trim() == "" ||
                    price.Trim() == "" || state.Trim() == "") throw new Exception();

                // Создать команду для добавления
                SqlCommand myComm = new SqlCommand("execute add_room @p1, @p2, @p3, @p4", myConn);

                // Создать параметр и передать в него значение текстового поля 
                myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 40);
                myComm.Parameters["@p1"].Value = comfortName;

                myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 40);
                myComm.Parameters["@p2"].Value = placementName;

                myComm.Parameters.Add("@p3", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p3"].Value = price;

                myComm.Parameters.Add("@p4", SqlDbType.NVarChar, 25);
                myComm.Parameters["@p4"].Value = state;

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
                    if (idRoom == "") throw new Exception();

                    // Создать команду для удаления
                    SqlCommand myComm = new SqlCommand("execute delete_room @p1", myConn);

                    // Создать параметр и передать в него значение текстового поля 
                    myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 10);
                    myComm.Parameters["@p1"].Value = idRoom;

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
                idRoom = dataGridView1[0, indexSelectRow].Value.ToString();
                comfortName = dataGridView1[1, indexSelectRow].Value.ToString();
                placementName = dataGridView1[2, indexSelectRow].Value.ToString();
                price = dataGridView1[3, indexSelectRow].Value.ToString();
                state = dataGridView1[4, indexSelectRow].Value.ToString();

                if (idRoom.Trim() == "") throw new Exception();

                // Создать команду для изменения
                SqlCommand myComm = new SqlCommand("execute update_room @p1, @p2, @p3, @p4, @p5", myConn);

                // Создать параметр и передать в него значение текстового поля 
                myComm.Parameters.Add("@p1", SqlDbType.Int);
                myComm.Parameters["@p1"].Value = idRoom;

                myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p2"].Value = comfortName;

                myComm.Parameters.Add("@p3", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p3"].Value = placementName;

                myComm.Parameters.Add("@p4", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p4"].Value = price;

                myComm.Parameters.Add("@p5", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p5"].Value = state;

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

        }

        private void back_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Close();
        }

        private void loadDataComboBox1()
        {
            myConn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select Название AS Комфортность from Комфортность", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            comfort_name.DisplayMember = "Комфортность";
            comfort_name.DataSource = dtbl;

            myConn.Close();
        }

        private void loadDataComboBox2()
        {
            myConn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select Название AS Размещение from Размещение", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            placement_name.DisplayMember = "Размещение";
            placement_name.DataSource = dtbl;

            myConn.Close();
        }

        private void loadData()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.View_Room", myConn);

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

            // Устанавливаем значения по умолчанию переменным (первая строка)
            indexSelectRow = 0;

            // Если в таблице есть минимум одна запись
            if (dataGridView1.Rows.Count > 1)
            {
                idRoom = dataGridView1[0, indexSelectRow].Value.ToString();
                comfortName = dataGridView1[1, indexSelectRow].Value.ToString();
                placementName = dataGridView1[2, indexSelectRow].Value.ToString();
                price = dataGridView1[3, indexSelectRow].Value.ToString();
                state = dataGridView1[4, indexSelectRow].Value.ToString();
            }
        }
    }
}
