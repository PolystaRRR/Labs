﻿
namespace Labs.part_2
{
    partial class Form1
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
            this.OperandTB = new System.Windows.Forms.MaskedTextBox();
            this.eventBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OperandTB
            // 
            this.OperandTB.Location = new System.Drawing.Point(442, 146);
            this.OperandTB.Name = "OperandTB";
            this.OperandTB.Size = new System.Drawing.Size(100, 20);
            this.OperandTB.TabIndex = 0;
            this.OperandTB.Leave += new System.EventHandler(this.operandTB_Leave);
            // 
            // eventBtn
            // 
            this.eventBtn.Location = new System.Drawing.Point(453, 172);
            this.eventBtn.Name = "eventBtn";
            this.eventBtn.Size = new System.Drawing.Size(75, 23);
            this.eventBtn.TabIndex = 1;
            this.eventBtn.Text = "button1";
            this.eventBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 596);
            this.Controls.Add(this.eventBtn);
            this.Controls.Add(this.OperandTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox OperandTB;
        private System.Windows.Forms.Button eventBtn;
    }
}