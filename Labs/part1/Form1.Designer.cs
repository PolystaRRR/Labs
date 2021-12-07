
namespace Labs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sbyteTypeBtn = new System.Windows.Forms.Button();
            this.ulongTypeBtn = new System.Windows.Forms.Button();
            this.shortTypeBtn = new System.Windows.Forms.Button();
            this.decimalTypeBtn = new System.Windows.Forms.Button();
            this.sbyteTypeLabel = new System.Windows.Forms.Label();
            this.ulongTypeLabel = new System.Windows.Forms.Label();
            this.shortTypeLabel = new System.Windows.Forms.Label();
            this.decimalTypeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.shortTypeLabel);
            this.panel1.Controls.Add(this.ulongTypeLabel);
            this.panel1.Controls.Add(this.sbyteTypeLabel);
            this.panel1.Controls.Add(this.shortTypeBtn);
            this.panel1.Controls.Add(this.ulongTypeBtn);
            this.panel1.Controls.Add(this.sbyteTypeBtn);
            this.panel1.Location = new System.Drawing.Point(52, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 428);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.decimalTypeLabel);
            this.panel2.Controls.Add(this.decimalTypeBtn);
            this.panel2.Location = new System.Drawing.Point(623, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 428);
            this.panel2.TabIndex = 1;
            // 
            // sbyteTypeBtn
            // 
            this.sbyteTypeBtn.Location = new System.Drawing.Point(53, 56);
            this.sbyteTypeBtn.Name = "sbyteTypeBtn";
            this.sbyteTypeBtn.Size = new System.Drawing.Size(99, 23);
            this.sbyteTypeBtn.TabIndex = 0;
            this.sbyteTypeBtn.Text = "SbyteTypeBtn";
            this.sbyteTypeBtn.UseVisualStyleBackColor = true;
            this.sbyteTypeBtn.Click += new System.EventHandler(this.sbyteTypeBtn_Click);
            // 
            // ulongTypeBtn
            // 
            this.ulongTypeBtn.Location = new System.Drawing.Point(53, 194);
            this.ulongTypeBtn.Name = "ulongTypeBtn";
            this.ulongTypeBtn.Size = new System.Drawing.Size(105, 23);
            this.ulongTypeBtn.TabIndex = 1;
            this.ulongTypeBtn.Text = "UlongTypeBtn";
            this.ulongTypeBtn.UseVisualStyleBackColor = true;
            this.ulongTypeBtn.Click += new System.EventHandler(this.ulongTypeBtn_Click);
            // 
            // shortTypeBtn
            // 
            this.shortTypeBtn.Location = new System.Drawing.Point(53, 300);
            this.shortTypeBtn.Name = "shortTypeBtn";
            this.shortTypeBtn.Size = new System.Drawing.Size(105, 23);
            this.shortTypeBtn.TabIndex = 2;
            this.shortTypeBtn.Text = "ShortTypeBtn";
            this.shortTypeBtn.UseVisualStyleBackColor = true;
            this.shortTypeBtn.Click += new System.EventHandler(this.shortTypeBtn_Click);
            // 
            // decimalTypeBtn
            // 
            this.decimalTypeBtn.Location = new System.Drawing.Point(30, 44);
            this.decimalTypeBtn.Name = "decimalTypeBtn";
            this.decimalTypeBtn.Size = new System.Drawing.Size(108, 23);
            this.decimalTypeBtn.TabIndex = 1;
            this.decimalTypeBtn.Text = "DecimalTypeBtn";
            this.decimalTypeBtn.UseVisualStyleBackColor = true;
            this.decimalTypeBtn.Click += new System.EventHandler(this.decimalTypeBtn_Click);
            // 
            // sbyteTypeLabel
            // 
            this.sbyteTypeLabel.AutoSize = true;
            this.sbyteTypeLabel.Location = new System.Drawing.Point(225, 61);
            this.sbyteTypeLabel.Name = "sbyteTypeLabel";
            this.sbyteTypeLabel.Size = new System.Drawing.Size(35, 13);
            this.sbyteTypeLabel.TabIndex = 3;
            this.sbyteTypeLabel.Text = "label1";
            // 
            // ulongTypeLabel
            // 
            this.ulongTypeLabel.AutoSize = true;
            this.ulongTypeLabel.Location = new System.Drawing.Point(225, 194);
            this.ulongTypeLabel.Name = "ulongTypeLabel";
            this.ulongTypeLabel.Size = new System.Drawing.Size(35, 13);
            this.ulongTypeLabel.TabIndex = 4;
            this.ulongTypeLabel.Text = "label2";
            // 
            // shortTypeLabel
            // 
            this.shortTypeLabel.AutoSize = true;
            this.shortTypeLabel.Location = new System.Drawing.Point(225, 305);
            this.shortTypeLabel.Name = "shortTypeLabel";
            this.shortTypeLabel.Size = new System.Drawing.Size(35, 13);
            this.shortTypeLabel.TabIndex = 5;
            this.shortTypeLabel.Text = "label3";
            // 
            // decimalTypeLabel
            // 
            this.decimalTypeLabel.AutoSize = true;
            this.decimalTypeLabel.Location = new System.Drawing.Point(193, 49);
            this.decimalTypeLabel.Name = "decimalTypeLabel";
            this.decimalTypeLabel.Size = new System.Drawing.Size(35, 13);
            this.decimalTypeLabel.TabIndex = 6;
            this.decimalTypeLabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shortTypeLabel;
        private System.Windows.Forms.Label ulongTypeLabel;
        private System.Windows.Forms.Label sbyteTypeLabel;
        private System.Windows.Forms.Button shortTypeBtn;
        private System.Windows.Forms.Button ulongTypeBtn;
        private System.Windows.Forms.Button sbyteTypeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label decimalTypeLabel;
        private System.Windows.Forms.Button decimalTypeBtn;
    }
}

