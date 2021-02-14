namespace _15_html_parser
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
            this.titlesList = new System.Windows.Forms.ListBox();
            this.StartPoint = new System.Windows.Forms.TextBox();
            this.EndPoint = new System.Windows.Forms.TextBox();
            this.parseBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlesList
            // 
            this.titlesList.FormattingEnabled = true;
            this.titlesList.Location = new System.Drawing.Point(12, 12);
            this.titlesList.Name = "titlesList";
            this.titlesList.Size = new System.Drawing.Size(822, 563);
            this.titlesList.TabIndex = 0;
            // 
            // StartPoint
            // 
            this.StartPoint.Location = new System.Drawing.Point(852, 154);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Size = new System.Drawing.Size(204, 20);
            this.StartPoint.TabIndex = 1;
            this.StartPoint.TextChanged += new System.EventHandler(this.StartPoint_TextChanged);
            // 
            // EndPoint
            // 
            this.EndPoint.Location = new System.Drawing.Point(852, 201);
            this.EndPoint.Name = "EndPoint";
            this.EndPoint.Size = new System.Drawing.Size(204, 20);
            this.EndPoint.TabIndex = 2;
            // 
            // parseBtn
            // 
            this.parseBtn.Location = new System.Drawing.Point(852, 255);
            this.parseBtn.Name = "parseBtn";
            this.parseBtn.Size = new System.Drawing.Size(204, 44);
            this.parseBtn.TabIndex = 3;
            this.parseBtn.Text = "начать парсинг";
            this.parseBtn.UseVisualStyleBackColor = true;
            this.parseBtn.Click += new System.EventHandler(this.parseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(852, 321);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(204, 42);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "стоп";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 617);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.parseBtn);
            this.Controls.Add(this.EndPoint);
            this.Controls.Add(this.StartPoint);
            this.Controls.Add(this.titlesList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox titlesList;
        private System.Windows.Forms.TextBox StartPoint;
        private System.Windows.Forms.TextBox EndPoint;
        private System.Windows.Forms.Button parseBtn;
        private System.Windows.Forms.Button stopBtn;
    }
}

