
namespace Лаба_5
{
    partial class Delete
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

        /// <summary
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Group_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_enter_in_login = new System.Windows.Forms.Button();
            this.textBox_stud_fio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "*Поле для поиска*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "*Поле для поиска*";
            // 
            // Group_Box
            // 
            this.Group_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.Group_Box.Location = new System.Drawing.Point(173, 10);
            this.Group_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Group_Box.Name = "Group_Box";
            this.Group_Box.Size = new System.Drawing.Size(472, 22);
            this.Group_Box.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Номер группы";
            // 
            // button_enter_in_login
            // 
            this.button_enter_in_login.BackColor = System.Drawing.Color.Linen;
            this.button_enter_in_login.Location = new System.Drawing.Point(306, 105);
            this.button_enter_in_login.Margin = new System.Windows.Forms.Padding(4);
            this.button_enter_in_login.Name = "button_enter_in_login";
            this.button_enter_in_login.Size = new System.Drawing.Size(173, 62);
            this.button_enter_in_login.TabIndex = 36;
            this.button_enter_in_login.Text = "Ок";
            this.button_enter_in_login.UseVisualStyleBackColor = false;
            this.button_enter_in_login.Click += new System.EventHandler(this.button_enter_in_login_Click);
            // 
            // textBox_stud_fio
            // 
            this.textBox_stud_fio.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_stud_fio.Location = new System.Drawing.Point(173, 53);
            this.textBox_stud_fio.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_stud_fio.Name = "textBox_stud_fio";
            this.textBox_stud_fio.Size = new System.Drawing.Size(472, 22);
            this.textBox_stud_fio.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Фамилия студента";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(785, 180);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Group_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_enter_in_login);
            this.Controls.Add(this.textBox_stud_fio);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(803, 289);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Group_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_enter_in_login;
        private System.Windows.Forms.TextBox textBox_stud_fio;
        private System.Windows.Forms.Label label1;
    }
}
