namespace datorium_projekts
{
    partial class FormHandouts
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
            materialLabelError = new MaterialSkin.Controls.MaterialLabel();
            materialLabelType = new MaterialSkin.Controls.MaterialLabel();
            materialButtonFinish = new MaterialSkin.Controls.MaterialButton();
            materialTextBoxType = new MaterialSkin.Controls.MaterialTextBox();
            dtpTimeUntil = new DateTimePicker();
            materialLabelTimeUntil = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialLabelError
            // 
            materialLabelError.AutoSize = true;
            materialLabelError.Depth = 0;
            materialLabelError.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelError.HighEmphasis = true;
            materialLabelError.Location = new Point(24, 267);
            materialLabelError.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelError.Name = "materialLabelError";
            materialLabelError.Size = new Size(41, 19);
            materialLabelError.TabIndex = 11;
            materialLabelError.Text = "[error]";
            materialLabelError.UseAccent = true;
            // 
            // materialLabelType
            // 
            materialLabelType.AutoSize = true;
            materialLabelType.Depth = 0;
            materialLabelType.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelType.Location = new Point(24, 83);
            materialLabelType.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelType.Name = "materialLabelType";
            materialLabelType.Size = new Size(67, 19);
            materialLabelType.TabIndex = 10;
            materialLabelType.Text = "Vienums:";
            // 
            // materialButtonFinish
            // 
            materialButtonFinish.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonFinish.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonFinish.Depth = 0;
            materialButtonFinish.HighEmphasis = true;
            materialButtonFinish.Icon = null;
            materialButtonFinish.Location = new Point(24, 225);
            materialButtonFinish.Margin = new Padding(4, 6, 4, 6);
            materialButtonFinish.MinimumSize = new Size(200, 0);
            materialButtonFinish.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonFinish.Name = "materialButtonFinish";
            materialButtonFinish.NoAccentTextColor = Color.Empty;
            materialButtonFinish.Size = new Size(200, 36);
            materialButtonFinish.TabIndex = 9;
            materialButtonFinish.Text = "Izsniegt";
            materialButtonFinish.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonFinish.UseAccentColor = false;
            materialButtonFinish.UseVisualStyleBackColor = true;
            materialButtonFinish.Click += materialButtonFinish_Click;
            // 
            // materialTextBoxType
            // 
            materialTextBoxType.AnimateReadOnly = false;
            materialTextBoxType.BorderStyle = BorderStyle.None;
            materialTextBoxType.Depth = 0;
            materialTextBoxType.Enabled = false;
            materialTextBoxType.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxType.LeadingIcon = null;
            materialTextBoxType.Location = new Point(24, 105);
            materialTextBoxType.MaxLength = 50;
            materialTextBoxType.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxType.Multiline = false;
            materialTextBoxType.Name = "materialTextBoxType";
            materialTextBoxType.Size = new Size(200, 50);
            materialTextBoxType.TabIndex = 8;
            materialTextBoxType.Text = "";
            materialTextBoxType.TrailingIcon = null;
            // 
            // dtpTimeUntil
            // 
            dtpTimeUntil.Location = new Point(24, 189);
            dtpTimeUntil.Name = "dtpTimeUntil";
            dtpTimeUntil.Size = new Size(200, 23);
            dtpTimeUntil.TabIndex = 12;
            // 
            // materialLabelTimeUntil
            // 
            materialLabelTimeUntil.AutoSize = true;
            materialLabelTimeUntil.Depth = 0;
            materialLabelTimeUntil.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelTimeUntil.Location = new Point(24, 167);
            materialLabelTimeUntil.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelTimeUntil.Name = "materialLabelTimeUntil";
            materialLabelTimeUntil.Size = new Size(89, 19);
            materialLabelTimeUntil.TabIndex = 13;
            materialLabelTimeUntil.Text = "Izsniegt līdz:";
            // 
            // FormHandouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 300);
            Controls.Add(materialLabelTimeUntil);
            Controls.Add(dtpTimeUntil);
            Controls.Add(materialLabelError);
            Controls.Add(materialLabelType);
            Controls.Add(materialButtonFinish);
            Controls.Add(materialTextBoxType);
            MaximumSize = new Size(248, 300);
            MinimumSize = new Size(248, 300);
            Name = "FormHandouts";
            Text = "Izsniegt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabelError;
        private MaterialSkin.Controls.MaterialLabel materialLabelType;
        private MaterialSkin.Controls.MaterialButton materialButtonFinish;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxType;
        private DateTimePicker dtpTimeUntil;
        private MaterialSkin.Controls.MaterialLabel materialLabelTimeUntil;
    }
}