namespace Steam_Auto_Login_v2
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.acc3 = new System.Windows.Forms.Button();
            this.acc2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.enterAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSteamPath = new System.Windows.Forms.ToolStripMenuItem();
            this.manualStartToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manualStart = new System.Windows.Forms.ToolStripMenuItem();
            this.manualStartTCP = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.infoAboutProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.acc4 = new System.Windows.Forms.Button();
            this.edit_data = new System.Windows.Forms.Button();
            this.login_in = new System.Windows.Forms.Button();
            this.folderBrowserDialogMain = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_ = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enterAccount_ = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSteamPath_ = new System.Windows.Forms.ToolStripMenuItem();
            this.manualStartToolStripMenu_ = new System.Windows.Forms.ToolStripMenuItem();
            this.manualStart_ = new System.Windows.Forms.ToolStripMenuItem();
            this.manualStartTCP_ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1_ = new System.Windows.Forms.ToolStripSeparator();
            this.mExit_ = new System.Windows.Forms.ToolStripMenuItem();
            this.acc1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip_.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аккаунты:";
            // 
            // acc3
            // 
            this.acc3.Location = new System.Drawing.Point(16, 145);
            this.acc3.Name = "acc3";
            this.acc3.Size = new System.Drawing.Size(121, 76);
            this.acc3.TabIndex = 4;
            this.acc3.Text = "3";
            this.acc3.UseVisualStyleBackColor = true;
            this.acc3.Click += new System.EventHandler(this.acc3_Click);
            // 
            // acc2
            // 
            this.acc2.Location = new System.Drawing.Point(143, 63);
            this.acc2.Name = "acc2";
            this.acc2.Size = new System.Drawing.Size(121, 76);
            this.acc2.TabIndex = 5;
            this.acc2.Text = "2";
            this.acc2.UseVisualStyleBackColor = true;
            this.acc2.Click += new System.EventHandler(this.acc2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 280);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(252, 30);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Запуск Steam с использованием протокола \r\nTCP, а не протокола UDP\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMenu,
            this.infoMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuMenu
            // 
            this.menuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterAccount,
            this.selectSteamPath,
            this.manualStartToolStripMenu,
            this.mExit});
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(53, 20);
            this.menuMenu.Text = "Меню";
            // 
            // enterAccount
            // 
            this.enterAccount.Name = "enterAccount";
            this.enterAccount.Size = new System.Drawing.Size(194, 22);
            this.enterAccount.Text = "Вход в другой аккаунт";
            this.enterAccount.Click += new System.EventHandler(this.enterAccount_Click);
            // 
            // selectSteamPath
            // 
            this.selectSteamPath.Name = "selectSteamPath";
            this.selectSteamPath.Size = new System.Drawing.Size(194, 22);
            this.selectSteamPath.Text = "Выбор файла Steam...";
            this.selectSteamPath.Click += new System.EventHandler(this.selectSteamPath_Click);
            // 
            // manualStartToolStripMenu
            // 
            this.manualStartToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualStart,
            this.manualStartTCP});
            this.manualStartToolStripMenu.Name = "manualStartToolStripMenu";
            this.manualStartToolStripMenu.Size = new System.Drawing.Size(194, 22);
            this.manualStartToolStripMenu.Text = "Ручной запуск";
            // 
            // manualStart
            // 
            this.manualStart.Name = "manualStart";
            this.manualStart.Size = new System.Drawing.Size(203, 22);
            this.manualStart.Text = "Обычный";
            // 
            // manualStartTCP
            // 
            this.manualStartTCP.Name = "manualStartTCP";
            this.manualStartTCP.Size = new System.Drawing.Size(203, 22);
            this.manualStartTCP.Text = "С использованием TCP";
            this.manualStartTCP.Click += new System.EventHandler(this.manualStartTCP_Click);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.ShowShortcutKeys = false;
            this.mExit.Size = new System.Drawing.Size(194, 22);
            this.mExit.Text = "Выход";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // infoMenu
            // 
            this.infoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoAboutProgramm});
            this.infoMenu.Name = "infoMenu";
            this.infoMenu.Size = new System.Drawing.Size(93, 20);
            this.infoMenu.Text = "Информация";
            // 
            // infoAboutProgramm
            // 
            this.infoAboutProgramm.Name = "infoAboutProgramm";
            this.infoAboutProgramm.Size = new System.Drawing.Size(149, 22);
            this.infoAboutProgramm.Text = "О программе";
            this.infoAboutProgramm.Click += new System.EventHandler(this.infoAboutProgramm_Click);
            // 
            // acc4
            // 
            this.acc4.Location = new System.Drawing.Point(143, 145);
            this.acc4.Name = "acc4";
            this.acc4.Size = new System.Drawing.Size(121, 76);
            this.acc4.TabIndex = 12;
            this.acc4.Text = "4";
            this.acc4.UseVisualStyleBackColor = true;
            this.acc4.Click += new System.EventHandler(this.acc4_Click);
            // 
            // edit_data
            // 
            this.edit_data.Location = new System.Drawing.Point(16, 227);
            this.edit_data.Name = "edit_data";
            this.edit_data.Size = new System.Drawing.Size(121, 47);
            this.edit_data.TabIndex = 13;
            this.edit_data.Text = "Изменение данных";
            this.edit_data.UseVisualStyleBackColor = true;
            this.edit_data.Click += new System.EventHandler(this.edit_data_Click);
            // 
            // login_in
            // 
            this.login_in.Location = new System.Drawing.Point(143, 227);
            this.login_in.Name = "login_in";
            this.login_in.Size = new System.Drawing.Size(121, 47);
            this.login_in.TabIndex = 14;
            this.login_in.Text = "Вход в другой аккаунт...";
            this.login_in.UseVisualStyleBackColor = true;
            this.login_in.Click += new System.EventHandler(this.login_in_Click);
            // 
            // folderBrowserDialogMain
            // 
            this.folderBrowserDialogMain.RootFolder = System.Environment.SpecialFolder.ProgramFilesX86;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip_;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Steam Auto Login";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip_
            // 
            this.contextMenuStrip_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterAccount_,
            this.selectSteamPath_,
            this.manualStartToolStripMenu_,
            this.toolStripSeparator1_,
            this.mExit_});
            this.contextMenuStrip_.Name = "contextMenuStrip_";
            this.contextMenuStrip_.Size = new System.Drawing.Size(195, 98);
            // 
            // enterAccount_
            // 
            this.enterAccount_.Name = "enterAccount_";
            this.enterAccount_.Size = new System.Drawing.Size(194, 22);
            this.enterAccount_.Text = "Вход в другой аккаунт";
            // 
            // selectSteamPath_
            // 
            this.selectSteamPath_.Name = "selectSteamPath_";
            this.selectSteamPath_.Size = new System.Drawing.Size(194, 22);
            this.selectSteamPath_.Text = "Выбор файла Steam...";
            // 
            // manualStartToolStripMenu_
            // 
            this.manualStartToolStripMenu_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualStart_,
            this.manualStartTCP_});
            this.manualStartToolStripMenu_.Name = "manualStartToolStripMenu_";
            this.manualStartToolStripMenu_.Size = new System.Drawing.Size(194, 22);
            this.manualStartToolStripMenu_.Text = "Ручной запуск";
            // 
            // manualStart_
            // 
            this.manualStart_.Name = "manualStart_";
            this.manualStart_.Size = new System.Drawing.Size(203, 22);
            this.manualStart_.Text = "Обычный";
            // 
            // manualStartTCP_
            // 
            this.manualStartTCP_.Name = "manualStartTCP_";
            this.manualStartTCP_.Size = new System.Drawing.Size(203, 22);
            this.manualStartTCP_.Text = "С использованием TCP";
            // 
            // toolStripSeparator1_
            // 
            this.toolStripSeparator1_.Name = "toolStripSeparator1_";
            this.toolStripSeparator1_.Size = new System.Drawing.Size(191, 6);
            // 
            // mExit_
            // 
            this.mExit_.Name = "mExit_";
            this.mExit_.Size = new System.Drawing.Size(194, 22);
            this.mExit_.Text = "Выход";
            // 
            // acc1
            // 
            this.acc1.Location = new System.Drawing.Point(16, 63);
            this.acc1.Name = "acc1";
            this.acc1.Size = new System.Drawing.Size(121, 76);
            this.acc1.TabIndex = 3;
            this.acc1.Text = "1";
            this.acc1.UseVisualStyleBackColor = true;
            this.acc1.Click += new System.EventHandler(this.acc1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 314);
            this.Controls.Add(this.login_in);
            this.Controls.Add(this.edit_data);
            this.Controls.Add(this.acc4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.acc2);
            this.Controls.Add(this.acc3);
            this.Controls.Add(this.acc1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.Text = "Steam Auto Login";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip_.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acc1;
        private System.Windows.Forms.Button acc3;
        private System.Windows.Forms.Button acc2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMenu;
        private System.Windows.Forms.ToolStripMenuItem enterAccount;
        private System.Windows.Forms.ToolStripMenuItem selectSteamPath;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.Button acc4;
        private System.Windows.Forms.Button edit_data;
        private System.Windows.Forms.Button login_in;
        private System.Windows.Forms.ToolStripMenuItem infoMenu;
        private System.Windows.Forms.ToolStripMenuItem infoAboutProgramm;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMain;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_;
        private System.Windows.Forms.ToolStripMenuItem enterAccount_;
        private System.Windows.Forms.ToolStripMenuItem selectSteamPath_;
        private System.Windows.Forms.ToolStripMenuItem manualStartToolStripMenu_;
        private System.Windows.Forms.ToolStripMenuItem manualStart_;
        private System.Windows.Forms.ToolStripMenuItem manualStartTCP_;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1_;
        private System.Windows.Forms.ToolStripMenuItem mExit_;
        private System.Windows.Forms.ToolStripMenuItem manualStartToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem manualStart;
        private System.Windows.Forms.ToolStripMenuItem manualStartTCP;
    }
}