namespace Приложение_для_деканата_v1
{
    partial class EntranceWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxPasswordVision = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBoxPasswordVision);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LoginBox);
            this.panel1.Controls.Add(this.EnterButton);
            this.panel1.Controls.Add(this.PasswordBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 326);
            this.panel1.TabIndex = 3;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordBox.Location = new System.Drawing.Point(219, 113);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(161, 22);
            this.PasswordBox.TabIndex = 1;
            // 
            // EnterButton
            // 
            this.EnterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterButton.Location = new System.Drawing.Point(253, 160);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(100, 28);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Показывать пароль";
            // 
            // checkBoxPasswordVision
            // 
            this.checkBoxPasswordVision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxPasswordVision.AutoSize = true;
            this.checkBoxPasswordVision.Location = new System.Drawing.Point(362, 139);
            this.checkBoxPasswordVision.Name = "checkBoxPasswordVision";
            this.checkBoxPasswordVision.Size = new System.Drawing.Size(18, 17);
            this.checkBoxPasswordVision.TabIndex = 4;
            this.checkBoxPasswordVision.UseVisualStyleBackColor = true;
            this.checkBoxPasswordVision.CheckedChanged += new System.EventHandler(this.checkBoxPasswordVision_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин:";
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(219, 83);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(161, 22);
            this.LoginBox.TabIndex = 0;
            // 
            // EntranceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 326);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(628, 373);
            this.Name = "EntranceWindow";
            this.Text = "EntranceWindow";
            this.Resize += new System.EventHandler(this.EntranceWindow_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxPasswordVision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox PasswordBox;
    }
}

