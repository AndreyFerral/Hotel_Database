
namespace Hotel_Database
{
    partial class reservation_list
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
            this.addBig_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.update_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.back_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_room = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.worker_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 73;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // add_ToolStripMenuItem
            // 
            this.add_ToolStripMenuItem.Name = "add_ToolStripMenuItem";
            this.add_ToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.add_ToolStripMenuItem.Text = "Добавление";
            this.add_ToolStripMenuItem.Click += new System.EventHandler(this.add_ToolStripMenuItem_Click);
            // 
            // addBig_ToolStripMenuItem
            // 
            this.addBig_ToolStripMenuItem.Name = "addBig_ToolStripMenuItem";
            this.addBig_ToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.addBig_ToolStripMenuItem.Text = "Добавление (расширенное)";
            this.addBig_ToolStripMenuItem.Click += new System.EventHandler(this.addBig_ToolStripMenuItem_Click);
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
            this.id_reservation,
            this.number_room,
            this.worker_name,
            this.client_name,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn9,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(968, 390);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_reservation
            // 
            this.id_reservation.DataPropertyName = "id_Бронирование";
            this.id_reservation.HeaderText = "Номер брони";
            this.id_reservation.Name = "id_reservation";
            this.id_reservation.ReadOnly = true;
            this.id_reservation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_reservation.Width = 76;
            // 
            // number_room
            // 
            this.number_room.DataPropertyName = "Номер_комнаты";
            this.number_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_room.HeaderText = "Номер комнаты";
            this.number_room.Name = "number_room";
            this.number_room.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.number_room.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.number_room.Width = 76;
            // 
            // worker_name
            // 
            this.worker_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.worker_name.DataPropertyName = "ФИО_Сотрудника";
            this.worker_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.worker_name.HeaderText = "Сотрудник";
            this.worker_name.Name = "worker_name";
            this.worker_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.worker_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.worker_name.Width = 103;
            // 
            // client_name
            // 
            this.client_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.client_name.DataPropertyName = "ФИО_клиента";
            this.client_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_name.HeaderText = "Клиент";
            this.client_name.Name = "client_name";
            this.client_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.client_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.client_name.Width = 81;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Дата_бронирования";
            this.dataGridViewTextBoxColumn15.HeaderText = "Дата брони";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Запланированная_дата_заезда";
            this.dataGridViewTextBoxColumn14.HeaderText = "Запланированная дата заезда";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Запланированная_дата_выезда";
            this.dataGridViewTextBoxColumn13.HeaderText = "Запланированная дата выезда";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Количество_человек";
            this.dataGridViewTextBoxColumn16.HeaderText = "Количество человек";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Тип_бронирования";
            this.dataGridViewTextBoxColumn9.HeaderText = "Тип брони";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 94;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Сумма_предоплаты";
            this.Column2.HeaderText = "Сумма предоплаты";
            this.Column2.Name = "Column2";
            // 
            // reservation_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 414);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "reservation_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список бронирований";
            this.Load += new System.EventHandler(this.Form14_Load);
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
        private System.Windows.Forms.ToolStripMenuItem addBig_ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_reservation;
        private System.Windows.Forms.DataGridViewComboBoxColumn number_room;
        private System.Windows.Forms.DataGridViewComboBoxColumn worker_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}