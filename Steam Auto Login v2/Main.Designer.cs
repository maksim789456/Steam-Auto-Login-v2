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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.acc1 = new System.Windows.Forms.Button();
            this.acc3 = new System.Windows.Forms.Button();
            this.acc2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.выборФайлаSteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ручнойЗапускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acc4 = new System.Windows.Forms.Button();
            this.edit_data = new System.Windows.Forms.Button();
            this.login_in = new System.Windows.Forms.Button();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.менюToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterAccount,
            this.выборФайлаSteamToolStripMenuItem,
            this.ручнойЗапускToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // enterAccount
            // 
            this.enterAccount.Name = "enterAccount";
            this.enterAccount.Size = new System.Drawing.Size(194, 22);
            this.enterAccount.Text = "Вход в другой аккаунт";
            // 
            // выборФайлаSteamToolStripMenuItem
            // 
            this.выборФайлаSteamToolStripMenuItem.Name = "выборФайлаSteamToolStripMenuItem";
            this.выборФайлаSteamToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.выборФайлаSteamToolStripMenuItem.Text = "Выбор файла Steam...";
            // 
            // ручнойЗапускToolStripMenuItem
            // 
            this.ручнойЗапускToolStripMenuItem.Name = "ручнойЗапускToolStripMenuItem";
            this.ручнойЗапускToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ручнойЗапускToolStripMenuItem.Text = "Ручной запуск";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShowShortcutKeys = false;
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.выходToolStripMenuItem.Text = "Выход";
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
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
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
            this.Text = "Steam Auto Login";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterAccount;
        private System.Windows.Forms.ToolStripMenuItem выборФайлаSteamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ручнойЗапускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button acc4;
        private System.Windows.Forms.Button edit_data;
        private System.Windows.Forms.Button login_in;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}