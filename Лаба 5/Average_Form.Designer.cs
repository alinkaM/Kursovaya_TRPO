
namespace Лаба_5
{
    partial class Average_Form
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
            this.Label_Result = new System.Windows.Forms.Label();
            this.Group_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_enter_in_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GridResult = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dolg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Location = new System.Drawing.Point(161, 58);
            this.Label_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(16, 17);
            this.Label_Result.TabIndex = 48;
            this.Label_Result.Text = "0";
            // 
            // Group_Box
            // 
            this.Group_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.Group_Box.Location = new System.Drawing.Point(161, 12);
            this.Group_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Group_Box.Name = "Group_Box";
            this.Group_Box.Size = new System.Drawing.Size(472, 22);
            this.Group_Box.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Номер группы";
            // 
            // button_enter_in_login
            // 
            this.button_enter_in_login.BackColor = System.Drawing.Color.Linen;
            this.button_enter_in_login.Location = new System.Drawing.Point(161, 209);
            this.button_enter_in_login.Margin = new System.Windows.Forms.Padding(4);
            this.button_enter_in_login.Name = "button_enter_in_login";
            this.button_enter_in_login.Size = new System.Drawing.Size(173, 62);
            this.button_enter_in_login.TabIndex = 44;
            this.button_enter_in_login.Text = "Рассчитать";
            this.button_enter_in_login.UseVisualStyleBackColor = false;
            this.button_enter_in_login.Click += new System.EventHandler(this.button_enter_in_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Средняя оценка:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Location = new System.Drawing.Point(460, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 62);
            this.button1.TabIndex = 49;
            this.button1.Text = "Закрыть окно";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridResult
            // 
            this.GridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.Average_Result,
            this.Dolg});
            this.GridResult.Location = new System.Drawing.Point(230, 41);
            this.GridResult.Name = "GridResult";
            this.GridResult.RowHeadersWidth = 51;
            this.GridResult.RowTemplate.Height = 24;
            this.GridResult.Size = new System.Drawing.Size(403, 161);
            this.GridResult.TabIndex = 50;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "Фамилия";
            this.FIO.MinimumWidth = 6;
            this.FIO.Name = "FIO";
            this.FIO.Width = 125;
            // 
            // Average_Result
            // 
            this.Average_Result.HeaderText = "Средний результат";
            this.Average_Result.MinimumWidth = 6;
            this.Average_Result.Name = "Average_Result";
            this.Average_Result.Width = 125;
            // 
            // Dolg
            // 
            this.Dolg.HeaderText = "Количество долгов";
            this.Dolg.MinimumWidth = 6;
            this.Dolg.Name = "Dolg";
            this.Dolg.Width = 125;
            // 
            // Average_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(661, 284);
            this.Controls.Add(this.GridResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Group_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_enter_in_login);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(679, 331);
            this.MinimumSize = new System.Drawing.Size(679, 331);
            this.Name = "Average_Form";
            this.Text = "Average_Form";
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Result;
        private System.Windows.Forms.TextBox Group_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_enter_in_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dolg;
    }
}