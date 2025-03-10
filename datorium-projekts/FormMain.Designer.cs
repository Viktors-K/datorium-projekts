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
            materialListViewItems = new MaterialSkin.Controls.MaterialListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            tabPageReservations = new TabPage();
            tabPageUser = new TabPage();
            materialCardProfile = new MaterialSkin.Controls.MaterialCard();
            materialLabelGrade = new MaterialSkin.Controls.MaterialLabel();
            materialLabelName = new MaterialSkin.Controls.MaterialLabel();
            materialLabelUsername = new MaterialSkin.Controls.MaterialLabel();
            tabPageAdminItem = new TabPage();
            tabPageAdminUser = new TabPage();
            imageListIcons = new ImageList(components);
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            columnHeaderID = new ColumnHeader();
            columnHeaderUsername = new ColumnHeader();
            columnHeaderEmail = new ColumnHeader();
            columnHeaderAdmin = new ColumnHeader();
            columnHeaderName = new ColumnHeader();
            columnHeaderSurname = new ColumnHeader();
            columnHeaderGrade = new ColumnHeader();
            materialTabControlMain.SuspendLayout();
            tabPageHandouts.SuspendLayout();
            tabPageUser.SuspendLayout();
            materialCardProfile.SuspendLayout();
            tabPageAdminUser.SuspendLayout();
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
            materialTabControlMain.Controls.Add(tabPageUser);
            materialTabControlMain.Controls.Add(tabPageAdminItem);
            materialTabControlMain.Controls.Add(tabPageAdminUser);
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
            tabPageHandouts.Controls.Add(materialListViewItems);
            tabPageHandouts.ImageKey = "home_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png";
            tabPageHandouts.Location = new Point(4, 24);
            tabPageHandouts.Name = "tabPageHandouts";
            tabPageHandouts.Size = new Size(792, 385);
            tabPageHandouts.TabIndex = 5;
            tabPageHandouts.Text = "Izsniegumi";
            tabPageHandouts.UseVisualStyleBackColor = true;
            // 
            // materialListViewItems
            // 
            materialListViewItems.AutoSizeTable = false;
            materialListViewItems.BackColor = Color.FromArgb(255, 255, 255);
            materialListViewItems.BorderStyle = BorderStyle.None;
            materialListViewItems.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            materialListViewItems.Depth = 0;
            materialListViewItems.FullRowSelect = true;
            materialListViewItems.Location = new Point(50, 0);
            materialListViewItems.MaximumSize = new Size(750, 200);
            materialListViewItems.MinimumSize = new Size(750, 100);
            materialListViewItems.MouseLocation = new Point(-1, -1);
            materialListViewItems.MouseState = MaterialSkin.MouseState.OUT;
            materialListViewItems.Name = "materialListViewItems";
            materialListViewItems.OwnerDraw = true;
            materialListViewItems.Size = new Size(750, 200);
            materialListViewItems.TabIndex = 2;
            materialListViewItems.UseCompatibleStateImageBehavior = false;
            materialListViewItems.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ID";
            columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Veids";
            columnHeader6.Width = 125;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Apraksts";
            columnHeader7.Width = 450;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Statuss";
            columnHeader8.Width = 125;
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
            // tabPageUser
            // 
            tabPageUser.Controls.Add(materialCardProfile);
            tabPageUser.ImageKey = "person_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png";
            tabPageUser.Location = new Point(4, 24);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new Padding(3);
            tabPageUser.Size = new Size(792, 385);
            tabPageUser.TabIndex = 4;
            tabPageUser.Text = "Konts";
            tabPageUser.UseVisualStyleBackColor = true;
            // 
            // materialCardProfile
            // 
            materialCardProfile.BackColor = Color.FromArgb(255, 255, 255);
            materialCardProfile.Controls.Add(materialLabelGrade);
            materialCardProfile.Controls.Add(materialLabelName);
            materialCardProfile.Controls.Add(materialLabelUsername);
            materialCardProfile.Depth = 0;
            materialCardProfile.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardProfile.Location = new Point(70, 10);
            materialCardProfile.Margin = new Padding(14);
            materialCardProfile.MouseState = MaterialSkin.MouseState.HOVER;
            materialCardProfile.Name = "materialCardProfile";
            materialCardProfile.Padding = new Padding(14);
            materialCardProfile.Size = new Size(284, 161);
            materialCardProfile.TabIndex = 0;
            // 
            // materialLabelGrade
            // 
            materialLabelGrade.AutoSize = true;
            materialLabelGrade.Depth = 0;
            materialLabelGrade.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelGrade.Location = new Point(10, 73);
            materialLabelGrade.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelGrade.Name = "materialLabelGrade";
            materialLabelGrade.Size = new Size(49, 19);
            materialLabelGrade.TabIndex = 2;
            materialLabelGrade.Text = "[grade]";
            // 
            // materialLabelName
            // 
            materialLabelName.AutoSize = true;
            materialLabelName.Depth = 0;
            materialLabelName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelName.Location = new Point(10, 44);
            materialLabelName.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelName.Name = "materialLabelName";
            materialLabelName.Size = new Size(123, 19);
            materialLabelName.TabIndex = 1;
            materialLabelName.Text = "[name] [surname]";
            // 
            // materialLabelUsername
            // 
            materialLabelUsername.AutoSize = true;
            materialLabelUsername.Depth = 0;
            materialLabelUsername.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabelUsername.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabelUsername.Location = new Point(10, 10);
            materialLabelUsername.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelUsername.Name = "materialLabelUsername";
            materialLabelUsername.Size = new Size(183, 24);
            materialLabelUsername.TabIndex = 0;
            materialLabelUsername.Text = "Lietotājs [username]";
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
            tabPageAdminUser.Controls.Add(materialListView1);
            tabPageAdminUser.ImageKey = "manage_accounts_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png";
            tabPageAdminUser.Location = new Point(4, 24);
            tabPageAdminUser.Name = "tabPageAdminUser";
            tabPageAdminUser.Padding = new Padding(3);
            tabPageAdminUser.Size = new Size(792, 385);
            tabPageAdminUser.TabIndex = 3;
            tabPageAdminUser.Text = "Lietotāji";
            tabPageAdminUser.UseVisualStyleBackColor = true;
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
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Columns.AddRange(new ColumnHeader[] { columnHeaderID, columnHeaderUsername, columnHeaderEmail, columnHeaderAdmin, columnHeaderName, columnHeaderSurname, columnHeaderGrade });
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(60, 0);
            materialListView1.MaximumSize = new Size(730, 200);
            materialListView1.MinimumSize = new Size(730, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(730, 200);
            materialListView1.TabIndex = 3;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // columnHeaderID
            // 
            columnHeaderID.Text = "ID";
            columnHeaderID.Width = 50;
            // 
            // columnHeaderUsername
            // 
            columnHeaderUsername.Text = "Lietotājvārds";
            columnHeaderUsername.Width = 125;
            // 
            // columnHeaderEmail
            // 
            columnHeaderEmail.Text = "E-pasts";
            columnHeaderEmail.Width = 200;
            // 
            // columnHeaderAdmin
            // 
            columnHeaderAdmin.Text = "Statuss";
            columnHeaderAdmin.Width = 125;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Vārds";
            // 
            // columnHeaderSurname
            // 
            columnHeaderSurname.Text = "Uzvārds";
            // 
            // columnHeaderGrade
            // 
            columnHeaderGrade.Text = "Klase";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(992, 440);
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
            tabPageHandouts.ResumeLayout(false);
            tabPageUser.ResumeLayout(false);
            materialCardProfile.ResumeLayout(false);
            materialCardProfile.PerformLayout();
            tabPageAdminUser.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControlMain;
        private TabPage tabPageReservations;
        private TabPage tabPageAdminItem;
        private TabPage tabPageAdminUser;
        private TabPage tabPageUser;
        private ImageList imageListIcons;
        private TabPage tabPageHandouts;
        private MaterialSkin.Controls.MaterialListView materialListViewItems;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialCard materialCardProfile;
        private MaterialSkin.Controls.MaterialLabel materialLabelUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabelName;
        private MaterialSkin.Controls.MaterialLabel materialLabelGrade;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader columnHeaderID;
        private ColumnHeader columnHeaderUsername;
        private ColumnHeader columnHeaderEmail;
        private ColumnHeader columnHeaderAdmin;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderSurname;
        private ColumnHeader columnHeaderGrade;
    }
}