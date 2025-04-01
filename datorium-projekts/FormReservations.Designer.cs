namespace datorium_projekts
{
    partial class FormReservations
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
            materialLabelTimeFrom = new MaterialSkin.Controls.MaterialLabel();
            dtpTimeFrom = new DateTimePicker();
            materialLabelType = new MaterialSkin.Controls.MaterialLabel();
            materialTextBoxType = new MaterialSkin.Controls.MaterialTextBox();
            materialLabelError = new MaterialSkin.Controls.MaterialLabel();
            materialButtonFinish = new MaterialSkin.Controls.MaterialButton();
            materialLabelTimeUntil = new MaterialSkin.Controls.MaterialLabel();
            dtpTimeUntil = new DateTimePicker();
            SuspendLayout();
            // 
            // materialLabelTimeFrom
            // 
            materialLabelTimeFrom.AutoSize = true;
            materialLabelTimeFrom.Depth = 0;
            materialLabelTimeFrom.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelTimeFrom.Location = new Point(24, 161);
            materialLabelTimeFrom.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelTimeFrom.Name = "materialLabelTimeFrom";
            materialLabelTimeFrom.Size = new Size(87, 19);
            materialLabelTimeFrom.TabIndex = 17;
            materialLabelTimeFrom.Text = "Rezervēt no:";
            // 
            // dtpTimeFrom
            // 
            dtpTimeFrom.Location = new Point(24, 183);
            dtpTimeFrom.Name = "dtpTimeFrom";
            dtpTimeFrom.Size = new Size(200, 23);
            dtpTimeFrom.TabIndex = 16;
            // 
            // materialLabelType
            // 
            materialLabelType.AutoSize = true;
            materialLabelType.Depth = 0;
            materialLabelType.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelType.Location = new Point(24, 77);
            materialLabelType.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelType.Name = "materialLabelType";
            materialLabelType.Size = new Size(67, 19);
            materialLabelType.TabIndex = 15;
            materialLabelType.Text = "Vienums:";
            // 
            // materialTextBoxType
            // 
            materialTextBoxType.AnimateReadOnly = false;
            materialTextBoxType.BorderStyle = BorderStyle.None;
            materialTextBoxType.Depth = 0;
            materialTextBoxType.Enabled = false;
            materialTextBoxType.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxType.LeadingIcon = null;
            materialTextBoxType.Location = new Point(24, 99);
            materialTextBoxType.MaxLength = 50;
            materialTextBoxType.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxType.Multiline = false;
            materialTextBoxType.Name = "materialTextBoxType";
            materialTextBoxType.Size = new Size(200, 50);
            materialTextBoxType.TabIndex = 14;
            materialTextBoxType.Text = "";
            materialTextBoxType.TrailingIcon = null;
            // 
            // materialLabelError
            // 
            materialLabelError.AutoSize = true;
            materialLabelError.Depth = 0;
            materialLabelError.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelError.HighEmphasis = true;
            materialLabelError.Location = new Point(24, 314);
            materialLabelError.MaximumSize = new Size(200, 0);
            materialLabelError.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelError.Name = "materialLabelError";
            materialLabelError.Size = new Size(41, 19);
            materialLabelError.TabIndex = 19;
            materialLabelError.Text = "[error]";
            materialLabelError.UseAccent = true;
            // 
            // materialButtonFinish
            // 
            materialButtonFinish.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonFinish.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonFinish.Depth = 0;
            materialButtonFinish.HighEmphasis = true;
            materialButtonFinish.Icon = null;
            materialButtonFinish.Location = new Point(24, 272);
            materialButtonFinish.Margin = new Padding(4, 6, 4, 6);
            materialButtonFinish.MinimumSize = new Size(200, 0);
            materialButtonFinish.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonFinish.Name = "materialButtonFinish";
            materialButtonFinish.NoAccentTextColor = Color.Empty;
            materialButtonFinish.Size = new Size(200, 36);
            materialButtonFinish.TabIndex = 18;
            materialButtonFinish.Text = "Rezervēt";
            materialButtonFinish.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonFinish.UseAccentColor = false;
            materialButtonFinish.UseVisualStyleBackColor = true;
            materialButtonFinish.Click += materialButtonFinish_Click;
            // 
            // materialLabelTimeUntil
            // 
            materialLabelTimeUntil.AutoSize = true;
            materialLabelTimeUntil.Depth = 0;
            materialLabelTimeUntil.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelTimeUntil.Location = new Point(24, 218);
            materialLabelTimeUntil.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelTimeUntil.Name = "materialLabelTimeUntil";
            materialLabelTimeUntil.Size = new Size(94, 19);
            materialLabelTimeUntil.TabIndex = 21;
            materialLabelTimeUntil.Text = "Rezervēt līdz:";
            // 
            // dtpTimeUntil
            // 
            dtpTimeUntil.Location = new Point(24, 240);
            dtpTimeUntil.Name = "dtpTimeUntil";
            dtpTimeUntil.Size = new Size(200, 23);
            dtpTimeUntil.TabIndex = 20;
            // 
            // FormReservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 361);
            Controls.Add(materialLabelTimeUntil);
            Controls.Add(dtpTimeUntil);
            Controls.Add(materialLabelError);
            Controls.Add(materialButtonFinish);
            Controls.Add(materialLabelTimeFrom);
            Controls.Add(dtpTimeFrom);
            Controls.Add(materialLabelType);
            Controls.Add(materialTextBoxType);
            Name = "FormReservations";
            Text = "Rezervēt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabelTimeFrom;
        private DateTimePicker dtpTimeFrom;
        private MaterialSkin.Controls.MaterialLabel materialLabelType;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxType;
        private MaterialSkin.Controls.MaterialLabel materialLabelError;
        private MaterialSkin.Controls.MaterialButton materialButtonFinish;
        private MaterialSkin.Controls.MaterialLabel materialLabelTimeUntil;
        private DateTimePicker dtpTimeUntil;
    }
}