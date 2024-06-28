namespace Приложение_для_деканата_v1._2
{
    partial class SubjectsForm
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxSubjectsName = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус предмета:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(133, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(85, 16);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "неизвестно";
            // 
            // textBoxSubjectsName
            // 
            this.textBoxSubjectsName.Location = new System.Drawing.Point(15, 38);
            this.textBoxSubjectsName.Name = "textBoxSubjectsName";
            this.textBoxSubjectsName.Size = new System.Drawing.Size(156, 22);
            this.textBoxSubjectsName.TabIndex = 2;
            this.textBoxSubjectsName.TextChanged += new System.EventHandler(this.textBoxSubjectsName_TextChanged);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(15, 66);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(100, 25);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "Добавить";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 107);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxSubjectsName);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label1);
            this.Name = "SubjectsForm";
            this.Text = "SubjectsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxSubjectsName;
        private System.Windows.Forms.Button buttonInsert;
    }
}