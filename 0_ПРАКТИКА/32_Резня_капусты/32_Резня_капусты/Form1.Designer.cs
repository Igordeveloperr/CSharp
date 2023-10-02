namespace _32_Резня_капусты
{
    partial class MainWindow
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
            this.basePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.startBtn = new System.Windows.Forms.Button();
            this.lamp = new System.Windows.Forms.Panel();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.pauseBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.probTrack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.speedTrack = new System.Windows.Forms.TrackBar();
            this.probValue = new System.Windows.Forms.TextBox();
            this.speedValue = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.probTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrack)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.Location = new System.Drawing.Point(12, 57);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(720, 560);
            this.basePanel.TabIndex = 0;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.startBtn.Location = new System.Drawing.Point(761, 404);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(258, 59);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Старт";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // lamp
            // 
            this.lamp.Location = new System.Drawing.Point(835, 32);
            this.lamp.Name = "lamp";
            this.lamp.Size = new System.Drawing.Size(99, 92);
            this.lamp.TabIndex = 2;
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pauseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.pauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pauseBtn.Location = new System.Drawing.Point(760, 480);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(258, 59);
            this.pauseBtn.TabIndex = 3;
            this.pauseBtn.Text = "Пауза";
            this.pauseBtn.UseVisualStyleBackColor = false;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitBtn.Location = new System.Drawing.Point(760, 558);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(258, 59);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // probTrack
            // 
            this.probTrack.Location = new System.Drawing.Point(760, 152);
            this.probTrack.Maximum = 15;
            this.probTrack.Name = "probTrack";
            this.probTrack.Size = new System.Drawing.Size(195, 45);
            this.probTrack.TabIndex = 5;
            this.probTrack.Scroll += new System.EventHandler(this.probTrack_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(757, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вероятность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(757, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Скорость";
            // 
            // speedTrack
            // 
            this.speedTrack.Location = new System.Drawing.Point(761, 225);
            this.speedTrack.Maximum = 100;
            this.speedTrack.Minimum = 1;
            this.speedTrack.Name = "speedTrack";
            this.speedTrack.Size = new System.Drawing.Size(195, 45);
            this.speedTrack.TabIndex = 8;
            this.speedTrack.TickFrequency = 10;
            this.speedTrack.Value = 1;
            this.speedTrack.Scroll += new System.EventHandler(this.speedTrack_Scroll);
            // 
            // probValue
            // 
            this.probValue.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.probValue.Location = new System.Drawing.Point(961, 152);
            this.probValue.Name = "probValue";
            this.probValue.Size = new System.Drawing.Size(57, 33);
            this.probValue.TabIndex = 10;
            this.probValue.Text = "0";
            // 
            // speedValue
            // 
            this.speedValue.BackColor = System.Drawing.Color.White;
            this.speedValue.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.speedValue.Location = new System.Drawing.Point(961, 225);
            this.speedValue.Name = "speedValue";
            this.speedValue.Size = new System.Drawing.Size(58, 33);
            this.speedValue.TabIndex = 11;
            this.speedValue.Text = "1";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.setMenuItem,
            this.referenceMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1075, 29);
            this.menu.TabIndex = 12;
            this.menu.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(63, 25);
            this.fileMenuItem.Text = "Файл";
            // 
            // openMenuItem
            // 
            this.openMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(164, 26);
            this.openMenuItem.Text = "Открыть";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(164, 26);
            this.saveMenuItem.Text = "Сохранить";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(164, 26);
            this.exitMenuItem.Text = "Выход";
            // 
            // setMenuItem
            // 
            this.setMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillMenuItem,
            this.colorMenuItem});
            this.setMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setMenuItem.Name = "setMenuItem";
            this.setMenuItem.Size = new System.Drawing.Size(107, 25);
            this.setMenuItem.Text = "Настройки";
            // 
            // fillMenuItem
            // 
            this.fillMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fillMenuItem.Name = "fillMenuItem";
            this.fillMenuItem.Size = new System.Drawing.Size(175, 26);
            this.fillMenuItem.Text = "Заполнение";
            // 
            // colorMenuItem
            // 
            this.colorMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colorMenuItem.Name = "colorMenuItem";
            this.colorMenuItem.Size = new System.Drawing.Size(175, 26);
            this.colorMenuItem.Text = "Цвета";
            // 
            // referenceMenuItem
            // 
            this.referenceMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progInfoMenuItem,
            this.authorInfoMenuItem});
            this.referenceMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.referenceMenuItem.Name = "referenceMenuItem";
            this.referenceMenuItem.Size = new System.Drawing.Size(89, 25);
            this.referenceMenuItem.Text = "Справка";
            // 
            // progInfoMenuItem
            // 
            this.progInfoMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progInfoMenuItem.Name = "progInfoMenuItem";
            this.progInfoMenuItem.Size = new System.Drawing.Size(187, 26);
            this.progInfoMenuItem.Text = "О программе";
            // 
            // authorInfoMenuItem
            // 
            this.authorInfoMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.authorInfoMenuItem.Name = "authorInfoMenuItem";
            this.authorInfoMenuItem.Size = new System.Drawing.Size(187, 26);
            this.authorInfoMenuItem.Text = "Об авторе";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1021, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1025, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "м/с";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 646);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speedValue);
            this.Controls.Add(this.probValue);
            this.Controls.Add(this.speedTrack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.probTrack);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.lamp);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.basePanel);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainWindow";
            this.Text = "Игра";
            ((System.ComponentModel.ISupportInitialize)(this.probTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrack)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel basePanel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel lamp;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TrackBar probTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar speedTrack;
        private System.Windows.Forms.TextBox probValue;
        private System.Windows.Forms.TextBox speedValue;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorInfoMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

