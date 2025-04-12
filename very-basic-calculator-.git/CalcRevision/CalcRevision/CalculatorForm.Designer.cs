
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
            this.CirclePic = new System.Windows.Forms.PictureBox();
            this.DicePic = new System.Windows.Forms.PictureBox();
            this.PythagPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DicePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PythagPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculatorTitle
            // 
            this.CalculatorTitle.AutoSize = true;
            this.CalculatorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CalculatorTitle.Location = new System.Drawing.Point(404, 36);
            this.CalculatorTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CalculatorTitle.Name = "CalculatorTitle";
            this.CalculatorTitle.Size = new System.Drawing.Size(399, 55);
            this.CalculatorTitle.TabIndex = 0;
            this.CalculatorTitle.Text = "Simple Calculator";
            // 
            // QuestionEnterTXTBOX
            // 
            this.QuestionEnterTXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.QuestionEnterTXTBOX.Location = new System.Drawing.Point(495, 114);
            this.QuestionEnterTXTBOX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuestionEnterTXTBOX.Name = "QuestionEnterTXTBOX";
            this.QuestionEnterTXTBOX.Size = new System.Drawing.Size(198, 38);
            this.QuestionEnterTXTBOX.TabIndex = 1;
            this.QuestionEnterTXTBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuestionEnterTXTBOX_KeyDown);
            // 
            // AnswerBox
            // 
            this.AnswerBox.AutoSize = true;
            this.AnswerBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AnswerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AnswerBox.Location = new System.Drawing.Point(515, 207);
            this.AnswerBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(161, 31);
            this.AnswerBox.TabIndex = 2;
            this.AnswerBox.Text = "                     ";
            // 
            // AnsButton
            // 
            this.AnsButton.AutoSize = true;
            this.AnsButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AnsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AnsButton.Location = new System.Drawing.Point(88, 361);
            this.AnsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AnsButton.Name = "AnsButton";
            this.AnsButton.Size = new System.Drawing.Size(71, 41);
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
            this.piButton.Location = new System.Drawing.Point(176, 361);
            this.piButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.piButton.Name = "piButton";
            this.piButton.Size = new System.Drawing.Size(64, 41);
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
            this.squareButton.Location = new System.Drawing.Point(88, 305);
            this.squareButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(65, 38);
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
            this.cubedButton.Location = new System.Drawing.Point(176, 305);
            this.cubedButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cubedButton.Name = "cubedButton";
            this.cubedButton.Size = new System.Drawing.Size(64, 38);
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
            this.cubedRoot.Location = new System.Drawing.Point(256, 305);
            this.cubedRoot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cubedRoot.Name = "cubedRoot";
            this.cubedRoot.Size = new System.Drawing.Size(59, 38);
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
            this.squareRoot.Location = new System.Drawing.Point(256, 361);
            this.squareRoot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(59, 38);
            this.squareRoot.TabIndex = 9;
            this.squareRoot.Text = "√x";
            this.squareRoot.UseVisualStyleBackColor = false;
            this.squareRoot.Click += new System.EventHandler(this.squareRoot_Click);
            // 
            // TimeLBL
            // 
            this.TimeLBL.AutoSize = true;
            this.TimeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TimeLBL.Location = new System.Drawing.Point(14, 6);
            this.TimeLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLBL.Name = "TimeLBL";
            this.TimeLBL.Size = new System.Drawing.Size(251, 31);
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
            this.formatButton.Location = new System.Drawing.Point(184, 11);
            this.formatButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(48, 21);
            this.formatButton.TabIndex = 11;
            this.formatButton.Text = "format";
            this.formatButton.UseVisualStyleBackColor = false;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // timeTillBreak
            // 
            this.timeTillBreak.AutoSize = true;
            this.timeTillBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.timeTillBreak.Location = new System.Drawing.Point(14, 54);
            this.timeTillBreak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeTillBreak.Name = "timeTillBreak";
            this.timeTillBreak.Size = new System.Drawing.Size(251, 31);
            this.timeTillBreak.TabIndex = 12;
            this.timeTillBreak.Text = "placeholder for time";
            // 
            // BreakIndicatorLBL
            // 
            this.BreakIndicatorLBL.AutoSize = true;
            this.BreakIndicatorLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BreakIndicatorLBL.Location = new System.Drawing.Point(250, 54);
            this.BreakIndicatorLBL.Name = "BreakIndicatorLBL";
            this.BreakIndicatorLBL.Size = new System.Drawing.Size(139, 31);
            this.BreakIndicatorLBL.TabIndex = 13;
            this.BreakIndicatorLBL.Text = "until break";
            // 
            // CirclePic
            // 
            this.CirclePic.Image = global::CalcRevision.Properties.Resources.area_of_a_circle_diameter_and_radius_ver_1;
            this.CirclePic.Location = new System.Drawing.Point(601, 346);
            this.CirclePic.Name = "CirclePic";
            this.CirclePic.Size = new System.Drawing.Size(32, 32);
            this.CirclePic.TabIndex = 16;
            this.CirclePic.TabStop = false;
            // 
            // DicePic
            // 
            this.DicePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DicePic.Image = global::CalcRevision.Properties.Resources.resized_cropped_dice_icon_614x460;
            this.DicePic.Location = new System.Drawing.Point(601, 463);
            this.DicePic.Name = "DicePic";
            this.DicePic.Size = new System.Drawing.Size(32, 36);
            this.DicePic.TabIndex = 15;
            this.DicePic.TabStop = false;
            this.DicePic.Click += new System.EventHandler(this.DicePic_Click);
            // 
            // PythagPic
            // 
            this.PythagPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PythagPic.Image = global::CalcRevision.Properties.Resources.resized_32x32_cropped_image_for_pythag_calc;
            this.PythagPic.Location = new System.Drawing.Point(521, 346);
            this.PythagPic.Name = "PythagPic";
            this.PythagPic.Size = new System.Drawing.Size(32, 32);
            this.PythagPic.TabIndex = 14;
            this.PythagPic.TabStop = false;
            this.PythagPic.Click += new System.EventHandler(this.PythagPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalcRevision.Properties.Resources.calculator_1_;
            this.pictureBox1.Location = new System.Drawing.Point(473, 258);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 257);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(954, 526);
            this.Controls.Add(this.CirclePic);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(690, 470);
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.CirclePic)).EndInit();
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
        private System.Windows.Forms.PictureBox CirclePic;
    }
}