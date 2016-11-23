namespace Tanks
{
    partial class ControllerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControllerMainForm));
            this.Start_Stop_btn = new System.Windows.Forms.Button();
            this.Help_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Main_Menu_Strip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.countTanksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CBTanks = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.countApplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CBApplesOnMap = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.applesForWinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CBApplesForWin = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.speedGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CBSpeedGame = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.sizeOfFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CBSizeField = new System.Windows.Forms.ToolStripComboBox();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.Main_statusStrip = new System.Windows.Forms.StatusStrip();
            this.Main_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GameStLbl = new System.Windows.Forms.Label();
            this.Main_Menu_Strip.SuspendLayout();
            this.Main_statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start_Stop_btn
            // 
            this.Start_Stop_btn.AutoSize = true;
            this.Start_Stop_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Start_Stop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Start_Stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Start_Stop_btn.FlatAppearance.BorderSize = 2;
            this.Start_Stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Stop_btn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_Stop_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Start_Stop_btn.Location = new System.Drawing.Point(290, 40);
            this.Start_Stop_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Start_Stop_btn.Name = "Start_Stop_btn";
            this.Start_Stop_btn.Size = new System.Drawing.Size(76, 70);
            this.Start_Stop_btn.TabIndex = 0;
            this.Start_Stop_btn.Text = "Start/\r\nPause";
            this.Help_toolTip.SetToolTip(this.Start_Stop_btn, "Click for start/pause game");
            this.Start_Stop_btn.UseVisualStyleBackColor = false;
            this.Start_Stop_btn.Click += new System.EventHandler(this.Start_Stop_btn_Click);
            this.Start_Stop_btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ManipulatePackman);
            // 
            // Help_toolTip
            // 
            this.Help_toolTip.IsBalloon = true;
            this.Help_toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Help_toolTip.ToolTipTitle = "Tanks 1.0";
            // 
            // Main_Menu_Strip
            // 
            this.Main_Menu_Strip.BackColor = System.Drawing.Color.Gray;
            this.Main_Menu_Strip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.Main_Menu_Strip.Location = new System.Drawing.Point(0, 0);
            this.Main_Menu_Strip.Name = "Main_Menu_Strip";
            this.Main_Menu_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Main_Menu_Strip.Size = new System.Drawing.Size(380, 29);
            this.Main_Menu_Strip.TabIndex = 1;
            this.Main_Menu_Strip.Text = "menuStrip1";
            this.Main_Menu_Strip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControllerMainForm_MouseDown);
            this.Main_Menu_Strip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_Menu_Strip_MouseMove);
            this.Main_Menu_Strip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_Menu_Strip_MouseUp);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Image = global::Tanks.Properties.Resources.NewGame1;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.newGameToolStripMenuItem.Text = "&NewGame";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Tanks.Properties.Resources.Exit1;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundToolStripMenuItem,
            this.toolStripSeparator1,
            this.countTanksToolStripMenuItem,
            this.CBTanks,
            this.toolStripSeparator3,
            this.countApplesToolStripMenuItem,
            this.CBApplesOnMap,
            this.toolStripSeparator4,
            this.applesForWinToolStripMenuItem,
            this.CBApplesForWin,
            this.toolStripSeparator5,
            this.speedGameToolStripMenuItem,
            this.CBSpeedGame,
            this.toolStripSeparator6,
            this.sizeOfFieldToolStripMenuItem,
            this.CBSizeField});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.settingToolStripMenuItem.Text = "&Setting";
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.Image = global::Tanks.Properties.Resources.Sound3;
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.soundToolStripMenuItem.Text = "&Sound";
            this.soundToolStripMenuItem.Click += new System.EventHandler(this.SoundToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // countTanksToolStripMenuItem
            // 
            this.countTanksToolStripMenuItem.Image = global::Tanks.Properties.Resources.Tank1R;
            this.countTanksToolStripMenuItem.Name = "countTanksToolStripMenuItem";
            this.countTanksToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.countTanksToolStripMenuItem.Text = "Tanks:";
            // 
            // CBTanks
            // 
            this.CBTanks.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "7",
            "10",
            "15",
            "20"});
            this.CBTanks.Name = "CBTanks";
            this.CBTanks.Size = new System.Drawing.Size(121, 23);
            this.CBTanks.Text = "5";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // countApplesToolStripMenuItem
            // 
            this.countApplesToolStripMenuItem.Image = global::Tanks.Properties.Resources.NewApple1;
            this.countApplesToolStripMenuItem.Name = "countApplesToolStripMenuItem";
            this.countApplesToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.countApplesToolStripMenuItem.Text = "Apples on map:";
            // 
            // CBApplesOnMap
            // 
            this.CBApplesOnMap.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "7",
            "10",
            "15"});
            this.CBApplesOnMap.Name = "CBApplesOnMap";
            this.CBApplesOnMap.Size = new System.Drawing.Size(121, 23);
            this.CBApplesOnMap.Text = "5";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // applesForWinToolStripMenuItem
            // 
            this.applesForWinToolStripMenuItem.Image = global::Tanks.Properties.Resources.NewApple1;
            this.applesForWinToolStripMenuItem.Name = "applesForWinToolStripMenuItem";
            this.applesForWinToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.applesForWinToolStripMenuItem.Text = "Apples for win:";
            // 
            // CBApplesForWin
            // 
            this.CBApplesForWin.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "10",
            "15"});
            this.CBApplesForWin.Name = "CBApplesForWin";
            this.CBApplesForWin.Size = new System.Drawing.Size(121, 23);
            this.CBApplesForWin.Text = "5";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(184, 6);
            // 
            // speedGameToolStripMenuItem
            // 
            this.speedGameToolStripMenuItem.Image = global::Tanks.Properties.Resources.speed;
            this.speedGameToolStripMenuItem.Name = "speedGameToolStripMenuItem";
            this.speedGameToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.speedGameToolStripMenuItem.Text = "Speed game:";
            // 
            // CBSpeedGame
            // 
            this.CBSpeedGame.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CBSpeedGame.Name = "CBSpeedGame";
            this.CBSpeedGame.Size = new System.Drawing.Size(121, 23);
            this.CBSpeedGame.Text = "2";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(184, 6);
            // 
            // sizeOfFieldToolStripMenuItem
            // 
            this.sizeOfFieldToolStripMenuItem.Image = global::Tanks.Properties.Resources.field;
            this.sizeOfFieldToolStripMenuItem.Name = "sizeOfFieldToolStripMenuItem";
            this.sizeOfFieldToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.sizeOfFieldToolStripMenuItem.Text = "Size of field:";
            // 
            // CBSizeField
            // 
            this.CBSizeField.Items.AddRange(new object[] {
            "Small",
            "Avarage",
            "Big"});
            this.CBSizeField.Name = "CBSizeField";
            this.CBSizeField.Size = new System.Drawing.Size(121, 23);
            this.CBSizeField.Text = "Small";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.infoToolStripMenuItem.Text = "&Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Tanks.Properties.Resources.About2;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem1_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // Main_statusStrip
            // 
            this.Main_statusStrip.BackColor = System.Drawing.Color.Gray;
            this.Main_statusStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main_StatusLabel});
            this.Main_statusStrip.Location = new System.Drawing.Point(0, 335);
            this.Main_statusStrip.MaximumSize = new System.Drawing.Size(1080, 25);
            this.Main_statusStrip.MinimumSize = new System.Drawing.Size(380, 25);
            this.Main_statusStrip.Name = "Main_statusStrip";
            this.Main_statusStrip.Size = new System.Drawing.Size(380, 25);
            this.Main_statusStrip.TabIndex = 2;
            this.Main_statusStrip.Text = "statusStrkjkl";
            // 
            // Main_StatusLabel
            // 
            this.Main_StatusLabel.BackColor = System.Drawing.Color.Gray;
            this.Main_StatusLabel.Name = "Main_StatusLabel";
            this.Main_StatusLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // GameStLbl
            // 
            this.GameStLbl.AutoSize = true;
            this.GameStLbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameStLbl.ForeColor = System.Drawing.Color.Red;
            this.GameStLbl.Location = new System.Drawing.Point(270, 110);
            this.GameStLbl.Name = "GameStLbl";
            this.GameStLbl.Size = new System.Drawing.Size(0, 33);
            this.GameStLbl.TabIndex = 3;
            // 
            // ControllerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(380, 360);
            this.Controls.Add(this.GameStLbl);
            this.Controls.Add(this.Main_statusStrip);
            this.Controls.Add(this.Start_Stop_btn);
            this.Controls.Add(this.Main_Menu_Strip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Main_Menu_Strip;
            this.MaximizeBox = false;
            this.Name = "ControllerMainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControllerMainForm_FormClosing);
            this.Main_Menu_Strip.ResumeLayout(false);
            this.Main_Menu_Strip.PerformLayout();
            this.Main_statusStrip.ResumeLayout(false);
            this.Main_statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Stop_btn;
        private System.Windows.Forms.ToolTip Help_toolTip;
        private System.Windows.Forms.MenuStrip Main_Menu_Strip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip Main_statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Main_StatusLabel;
        private System.Windows.Forms.Label GameStLbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem countTanksToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox CBTanks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem countApplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox CBApplesOnMap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem applesForWinToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox CBApplesForWin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem speedGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox CBSpeedGame;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem sizeOfFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox CBSizeField;
    }
}

