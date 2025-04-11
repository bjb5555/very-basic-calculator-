
namespace CalcRevision
{
    partial class CalculatorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.CalculatorTitle = new System.Windows.Forms.Label();
            this.QuestionEnterTXTBOX = new System.Windows.Forms.TextBox();
            this.AnswerBox = new System.Windows.Forms.Label();
            this.AnsButton = new System.Windows.Forms.Button();
            this.piButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.cubedButton = new System.Windows.Forms.Button();
            this.cubedRoot = new System.Windows.Forms.Button();
            this.squareRoot = new System.Windows.Forms.Button();
            this.TimeLBL = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.formatButton = new System.Windows.Forms.Button();
            this.timeTillBreak = new System.Windows.Forms.Label();
            this.BreakIndicatorLBL = new System.Windows.Forms.Label();
            this.DicePic = new System.Windows.Forms.PictureBox();
            this.PythagPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DicePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PythagPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculatorTitle
            // 
            this.CalculatorTitle.AutoSize = true;
            this.CalculatorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CalculatorTitle.Location = new System.Drawing.Point(539, 44);
            this.CalculatorTitle.Name = "CalculatorTitle";
            this.CalculatorTitle.Size = new System.Drawing.Size(500, 69);
            this.CalculatorTitle.TabIndex = 0;
            this.CalculatorTitle.Text = "Simple Calculator";
            // 
            // QuestionEnterTXTBOX
            // 
            this.QuestionEnterTXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.QuestionEnterTXTBOX.Location = new System.Drawing.Point(660, 140);
            this.QuestionEnterTXTBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuestionEnterTXTBOX.Name = "QuestionEnterTXTBOX";
            this.QuestionEnterTXTBOX.Size = new System.Drawing.Size(263, 45);
            this.QuestionEnterTXTBOX.TabIndex = 1;
            this.QuestionEnterTXTBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuestionEnterTXTBOX_KeyDown);
            // 
            // AnswerBox
            // 
            this.AnswerBox.AutoSize = true;
            this.AnswerBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AnswerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AnswerBox.Location = new System.Drawing.Point(687, 255);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(206, 39);
            this.AnswerBox.TabIndex = 2;
            this.AnswerBox.Text = "                     ";
            // 
            // AnsButton
            // 
            this.AnsButton.AutoSize = true;
            this.AnsButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AnsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AnsButton.Location = new System.Drawing.Point(117, 444);
            this.AnsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnsButton.Name = "AnsButton";
            this.AnsButton.Size = new System.Drawing.Size(95, 50);
            this.AnsButton.TabIndex = 3;
            this.AnsButton.Text = "Ans";
            this.AnsButton.UseVisualStyleBackColor = false;
            this.AnsButton.Click += new System.EventHandler(this.AnsButton_Click);
            // 
            // piButton
            // 
            this.piButton.AutoSize = true;
            this.piButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.piButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.piButton.Location = new System.Drawing.Point(235, 444);
            this.piButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.piButton.Name = "piButton";
            this.piButton.Size = new System.Drawing.Size(85, 50);
            this.piButton.TabIndex = 4;
            this.piButton.Text = "π";
            this.piButton.UseVisualStyleBackColor = false;
            this.piButton.Click += new System.EventHandler(this.piButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.squareButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.squareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.squareButton.Location = new System.Drawing.Point(117, 375);
            this.squareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(87, 47);
            this.squareButton.TabIndex = 6;
            this.squareButton.Text = "x²";
            this.squareButton.UseVisualStyleBackColor = false;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // cubedButton
            // 
            this.cubedButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cubedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cubedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cubedButton.Location = new System.Drawing.Point(235, 375);
            this.cubedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cubedButton.Name = "cubedButton";
            this.cubedButton.Size = new System.Drawing.Size(85, 47);
            this.cubedButton.TabIndex = 7;
            this.cubedButton.Text = "x³";
            this.cubedButton.UseVisualStyleBackColor = false;
            this.cubedButton.Click += new System.EventHandler(this.cubedButton_Click);
            // 
            // cubedRoot
            // 
            this.cubedRoot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cubedRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cubedRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cubedRoot.Location = new System.Drawing.Point(341, 375);
            this.cubedRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cubedRoot.Name = "cubedRoot";
            this.cubedRoot.Size = new System.Drawing.Size(79, 47);
            this.cubedRoot.TabIndex = 8;
            this.cubedRoot.Text = "∛x";
            this.cubedRoot.UseVisualStyleBackColor = false;
            this.cubedRoot.Click += new System.EventHandler(this.cubedRoot_Click);
            // 
            // squareRoot
            // 
            this.squareRoot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.squareRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.squareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.squareRoot.Location = new System.Drawing.Point(341, 444);
            this.squareRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(79, 47);
            this.squareRoot.TabIndex = 9;
            this.squareRoot.Text = "√x";
            this.squareRoot.UseVisualStyleBackColor = false;
            this.squareRoot.Click += new System.EventHandler(this.squareRoot_Click);
            // 
            // TimeLBL
            // 
            this.TimeLBL.AutoSize = true;
            this.TimeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TimeLBL.Location = new System.Drawing.Point(19, 7);
            this.TimeLBL.Name = "TimeLBL";
            this.TimeLBL.Size = new System.Drawing.Size(315, 39);
            this.TimeLBL.TabIndex = 10;
            this.TimeLBL.Text = "placeholder for time";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 1;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // formatButton
            // 
            this.formatButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.formatButton.Location = new System.Drawing.Point(245, 14);
            this.formatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(64, 26);
            this.formatButton.TabIndex = 11;
            this.formatButton.Text = "format";
            this.formatButton.UseVisualStyleBackColor = false;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // timeTillBreak
            // 
            this.timeTillBreak.AutoSize = true;
            this.timeTillBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.timeTillBreak.Location = new System.Drawing.Point(19, 66);
            this.timeTillBreak.Name = "timeTillBreak";
            this.timeTillBreak.Size = new System.Drawing.Size(315, 39);
            this.timeTillBreak.TabIndex = 12;
            this.timeTillBreak.Text = "placeholder for time";
            // 
            // BreakIndicatorLBL
            // 
            this.BreakIndicatorLBL.AutoSize = true;
            this.BreakIndicatorLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BreakIndicatorLBL.Location = new System.Drawing.Point(333, 66);
            this.BreakIndicatorLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BreakIndicatorLBL.Name = "BreakIndicatorLBL";
            this.BreakIndicatorLBL.Size = new System.Drawing.Size(174, 39);
            this.BreakIndicatorLBL.TabIndex = 13;
            this.BreakIndicatorLBL.Text = "until break";
            // 
            // DicePic
            // 
            this.DicePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DicePic.Image = global::CalcRevision.Properties.Resources.resized_cropped_dice_icon_614x460;
            this.DicePic.Location = new System.Drawing.Point(801, 570);
            this.DicePic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DicePic.Name = "DicePic";
            this.DicePic.Size = new System.Drawing.Size(43, 44);
            this.DicePic.TabIndex = 15;
            this.DicePic.TabStop = false;
            this.DicePic.Click += new System.EventHandler(this.DicePic_Click);
            // 
            // PythagPic
            // 
            this.PythagPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PythagPic.Image = global::CalcRevision.Properties.Resources.resized_32x32_cropped_image_for_pythag_calc;
            this.PythagPic.Location = new System.Drawing.Point(695, 426);
            this.PythagPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PythagPic.Name = "PythagPic";
            this.PythagPic.Size = new System.Drawing.Size(43, 39);
            this.PythagPic.TabIndex = 14;
            this.PythagPic.TabStop = false;
            this.PythagPic.Click += new System.EventHandler(this.PythagPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalcRevision.Properties.Resources.calculator_1_;
            this.pictureBox1.Location = new System.Drawing.Point(631, 318);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 316);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1272, 647);
            this.Controls.Add(this.DicePic);
            this.Controls.Add(this.PythagPic);
            this.Controls.Add(this.BreakIndicatorLBL);
            this.Controls.Add(this.timeTillBreak);
            this.Controls.Add(this.formatButton);
            this.Controls.Add(this.TimeLBL);
            this.Controls.Add(this.squareRoot);
            this.Controls.Add(this.cubedRoot);
            this.Controls.Add(this.cubedButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.piButton);
            this.Controls.Add(this.AnsButton);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.QuestionEnterTXTBOX);
            this.Controls.Add(this.CalculatorTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(915, 569);
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.DicePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PythagPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CalculatorTitle;
        private System.Windows.Forms.TextBox QuestionEnterTXTBOX;
        private System.Windows.Forms.Label AnswerBox;
        private System.Windows.Forms.Button AnsButton;
        private System.Windows.Forms.Button piButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button cubedButton;
        private System.Windows.Forms.Button cubedRoot;
        private System.Windows.Forms.Button squareRoot;
        private System.Windows.Forms.Label TimeLBL;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Button formatButton;
        private System.Windows.Forms.Label timeTillBreak;
        private System.Windows.Forms.Label BreakIndicatorLBL;
        private System.Windows.Forms.PictureBox PythagPic;
        private System.Windows.Forms.PictureBox DicePic;
    }
}