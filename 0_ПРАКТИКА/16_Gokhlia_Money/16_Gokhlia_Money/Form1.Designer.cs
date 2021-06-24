namespace _16_Gokhlia_Money
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
            this.table = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.updateTableBtn = new System.Windows.Forms.Button();
            this.graphikBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.updateListBtn = new System.Windows.Forms.Button();
            this.stateBtn = new System.Windows.Forms.Button();
            this.selectUrlBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.Font = new System.Drawing.Font("Toledo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table.FormattingEnabled = true;
            this.table.ItemHeight = 24;
            this.table.Location = new System.Drawing.Point(12, 134);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(1127, 652);
            this.table.TabIndex = 0;
            this.table.SelectedIndexChanged += new System.EventHandler(this.table_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.stateBtn);
            this.flowLayoutPanel1.Controls.Add(this.updateTableBtn);
            this.flowLayoutPanel1.Controls.Add(this.graphikBtn);
            this.flowLayoutPanel1.Controls.Add(this.selectUrlBtn);
            this.flowLayoutPanel1.Controls.Add(this.updateListBtn);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1151, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // updateTableBtn
            // 
            this.updateTableBtn.Location = new System.Drawing.Point(245, 33);
            this.updateTableBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.updateTableBtn.Name = "updateTableBtn";
            this.updateTableBtn.Size = new System.Drawing.Size(212, 44);
            this.updateTableBtn.TabIndex = 3;
            this.updateTableBtn.Text = "обновить таблицу";
            this.updateTableBtn.UseVisualStyleBackColor = true;
            this.updateTableBtn.Click += new System.EventHandler(this.updateTableBtn_Click);
            // 
            // graphikBtn
            // 
            this.graphikBtn.Location = new System.Drawing.Point(470, 33);
            this.graphikBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.graphikBtn.Name = "graphikBtn";
            this.graphikBtn.Size = new System.Drawing.Size(212, 44);
            this.graphikBtn.TabIndex = 2;
            this.graphikBtn.Text = "график";
            this.graphikBtn.UseVisualStyleBackColor = true;
            this.graphikBtn.Click += new System.EventHandler(this.graphikBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(571, 134);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(568, 652);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // updateListBtn
            // 
            this.updateListBtn.Location = new System.Drawing.Point(920, 33);
            this.updateListBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.updateListBtn.Name = "updateListBtn";
            this.updateListBtn.Size = new System.Drawing.Size(212, 44);
            this.updateListBtn.TabIndex = 5;
            this.updateListBtn.Text = "журнал обнавлений";
            this.updateListBtn.UseVisualStyleBackColor = true;
            this.updateListBtn.Click += new System.EventHandler(this.updateListBtn_Click);
            // 
            // stateBtn
            // 
            this.stateBtn.Location = new System.Drawing.Point(20, 33);
            this.stateBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.stateBtn.Name = "stateBtn";
            this.stateBtn.Size = new System.Drawing.Size(212, 44);
            this.stateBtn.TabIndex = 1;
            this.stateBtn.Text = "статистика";
            this.stateBtn.UseVisualStyleBackColor = true;
            this.stateBtn.Click += new System.EventHandler(this.stateBtn_Click);
            // 
            // selectUrlBtn
            // 
            this.selectUrlBtn.Location = new System.Drawing.Point(695, 33);
            this.selectUrlBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.selectUrlBtn.Name = "selectUrlBtn";
            this.selectUrlBtn.Size = new System.Drawing.Size(212, 44);
            this.selectUrlBtn.TabIndex = 4;
            this.selectUrlBtn.Text = "сменить источник";
            this.selectUrlBtn.UseVisualStyleBackColor = true;
            this.selectUrlBtn.Click += new System.EventHandler(this.selectUrlBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 796);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "GokhliaMoney";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox table;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button graphikBtn;
        private System.Windows.Forms.Button updateTableBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button stateBtn;
        private System.Windows.Forms.Button selectUrlBtn;
        private System.Windows.Forms.Button updateListBtn;
    }
}

