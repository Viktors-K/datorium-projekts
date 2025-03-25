namespace datorium_projekts
{
    partial class FormAdminItems
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
            materialTextBoxType = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxDetails = new MaterialSkin.Controls.MaterialTextBox();
            materialButtonFinish = new MaterialSkin.Controls.MaterialButton();
            materialLabelType = new MaterialSkin.Controls.MaterialLabel();
            materialLabelDetails = new MaterialSkin.Controls.MaterialLabel();
            materialLabelError = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialTextBoxType
            // 
            materialTextBoxType.AnimateReadOnly = false;
            materialTextBoxType.BorderStyle = BorderStyle.None;
            materialTextBoxType.Depth = 0;
            materialTextBoxType.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxType.LeadingIcon = null;
            materialTextBoxType.Location = new Point(19, 96);
            materialTextBoxType.MaxLength = 50;
            materialTextBoxType.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxType.Multiline = false;
            materialTextBoxType.Name = "materialTextBoxType";
            materialTextBoxType.Size = new Size(200, 50);
            materialTextBoxType.TabIndex = 1;
            materialTextBoxType.Text = "";
            materialTextBoxType.TrailingIcon = null;
            // 
            // materialTextBoxDetails
            // 
            materialTextBoxDetails.AnimateReadOnly = false;
            materialTextBoxDetails.BorderStyle = BorderStyle.None;
            materialTextBoxDetails.Depth = 0;
            materialTextBoxDetails.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxDetails.LeadingIcon = null;
            materialTextBoxDetails.Location = new Point(19, 185);
            materialTextBoxDetails.MaxLength = 50;
            materialTextBoxDetails.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxDetails.Multiline = false;
            materialTextBoxDetails.Name = "materialTextBoxDetails";
            materialTextBoxDetails.Size = new Size(200, 50);
            materialTextBoxDetails.TabIndex = 2;
            materialTextBoxDetails.Text = "";
            materialTextBoxDetails.TrailingIcon = null;
            // 
            // materialButtonFinish
            // 
            materialButtonFinish.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonFinish.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonFinish.Depth = 0;
            materialButtonFinish.HighEmphasis = true;
            materialButtonFinish.Icon = null;
            materialButtonFinish.Location = new Point(19, 244);
            materialButtonFinish.Margin = new Padding(4, 6, 4, 6);
            materialButtonFinish.MinimumSize = new Size(200, 0);
            materialButtonFinish.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonFinish.Name = "materialButtonFinish";
            materialButtonFinish.NoAccentTextColor = Color.Empty;
            materialButtonFinish.Size = new Size(200, 36);
            materialButtonFinish.TabIndex = 3;
            materialButtonFinish.Text = "[finish]";
            materialButtonFinish.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonFinish.UseAccentColor = false;
            materialButtonFinish.UseVisualStyleBackColor = true;
            materialButtonFinish.Click += materialButtonFinish_Click;
            // 
            // materialLabelType
            // 
            materialLabelType.AutoSize = true;
            materialLabelType.Depth = 0;
            materialLabelType.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelType.Location = new Point(19, 74);
            materialLabelType.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelType.Name = "materialLabelType";
            materialLabelType.Size = new Size(44, 19);
            materialLabelType.TabIndex = 4;
            materialLabelType.Text = "Veids:";
            // 
            // materialLabelDetails
            // 
            materialLabelDetails.AutoSize = true;
            materialLabelDetails.Depth = 0;
            materialLabelDetails.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelDetails.Location = new Point(19, 163);
            materialLabelDetails.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelDetails.Name = "materialLabelDetails";
            materialLabelDetails.Size = new Size(67, 19);
            materialLabelDetails.TabIndex = 6;
            materialLabelDetails.Text = "Apraksts:";
            // 
            // materialLabelError
            // 
            materialLabelError.AutoSize = true;
            materialLabelError.Depth = 0;
            materialLabelError.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelError.HighEmphasis = true;
            materialLabelError.Location = new Point(19, 286);
            materialLabelError.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelError.Name = "materialLabelError";
            materialLabelError.Size = new Size(41, 19);
            materialLabelError.TabIndex = 7;
            materialLabelError.Text = "[error]";
            materialLabelError.UseAccent = true;
            // 
            // FormAdminItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 318);
            Controls.Add(materialLabelError);
            Controls.Add(materialLabelDetails);
            Controls.Add(materialLabelType);
            Controls.Add(materialButtonFinish);
            Controls.Add(materialTextBoxDetails);
            Controls.Add(materialTextBoxType);
            Name = "FormAdminItems";
            Text = "[usage]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxType;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxDetails;
        private MaterialSkin.Controls.MaterialButton materialButtonFinish;
        private MaterialSkin.Controls.MaterialLabel materialLabelType;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabelDetails;
        private MaterialSkin.Controls.MaterialLabel materialLabelError;
    }
}