namespace datorium_projekts
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            buttonRegister = new Button();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            textBoxRepeatPassword = new TextBox();
            labelRepeatPassword = new Label();
            labelError = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxSurname = new TextBox();
            labelSurname = new Label();
            textBoxClass = new TextBox();
            labelClass = new Label();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(29, 82);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(124, 23);
            textBoxPassword.TabIndex = 12;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(29, 64);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(43, 15);
            labelPassword.TabIndex = 11;
            labelPassword.Text = "Parole:";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(27, 199);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(124, 23);
            buttonRegister.TabIndex = 10;
            buttonRegister.Text = "Pieslēgties";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(210, 38);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(124, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(210, 20);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(48, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "E-pasts:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(29, 38);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(124, 23);
            textBoxUsername.TabIndex = 14;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(27, 20);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(77, 15);
            labelUsername.TabIndex = 13;
            labelUsername.Text = "Lietotājvārds:";
            // 
            // textBoxRepeatPassword
            // 
            textBoxRepeatPassword.Location = new Point(29, 126);
            textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            textBoxRepeatPassword.Size = new Size(124, 23);
            textBoxRepeatPassword.TabIndex = 16;
            textBoxRepeatPassword.UseSystemPasswordChar = true;
            // 
            // labelRepeatPassword
            // 
            labelRepeatPassword.AutoSize = true;
            labelRepeatPassword.Location = new Point(29, 108);
            labelRepeatPassword.Name = "labelRepeatPassword";
            labelRepeatPassword.Size = new Size(82, 15);
            labelRepeatPassword.TabIndex = 15;
            labelRepeatPassword.Text = "Atkātot paroli:";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = Color.Silver;
            labelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(27, 225);
            labelError.Name = "labelError";
            labelError.Size = new Size(105, 15);
            labelError.TabIndex = 17;
            labelError.Text = "Nepareiza parole!";
            labelError.Visible = false;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(210, 82);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(124, 23);
            textBoxName.TabIndex = 19;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(210, 64);
            labelName.Name = "labelName";
            labelName.Size = new Size(38, 15);
            labelName.TabIndex = 18;
            labelName.Text = "Vārds:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(210, 126);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(124, 23);
            textBoxSurname.TabIndex = 21;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(210, 108);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(51, 15);
            labelSurname.TabIndex = 20;
            labelSurname.Text = "Uzvārds:";
            // 
            // textBoxClass
            // 
            textBoxClass.Location = new Point(210, 170);
            textBoxClass.Name = "textBoxClass";
            textBoxClass.Size = new Size(124, 23);
            textBoxClass.TabIndex = 23;
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Location = new Point(211, 152);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(37, 15);
            labelClass.TabIndex = 22;
            labelClass.Text = "Klase:";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(368, 252);
            Controls.Add(textBoxClass);
            Controls.Add(labelClass);
            Controls.Add(textBoxSurname);
            Controls.Add(labelSurname);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(labelError);
            Controls.Add(textBoxRepeatPassword);
            Controls.Add(labelRepeatPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(384, 291);
            MinimumSize = new Size(384, 291);
            Name = "FormRegister";
            Text = "Reģistrācija";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private Label labelPassword;
        private Button buttonRegister;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private TextBox textBoxRepeatPassword;
        private Label labelRepeatPassword;
        private Label labelError;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxSurname;
        private Label labelSurname;
        private TextBox textBoxClass;
        private Label labelClass;
    }
}