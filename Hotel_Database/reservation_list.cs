using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class reservation_list : Form
    {
        SqlConnection myConn = new SqlConnection();
        int indexSelectRow;
        string idReservation, roomNumber, workerName, clientName,
            dateReservation, scheduledDateArrival, scheduledDateLeave, 
            peopleNum, reservationType, reservaionPrice;

        public reservation_list()
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
            if (e.RowIndex != indexSelectRow && e.RowIndex != -1)
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

        private void addBig_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advanced_reservation_adding form17 = new advanced_reservation_adding();
            form17.ShowDialog();

            // Перезапускаем форму для обновления данных
            this.Hide();
            reservation_list form14 = new reservation_list();
            form14.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dataGridView1.Rows.Count - 1 && e.RowIndex != -1)
                if (e.ColumnIndex == 9 || e.ColumnIndex == 8)
                {
                    if (dataGridView1[8, e.RowIndex].Value.ToString() == "с предоплатой")
                        dataGridView1[9, e.RowIndex].ReadOnly = false;
                    if (dataGridView1[8, e.RowIndex].Value.ToString() == "без предоплаты")
                    {
                        dataGridView1[9, e.RowIndex].ReadOnly = true;
                        dataGridView1[9, e.RowIndex].Value = "0,0000";       
                    }
                }
        }

        private void add_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Берем значения для добавления из предпоследней строчки (последняя - пустая)
                indexSelectRow = dataGridView1.Rows.Count - 2;
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

                // надо фиксить - если запятой не будет, то исключение
                // удаляем лишние знаки
                /*
                reservaionPrice = pricePerStay.Substring(0, pricePerStay.LastIndexOf(','));
                */

                myConn.Open();
                // Остальные поля могут быть нулевыми
                if (roomNumber.Trim() == "" || workerName.Trim() == "" ||
                    clientName.Trim() == "" || dateReservation.Trim() == "" ||
                    scheduledDateArrival.Trim() == "" || scheduledDateLeave.Trim() == "") throw new Exception();

                // Если три последних поля оставить пустыми, то они установятся по умолчанию
                string procedure = "execute add_reservation @workerName = @p1, @clientName = @p2, @room = @p3, " +
                    "@dateReservation = @p4, @scheduledDateArrival = @p5, @scheduledDateLeave = @p6";
                if (peopleNum != "") procedure = procedure + ", @peopleNum = @p7";
                if (reservationType != "") procedure = procedure + ", @reservationType = @p8";
                if (reservaionPrice != "") procedure = procedure + ", @reservaionPrice = @p9";

                // Создать команду для добавления
                SqlCommand myComm = new SqlCommand(procedure, myConn);

                // Создать параметр и передать в него значение текстового поля 
                myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p1"].Value = workerName;

                myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p2"].Value = clientName;

                myComm.Parameters.Add("@p3", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p3"].Value = roomNumber;

                myComm.Parameters.Add("@p4", SqlDbType.SmallDateTime, 100);
                myComm.Parameters["@p4"].Value = dateReservation;
                
                myComm.Parameters.Add("@p5", SqlDbType.SmallDateTime, 100);
                myComm.Parameters["@p5"].Value = scheduledDateArrival;
                
                myComm.Parameters.Add("@p6", SqlDbType.SmallDateTime, 100);
                myComm.Parameters["@p6"].Value = scheduledDateLeave;
                
                if (peopleNum != "") {
                    myComm.Parameters.Add("@p7", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p7"].Value = peopleNum;
                }

                if (reservationType != "") {
                    myComm.Parameters.Add("@p8", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p8"].Value = reservationType;
                }

                if (reservaionPrice != "") {
                    myComm.Parameters.Add("@p9", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p9"].Value = reservaionPrice;
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
                    if (idReservation == "") throw new Exception();

                    // Создать команду для удаления
                    SqlCommand myComm = new SqlCommand("execute delete_reservation @p1", myConn);

                    // Создать параметр и передать в него значение текстового поля 
                    myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p1"].Value = idReservation;

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
                // Берем значения для добавления из предпоследней строчки (последняя - пустая)
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

                // надо фиксить - если запятой не будет, то исключение
                // удаляем лишние знаки
                /*
                reservaionPrice = pricePerStay.Substring(0, pricePerStay.LastIndexOf(','));
                */

                myConn.Open();
                // Остальные поля могут быть нулевыми
                if (roomNumber.Trim() == "" || workerName.Trim() == "" ||
                    clientName.Trim() == "" || dateReservation.Trim() == "" ||
                    scheduledDateArrival.Trim() == "" || scheduledDateLeave.Trim() == "") throw new Exception();

                // Если три последних поля оставить пустыми, то они установятся по умолчанию
                string procedure = "execute update_reservation @idReservation = @p10, @workerName = @p1, @clientName = @p2, @room = @p3, " +
                    "@dateReservation = @p4, @scheduledDateArrival = @p5, @scheduledDateLeave = @p6";
                if (peopleNum != "") procedure = procedure + ", @peopleNum = @p7";
                if (reservationType != "") procedure = procedure + ", @reservationType = @p8";
                if (reservaionPrice != "") procedure = procedure + ", @reservaionPrice = @p9";

                // Создать команду для добавления
                SqlCommand myComm = new SqlCommand(procedure, myConn);

                // Создать параметр и передать в него значение текстового поля 
                myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p1"].Value = workerName;

                myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p2"].Value = clientName;

                myComm.Parameters.Add("@p3", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p3"].Value = roomNumber;

                myComm.Parameters.Add("@p4", SqlDbType.SmallDateTime, 100);
                myComm.Parameters["@p4"].Value = dateReservation;

                myComm.Parameters.Add("@p5", SqlDbType.SmallDateTime, 100);
                myComm.Parameters["@p5"].Value = scheduledDateArrival;

                myComm.Parameters.Add("@p6", SqlDbType.SmallDateTime, 100);
                myComm.Parameters["@p6"].Value = scheduledDateLeave;

                if (peopleNum != "") {
                    myComm.Parameters.Add("@p7", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p7"].Value = peopleNum;
                }

                if (reservationType != "") {
                    myComm.Parameters.Add("@p8", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p8"].Value = reservationType;
                }

                if (reservaionPrice != "") {
                    myComm.Parameters.Add("@p9", SqlDbType.NVarChar, 100);
                    myComm.Parameters["@p9"].Value = reservaionPrice;
                }

                myComm.Parameters.Add("@p10", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p10"].Value = idReservation;

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
                if (idReservation.Trim() == "") throw new Exception();

                reservation_information form15 = new reservation_information(idReservation, roomNumber, workerName, clientName,
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
            main_menu form2 = new main_menu();
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
            dtbl.Columns[9].AllowDBNull = true;

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
