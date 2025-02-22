namespace datorium_projekts
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            checkBoxRememberMe = new CheckBox();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            buttonRegister = new Button();
            labelError = new Label();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(92, 25);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(77, 15);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Lietotājvārds:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(92, 43);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(124, 23);
            textBoxUsername.TabIndex = 1;
            // 
            // checkBoxRememberMe
            // 
            checkBoxRememberMe.AutoSize = true;
            checkBoxRememberMe.Location = new Point(92, 116);
            checkBoxRememberMe.Name = "checkBoxRememberMe";
            checkBoxRememberMe.Size = new Size(108, 19);
            checkBoxRememberMe.TabIndex = 2;
            checkBoxRememberMe.Text = "Atcerēties mani";
            checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(92, 141);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(124, 23);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Pieslēgties";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(92, 87);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(124, 23);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(92, 69);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(43, 15);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Parole:";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(92, 170);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(124, 23);
            buttonRegister.TabIndex = 6;
            buttonRegister.Text = "Neesmu reģistrējies";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = Color.Silver;
            labelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(12, 204);
            labelError.MaximumSize = new Size(290, 0);
            labelError.MinimumSize = new Size(290, 0);
            labelError.Name = "labelError";
            labelError.Size = new Size(290, 15);
            labelError.TabIndex = 18;
            labelError.Text = "Nepareiza parole!";
            labelError.TextAlign = ContentAlignment.MiddleCenter;
            labelError.Visible = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(315, 228);
            Controls.Add(labelError);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(buttonLogin);
            Controls.Add(checkBoxRememberMe);
            Controls.Add(textBoxUsername);
            Controls.Add(labelUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            Text = "Datoru izsniegšanas sistēma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private TextBox textBoxUsername;
        private CheckBox checkBoxRememberMe;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Button buttonRegister;
        private Label labelError;
    }
}
