namespace Приложение_для_деканата_v1
{
    partial class AddEvaluations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.comboBoxEstmition = new System.Windows.Forms.ComboBox();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.comboBoxExaminers = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelWork = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Предмет";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Оценка";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Семестр";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Преподаватель";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "*-обязательно к заполнению";
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(34, 70);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(235, 24);
            this.comboBoxSubjects.TabIndex = 5;
            // 
            // comboBoxEstmition
            // 
            this.comboBoxEstmition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEstmition.FormattingEnabled = true;
            this.comboBoxEstmition.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1",
            "Незачёт",
            "Зачёт"});
            this.comboBoxEstmition.Location = new System.Drawing.Point(275, 70);
            this.comboBoxEstmition.Name = "comboBoxEstmition";
            this.comboBoxEstmition.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEstmition.TabIndex = 6;
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(402, 70);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(65, 24);
            this.comboBoxSemester.TabIndex = 7;
            // 
            // comboBoxExaminers
            // 
            this.comboBoxExaminers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxExaminers.FormattingEnabled = true;
            this.comboBoxExaminers.Location = new System.Drawing.Point(473, 70);
            this.comboBoxExaminers.Name = "comboBoxExaminers";
            this.comboBoxExaminers.Size = new System.Drawing.Size(201, 24);
            this.comboBoxExaminers.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.Location = new System.Drawing.Point(588, 124);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelWork
            // 
            this.labelWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWork.AutoSize = true;
            this.labelWork.Location = new System.Drawing.Point(585, 164);
            this.labelWork.Name = "labelWork";
            this.labelWork.Size = new System.Drawing.Size(108, 16);
            this.labelWork.TabIndex = 10;
            this.labelWork.Text = "Готов к работе!";
            // 
            // AddEvaluations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 210);
            this.Controls.Add(this.labelWork);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxExaminers);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.comboBoxEstmition);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEvaluations";
            this.Text = "AddEvaluations";
            this.Load += new System.EventHandler(this.AddEvaluations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.ComboBox comboBoxEstmition;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.ComboBox comboBoxExaminers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelWork;
    }
}