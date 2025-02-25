namespace MaterialDesignTest
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
            materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            materialTextBoxUsername = new MaterialSkin.Controls.MaterialTextBox();
            materialLabelUsername = new MaterialSkin.Controls.MaterialLabel();
            materialLabelPassword = new MaterialSkin.Controls.MaterialLabel();
            materialTextBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialCheckboxRememberMe = new MaterialSkin.Controls.MaterialCheckbox();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialLabelError = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new Point(-250, 114);
            materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.Size = new Size(250, 120);
            materialDrawer1.TabIndex = 0;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // materialTextBoxUsername
            // 
            materialTextBoxUsername.AnimateReadOnly = false;
            materialTextBoxUsername.BorderStyle = BorderStyle.None;
            materialTextBoxUsername.Depth = 0;
            materialTextBoxUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxUsername.LeadingIcon = null;
            materialTextBoxUsername.Location = new Point(19, 111);
            materialTextBoxUsername.MaxLength = 50;
            materialTextBoxUsername.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxUsername.Multiline = false;
            materialTextBoxUsername.Name = "materialTextBoxUsername";
            materialTextBoxUsername.Size = new Size(250, 50);
            materialTextBoxUsername.TabIndex = 1;
            materialTextBoxUsername.Text = "";
            materialTextBoxUsername.TrailingIcon = null;
            // 
            // materialLabelUsername
            // 
            materialLabelUsername.AutoSize = true;
            materialLabelUsername.Depth = 0;
            materialLabelUsername.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelUsername.Location = new Point(19, 89);
            materialLabelUsername.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelUsername.Name = "materialLabelUsername";
            materialLabelUsername.Size = new Size(97, 19);
            materialLabelUsername.TabIndex = 3;
            materialLabelUsername.Text = "Lietotājvārds:";
            // 
            // materialLabelPassword
            // 
            materialLabelPassword.AutoSize = true;
            materialLabelPassword.Depth = 0;
            materialLabelPassword.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelPassword.Location = new Point(19, 166);
            materialLabelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelPassword.Name = "materialLabelPassword";
            materialLabelPassword.Size = new Size(50, 19);
            materialLabelPassword.TabIndex = 5;
            materialLabelPassword.Text = "Parole:";
            // 
            // materialTextBoxPassword
            // 
            materialTextBoxPassword.AnimateReadOnly = false;
            materialTextBoxPassword.BorderStyle = BorderStyle.None;
            materialTextBoxPassword.Depth = 0;
            materialTextBoxPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxPassword.LeadingIcon = null;
            materialTextBoxPassword.LeaveOnEnterKey = true;
            materialTextBoxPassword.Location = new Point(19, 188);
            materialTextBoxPassword.MaxLength = 50;
            materialTextBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxPassword.Multiline = false;
            materialTextBoxPassword.Name = "materialTextBoxPassword";
            materialTextBoxPassword.Password = true;
            materialTextBoxPassword.Size = new Size(250, 50);
            materialTextBoxPassword.TabIndex = 4;
            materialTextBoxPassword.Text = "";
            materialTextBoxPassword.TrailingIcon = null;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(19, 284);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MinimumSize = new Size(250, 0);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(250, 36);
            materialButton1.TabIndex = 6;
            materialButton1.Text = "Pieslēgties";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialCheckboxRememberMe
            // 
            materialCheckboxRememberMe.AutoSize = true;
            materialCheckboxRememberMe.Depth = 0;
            materialCheckboxRememberMe.Location = new Point(19, 241);
            materialCheckboxRememberMe.Margin = new Padding(0);
            materialCheckboxRememberMe.MouseLocation = new Point(-1, -1);
            materialCheckboxRememberMe.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckboxRememberMe.Name = "materialCheckboxRememberMe";
            materialCheckboxRememberMe.ReadOnly = false;
            materialCheckboxRememberMe.Ripple = true;
            materialCheckboxRememberMe.Size = new Size(144, 37);
            materialCheckboxRememberMe.TabIndex = 7;
            materialCheckboxRememberMe.Text = "Atcerēties mani";
            materialCheckboxRememberMe.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(19, 327);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MinimumSize = new Size(250, 0);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(250, 36);
            materialButton2.TabIndex = 8;
            materialButton2.Text = "Neesmu reģistrējies";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabelError
            // 
            materialLabelError.AutoSize = true;
            materialLabelError.Depth = 0;
            materialLabelError.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelError.ForeColor = Color.Red;
            materialLabelError.Location = new Point(19, 369);
            materialLabelError.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelError.Name = "materialLabelError";
            materialLabelError.Size = new Size(46, 19);
            materialLabelError.TabIndex = 9;
            materialLabelError.Text = "Kļūda!";
            materialLabelError.UseAccent = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 397);
            Controls.Add(materialLabelError);
            Controls.Add(materialButton2);
            Controls.Add(materialCheckboxRememberMe);
            Controls.Add(materialButton1);
            Controls.Add(materialLabelPassword);
            Controls.Add(materialTextBoxPassword);
            Controls.Add(materialLabelUsername);
            Controls.Add(materialTextBoxUsername);
            Controls.Add(materialDrawer1);
            FormStyle = FormStyles.ActionBar_48;
            Name = "FormLogin";
            Padding = new Padding(3, 72, 3, 3);
            Text = "Datoru izsniegšanas sistēma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabelUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabelPassword;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxPassword;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxRememberMe;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabelError;
    }
}
