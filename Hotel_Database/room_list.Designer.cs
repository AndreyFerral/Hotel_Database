
namespace Hotel_Database
{
    partial class room_list
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
            this.back_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comfort_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.placement_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_ToolStripMenuItem,
            this.delete_ToolStripMenuItem,
            this.update_ToolStripMenuItem,
            this.back_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
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
            this.id_room,
            this.comfort_name,
            this.placement_name,
            this.cost,
            this.dataGridViewTextBoxColumn19});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 437);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_room
            // 
            this.id_room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_room.DataPropertyName = "Номер_комнаты";
            this.id_room.HeaderText = "Номер комнаты";
            this.id_room.Name = "id_room";
            this.id_room.ReadOnly = true;
            this.id_room.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // comfort_name
            // 
            this.comfort_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.comfort_name.DataPropertyName = "Комфортность";
            this.comfort_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comfort_name.HeaderText = "Комфортность";
            this.comfort_name.Name = "comfort_name";
            this.comfort_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comfort_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comfort_name.Width = 130;
            // 
            // placement_name
            // 
            this.placement_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.placement_name.DataPropertyName = "Размещение";
            this.placement_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placement_name.HeaderText = "Размещение";
            this.placement_name.Name = "placement_name";
            this.placement_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.placement_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.placement_name.Width = 117;
            // 
            // cost
            // 
            this.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cost.DataPropertyName = "Цена";
            this.cost.HeaderText = "Цена";
            this.cost.Name = "cost";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Состояние_номера";
            this.dataGridViewTextBoxColumn19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn19.HeaderText = "Состояние";
            this.dataGridViewTextBoxColumn19.Items.AddRange(new object[] {
            "готов к эксплуатации",
            "не готов к эксплуатации"});
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn19.Width = 104;
            // 
            // room_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "room_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список номеров";
            this.Load += new System.EventHandler(this.Form13_Load);
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
        private System.Windows.Forms.ToolStripMenuItem back_ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_room;
        private System.Windows.Forms.DataGridViewComboBoxColumn comfort_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn placement_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn19;
    }
}