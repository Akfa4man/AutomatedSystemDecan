namespace Приложение_для_деканата_v1._2
{
    partial class ExaminersForm
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
            this.labelFullname = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAmendment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Location = new System.Drawing.Point(12, 9);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(146, 16);
            this.labelFullname.TabIndex = 0;
            this.labelFullname.Text = "ФИО преподавателя:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(12, 39);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(36, 16);
            this.labelGender.TabIndex = 1;
            this.labelGender.Text = "Пол:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(12, 67);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(109, 16);
            this.labelBirthday.TabIndex = 2;
            this.labelBirthday.Text = "Дата рождения:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.Enabled = false;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(54, 36);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(146, 24);
            this.comboBoxGender.TabIndex = 3;
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.Enabled = false;
            this.textBoxFullname.Location = new System.Drawing.Point(164, 6);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.Size = new System.Drawing.Size(318, 22);
            this.textBoxFullname.TabIndex = 4;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Enabled = false;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(127, 67);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(168, 22);
            this.dateTimePickerBirthday.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(15, 102);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 25);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAmendment
            // 
            this.buttonAmendment.Location = new System.Drawing.Point(348, 102);
            this.buttonAmendment.Name = "buttonAmendment";
            this.buttonAmendment.Size = new System.Drawing.Size(160, 25);
            this.buttonAmendment.TabIndex = 7;
            this.buttonAmendment.Text = "Внести изменения";
            this.buttonAmendment.UseVisualStyleBackColor = true;
            this.buttonAmendment.Click += new System.EventHandler(this.buttonAmendment_Click);
            // 
            // ExaminersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 144);
            this.Controls.Add(this.buttonAmendment);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.textBoxFullname);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelFullname);
            this.Name = "ExaminersForm";
            this.Text = "ExaminersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxFullname;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAmendment;
    }
}