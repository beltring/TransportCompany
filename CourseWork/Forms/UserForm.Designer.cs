namespace CourseWork
{
    partial class UserForm
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
            this.viewCargoButton = new System.Windows.Forms.Button();
            this.favouritesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewCargoButton
            // 
            this.viewCargoButton.Location = new System.Drawing.Point(48, 16);
            this.viewCargoButton.Name = "viewCargoButton";
            this.viewCargoButton.Size = new System.Drawing.Size(185, 61);
            this.viewCargoButton.TabIndex = 0;
            this.viewCargoButton.Text = "Просмотреть список грузов";
            this.viewCargoButton.UseVisualStyleBackColor = true;
            this.viewCargoButton.Click += new System.EventHandler(this.LoadCargoCatalog);
            // 
            // favouritesButton
            // 
            this.favouritesButton.Location = new System.Drawing.Point(48, 110);
            this.favouritesButton.Name = "favouritesButton";
            this.favouritesButton.Size = new System.Drawing.Size(185, 61);
            this.favouritesButton.TabIndex = 1;
            this.favouritesButton.Text = "Избранное";
            this.favouritesButton.UseVisualStyleBackColor = true;
            this.favouritesButton.Click += new System.EventHandler(this.LoadFavourites);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(48, 207);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(185, 61);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.Exit);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 280);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.favouritesButton);
            this.Controls.Add(this.viewCargoButton);
            this.Name = "UserForm";
            this.Text = "Пользователь";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_Closed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewCargoButton;
        private System.Windows.Forms.Button favouritesButton;
        private System.Windows.Forms.Button exitButton;
    }
}