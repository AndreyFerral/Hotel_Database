
namespace Hotel_Database
{
    partial class Form8
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
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(575, 186);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(108, 30);
            this.update.TabIndex = 69;
            this.update.Text = "Изменить";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(575, 150);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(108, 30);
            this.delete.TabIndex = 68;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(575, 114);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 30);
            this.add.TabIndex = 67;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_service,
            this.date_use,
            this.number_check,
            this.count_use});
            this.dataGridView1.Location = new System.Drawing.Point(1, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 143);
            this.dataGridView1.TabIndex = 66;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(250, 23);
            this.textBox1.TabIndex = 65;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(250, 23);
            this.textBox2.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(31, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Цена";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(250, 23);
            this.textBox3.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Номер услуги";
            // 
            // id_service
            // 
            this.id_service.DataPropertyName = "Дополнительные_услуги_id_Дополнительные_услуги";
            this.id_service.HeaderText = "Номер услуги";
            this.id_service.Name = "id_service";
            // 
            // date_use
            // 
            this.date_use.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_use.DataPropertyName = "Дата_пользования";
            this.date_use.HeaderText = "Дата";
            this.date_use.Name = "date_use";
            // 
            // number_check
            // 
            this.number_check.DataPropertyName = "Заезд_id_Заезд";
            this.number_check.HeaderText = "Номер заезда";
            this.number_check.Name = "number_check";
            // 
            // count_use
            // 
            this.count_use.DataPropertyName = "Количество_пользований";
            this.count_use.HeaderText = "Кол-во пользований";
            this.count_use.Name = "count_use";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 349);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form8";
            this.Text = "Просмотр информации о услуге";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_use;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}