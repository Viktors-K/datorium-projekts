namespace datorium_projekts
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            materialTabControlMain = new MaterialSkin.Controls.MaterialTabControl();
            tabPageHandouts = new TabPage();
            tabPageReservations = new TabPage();
            tabPageAdminItem = new TabPage();
            tabPageAdminUser = new TabPage();
            tabPageUser = new TabPage();
            imageListIcons = new ImageList(components);
            materialTabControlMain.SuspendLayout();
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
            materialDrawer1.Location = new Point(-250, 138);
            materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.Size = new Size(250, 120);
            materialDrawer1.TabIndex = 2;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // materialTabControlMain
            // 
            materialTabControlMain.Controls.Add(tabPageHandouts);
            materialTabControlMain.Controls.Add(tabPageReservations);
            materialTabControlMain.Controls.Add(tabPageAdminItem);
            materialTabControlMain.Controls.Add(tabPageAdminUser);
            materialTabControlMain.Controls.Add(tabPageUser);
            materialTabControlMain.Depth = 0;
            materialTabControlMain.ImageList = imageListIcons;
            materialTabControlMain.Location = new Point(0, 24);
            materialTabControlMain.Margin = new Padding(0);
            materialTabControlMain.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControlMain.Multiline = true;
            materialTabControlMain.Name = "materialTabControlMain";
            materialTabControlMain.SelectedIndex = 0;
            materialTabControlMain.Size = new Size(800, 413);
            materialTabControlMain.TabIndex = 3;
            // 
            // tabPageHandouts
            // 
            tabPageHandouts.ImageKey = "home_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png";
            tabPageHandouts.Location = new Point(4, 24);
            tabPageHandouts.Name = "tabPageHandouts";
            tabPageHandouts.Padding = new Padding(3);
            tabPageHandouts.Size = new Size(792, 385);
            tabPageHandouts.TabIndex = 0;
            tabPageHandouts.Text = "Izsniegšana";
            tabPageHandouts.UseVisualStyleBackColor = true;
            // 
            // tabPageReservations
            // 
            tabPageReservations.ImageKey = "schedule_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png";
            tabPageReservations.Location = new Point(4, 24);
            tabPageReservations.Name = "tabPageReservations";
            tabPageReservations.Padding = new Padding(3);
            tabPageReservations.Size = new Size(792, 385);
            tabPageReservations.TabIndex = 1;
            tabPageReservations.Text = "Rezervācijas";
            tabPageReservations.UseVisualStyleBackColor = true;
            // 
            // tabPageAdminItem
            // 
            tabPageAdminItem.ImageKey = "inventory_2_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png";
            tabPageAdminItem.Location = new Point(4, 24);
            tabPageAdminItem.Name = "tabPageAdminItem";
            tabPageAdminItem.Padding = new Padding(3);
            tabPageAdminItem.Size = new Size(792, 385);
            tabPageAdminItem.TabIndex = 2;
            tabPageAdminItem.Text = "Inventārs";
            tabPageAdminItem.UseVisualStyleBackColor = true;
            // 
            // tabPageAdminUser
            // 
            tabPageAdminUser.ImageKey = "manage_accounts_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png";
            tabPageAdminUser.Location = new Point(4, 24);
            tabPageAdminUser.Name = "tabPageAdminUser";
            tabPageAdminUser.Padding = new Padding(3);
            tabPageAdminUser.Size = new Size(792, 385);
            tabPageAdminUser.TabIndex = 3;
            tabPageAdminUser.Text = "Lietotāji";
            tabPageAdminUser.UseVisualStyleBackColor = true;
            // 
            // tabPageUser
            // 
            tabPageUser.ImageKey = "person_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png";
            tabPageUser.Location = new Point(4, 24);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new Padding(3);
            tabPageUser.Size = new Size(792, 385);
            tabPageUser.TabIndex = 4;
            tabPageUser.Text = "Konts";
            tabPageUser.UseVisualStyleBackColor = true;
            // 
            // imageListIcons
            // 
            imageListIcons.ColorDepth = ColorDepth.Depth32Bit;
            imageListIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons.ImageStream");
            imageListIcons.TransparentColor = Color.Transparent;
            imageListIcons.Images.SetKeyName(0, "home_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png");
            imageListIcons.Images.SetKeyName(1, "inventory_2_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png");
            imageListIcons.Images.SetKeyName(2, "manage_accounts_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png");
            imageListIcons.Images.SetKeyName(3, "person_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png");
            imageListIcons.Images.SetKeyName(4, "schedule_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 440);
            Controls.Add(materialTabControlMain);
            Controls.Add(materialDrawer1);
            DrawerAutoShow = true;
            DrawerBackgroundWithAccent = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControlMain;
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Padding = new Padding(0, 24, 3, 3);
            Text = "Datoru izsniegšanas sistēma";
            materialTabControlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControlMain;
        private TabPage tabPageHandouts;
        private TabPage tabPageReservations;
        private TabPage tabPageAdminItem;
        private TabPage tabPageAdminUser;
        private TabPage tabPageUser;
        private ImageList imageListIcons;
    }
}