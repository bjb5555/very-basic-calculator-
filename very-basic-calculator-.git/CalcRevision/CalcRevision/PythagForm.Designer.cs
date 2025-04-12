﻿
namespace CalcRevision
{
    partial class PythagForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PythagForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ALBL = new System.Windows.Forms.Label();
            this.BLBL = new System.Windows.Forms.Label();
            this.CLBL = new System.Windows.Forms.Label();
            this.ATXT = new System.Windows.Forms.TextBox();
            this.BTXT = new System.Windows.Forms.TextBox();
            this.CTXT = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HelpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pythagorus calculator";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BackButton.Location = new System.Drawing.Point(0, 504);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(84, 38);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalcRevision.Properties.Resources.cropped_image_for_pythag_calc;
            this.pictureBox1.Location = new System.Drawing.Point(235, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 287);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ALBL
            // 
            this.ALBL.AutoSize = true;
            this.ALBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ALBL.Location = new System.Drawing.Point(232, 364);
            this.ALBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ALBL.Name = "ALBL";
            this.ALBL.Size = new System.Drawing.Size(32, 31);
            this.ALBL.TabIndex = 3;
            this.ALBL.Text = "A";
            // 
            // BLBL
            // 
            this.BLBL.AutoSize = true;
            this.BLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BLBL.Location = new System.Drawing.Point(232, 413);
            this.BLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BLBL.Name = "BLBL";
            this.BLBL.Size = new System.Drawing.Size(32, 31);
            this.BLBL.TabIndex = 4;
            this.BLBL.Text = "B";
            // 
            // CLBL
            // 
            this.CLBL.AutoSize = true;
            this.CLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CLBL.Location = new System.Drawing.Point(232, 457);
            this.CLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CLBL.Name = "CLBL";
            this.CLBL.Size = new System.Drawing.Size(34, 31);
            this.CLBL.TabIndex = 5;
            this.CLBL.Text = "C";
            // 
            // ATXT
            // 
            this.ATXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ATXT.Location = new System.Drawing.Point(288, 359);
            this.ATXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ATXT.Name = "ATXT";
            this.ATXT.Size = new System.Drawing.Size(190, 38);
            this.ATXT.TabIndex = 6;
            // 
            // BTXT
            // 
            this.BTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BTXT.Location = new System.Drawing.Point(288, 408);
            this.BTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTXT.Name = "BTXT";
            this.BTXT.Size = new System.Drawing.Size(190, 38);
            this.BTXT.TabIndex = 7;
            // 
            // CTXT
            // 
            this.CTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CTXT.Location = new System.Drawing.Point(288, 453);
            this.CTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CTXT.Name = "CTXT";
            this.CTXT.Size = new System.Drawing.Size(190, 38);
            this.CTXT.TabIndex = 8;
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.EnterButton.Location = new System.Drawing.Point(517, 404);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(90, 41);
            this.EnterButton.TabIndex = 9;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(586, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 80);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(0, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(506, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "-Value A or value B cannot be greater than the value of C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(2, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "-All values entered must be above zero.";
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.HelpButton.Location = new System.Drawing.Point(694, 2);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(69, 32);
            this.HelpButton.TabIndex = 2;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // PythagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(878, 543);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.CTXT);
            this.Controls.Add(this.BTXT);
            this.Controls.Add(this.ATXT);
            this.Controls.Add(this.CLBL);
            this.Controls.Add(this.BLBL);
            this.Controls.Add(this.ALBL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PythagForm";
            this.Text = "PythagForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ALBL;
        private System.Windows.Forms.Label BLBL;
        private System.Windows.Forms.Label CLBL;
        private System.Windows.Forms.TextBox ATXT;
        private System.Windows.Forms.TextBox BTXT;
        private System.Windows.Forms.TextBox CTXT;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HelpButton;
    }
}