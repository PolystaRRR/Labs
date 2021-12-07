
namespace Labs.part2_3
{
    partial class Form2
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
            this.firstOperandTB = new System.Windows.Forms.TextBox();
            this.operationTB = new System.Windows.Forms.TextBox();
            this.secondOperandTB = new System.Windows.Forms.TextBox();
            this.startCalcLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // firstOperandTB
            // 
            this.firstOperandTB.Location = new System.Drawing.Point(248, 196);
            this.firstOperandTB.Name = "firstOperandTB";
            this.firstOperandTB.Size = new System.Drawing.Size(100, 20);
            this.firstOperandTB.TabIndex = 0;
            // 
            // operationTB
            // 
            this.operationTB.Location = new System.Drawing.Point(440, 196);
            this.operationTB.Name = "operationTB";
            this.operationTB.Size = new System.Drawing.Size(100, 20);
            this.operationTB.TabIndex = 1;
            // 
            // secondOperandTB
            // 
            this.secondOperandTB.Location = new System.Drawing.Point(639, 196);
            this.secondOperandTB.Name = "secondOperandTB";
            this.secondOperandTB.Size = new System.Drawing.Size(100, 20);
            this.secondOperandTB.TabIndex = 2;
            // 
            // startCalcLabel
            // 
            this.startCalcLabel.AutoSize = true;
            this.startCalcLabel.Location = new System.Drawing.Point(459, 274);
            this.startCalcLabel.Name = "startCalcLabel";
            this.startCalcLabel.Size = new System.Drawing.Size(46, 13);
            this.startCalcLabel.TabIndex = 3;
            this.startCalcLabel.TabStop = true;
            this.startCalcLabel.Text = "Ответ : ";
            this.startCalcLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.startCalcLabel_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 635);
            this.Controls.Add(this.startCalcLabel);
            this.Controls.Add(this.secondOperandTB);
            this.Controls.Add(this.operationTB);
            this.Controls.Add(this.firstOperandTB);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstOperandTB;
        private System.Windows.Forms.TextBox operationTB;
        private System.Windows.Forms.TextBox secondOperandTB;
        private System.Windows.Forms.LinkLabel startCalcLabel;
    }
}