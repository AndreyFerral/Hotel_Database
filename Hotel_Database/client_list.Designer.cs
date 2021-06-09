
namespace Hotel_Database
{
    partial class client_list
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_children = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.info_ToolStripMenuItem,
            this.back_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
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
            this.id,
            this.passport,
            this.name_client,
            this.date,
            this.number,
            this.count_children});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 437);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id_Клиент";
            this.id.HeaderText = "Номер клиента";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // passport
            // 
            this.passport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.passport.DataPropertyName = "Номер_и_серия_паспорта";
            this.passport.HeaderText = "Паспорт";
            this.passport.Name = "passport";
            this.passport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.passport.Width = 89;
            // 
            // name_client
            // 
            this.name_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name_client.DataPropertyName = "ФИО_клиента";
            this.name_client.HeaderText = "ФИО Клиента";
            this.name_client.Name = "name_client";
            this.name_client.Width = 116;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "Дата_рождения";
            this.date.HeaderText = "Дата рождения";
            this.date.Name = "date";
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.number.DataPropertyName = "Номер_телефона";
            this.number.HeaderText = "Телефон";
            this.number.Name = "number";
            this.number.Width = 93;
            // 
            // count_children
            // 
            this.count_children.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.count_children.DataPropertyName = "Количество_детей";
            this.count_children.HeaderText = "Кол-во детей";
            this.count_children.Name = "count_children";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список клиентов";
            this.Load += new System.EventHandler(this.Form6_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_children;
    }
}