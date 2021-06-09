using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Database
{
    public partial class universal : Form
    {
        SqlConnection myConn = new SqlConnection();

        SqlCommand myCommPlacement = new SqlCommand("select*from dbo.Размещение");
        SqlCommand myCommComfort = new SqlCommand("select*from dbo.Комфортность");
        SqlCommand myCommStaff = new SqlCommand("select*from dbo.Сотрудники");

        SqlCommand myCommService = new SqlCommand("select*from dbo.Дополнительные_услуги");
        string idService, nameService, costService;
        int indexSelectRow;

        SqlDataAdapter sda = new SqlDataAdapter(); DataSet ds = new DataSet();
        int idNumberTable;

        public universal(int idNumberTable)
        {
            InitializeComponent();
            this.idNumberTable = idNumberTable;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Получаем строку подключения из параметров
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            // Создаем подключение 
            myConn.ConnectionString = StrConn;
            myConn.Open();

            switch (idNumberTable)
            {
                case 1:
                    {
                        // Устанавливаем заголовок формы
                        this.Text = "Список размещений";

                        info_ToolStripMenuItem.Visible = false;

                        // Настраиваем стобец "Номер размещения"
                        id.HeaderText = "Номер размещения";
                        id.DataPropertyName = "id_Размещение";

                        // Настраиваем стобец "Название"
                        name.HeaderText = "Название";
                        name.DataPropertyName = "Название";

                        // Избавляемся от ненужных столбцов
                        dataGridView1.Columns.Remove(passport);
                        dataGridView1.Columns.Remove(date);
                        dataGridView1.Columns.Remove(address);
                        dataGridView1.Columns.Remove(number);
                        dataGridView1.Columns.Remove(post);
                        dataGridView1.Columns.Remove(cost);

                        // Выборка создания и заполнения в DataSet таблицы
                        myCommPlacement.Connection = myConn;
                        sda.SelectCommand = myCommPlacement;

                        sda.Fill(ds, "Размещение");
                        dataGridView1.DataSource = ds.Tables["Размещение"];
                    }
                    break;
                case 2:
                    {
                        // Устанавливаем заголовок формы
                        this.Text = "Список комфортностей";

                        info_ToolStripMenuItem.Visible = false;

                        // Настраиваем стобец "Номер комфортности"
                        id.HeaderText = "Номер комфортности";
                        id.DataPropertyName = "id_Комфортность";

                        // Настраиваем стобец "Название"
                        name.HeaderText = "Название";
                        name.DataPropertyName = "Название";

                        // Избавляемся от ненужных столбцов
                        dataGridView1.Columns.Remove(passport);
                        dataGridView1.Columns.Remove(date);
                        dataGridView1.Columns.Remove(address);
                        dataGridView1.Columns.Remove(number);
                        dataGridView1.Columns.Remove(post);
                        dataGridView1.Columns.Remove(cost);

                        // Выборка создания и заполнения в DataSet таблицы
                        myCommComfort.Connection = myConn;
                        sda.SelectCommand = myCommComfort;

                        sda.Fill(ds, "Комфортность");
                        dataGridView1.DataSource = ds.Tables["Комфортность"];
                    }
                    break;
                case 3:
                    {
                        // Устанавливаем заголовок формы
                        this.Text = "Список дополнительных услуг";

                        // Настраиваем стобец "Номер услуги"
                        id.HeaderText = "Номер услуги";
                        id.DataPropertyName = "id_Дополнительные_услуги";

                        // Настраиваем стобец "Название"
                        name.HeaderText = "Название";
                        name.DataPropertyName = "Название";

                        // Настраиваем столбец "Цена"
                        cost.HeaderText = "Цена";
                        cost.DataPropertyName = "Цена";

                        // Избавляемся от ненужных столбцов
                        dataGridView1.Columns.Remove(passport);
                        dataGridView1.Columns.Remove(date);
                        dataGridView1.Columns.Remove(address);
                        dataGridView1.Columns.Remove(number);
                        dataGridView1.Columns.Remove(post);

                        // Выборка создания и заполнения в DataSet таблицы
                        myCommService.Connection = myConn;
                        sda.SelectCommand = myCommService;

                        sda.Fill(ds, "Услуга");
                        dataGridView1.DataSource = ds.Tables["Услуга"];

                        // Если пользователь нажмет просмотр информации без выбора записи
                        idService = dataGridView1[0, indexSelectRow].Value.ToString();
                        nameService = dataGridView1[1, indexSelectRow].Value.ToString();
                        costService = dataGridView1[2, indexSelectRow].Value.ToString();
                    }
                    break;
                case 4:
                    {
                        // Устанавливаем заголовок формы
                        this.Text = "Список сотрудников";

                        info_ToolStripMenuItem.Visible = false;

                        // Устанавливаем размер формы
                        this.Width = 1000;
                        this.Height = 500;

                        // Перемещаем форму в центр
                        this.CenterToScreen();

                        // Настраиваем стобец "Номер сотрудника"
                        id.HeaderText = "Номер сотрудника";
                        id.DataPropertyName = "id_Сотрудники";

                        // Настраиваем стобец "ФИО"
                        name.HeaderText = "ФИО";
                        name.DataPropertyName = "ФИО_Сотрудника";

                        // Настраиваем столбец "Паспорт"
                        passport.DataPropertyName = "Номер_и_серия_паспорта";
                        passport.HeaderText = "Паспорт";

                        // Настраиваем столбец "Дата рождения"
                        date.HeaderText = "Дата рождения";
                        date.DataPropertyName = "Дата_рождения";

                        // Настраиваем столбец "Адрес проживания"
                        address.HeaderText = "Адрес проживания";
                        address.DataPropertyName = "Адрес_проживания";

                        // Настраиваем столбец "Номер телефона"
                        number.HeaderText = "Номер телефона";
                        number.DataPropertyName = "Номер_телефона";

                        // Настраиваем столбец "Должность"
                        post.HeaderText = "Должность";
                        post.DataPropertyName = "Должность";

                        // Избавляемся от ненужных столбцов
                        dataGridView1.Columns.Remove(cost);

                        // Выборка создания и заполнения в DataSet таблицы
                        myCommStaff.Connection = myConn;
                        sda.SelectCommand = myCommStaff;

                        sda.Fill(ds, "Сотрудник");
                        dataGridView1.DataSource = ds.Tables["Сотрудник"];
                    }
                    break;
            }

            dataGridView1.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (idNumberTable == 3)
            {
                // Для того, чтобы не обновлялись значения, если нажатия происходит в одной строке
                if (e.RowIndex != indexSelectRow && e.RowIndex != -1)
                {
                    indexSelectRow = e.RowIndex;

                    idService = dataGridView1[0, indexSelectRow].Value.ToString();
                    nameService = dataGridView1[1, indexSelectRow].Value.ToString();
                    costService = dataGridView1[2, indexSelectRow].Value.ToString();
                }
            }
        }

        private void add_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (idNumberTable)
            {
                case 1: 
                    ds.Tables["Размещение"].Rows.Add();
                    break;
                case 2:
                    ds.Tables["Комфортность"].Rows.Add();
                    break;
                case 3:
                    ds.Tables["Услуга"].Rows.Add();
                    break;
                case 4:
                    ds.Tables["Сотрудник"].Rows.Add();
                    break;
            }

        }

        private void delete_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Данная информация будет удалена. Продолжить?", "Внимание!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(rowIndex);
                }
            }
            catch { MessageBox.Show("Почему-то вызвалось исключение.", "Внимание!"); }
        }

        private void save_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем команды манипулирования данными
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                scb.GetUpdateCommand(); scb.GetDeleteCommand(); scb.GetInsertCommand();

                // Отправляем изменения в БД
                switch (idNumberTable)
                {
                    case 1:
                        sda.Update(ds.Tables["Размещение"]);
                        break;
                    case 2:
                        sda.Update(ds.Tables["Комфортность"]);
                        break;
                    case 3:
                        sda.Update(ds.Tables["Услуга"]);
                        break;
                    case 4:
                        sda.Update(ds.Tables["Сотрудник"]);
                        break;
                }

            }
            catch { MessageBox.Show("Необходимо заполнить добавленную строку", "Внимание!"); }
        }
        private void info_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (idService.Trim() == "") throw new Exception();

                service_information form8 = new service_information(idService, nameService, costService);
                form8.ShowDialog();
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


    }
}
