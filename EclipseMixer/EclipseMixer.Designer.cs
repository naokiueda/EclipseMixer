
namespace EclipseBlender
{
    partial class EclipseMixer
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
            this.button_FOD = new System.Windows.Forms.Button();
            this.textBox_instructionFIlePath = new System.Windows.Forms.TextBox();
            this.label_BaseFile = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_SunShape = new System.Windows.Forms.Label();
            this.label_output = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton_Skip = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_overwrite = new System.Windows.Forms.RadioButton();
            this.label_progress = new System.Windows.Forms.Label();
            this.panel_progress = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ratio = new System.Windows.Forms.TextBox();
            this.panel_progress.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_FOD
            // 
            this.button_FOD.Location = new System.Drawing.Point(578, 4);
            this.button_FOD.Name = "button_FOD";
            this.button_FOD.Size = new System.Drawing.Size(33, 23);
            this.button_FOD.TabIndex = 0;
            this.button_FOD.Text = "...";
            this.button_FOD.UseVisualStyleBackColor = true;
            this.button_FOD.Click += new System.EventHandler(this.button_FOD_Click);
            // 
            // textBox_instructionFIlePath
            // 
            this.textBox_instructionFIlePath.Location = new System.Drawing.Point(120, 6);
            this.textBox_instructionFIlePath.Name = "textBox_instructionFIlePath";
            this.textBox_instructionFIlePath.Size = new System.Drawing.Size(452, 19);
            this.textBox_instructionFIlePath.TabIndex = 1;
            // 
            // label_BaseFile
            // 
            this.label_BaseFile.AutoSize = true;
            this.label_BaseFile.Location = new System.Drawing.Point(218, 7);
            this.label_BaseFile.Name = "label_BaseFile";
            this.label_BaseFile.Size = new System.Drawing.Size(9, 12);
            this.label_BaseFile.TabIndex = 2;
            this.label_BaseFile.Text = " ";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(536, 37);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 73);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(597, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label_SunShape
            // 
            this.label_SunShape.AutoSize = true;
            this.label_SunShape.Location = new System.Drawing.Point(218, 29);
            this.label_SunShape.Name = "label_SunShape";
            this.label_SunShape.Size = new System.Drawing.Size(9, 12);
            this.label_SunShape.TabIndex = 2;
            this.label_SunShape.Text = " ";
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(218, 51);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(9, 12);
            this.label_output.TabIndex = 2;
            this.label_output.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Instruction File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Output file";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sun Shape file";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Base file";
            // 
            // radioButton_Skip
            // 
            this.radioButton_Skip.AutoSize = true;
            this.radioButton_Skip.Checked = true;
            this.radioButton_Skip.Location = new System.Drawing.Point(380, 40);
            this.radioButton_Skip.Name = "radioButton_Skip";
            this.radioButton_Skip.Size = new System.Drawing.Size(47, 16);
            this.radioButton_Skip.TabIndex = 9;
            this.radioButton_Skip.TabStop = true;
            this.radioButton_Skip.Text = "SKIP";
            this.radioButton_Skip.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Existing Output File:";
            // 
            // radioButton_overwrite
            // 
            this.radioButton_overwrite.AutoSize = true;
            this.radioButton_overwrite.Location = new System.Drawing.Point(433, 40);
            this.radioButton_overwrite.Name = "radioButton_overwrite";
            this.radioButton_overwrite.Size = new System.Drawing.Size(92, 16);
            this.radioButton_overwrite.TabIndex = 9;
            this.radioButton_overwrite.Text = "OVER WRITE";
            this.radioButton_overwrite.UseVisualStyleBackColor = true;
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.Location = new System.Drawing.Point(292, 79);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(23, 12);
            this.label_progress.TabIndex = 11;
            this.label_progress.Text = "0/0";
            // 
            // panel_progress
            // 
            this.panel_progress.Controls.Add(this.label_BaseFile);
            this.panel_progress.Controls.Add(this.label_progress);
            this.panel_progress.Controls.Add(this.label_SunShape);
            this.panel_progress.Controls.Add(this.label_output);
            this.panel_progress.Controls.Add(this.progressBar1);
            this.panel_progress.Controls.Add(this.label7);
            this.panel_progress.Controls.Add(this.label5);
            this.panel_progress.Controls.Add(this.label6);
            this.panel_progress.Location = new System.Drawing.Point(12, 60);
            this.panel_progress.Name = "panel_progress";
            this.panel_progress.Size = new System.Drawing.Size(602, 98);
            this.panel_progress.TabIndex = 12;
            this.panel_progress.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mix Ratio";
            // 
            // textBox_ratio
            // 
            this.textBox_ratio.Location = new System.Drawing.Point(174, 37);
            this.textBox_ratio.Name = "textBox_ratio";
            this.textBox_ratio.Size = new System.Drawing.Size(37, 19);
            this.textBox_ratio.TabIndex = 13;
            this.textBox_ratio.Text = "0.85";
            this.textBox_ratio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EclipseMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 162);
            this.Controls.Add(this.textBox_ratio);
            this.Controls.Add(this.panel_progress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_overwrite);
            this.Controls.Add(this.radioButton_Skip);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_instructionFIlePath);
            this.Controls.Add(this.button_FOD);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EclipseMixer";
            this.ShowIcon = false;
            this.Text = " Eclipse Mixer";
            this.panel_progress.ResumeLayout(false);
            this.panel_progress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_FOD;
        private System.Windows.Forms.TextBox textBox_instructionFIlePath;
        private System.Windows.Forms.Label label_BaseFile;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_SunShape;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton_Skip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_overwrite;
        private System.Windows.Forms.Label label_progress;
        private System.Windows.Forms.Panel panel_progress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ratio;
    }
}