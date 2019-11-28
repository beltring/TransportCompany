namespace CourseWork.Forms
{
    partial class EditForm
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
            this.informationGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trailerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downloadLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfDischarge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.placeOfDischargeTextBox = new System.Windows.Forms.TextBox();
            this.loadLocationTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trailerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uploadDateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.selectCargoButton = new System.Windows.Forms.Button();
            this.editCargoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.informationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // informationGridView
            // 
            this.informationGridView.AllowUserToAddRows = false;
            this.informationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.cost,
            this.weight,
            this.volume,
            this.trailerType,
            this.uploadDate,
            this.status,
            this.downloadLocation,
            this.placeOfDischarge,
            this.distance});
            this.informationGridView.Location = new System.Drawing.Point(273, 12);
            this.informationGridView.Name = "informationGridView";
            this.informationGridView.RowHeadersWidth = 51;
            this.informationGridView.RowTemplate.Height = 24;
            this.informationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.informationGridView.Size = new System.Drawing.Size(515, 426);
            this.informationGridView.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // cost
            // 
            this.cost.HeaderText = "Стоимость";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.Width = 125;
            // 
            // weight
            // 
            this.weight.HeaderText = "Вес";
            this.weight.MinimumWidth = 6;
            this.weight.Name = "weight";
            this.weight.Width = 60;
            // 
            // volume
            // 
            this.volume.HeaderText = "Объём";
            this.volume.MinimumWidth = 6;
            this.volume.Name = "volume";
            this.volume.Width = 70;
            // 
            // trailerType
            // 
            this.trailerType.HeaderText = "Тип Кузова";
            this.trailerType.MinimumWidth = 6;
            this.trailerType.Name = "trailerType";
            this.trailerType.Width = 125;
            // 
            // uploadDate
            // 
            this.uploadDate.HeaderText = "Дата загрузки";
            this.uploadDate.MinimumWidth = 6;
            this.uploadDate.Name = "uploadDate";
            this.uploadDate.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Статус";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // downloadLocation
            // 
            this.downloadLocation.HeaderText = "Место загрузки";
            this.downloadLocation.MinimumWidth = 6;
            this.downloadLocation.Name = "downloadLocation";
            this.downloadLocation.Width = 125;
            // 
            // placeOfDischarge
            // 
            this.placeOfDischarge.HeaderText = "Место выгрузки";
            this.placeOfDischarge.MinimumWidth = 6;
            this.placeOfDischarge.Name = "placeOfDischarge";
            this.placeOfDischarge.Width = 125;
            // 
            // distance
            // 
            this.distance.HeaderText = "Расстояние";
            this.distance.MinimumWidth = 6;
            this.distance.Name = "distance";
            this.distance.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Расстояние";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(146, 274);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.ReadOnly = true;
            this.distanceTextBox.Size = new System.Drawing.Size(121, 22);
            this.distanceTextBox.TabIndex = 40;
            // 
            // placeOfDischargeTextBox
            // 
            this.placeOfDischargeTextBox.Location = new System.Drawing.Point(146, 246);
            this.placeOfDischargeTextBox.Name = "placeOfDischargeTextBox";
            this.placeOfDischargeTextBox.ReadOnly = true;
            this.placeOfDischargeTextBox.Size = new System.Drawing.Size(121, 22);
            this.placeOfDischargeTextBox.TabIndex = 39;
            // 
            // loadLocationTextBox
            // 
            this.loadLocationTextBox.Location = new System.Drawing.Point(146, 218);
            this.loadLocationTextBox.Name = "loadLocationTextBox";
            this.loadLocationTextBox.ReadOnly = true;
            this.loadLocationTextBox.Size = new System.Drawing.Size(121, 22);
            this.loadLocationTextBox.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Место разгрузки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Место загрузки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Статус";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Доставлен",
            "Не доставлен"});
            this.statusComboBox.Location = new System.Drawing.Point(146, 188);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 24);
            this.statusComboBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Тип кузова";
            // 
            // trailerTypeComboBox
            // 
            this.trailerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trailerTypeComboBox.FormattingEnabled = true;
            this.trailerTypeComboBox.Items.AddRange(new object[] {
            "Крытый",
            "Открытый",
            "Цистерна"});
            this.trailerTypeComboBox.Location = new System.Drawing.Point(146, 158);
            this.trailerTypeComboBox.Name = "trailerTypeComboBox";
            this.trailerTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.trailerTypeComboBox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Дата загрузки";
            // 
            // uploadDateTextBox
            // 
            this.uploadDateTextBox.Location = new System.Drawing.Point(146, 130);
            this.uploadDateTextBox.Name = "uploadDateTextBox";
            this.uploadDateTextBox.ReadOnly = true;
            this.uploadDateTextBox.Size = new System.Drawing.Size(121, 22);
            this.uploadDateTextBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Объём";
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Location = new System.Drawing.Point(146, 102);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.ReadOnly = true;
            this.volumeTextBox.Size = new System.Drawing.Size(121, 22);
            this.volumeTextBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Вес";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(146, 74);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.ReadOnly = true;
            this.weightTextBox.Size = new System.Drawing.Size(121, 22);
            this.weightTextBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Стоимость";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(146, 46);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(121, 22);
            this.costTextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Название";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(146, 18);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(121, 22);
            this.nameTextBox.TabIndex = 22;
            // 
            // selectCargoButton
            // 
            this.selectCargoButton.Location = new System.Drawing.Point(24, 392);
            this.selectCargoButton.Name = "selectCargoButton";
            this.selectCargoButton.Size = new System.Drawing.Size(215, 46);
            this.selectCargoButton.TabIndex = 42;
            this.selectCargoButton.Text = "Выбрать груз";
            this.selectCargoButton.UseVisualStyleBackColor = true;
            this.selectCargoButton.Click += new System.EventHandler(this.SelectCargoButton_Click);
            // 
            // editCargoButton
            // 
            this.editCargoButton.Enabled = false;
            this.editCargoButton.Location = new System.Drawing.Point(24, 313);
            this.editCargoButton.Name = "editCargoButton";
            this.editCargoButton.Size = new System.Drawing.Size(215, 46);
            this.editCargoButton.TabIndex = 43;
            this.editCargoButton.Text = "Изменить";
            this.editCargoButton.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editCargoButton);
            this.Controls.Add(this.selectCargoButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.placeOfDischargeTextBox);
            this.Controls.Add(this.loadLocationTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trailerTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uploadDateTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.volumeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.informationGridView);
            this.Name = "EditForm";
            this.Text = "Редактирование груза";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditForm_FormClosed);
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView informationGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn trailerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn downloadLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfDischarge;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TextBox placeOfDischargeTextBox;
        private System.Windows.Forms.TextBox loadLocationTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox trailerTypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uploadDateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button selectCargoButton;
        private System.Windows.Forms.Button editCargoButton;
    }
}