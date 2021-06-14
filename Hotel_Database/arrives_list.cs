using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class arrives_list : Form
    {
        SqlConnection myConn = new SqlConnection();
        int indexSelectRow;
        string idАrrival, nameStaff, idRoom, nameClient, idReservation, 
            pricePerStay, priceForAddServe, fine, scheduledDateLeave, 
            dateArrival, dateLeave, peopleNum;

        public arrives_list()
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

        private void addBig_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.ShowDialog();

            // Перезапускаем форму для обновления данных
            this.Hide();
            arrives_list form11 = new arrives_list();
            form11.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Для того, чтобы не обновлялись значения, если нажатия происходит в одной строке
            if (e.RowIndex != indexSelectRow && e.RowIndex != -1)
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
        private void add_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Берем значения для добавления из предпоследней строчки (последняя - пустая)
                indexSelectRow = dataGridView1.Rows.Count - 2;
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

                myConn.Open();

                string procedure = "execute add_arrival ";

                if (nameStaff != "") procedure = procedure + "@workerName = @p1, ";
                if (nameClient != "") procedure = procedure + "@clientName = @p2, ";
                if (idRoom != "") procedure = procedure + "@room = @p3, ";
                if (idReservation != "") procedure = procedure + "@idReservation = @p4, ";
                if (pricePerStay != "") procedure = procedure + "@pricePerStay = @p5, ";
                if (priceForAddServe != "") procedure = procedure + "@priceForAddServe = @p6, ";
                if (fine != "") procedure = procedure + "@fine = @p7, ";
                procedure = procedure + "@dateArrival = @p8, ";
                if (scheduledDateLeave != "") procedure = procedure + "@scheduledDateLeave = @p9, ";
                if (dateLeave != "") procedure = procedure + "@dateLeave = @p10, ";
                procedure = procedure + "@peopleNum = @p11";
                // Создать команду для добавления
                SqlCommand myComm = new SqlCommand(procedure, myConn);


                // Создать параметр и передать в него значение текстового поля 
                if (nameStaff != "")
                {
                    myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p1"].Value = nameStaff;
                }
                if (nameClient != "")
                {
                    myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p2"].Value = nameClient;
                }
                if (idRoom != "")
                {
                    myComm.Parameters.Add("@p3", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p3"].Value = idRoom;
                }

                if (idReservation != "")
                {
                    myComm.Parameters.Add("@p4", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p4"].Value = idReservation;
                }
                if (pricePerStay != "")
                {
                    myComm.Parameters.Add("@p5", SqlDbType.Money);
                    myComm.Parameters["@p5"].Value = pricePerStay;
                }
                if (priceForAddServe != "")
                {
                    myComm.Parameters.Add("@p6", SqlDbType.Money);
                    myComm.Parameters["@p6"].Value = priceForAddServe;
                }
                if (fine != "")
                {
                    myComm.Parameters.Add("@p7", SqlDbType.Money);
                    myComm.Parameters["@p7"].Value = fine;
                }
                myComm.Parameters.Add("@p8", SqlDbType.SmallDateTime);
                myComm.Parameters["@p8"].Value = dateArrival;
                if (scheduledDateLeave != "")
                {
                    myComm.Parameters.Add("@p9", SqlDbType.SmallDateTime);
                    myComm.Parameters["@p9"].Value = scheduledDateLeave;
                }
                if (dateLeave != "")
                {
                    myComm.Parameters.Add("@p10", SqlDbType.SmallDateTime);
                    myComm.Parameters["@p10"].Value = dateLeave;
                }
                if (peopleNum != "")
                {
                    myComm.Parameters.Add("@p11", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p11"].Value = peopleNum;
                }
                else {
                    myComm.Parameters.Add("@p11", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p11"].Value = peopleNum;
                }
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
                    if (idАrrival == "") throw new Exception();

                    // Создать команду для удаления
                    SqlCommand myComm = new SqlCommand("execute delete_arrival @p1", myConn);

                    // Создать параметр и передать в него значение текстового поля 
                    myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p1"].Value = idАrrival;

                    // Выполнить запрос на удаление без возвращения результата
                    myComm.ExecuteReader();
                    myConn.Close();
                    idRoomComboBox();
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

                myConn.Open();
                // Остальные поля могут быть нулевыми
                if (nameStaff.Trim() == "" || idRoom.Trim() == "" ||
                    nameClient.Trim() == "" || scheduledDateLeave.Trim() == "" ||
                    dateArrival.Trim() == "" || peopleNum.Trim() == "") throw new Exception();

                string procedure = "execute update_arrival @workerName = @p1, @clientName = @p2, @room = @p3, ";
                if (idReservation != "") procedure = procedure + "@idReservation = @p4, ";
                if (pricePerStay != "") procedure = procedure + "@pricePerStay = @p5, ";
                if (priceForAddServe != "") procedure = procedure + "@priceForAddServe = @p6, ";
                if (fine != "") procedure = procedure + "@fine = @p7, ";
                procedure = procedure + "@dateArrival = @p8, @scheduledDateLeave = @p9, ";
                if (dateLeave != "") procedure = procedure + "@dateLeave = @p10, ";
                procedure = procedure + "@peopleNum = @p11, @idArrival = @p12";

                // Создать команду для добавления
                SqlCommand myComm = new SqlCommand(procedure, myConn);

                // Создать параметр и передать в него значение текстового поля 
                myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p1"].Value = nameStaff;

                myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p2"].Value = nameClient;

                myComm.Parameters.Add("@p3", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p3"].Value = idRoom;

                if (idReservation != "")
                {
                    myComm.Parameters.Add("@p4", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p4"].Value = idReservation;
                }
                if (pricePerStay != "")
                {
                    myComm.Parameters.Add("@p5", SqlDbType.Money);
                    myComm.Parameters["@p5"].Value = pricePerStay;
                }
                if (priceForAddServe != "")
                {
                    myComm.Parameters.Add("@p6", SqlDbType.Money);
                    myComm.Parameters["@p6"].Value = priceForAddServe;
                }
                if (fine != "")
                {
                    myComm.Parameters.Add("@p7", SqlDbType.Money);
                    myComm.Parameters["@p7"].Value = fine;
                }

                myComm.Parameters.Add("@p8", SqlDbType.SmallDateTime);
                myComm.Parameters["@p8"].Value = dateArrival;

                myComm.Parameters.Add("@p9", SqlDbType.SmallDateTime);
                myComm.Parameters["@p9"].Value = scheduledDateLeave;

                if (dateLeave != "")
                {
                    myComm.Parameters.Add("@p10", SqlDbType.SmallDateTime);
                    myComm.Parameters["@p10"].Value = dateLeave;
                }

                myComm.Parameters.Add("@p11", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p11"].Value = peopleNum;

                myComm.Parameters.Add("@p12", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p12"].Value = idАrrival;

                // Выполнить запрос на изменение без возвращения результата
                myComm.ExecuteNonQuery();
                myConn.Close();
                idRoomComboBox();
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
                if (idАrrival.Trim() == "") throw new Exception();

                arrive_information form12 = new arrive_information(idАrrival, nameStaff, idRoom, nameClient, idReservation,
                    pricePerStay, priceForAddServe, fine, scheduledDateLeave,
                    dateArrival, dateLeave, peopleNum);

                form12.ShowDialog();
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

            SqlDataAdapter sqlDa = new SqlDataAdapter("select [номер_комнаты], [info] from get_rooms_with_placement() order by 1", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            id_room.DataSource = dtbl; // Источник
            id_room.ValueMember = "Номер_комнаты"; // Реальное значение
            id_room.DisplayMember = "info"; // Отображаемое значение

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
