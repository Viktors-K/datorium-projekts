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
            materialButtonLogin = new MaterialSkin.Controls.MaterialButton();
            materialLabelUsername = new MaterialSkin.Controls.MaterialLabel();
            materialCheckboxRememberMe = new MaterialSkin.Controls.MaterialCheckbox();
            materialTextBoxUsername = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            materialLabelPassword = new MaterialSkin.Controls.MaterialLabel();
            materialButtonRegister = new MaterialSkin.Controls.MaterialButton();
            materialLabelError = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialButtonLogin
            // 
            materialButtonLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonLogin.Depth = 0;
            materialButtonLogin.HighEmphasis = true;
            materialButtonLogin.Icon = null;
            materialButtonLogin.Location = new Point(20, 280);
            materialButtonLogin.Margin = new Padding(4, 6, 4, 6);
            materialButtonLogin.MinimumSize = new Size(250, 0);
            materialButtonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonLogin.Name = "materialButtonLogin";
            materialButtonLogin.NoAccentTextColor = Color.Empty;
            materialButtonLogin.Size = new Size(250, 36);
            materialButtonLogin.TabIndex = 0;
            materialButtonLogin.Text = "Pieslēgties";
            materialButtonLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonLogin.UseAccentColor = true;
            materialButtonLogin.UseVisualStyleBackColor = true;
            materialButtonLogin.Click += buttonLogin_Click;
            // 
            // materialLabelUsername
            // 
            materialLabelUsername.AutoSize = true;
            materialLabelUsername.Depth = 0;
            materialLabelUsername.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelUsername.Location = new Point(20, 80);
            materialLabelUsername.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelUsername.Name = "materialLabelUsername";
            materialLabelUsername.Size = new Size(97, 19);
            materialLabelUsername.TabIndex = 1;
            materialLabelUsername.Text = "Lietotājvārds:";
            // 
            // materialCheckboxRememberMe
            // 
            materialCheckboxRememberMe.AutoSize = true;
            materialCheckboxRememberMe.Depth = 0;
            materialCheckboxRememberMe.Location = new Point(20, 235);
            materialCheckboxRememberMe.Margin = new Padding(0);
            materialCheckboxRememberMe.MouseLocation = new Point(-1, -1);
            materialCheckboxRememberMe.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckboxRememberMe.Name = "materialCheckboxRememberMe";
            materialCheckboxRememberMe.ReadOnly = false;
            materialCheckboxRememberMe.Ripple = true;
            materialCheckboxRememberMe.Size = new Size(144, 37);
            materialCheckboxRememberMe.TabIndex = 2;
            materialCheckboxRememberMe.Text = "Atcerēties mani";
            materialCheckboxRememberMe.UseVisualStyleBackColor = true;
            // 
            // materialTextBoxUsername
            // 
            materialTextBoxUsername.AnimateReadOnly = false;
            materialTextBoxUsername.BorderStyle = BorderStyle.None;
            materialTextBoxUsername.Depth = 0;
            materialTextBoxUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxUsername.LeadingIcon = null;
            materialTextBoxUsername.Location = new Point(20, 102);
            materialTextBoxUsername.MaxLength = 50;
            materialTextBoxUsername.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxUsername.Multiline = false;
            materialTextBoxUsername.Name = "materialTextBoxUsername";
            materialTextBoxUsername.Size = new Size(250, 50);
            materialTextBoxUsername.TabIndex = 3;
            materialTextBoxUsername.Text = "";
            materialTextBoxUsername.TrailingIcon = null;
            // 
            // materialTextBoxPassword
            // 
            materialTextBoxPassword.AnimateReadOnly = false;
            materialTextBoxPassword.BorderStyle = BorderStyle.None;
            materialTextBoxPassword.Depth = 0;
            materialTextBoxPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxPassword.LeadingIcon = null;
            materialTextBoxPassword.LeaveOnEnterKey = true;
            materialTextBoxPassword.Location = new Point(20, 180);
            materialTextBoxPassword.MaxLength = 50;
            materialTextBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxPassword.Multiline = false;
            materialTextBoxPassword.Name = "materialTextBoxPassword";
            materialTextBoxPassword.Password = true;
            materialTextBoxPassword.Size = new Size(250, 50);
            materialTextBoxPassword.TabIndex = 5;
            materialTextBoxPassword.Text = "";
            materialTextBoxPassword.TrailingIcon = null;
            // 
            // materialLabelPassword
            // 
            materialLabelPassword.AutoSize = true;
            materialLabelPassword.Depth = 0;
            materialLabelPassword.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelPassword.Location = new Point(20, 158);
            materialLabelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelPassword.Name = "materialLabelPassword";
            materialLabelPassword.Size = new Size(50, 19);
            materialLabelPassword.TabIndex = 4;
            materialLabelPassword.Text = "Parole:";
            // 
            // materialButtonRegister
            // 
            materialButtonRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonRegister.Depth = 0;
            materialButtonRegister.HighEmphasis = true;
            materialButtonRegister.Icon = null;
            materialButtonRegister.Location = new Point(20, 325);
            materialButtonRegister.Margin = new Padding(4, 6, 4, 6);
            materialButtonRegister.MinimumSize = new Size(250, 0);
            materialButtonRegister.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonRegister.Name = "materialButtonRegister";
            materialButtonRegister.NoAccentTextColor = Color.Empty;
            materialButtonRegister.Size = new Size(250, 36);
            materialButtonRegister.TabIndex = 6;
            materialButtonRegister.Text = "Neesmu reģistrējies";
            materialButtonRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonRegister.UseAccentColor = false;
            materialButtonRegister.UseVisualStyleBackColor = true;
            materialButtonRegister.Click += buttonRegister_Click;
            // 
            // materialLabelError
            // 
            materialLabelError.AutoSize = true;
            materialLabelError.Depth = 0;
            materialLabelError.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelError.HighEmphasis = true;
            materialLabelError.Location = new Point(20, 367);
            materialLabelError.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelError.Name = "materialLabelError";
            materialLabelError.Size = new Size(46, 19);
            materialLabelError.TabIndex = 7;
            materialLabelError.Text = "Kļūda!";
            materialLabelError.UseAccent = true;
            materialLabelError.Visible = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(291, 391);
            Controls.Add(materialLabelError);
            Controls.Add(materialButtonRegister);
            Controls.Add(materialTextBoxPassword);
            Controls.Add(materialLabelPassword);
            Controls.Add(materialTextBoxUsername);
            Controls.Add(materialCheckboxRememberMe);
            Controls.Add(materialLabelUsername);
            Controls.Add(materialButtonLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            Text = "Datoru izsniegšanas sistēma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabelUsername;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxRememberMe;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxUsername;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabelPassword;
        private MaterialSkin.Controls.MaterialButton materialButtonRegister;
        private MaterialSkin.Controls.MaterialLabel materialLabelError;
    }
}
