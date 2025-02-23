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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tabControlMain = new TabControl();
            tabPageDashboard = new TabPage();
            labelNotifications = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            buttonReserve = new Button();
            label3 = new Label();
            groupBoxUserControls = new GroupBox();
            labelWelcome = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            buttonUserChangeInfo = new Button();
            button6 = new Button();
            labelRole = new Label();
            listBoxNotifications = new ListBox();
            dataGridViewItems = new DataGridView();
            tabPageReservations = new TabPage();
            tabPageAdminItem = new TabPage();
            tabPageAdminUser = new TabPage();
            tabControlMain.SuspendLayout();
            tabPageDashboard.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBoxUserControls.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageDashboard);
            tabControlMain.Controls.Add(tabPageReservations);
            tabControlMain.Controls.Add(tabPageAdminItem);
            tabControlMain.Controls.Add(tabPageAdminUser);
            tabControlMain.Location = new Point(12, 12);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(776, 417);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.Controls.Add(labelNotifications);
            tabPageDashboard.Controls.Add(groupBox2);
            tabPageDashboard.Controls.Add(groupBoxUserControls);
            tabPageDashboard.Controls.Add(listBoxNotifications);
            tabPageDashboard.Controls.Add(dataGridViewItems);
            tabPageDashboard.Location = new Point(4, 24);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(3);
            tabPageDashboard.Size = new Size(768, 389);
            tabPageDashboard.TabIndex = 0;
            tabPageDashboard.Text = "Datori un rīki";
            tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // labelNotifications
            // 
            labelNotifications.AutoSize = true;
            labelNotifications.Location = new Point(620, 15);
            labelNotifications.Name = "labelNotifications";
            labelNotifications.Size = new Size(69, 15);
            labelNotifications.TabIndex = 5;
            labelNotifications.Text = "Paziņojumi:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(6, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(189, 185);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Izsniegumu kontrole";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "sample1";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(buttonReserve);
            groupBox3.Location = new Point(6, 63);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(177, 111);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ātrās darbības";
            // 
            // button1
            // 
            button1.Location = new Point(6, 80);
            button1.Name = "button1";
            button1.Size = new Size(165, 23);
            button1.TabIndex = 0;
            button1.Text = "Atgriezt";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 51);
            button2.Name = "button2";
            button2.Size = new Size(165, 23);
            button2.TabIndex = 0;
            button2.Text = "Izsniegt";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonReserve
            // 
            buttonReserve.Location = new Point(6, 22);
            buttonReserve.Name = "buttonReserve";
            buttonReserve.Size = new Size(165, 23);
            buttonReserve.TabIndex = 0;
            buttonReserve.Text = "Rezervēt";
            buttonReserve.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 34);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "sample2";
            // 
            // groupBoxUserControls
            // 
            groupBoxUserControls.Controls.Add(labelWelcome);
            groupBoxUserControls.Controls.Add(groupBox1);
            groupBoxUserControls.Controls.Add(labelRole);
            groupBoxUserControls.Location = new Point(6, 6);
            groupBoxUserControls.Name = "groupBoxUserControls";
            groupBoxUserControls.Size = new Size(189, 185);
            groupBoxUserControls.TabIndex = 5;
            groupBoxUserControls.TabStop = false;
            groupBoxUserControls.Text = "Lietotājs [username]";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(6, 19);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(105, 15);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Laipni lūgti, [user]!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(buttonUserChangeInfo);
            groupBox1.Controls.Add(button6);
            groupBox1.Location = new Point(6, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 111);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lietotāja rediģēšana";
            // 
            // button4
            // 
            button4.Location = new Point(6, 80);
            button4.Name = "button4";
            button4.Size = new Size(165, 23);
            button4.TabIndex = 0;
            button4.Text = "Preferences...";
            button4.UseVisualStyleBackColor = true;
            // 
            // buttonUserChangeInfo
            // 
            buttonUserChangeInfo.Location = new Point(6, 51);
            buttonUserChangeInfo.Name = "buttonUserChangeInfo";
            buttonUserChangeInfo.Size = new Size(165, 23);
            buttonUserChangeInfo.TabIndex = 0;
            buttonUserChangeInfo.Text = "Mainīt profila informāciju";
            buttonUserChangeInfo.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(6, 22);
            button6.Name = "button6";
            button6.Size = new Size(165, 23);
            button6.TabIndex = 0;
            button6.Text = "Mainīt paroli";
            button6.UseVisualStyleBackColor = true;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(6, 34);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(112, 15);
            labelRole.TabIndex = 1;
            labelRole.Text = "Pieslēdzies kā: [role]";
            // 
            // listBoxNotifications
            // 
            listBoxNotifications.FormattingEnabled = true;
            listBoxNotifications.ItemHeight = 15;
            listBoxNotifications.Location = new Point(620, 33);
            listBoxNotifications.Name = "listBoxNotifications";
            listBoxNotifications.Size = new Size(142, 349);
            listBoxNotifications.TabIndex = 4;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.AllowUserToAddRows = false;
            dataGridViewItems.AllowUserToDeleteRows = false;
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(201, 6);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.ReadOnly = true;
            dataGridViewItems.Size = new Size(413, 376);
            dataGridViewItems.TabIndex = 2;
            // 
            // tabPageReservations
            // 
            tabPageReservations.Location = new Point(4, 24);
            tabPageReservations.Name = "tabPageReservations";
            tabPageReservations.Padding = new Padding(3);
            tabPageReservations.Size = new Size(768, 389);
            tabPageReservations.TabIndex = 1;
            tabPageReservations.Text = "Rezervācijas";
            tabPageReservations.UseVisualStyleBackColor = true;
            // 
            // tabPageAdminItem
            // 
            tabPageAdminItem.Location = new Point(4, 24);
            tabPageAdminItem.Name = "tabPageAdminItem";
            tabPageAdminItem.Padding = new Padding(3);
            tabPageAdminItem.Size = new Size(768, 389);
            tabPageAdminItem.TabIndex = 2;
            tabPageAdminItem.Text = "Vienumu rediģēšana";
            tabPageAdminItem.UseVisualStyleBackColor = true;
            // 
            // tabPageAdminUser
            // 
            tabPageAdminUser.Location = new Point(4, 24);
            tabPageAdminUser.Name = "tabPageAdminUser";
            tabPageAdminUser.Padding = new Padding(3);
            tabPageAdminUser.Size = new Size(768, 389);
            tabPageAdminUser.TabIndex = 3;
            tabPageAdminUser.Text = "Lietotāju rediģēšana";
            tabPageAdminUser.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 440);
            Controls.Add(tabControlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "Datoru izsniegšanas sistēma";
            tabControlMain.ResumeLayout(false);
            tabPageDashboard.ResumeLayout(false);
            tabPageDashboard.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBoxUserControls.ResumeLayout(false);
            groupBoxUserControls.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageDashboard;
        private TabPage tabPageReservations;
        private TabPage tabPageAdminItem;
        private DataGridView dataGridViewItems;
        private Label labelRole;
        private Label labelWelcome;
        private GroupBox groupBox1;
        private Button button4;
        private Button buttonUserChangeInfo;
        private Button button6;
        private ListBox listBoxNotifications;
        private GroupBox groupBoxUserControls;
        private Label labelNotifications;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
        private Button button1;
        private Button button2;
        private Button buttonReserve;
        private Label label3;
        private TabPage tabPageAdminUser;
    }
}