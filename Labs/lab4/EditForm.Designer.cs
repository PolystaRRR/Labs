
namespace Labs.lab4
{
    partial class EditForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCancelBtnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.falseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // changesToolStripMenuItem
            // 
            this.changesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.addCancelBtnToolStripMenuItem,
            this.showIconToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.changesToolStripMenuItem.Name = "changesToolStripMenuItem";
            this.changesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.changesToolStripMenuItem.Text = "Changes";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add accepBtn";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // addCancelBtnToolStripMenuItem
            // 
            this.addCancelBtnToolStripMenuItem.Name = "addCancelBtnToolStripMenuItem";
            this.addCancelBtnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCancelBtnToolStripMenuItem.Text = "Add cancelBtn";
            // 
            // showIconToolStripMenuItem
            // 
            this.showIconToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trueToolStripMenuItem,
            this.falseToolStripMenuItem});
            this.showIconToolStripMenuItem.Name = "showIconToolStripMenuItem";
            this.showIconToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showIconToolStripMenuItem.Text = "Show icon";
            // 
            // trueToolStripMenuItem
            // 
            this.trueToolStripMenuItem.Name = "trueToolStripMenuItem";
            this.trueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trueToolStripMenuItem.Text = "True";
            this.trueToolStripMenuItem.Click += new System.EventHandler(this.trueToolStripMenuItem_Click);
            // 
            // falseToolStripMenuItem
            // 
            this.falseToolStripMenuItem.Name = "falseToolStripMenuItem";
            this.falseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.falseToolStripMenuItem.Text = "False";
            this.falseToolStripMenuItem.Click += new System.EventHandler(this.falseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCancelBtnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem falseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}