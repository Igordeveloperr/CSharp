namespace _32_Резня_капусты
{
    partial class Form1
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
            this.basePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.startBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.startBtn.Location = new System.Drawing.Point(751, 558);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(258, 59);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "СТАРТ";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(751, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 55);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 747);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.basePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel basePanel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

