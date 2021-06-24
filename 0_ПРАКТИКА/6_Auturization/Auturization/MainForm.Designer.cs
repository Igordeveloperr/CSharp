namespace Auturization
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newsText = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.send = new System.Windows.Forms.Button();
            this.newsCount = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.addNewsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 512);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addNewsBtn);
            this.panel1.Controls.Add(this.newsText);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 248);
            this.panel1.TabIndex = 0;
            // 
            // newsText
            // 
            this.newsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newsText.Enabled = false;
            this.newsText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newsText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newsText.Location = new System.Drawing.Point(0, 65);
            this.newsText.Multiline = true;
            this.newsText.Name = "newsText";
            this.newsText.Size = new System.Drawing.Size(829, 180);
            this.newsText.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(7, 30);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 25);
            this.Title.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.send);
            this.panel2.Controls.Add(this.newsCount);
            this.panel2.Controls.Add(this.next);
            this.panel2.Controls.Add(this.prev);
            this.panel2.Location = new System.Drawing.Point(4, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 249);
            this.panel2.TabIndex = 1;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.send.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.send.Location = new System.Drawing.Point(553, 100);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(237, 45);
            this.send.TabIndex = 3;
            this.send.Text = "ввести";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // newsCount
            // 
            this.newsCount.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newsCount.Location = new System.Drawing.Point(553, 47);
            this.newsCount.Name = "newsCount";
            this.newsCount.Size = new System.Drawing.Size(237, 27);
            this.newsCount.TabIndex = 2;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.next.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.next.Location = new System.Drawing.Point(272, 100);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(237, 45);
            this.next.TabIndex = 1;
            this.next.Text = "вперед";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prev
            // 
            this.prev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.prev.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prev.Location = new System.Drawing.Point(13, 100);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(237, 45);
            this.prev.TabIndex = 0;
            this.prev.Text = "назад";
            this.prev.UseVisualStyleBackColor = false;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // addNewsBtn
            // 
            this.addNewsBtn.BackColor = System.Drawing.SystemColors.WindowText;
            this.addNewsBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewsBtn.Location = new System.Drawing.Point(668, 7);
            this.addNewsBtn.Name = "addNewsBtn";
            this.addNewsBtn.Size = new System.Drawing.Size(151, 37);
            this.addNewsBtn.TabIndex = 2;
            this.addNewsBtn.Text = "добавить";
            this.addNewsBtn.UseVisualStyleBackColor = false;
            this.addNewsBtn.Visible = false;
            this.addNewsBtn.Click += new System.EventHandler(this.addNewsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 509);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox newsCount;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.TextBox newsText;
        private System.Windows.Forms.Button addNewsBtn;
    }
}