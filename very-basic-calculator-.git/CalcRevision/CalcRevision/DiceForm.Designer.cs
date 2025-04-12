﻿
namespace CalcRevision
{
    partial class DiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceForm));
            this.DiceTitleLBL = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.DiceButton = new System.Windows.Forms.Button();
            this.DicePictureLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DiceTitleLBL
            // 
            this.DiceTitleLBL.AutoSize = true;
            this.DiceTitleLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.DiceTitleLBL.Location = new System.Drawing.Point(377, 25);
            this.DiceTitleLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiceTitleLBL.Name = "DiceTitleLBL";
            this.DiceTitleLBL.Size = new System.Drawing.Size(303, 48);
            this.DiceTitleLBL.TabIndex = 0;
            this.DiceTitleLBL.Text = "Dice Generator";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BackButton.Location = new System.Drawing.Point(1, 507);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(116, 46);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DiceButton
            // 
            this.DiceButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DiceButton.Location = new System.Drawing.Point(481, 97);
            this.DiceButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DiceButton.Name = "DiceButton";
            this.DiceButton.Size = new System.Drawing.Size(100, 58);
            this.DiceButton.TabIndex = 2;
            this.DiceButton.Text = "Roll";
            this.DiceButton.UseVisualStyleBackColor = false;
            this.DiceButton.Click += new System.EventHandler(this.DiceButton_Click);
            // 
            // DicePictureLBL
            // 
            this.DicePictureLBL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DicePictureLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DicePictureLBL.Location = new System.Drawing.Point(241, 192);
            this.DicePictureLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DicePictureLBL.Name = "DicePictureLBL";
            this.DicePictureLBL.Size = new System.Drawing.Size(576, 306);
            this.DicePictureLBL.TabIndex = 3;
            this.DicePictureLBL.Text = "   ";
            // 
            // DiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DicePictureLBL);
            this.Controls.Add(this.DiceButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DiceTitleLBL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DiceForm";
            this.Text = "DiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiceTitleLBL;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DiceButton;
        private System.Windows.Forms.Label DicePictureLBL;
    }
}