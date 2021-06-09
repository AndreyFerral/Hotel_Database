using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class Form4 : Form
    {
        SqlConnection myConn = new SqlConnection();
        int indexSelectRow;
        string idChildren, nameParent, nameChildren, dateChildren;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;

            // Заполняем объект типа ComboBox
            loadDataComboBox();

            // Запускаем процедуру выборки данных
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Для того, чтобы не обновлялись значения, если нажатия происходит в одной строке
            if (e.RowIndex != indexSelectRow && e.RowIndex != -1)
            {
                indexSelectRow = e.RowIndex;

                idChildren = dataGridView1[0, indexSelectRow].Value.ToString();
                nameParent = dataGridView1[1, indexSelectRow].Value.ToString();
                nameChildren = dataGridView1[2, indexSelectRow].Value.ToString();
                dateChildren = dataGridView1[3, indexSelectRow].Value.ToString();
            }
        }

        private void add_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Берем значения для добавления из предпоследней строчки (последняя - пустая)
                indexSelectRow = dataGridView1.Rows.Count - 2;
                idChildren = dataGridView1[0, indexSelectRow].Value.ToString();
                nameParent = dataGridView1[1, indexSelectRow].Value.ToString();
                nameChildren = dataGridView1[2, indexSelectRow].Value.ToString();
                dateChildren = dataGridView1[3, indexSelectRow].Value.ToString();

                myConn.Open();
                if (nameParent.Trim() == "" || nameChildren.Trim() == "" ||
                    dateChildren.Trim() == "") throw new Exception();

                // Создать команду для добавления
                SqlCommand myComm = new SqlCommand("execute add_child @p1, @p2, @p3", myConn);

                // Создать параметр и передать в него значение текстового поля 
                myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p1"].Value = nameParent;

                myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p2"].Value = nameChildren;

                myComm.Parameters.Add("@p3", SqlDbType.Date);
                myComm.Parameters["@p3"].Value = dateChildren;

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
                    if (idChildren == "") throw new Exception();

                    // Создать команду для удаления
                    SqlCommand myComm = new SqlCommand("execute delete_child @p1", myConn);

                    // Создать параметр и передать в него значение текстового поля 
                    myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 10);
                    myComm.Parameters["@p1"].Value = idChildren;

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
                idChildren = dataGridView1[0, indexSelectRow].Value.ToString();
                nameParent = dataGridView1[1, indexSelectRow].Value.ToString();
                nameChildren = dataGridView1[2, indexSelectRow].Value.ToString();
                dateChildren = dataGridView1[3, indexSelectRow].Value.ToString();

                if (nameParent.Trim() == "" || nameChildren.Trim() == "" ||
                    dateChildren.Trim() == "") throw new Exception();

                // Создать команду для изменения
                SqlCommand myComm = new SqlCommand("execute update_child @p1, @p2, @p3, @p4", myConn);

                // Создать параметр и передать в него значение текстового поля 
                myComm.Parameters.Add("@p1", SqlDbType.Int);
                myComm.Parameters["@p1"].Value = idChildren;

                myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p2"].Value = nameParent;

                myComm.Parameters.Add("@p3", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p3"].Value = nameChildren;

                myComm.Parameters.Add("@p4", SqlDbType.Date);
                myComm.Parameters["@p4"].Value = dateChildren;

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
                if (idChildren.Trim() == "") throw new Exception();

                Form5 form5 = new Form5(idChildren, nameParent, nameChildren, dateChildren);
                form5.ShowDialog();
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
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Close();
        }

        private void loadDataComboBox()
        {
            myConn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select ФИО_клиента from Клиент", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            name_parent.DisplayMember = "ФИО_клиента";
            name_parent.DataSource = dtbl;

            myConn.Close();
        }

        private void loadData()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.View_ClientChild", myConn);

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
                idChildren = dataGridView1[0, indexSelectRow].Value.ToString();
                nameParent = dataGridView1[1, indexSelectRow].Value.ToString();
                nameChildren = dataGridView1[2, indexSelectRow].Value.ToString();
                dateChildren = dataGridView1[3, indexSelectRow].Value.ToString();
            }
        }
    }
}
