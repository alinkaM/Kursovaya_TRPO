
namespace Лаба_5
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_enter_in_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_password.Location = new System.Drawing.Point(125, 309);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(523, 22);
            this.textBox_password.TabIndex = 1;
            // 
            // button_enter_in_login
            // 
            this.button_enter_in_login.Location = new System.Drawing.Point(277, 407);
            this.button_enter_in_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_enter_in_login.Name = "button_enter_in_login";
            this.button_enter_in_login.Size = new System.Drawing.Size(217, 84);
            this.button_enter_in_login.TabIndex = 2;
            this.button_enter_in_login.Text = "Ок";
            this.button_enter_in_login.UseVisualStyleBackColor = true;
            this.button_enter_in_login.Click += new System.EventHandler(this.button_enter_in_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_login.Location = new System.Drawing.Point(124, 137);
            this.textBox_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(523, 22);
            this.textBox_login.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(797, 554);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_enter_in_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_enter_in_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
    }
}

