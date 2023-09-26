namespace AutorisationExample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.labelUsers = new System.Windows.Forms.Label();
            this.buttonTestLogin = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.lbConnect = new System.Windows.Forms.Label();
            this.buttonSaveToDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxGend = new System.Windows.Forms.TextBox();
            this.textboxPos = new System.Windows.Forms.TextBox();
            this.textboxStatus = new System.Windows.Forms.TextBox();
            this.comboBoxCh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(23, 68);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(212, 45);
            this.textBoxLogin.TabIndex = 0;
            // 
            // maskedTextBoxPassword
            // 
            this.maskedTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPassword.Location = new System.Drawing.Point(260, 68);
            this.maskedTextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            this.maskedTextBoxPassword.PasswordChar = '*';
            this.maskedTextBoxPassword.Size = new System.Drawing.Size(212, 45);
            this.maskedTextBoxPassword.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUser.Location = new System.Drawing.Point(29, 11);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(111, 39);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "Логин";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.Location = new System.Drawing.Point(283, 11);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(136, 39);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Пароль";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddUser.Location = new System.Drawing.Point(840, 68);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(224, 47);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Добавить";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsers.Location = new System.Drawing.Point(833, 332);
            this.labelUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(244, 39);
            this.labelUsers.TabIndex = 2;
            this.labelUsers.Text = "Пользователи";
            // 
            // buttonTestLogin
            // 
            this.buttonTestLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTestLogin.Location = new System.Drawing.Point(840, 133);
            this.buttonTestLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTestLogin.Name = "buttonTestLogin";
            this.buttonTestLogin.Size = new System.Drawing.Size(224, 47);
            this.buttonTestLogin.TabIndex = 3;
            this.buttonTestLogin.Text = "Проверить";
            this.buttonTestLogin.UseVisualStyleBackColor = true;
            this.buttonTestLogin.Click += new System.EventHandler(this.buttonTestLogin_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(37, 290);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.Size = new System.Drawing.Size(757, 302);
            this.dataGridViewUsers.TabIndex = 4;
            // 
            // lbConnect
            // 
            this.lbConnect.AutoSize = true;
            this.lbConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbConnect.Location = new System.Drawing.Point(29, 651);
            this.lbConnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConnect.Name = "lbConnect";
            this.lbConnect.Size = new System.Drawing.Size(214, 39);
            this.lbConnect.TabIndex = 2;
            this.lbConnect.Text = "Соединение";
            // 
            // buttonSaveToDB
            // 
            this.buttonSaveToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveToDB.Location = new System.Drawing.Point(542, 643);
            this.buttonSaveToDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveToDB.Name = "buttonSaveToDB";
            this.buttonSaveToDB.Size = new System.Drawing.Size(252, 47);
            this.buttonSaveToDB.TabIndex = 3;
            this.buttonSaveToDB.Text = "Обновить БД";
            this.buttonSaveToDB.UseVisualStyleBackColor = true;
            this.buttonSaveToDB.Click += new System.EventHandler(this.buttonSaveToDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(554, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Статус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(273, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Положение";
            // 
            // textboxGend
            // 
            this.textboxGend.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxGend.Location = new System.Drawing.Point(23, 200);
            this.textboxGend.Margin = new System.Windows.Forms.Padding(4);
            this.textboxGend.Name = "textboxGend";
            this.textboxGend.Size = new System.Drawing.Size(212, 45);
            this.textboxGend.TabIndex = 0;
            // 
            // textboxPos
            // 
            this.textboxPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxPos.Location = new System.Drawing.Point(260, 200);
            this.textboxPos.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPos.Name = "textboxPos";
            this.textboxPos.Size = new System.Drawing.Size(212, 45);
            this.textboxPos.TabIndex = 0;
            // 
            // textboxStatus
            // 
            this.textboxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxStatus.Location = new System.Drawing.Point(513, 68);
            this.textboxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textboxStatus.Name = "textboxStatus";
            this.textboxStatus.Size = new System.Drawing.Size(212, 45);
            this.textboxStatus.TabIndex = 0;
            // 
            // comboBoxCh
            // 
            this.comboBoxCh.FormattingEnabled = true;
            this.comboBoxCh.Location = new System.Drawing.Point(840, 290);
            this.comboBoxCh.Name = "comboBoxCh";
            this.comboBoxCh.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCh.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 724);
            this.Controls.Add(this.comboBoxCh);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.buttonSaveToDB);
            this.Controls.Add(this.buttonTestLogin);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lbConnect);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.maskedTextBoxPassword);
            this.Controls.Add(this.textboxPos);
            this.Controls.Add(this.textboxStatus);
            this.Controls.Add(this.textboxGend);
            this.Controls.Add(this.textBoxLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassword;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Button buttonTestLogin;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label lbConnect;
        private System.Windows.Forms.Button buttonSaveToDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxGend;
        private System.Windows.Forms.TextBox textboxPos;
        private System.Windows.Forms.TextBox textboxStatus;
        private System.Windows.Forms.ComboBox comboBoxCh;
    }
}

