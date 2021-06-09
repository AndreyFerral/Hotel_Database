
namespace Hotel_Database
{
    partial class connection
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttConnect = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtNameDB = new System.Windows.Forms.TextBox();
            this.txtNameSrv = new System.Windows.Forms.TextBox();
            this.cmbTypeAutor = new System.Windows.Forms.ComboBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTypeAutor = new System.Windows.Forms.Label();
            this.lblNameDB = new System.Windows.Forms.Label();
            this.lblNameSrv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttConnect
            // 
            this.bttConnect.Location = new System.Drawing.Point(344, 165);
            this.bttConnect.Name = "bttConnect";
            this.bttConnect.Size = new System.Drawing.Size(100, 25);
            this.bttConnect.TabIndex = 21;
            this.bttConnect.Text = "Соединить";
            this.bttConnect.UseVisualStyleBackColor = true;
            this.bttConnect.Click += new System.EventHandler(this.bttConnect_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(194, 135);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(250, 23);
            this.txtPass.TabIndex = 20;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(194, 106);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(250, 23);
            this.txtUserName.TabIndex = 19;
            // 
            // txtNameDB
            // 
            this.txtNameDB.Location = new System.Drawing.Point(194, 47);
            this.txtNameDB.Name = "txtNameDB";
            this.txtNameDB.Size = new System.Drawing.Size(250, 23);
            this.txtNameDB.TabIndex = 18;
            this.txtNameDB.Text = "Hotel";
            // 
            // txtNameSrv
            // 
            this.txtNameSrv.Location = new System.Drawing.Point(194, 18);
            this.txtNameSrv.Name = "txtNameSrv";
            this.txtNameSrv.Size = new System.Drawing.Size(250, 23);
            this.txtNameSrv.TabIndex = 17;
            this.txtNameSrv.Text = "(localdb)\\MSSQLLocalDB";
            // 
            // cmbTypeAutor
            // 
            this.cmbTypeAutor.FormattingEnabled = true;
            this.cmbTypeAutor.Location = new System.Drawing.Point(194, 76);
            this.cmbTypeAutor.Name = "cmbTypeAutor";
            this.cmbTypeAutor.Size = new System.Drawing.Size(250, 24);
            this.cmbTypeAutor.TabIndex = 16;
            this.cmbTypeAutor.Tag = "";
            this.cmbTypeAutor.Text = "Проверка подлинности Windows";
            this.cmbTypeAutor.SelectionChangeCommitted += new System.EventHandler(this.cmbTypeAutor_SelectionChangeCommitted);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPass.Location = new System.Drawing.Point(22, 138);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(57, 17);
            this.lblPass.TabIndex = 15;
            this.lblPass.Text = "Пароль";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUserName.Location = new System.Drawing.Point(22, 109);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserName.Size = new System.Drawing.Size(131, 17);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "Имя пользователя";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTypeAutor
            // 
            this.lblTypeAutor.AutoSize = true;
            this.lblTypeAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTypeAutor.Location = new System.Drawing.Point(22, 79);
            this.lblTypeAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeAutor.Name = "lblTypeAutor";
            this.lblTypeAutor.Size = new System.Drawing.Size(162, 17);
            this.lblTypeAutor.TabIndex = 13;
            this.lblTypeAutor.Text = "Проверка подлинности";
            // 
            // lblNameDB
            // 
            this.lblNameDB.AutoSize = true;
            this.lblNameDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNameDB.Location = new System.Drawing.Point(22, 50);
            this.lblNameDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameDB.Name = "lblNameDB";
            this.lblNameDB.Size = new System.Drawing.Size(124, 17);
            this.lblNameDB.TabIndex = 12;
            this.lblNameDB.Text = "Имя базы данных";
            // 
            // lblNameSrv
            // 
            this.lblNameSrv.AutoSize = true;
            this.lblNameSrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNameSrv.Location = new System.Drawing.Point(22, 21);
            this.lblNameSrv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameSrv.Name = "lblNameSrv";
            this.lblNameSrv.Size = new System.Drawing.Size(93, 17);
            this.lblNameSrv.TabIndex = 11;
            this.lblNameSrv.Text = "Имя сервера";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 202);
            this.Controls.Add(this.bttConnect);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtNameDB);
            this.Controls.Add(this.txtNameSrv);
            this.Controls.Add(this.cmbTypeAutor);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblTypeAutor);
            this.Controls.Add(this.lblNameDB);
            this.Controls.Add(this.lblNameSrv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введите параметры подключения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttConnect;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtNameDB;
        private System.Windows.Forms.TextBox txtNameSrv;
        private System.Windows.Forms.ComboBox cmbTypeAutor;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTypeAutor;
        private System.Windows.Forms.Label lblNameDB;
        private System.Windows.Forms.Label lblNameSrv;
    }
}

