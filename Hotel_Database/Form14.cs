using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class Form14 : Form
    {
        SqlConnection myConn = new SqlConnection();
        int indexSelectRow;
        string idReservation, roomNumber, workerName, clientName,
            dateReservation, scheduledDateArrival, scheduledDateLeave, 
            peopleNum, reservationType, reservaionPrice;

        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;

            // Заполняем объект типа ComboBox            
            nameStaffComboBox();
            idRoomComboBox();
            nameClientComboBox();

            // Запускаем процедуру выборки данных
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Для того, чтобы не обновлялись значения, если нажатия происходит в одной строке
            if (e.RowIndex != indexSelectRow)
            {
                indexSelectRow = e.RowIndex;

                idReservation = dataGridView1[0, indexSelectRow].Value.ToString();
                roomNumber = dataGridView1[1, indexSelectRow].Value.ToString();
                workerName = dataGridView1[2, indexSelectRow].Value.ToString();
                clientName = dataGridView1[3, indexSelectRow].Value.ToString();
                dateReservation = dataGridView1[4, indexSelectRow].Value.ToString();
                scheduledDateArrival = dataGridView1[5, indexSelectRow].Value.ToString();
                scheduledDateLeave = dataGridView1[6, indexSelectRow].Value.ToString();
                peopleNum = dataGridView1[7, indexSelectRow].Value.ToString();
                reservationType = dataGridView1[8, indexSelectRow].Value.ToString();
                reservaionPrice = dataGridView1[9, indexSelectRow].Value.ToString();
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
            try
            {
                if (idReservation.Trim() == "") throw new Exception();

                Form15 form15 = new Form15(idReservation, roomNumber, workerName, clientName,
                                            dateReservation, scheduledDateArrival, scheduledDateLeave,
                                            peopleNum, reservationType, reservaionPrice);

                form15.ShowDialog();
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


        private void nameStaffComboBox()
        {
            myConn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select ФИО_сотрудника from Сотрудники", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            worker_name.DisplayMember = "ФИО_сотрудника";
            worker_name.DataSource = dtbl;

            myConn.Close();
        }

        private void idRoomComboBox()
        {
            myConn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select Номер_комнаты from Номер", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            number_room.DisplayMember = "Номер_комнаты";
            number_room.DataSource = dtbl;

            myConn.Close();
        }

        private void nameClientComboBox()
        {
            myConn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select ФИО_клиента from Клиент", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            client_name.DisplayMember = "ФИО_клиента";
            client_name.DataSource = dtbl;

            myConn.Close();
        }

        private void loadData()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.View_Reservation", myConn);

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
            dtbl.Columns[6].AllowDBNull = true;
            dtbl.Columns[7].AllowDBNull = true;
            dtbl.Columns[8].AllowDBNull = true;

            // Устанавливаем значения по умолчанию переменным (первая строка)
            indexSelectRow = 0;

            // Если в таблице есть минимум одна запись
            if (dataGridView1.Rows.Count > 1)
            {
                idReservation = dataGridView1[0, indexSelectRow].Value.ToString();
                roomNumber = dataGridView1[1, indexSelectRow].Value.ToString();
                workerName = dataGridView1[2, indexSelectRow].Value.ToString();
                clientName = dataGridView1[3, indexSelectRow].Value.ToString();
                dateReservation = dataGridView1[4, indexSelectRow].Value.ToString();
                scheduledDateArrival = dataGridView1[5, indexSelectRow].Value.ToString();
                scheduledDateLeave = dataGridView1[6, indexSelectRow].Value.ToString();
                peopleNum = dataGridView1[7, indexSelectRow].Value.ToString();
                reservationType = dataGridView1[8, indexSelectRow].Value.ToString();
                reservaionPrice = dataGridView1[9, indexSelectRow].Value.ToString();
            }
        }
    }
}
