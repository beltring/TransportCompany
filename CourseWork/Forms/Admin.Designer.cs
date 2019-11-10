namespace CourseWork
{
    partial class Admin
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить новый груз";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddCargo);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Редактировать груз";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить груз";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteCargo);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(92, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "Изменить статус груза";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(92, 280);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(260, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Посмотреть список грузов";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ViewTheListOfCargos);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(92, 343);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(260, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "Выйти";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ExitToHomeForm);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Admin";
            this.Text = "Администратор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}