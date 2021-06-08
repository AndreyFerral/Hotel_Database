
namespace Hotel_Database
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.add_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.update_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.back_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_staff = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.id_room = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.name_client = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.id_reservation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBig_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_ToolStripMenuItem,
            this.addBig_ToolStripMenuItem,
            this.delete_ToolStripMenuItem,
            this.update_ToolStripMenuItem,
            this.info_ToolStripMenuItem,
            this.back_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // add_ToolStripMenuItem
            // 
            this.add_ToolStripMenuItem.Name = "add_ToolStripMenuItem";
            this.add_ToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.add_ToolStripMenuItem.Text = "Добавление";
            this.add_ToolStripMenuItem.Click += new System.EventHandler(this.add_ToolStripMenuItem_Click);
            // 
            // delete_ToolStripMenuItem
            // 
            this.delete_ToolStripMenuItem.Name = "delete_ToolStripMenuItem";
            this.delete_ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.delete_ToolStripMenuItem.Text = "Удаление";
            this.delete_ToolStripMenuItem.Click += new System.EventHandler(this.delete_ToolStripMenuItem_Click);
            // 
            // update_ToolStripMenuItem
            // 
            this.update_ToolStripMenuItem.Name = "update_ToolStripMenuItem";
            this.update_ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.update_ToolStripMenuItem.Text = "Изменение";
            this.update_ToolStripMenuItem.Click += new System.EventHandler(this.update_ToolStripMenuItem_Click);
            // 
            // info_ToolStripMenuItem
            // 
            this.info_ToolStripMenuItem.Name = "info_ToolStripMenuItem";
            this.info_ToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.info_ToolStripMenuItem.Text = "Информация";
            this.info_ToolStripMenuItem.Click += new System.EventHandler(this.info_ToolStripMenuItem_Click);
            // 
            // back_ToolStripMenuItem
            // 
            this.back_ToolStripMenuItem.Name = "back_ToolStripMenuItem";
            this.back_ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.back_ToolStripMenuItem.Text = "Назад";
            this.back_ToolStripMenuItem.Click += new System.EventHandler(this.back_ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_arrival,
            this.name_staff,
            this.id_room,
            this.name_client,
            this.id_reservation,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 437);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_arrival
            // 
            this.id_arrival.DataPropertyName = "id_Заезд";
            this.id_arrival.HeaderText = "Номер заезда";
            this.id_arrival.Name = "id_arrival";
            this.id_arrival.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // name_staff
            // 
            this.name_staff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name_staff.DataPropertyName = "ФИО_Сотрудника";
            this.name_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_staff.HeaderText = "Сотрудник";
            this.name_staff.Name = "name_staff";
            this.name_staff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name_staff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.name_staff.Width = 103;
            // 
            // id_room
            // 
            this.id_room.DataPropertyName = "Номер_комнаты";
            this.id_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_room.HeaderText = "Номер комнаты";
            this.id_room.Name = "id_room";
            this.id_room.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_room.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // name_client
            // 
            this.name_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name_client.DataPropertyName = "ФИО_клиента";
            this.name_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_client.HeaderText = "Клиент";
            this.name_client.Name = "name_client";
            this.name_client.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name_client.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.name_client.Width = 81;
            // 
            // id_reservation
            // 
            this.id_reservation.DataPropertyName = "Бронирование_id_Бронирование";
            this.id_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_reservation.HeaderText = "Номер брони";
            this.id_reservation.Name = "id_reservation";
            this.id_reservation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_reservation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Цена_за_проживание";
            this.Column2.HeaderText = "Цена за проживание";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Цена_за_дополнительные_услуги";
            this.Column3.HeaderText = "Цена за услуги";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Размер_штрафа";
            this.Column4.HeaderText = "Размер штрафа";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Запланированная_дата_выезда";
            this.Column5.HeaderText = "Запланированная дата выезда";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Дата_заезда";
            this.Column7.HeaderText = "Дата заезда";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Дата_выезда";
            this.Column8.HeaderText = "Дата выезда";
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Количество_человек";
            this.Column6.HeaderText = "Количество человек";
            this.Column6.Name = "Column6";
            // 
            // addBig_ToolStripMenuItem
            // 
            this.addBig_ToolStripMenuItem.Name = "addBig_ToolStripMenuItem";
            this.addBig_ToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.addBig_ToolStripMenuItem.Text = "Добавление (расширенное)";
            this.addBig_ToolStripMenuItem.Click += new System.EventHandler(this.addBig_ToolStripMenuItem_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список заездов";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem add_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delete_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem update_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem info_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem back_ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_arrival;
        private System.Windows.Forms.DataGridViewComboBoxColumn name_staff;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_room;
        private System.Windows.Forms.DataGridViewComboBoxColumn name_client;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStripMenuItem addBig_ToolStripMenuItem;
    }
}