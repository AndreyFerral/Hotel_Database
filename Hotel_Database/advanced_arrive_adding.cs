using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class Form16 : Form
    {
        SqlConnection myConn = new SqlConnection();

        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;

            // Заполняем объект типа ComboBox
            workerComboBox();
            roomComboBox();
            clientComboBox();
            reservationComboBox();
        }

        private void workerComboBox()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("select ФИО_сотрудника from Сотрудники", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            comboBox1.DisplayMember = "ФИО_сотрудника";
            comboBox1.DataSource = dtbl;
        }

        private void roomComboBox()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("select [номер_комнаты], [info] from get_available_rooms() order by 1", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            comboBox2.DataSource = dtbl; // Источник
            comboBox2.ValueMember = "Номер_комнаты"; // Реальное значение
            comboBox2.DisplayMember = "info"; // Отображаемое значение
        }

        private void clientComboBox()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("select ФИО_клиента from Клиент", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            comboBox3.DisplayMember = "ФИО_клиента";
            comboBox3.DataSource = dtbl;
        }

        private void reservationComboBox()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("select id_Бронирование from Бронирование", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            // Добавляем пустое значение в ComboBox
            dtbl.Rows.Add();

            //comboBox4.DisplayMember = "id_Бронирование";
           // comboBox4.DataSource = dtbl;
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                // Данные заезда
                string nameStaff = comboBox1.Text;
                string idRoom = comboBox2.Text.Split()[0];
                string nameClient = comboBox3.Text;
               //string idReservation = comboBox4.Text;
                string pricePerStay = textBox5.Text;
                string priceForAddServe = textBox6.Text;
                string fine = textBox7.Text;
                string scheduledDateLeave = dateTimePicker1.Text + " " + dateTimePicker2.Text;
                string dateArrival = dateTimePicker3.Text + " " + dateTimePicker4.Text;
               // string dateLeave = dateTimePicker5.Text + " " + dateTimePicker6.Text;
                string peopleNum = textBox11.Text;

                // Данные клиента
                string passportClient = textBox12.Text;
                string dateClient = dateTimePicker7.Text;
                string numberClient = textBox14.Text;
                string countChildren = textBox15.Text;


                myConn.Open();
                // Остальные поля могут быть нулевыми
                if (nameStaff.Trim() == "" || idRoom.Trim() == "" ||
                    nameClient.Trim() == "" || scheduledDateLeave.Trim() == "" ||
                    dateArrival.Trim() == "" || peopleNum.Trim() == "") throw new Exception();

                string procedure = "execute add_arrival @workerName = @p1, @clientName = @p2, @room = @p3, ";
               // if (idReservation != "") procedure = procedure + "@idReservation = @p4, ";
                if (pricePerStay != "") procedure = procedure + "@pricePerStay = @p5, ";
                if (priceForAddServe != "") procedure = procedure + "@priceForAddServe = @p6, ";
                if (fine != "") procedure = procedure + "@fine = @p7, ";
                procedure = procedure + "@dateArrival = @p8, @scheduledDateLeave = @p9, ";
                //if (dateLeave != "") procedure = procedure + "@dateLeave = @p10, ";
                procedure = procedure + "@peopleNum = @p11, @clientPassport = @p12, " +
                    "@clientBirthday = @p13, @clientPhone = @p14, @clientChildCount = @p15";

                // Создать команду для добавления
                SqlCommand myComm = new SqlCommand(procedure, myConn);

                // Создать параметр и передать в него значение текстового поля 
                myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p1"].Value = nameStaff;

                myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p2"].Value = nameClient;

                myComm.Parameters.Add("@p3", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p3"].Value = idRoom;

                //if (idReservation != "") {
                //    myComm.Parameters.Add("@p4", SqlDbType.NVarChar, 100);
                //    myComm.Parameters["@p4"].Value = idReservation;
               // }

                if (pricePerStay != "") {
                    myComm.Parameters.Add("@p5", SqlDbType.Money, 100);
                    myComm.Parameters["@p5"].Value = pricePerStay;
                }

                if (priceForAddServe != "") {
                    myComm.Parameters.Add("@p6", SqlDbType.Money, 100);
                    myComm.Parameters["@p6"].Value = priceForAddServe;
                }

                if (fine != "") {
                    myComm.Parameters.Add("@p7", SqlDbType.Money, 100);
                    myComm.Parameters["@p7"].Value = fine;
                }

                myComm.Parameters.Add("@p8", SqlDbType.SmallDateTime);
                myComm.Parameters["@p8"].Value = dateArrival;

                myComm.Parameters.Add("@p9", SqlDbType.SmallDateTime);
                myComm.Parameters["@p9"].Value = scheduledDateLeave;

                /*
                if (dateLeave != "")
                {
                    myComm.Parameters.Add("@p10", SqlDbType.SmallDateTime);
                    myComm.Parameters["@p10"].Value = dateLeave;
                }
                */

                myComm.Parameters.Add("@p11", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p11"].Value = peopleNum;

                myComm.Parameters.Add("@p12", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p12"].Value = passportClient;

                myComm.Parameters.Add("@p13", SqlDbType.Date);
                myComm.Parameters["@p13"].Value = dateClient;

                myComm.Parameters.Add("@p14", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p14"].Value = numberClient;

                myComm.Parameters.Add("@p15", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p15"].Value = countChildren;

                // Выполнить запрос на изменение без возвращения результата
                myComm.ExecuteNonQuery();
                myConn.Close();
            }
            catch
            {
                myConn.Close();
                MessageBox.Show("Ошибка. Возможное решение:\n\n " +
                                " 1. Возможно вы пытаетесь добавить пустую строку.", "Внимание!");
            }

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
