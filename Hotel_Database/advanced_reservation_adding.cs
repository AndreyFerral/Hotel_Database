using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class advanced_reservation_adding : Form
    {
        SqlConnection myConn = new SqlConnection();

        public advanced_reservation_adding()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;

            // Заполняем объект типа ComboBox
            workerComboBox();
            roomComboBox();
            clientComboBox();
        }

        private void workerComboBox()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("select ФИО_сотрудника from Сотрудники", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            comboBox2.DisplayMember = "ФИО_сотрудника";
            comboBox2.DataSource = dtbl;
        }

        private void roomComboBox()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("select Номер_комнаты from Номер", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            comboBox1.DisplayMember = "Номер_комнаты";
            comboBox1.DataSource = dtbl;
        }

        private void clientComboBox()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("select ФИО_клиента from Клиент", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            comboBox3.DisplayMember = "ФИО_клиента";
            comboBox3.DataSource = dtbl;
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                // Данные бронирования
                string roomNumber = comboBox1.Text;
                string workerName = comboBox2.Text;
                string clientName = comboBox3.Text;
                string dateReservation = dateTimePicker1.Text + " " + dateTimePicker2.Text;
                string scheduledDateArrival = dateTimePicker3.Text + " " + dateTimePicker4.Text;
                string scheduledDateLeave = dateTimePicker5.Text + " " + dateTimePicker6.Text;
                string peopleNum = textBox7.Text;
                string reservationType = comboBox4.Text;
                string reservaionPrice = textBox9.Text;

                // Данные клиента
                string passportClient = textBox12.Text;
                string dateClient = dateTimePicker7.Text;
                string numberClient = textBox14.Text;
                string countChildren = textBox15.Text;

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
                procedure = procedure + ", @clientPassport = @p10, @clientBirthday = @p11," +
                    " @clientPhone = @p12, @clientChildCount = @p13";

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
                myComm.Parameters["@p10"].Value = passportClient;

                myComm.Parameters.Add("@p11", SqlDbType.Date);
                myComm.Parameters["@p11"].Value = dateClient;

                myComm.Parameters.Add("@p12", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p12"].Value = numberClient;

                myComm.Parameters.Add("@p13", SqlDbType.NVarChar, 100);
                myComm.Parameters["@p13"].Value = countChildren;


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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "с предоплатой") textBox9.ReadOnly = false;
            if (comboBox4.Text == "без предоплаты")
            {
                textBox9.ReadOnly = true;
                textBox9.Text = "0,0000";
            }
        }
    }
}
