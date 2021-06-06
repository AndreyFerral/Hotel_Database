using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class Form11 : Form
    {
        SqlConnection myConn = new SqlConnection();
        int indexSelectRow;
        string idАrrival, nameStaff, idRoom, nameClient, idReservation, 
            pricePerStay, priceForAddServe, fine, scheduledDateLeave, 
            dateArrival, dateLeave, peopleNum;

        private void back_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Close();
        }

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;

            // Заполняем объект типа ComboBox            
            nameStaffComboBox();
            idRoomComboBox();
            nameClientComboBox();
            idReservationComboBox();


            // Запускаем процедуру выборки данных
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Для того, чтобы не обновлялись значения, если нажатия происходит в одной строке
            if (e.RowIndex != indexSelectRow)
            {
                indexSelectRow = e.RowIndex;

                idАrrival = dataGridView1[0, indexSelectRow].Value.ToString();
                nameStaff = dataGridView1[1, indexSelectRow].Value.ToString();
                idRoom = dataGridView1[2, indexSelectRow].Value.ToString();
                nameClient = dataGridView1[3, indexSelectRow].Value.ToString();
                idReservation = dataGridView1[4, indexSelectRow].Value.ToString();
                pricePerStay = dataGridView1[5, indexSelectRow].Value.ToString();
                priceForAddServe = dataGridView1[6, indexSelectRow].Value.ToString();
                fine = dataGridView1[7, indexSelectRow].Value.ToString();
                scheduledDateLeave = dataGridView1[8, indexSelectRow].Value.ToString();
                dateArrival = dataGridView1[9, indexSelectRow].Value.ToString();
                dateLeave = dataGridView1[10, indexSelectRow].Value.ToString();
                peopleNum = dataGridView1[11, indexSelectRow].Value.ToString();
            }
        }

        private void nameStaffComboBox()
        {
            myConn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select ФИО_сотрудника from Сотрудники", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            name_staff.DisplayMember = "ФИО_сотрудника";
            name_staff.DataSource = dtbl;

            myConn.Close();
        }

        private void idRoomComboBox()
        {
            myConn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select Номер_комнаты from Номер", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            id_room.DisplayMember = "Номер_комнаты";
            id_room.DataSource = dtbl;

            myConn.Close();
        }

        private void nameClientComboBox()
        {
            myConn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select ФИО_клиента from Клиент", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            name_client.DisplayMember = "ФИО_клиента";
            name_client.DataSource = dtbl;

            myConn.Close();
        }

        private void idReservationComboBox()
        {
            myConn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("select id_Бронирование from Бронирование", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            // Добавляем пустое значение в ComboBox
            dtbl.Rows.Add();

            id_reservation.DisplayMember = "id_Бронирование";
            id_reservation.DataSource = dtbl;

            myConn.Close();
        }

        private void loadData()
        {
            myConn.Open();
            SqlCommand myComm = new SqlCommand("select*from dbo.View_Arrival", myConn);

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
            dtbl.Columns[9].AllowDBNull = true;
            dtbl.Columns[10].AllowDBNull = true;
            dtbl.Columns[11].AllowDBNull = true;

            // Устанавливаем значения по умолчанию переменным (первая строка)
            indexSelectRow = 0;

            // Если в таблице есть минимум одна запись
            if (dataGridView1.Rows.Count > 1)
            {
                idАrrival = dataGridView1[0, indexSelectRow].Value.ToString();
                nameStaff = dataGridView1[1, indexSelectRow].Value.ToString();
                idRoom = dataGridView1[2, indexSelectRow].Value.ToString();
                nameClient = dataGridView1[3, indexSelectRow].Value.ToString();
                idReservation = dataGridView1[4, indexSelectRow].Value.ToString();
                pricePerStay = dataGridView1[5, indexSelectRow].Value.ToString();
                priceForAddServe = dataGridView1[6, indexSelectRow].Value.ToString();
                fine = dataGridView1[7, indexSelectRow].Value.ToString();
                scheduledDateLeave = dataGridView1[8, indexSelectRow].Value.ToString();
                dateArrival = dataGridView1[9, indexSelectRow].Value.ToString();
                dateLeave = dataGridView1[10, indexSelectRow].Value.ToString();
                peopleNum = dataGridView1[11, indexSelectRow].Value.ToString();
            }
        }
    }
}
