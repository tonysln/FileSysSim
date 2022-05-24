namespace FileSysSim
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomAlgoTextbox = new System.Windows.Forms.TextBox();
            this.customAlgo = new System.Windows.Forms.RadioButton();
            this.sampleAlgo3 = new System.Windows.Forms.RadioButton();
            this.sampleAlgo2 = new System.Windows.Forms.RadioButton();
            this.sampleAlgo1 = new System.Windows.Forms.RadioButton();
            this.runButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.simChart = new System.Windows.Forms.PictureBox();
            this.arvutusedLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simChart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CustomAlgoTextbox);
            this.groupBox1.Controls.Add(this.customAlgo);
            this.groupBox1.Controls.Add(this.sampleAlgo3);
            this.groupBox1.Controls.Add(this.sampleAlgo2);
            this.groupBox1.Controls.Add(this.sampleAlgo1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vali või sisesta järjend kujul (A,2;B,3;A,-;C,4;B,+2). Max 10 faili.";
            // 
            // CustomAlgoTextbox
            // 
            this.CustomAlgoTextbox.Font = new System.Drawing.Font("Consolas", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomAlgoTextbox.Location = new System.Drawing.Point(123, 137);
            this.CustomAlgoTextbox.Name = "CustomAlgoTextbox";
            this.CustomAlgoTextbox.Size = new System.Drawing.Size(303, 23);
            this.CustomAlgoTextbox.TabIndex = 4;
            this.CustomAlgoTextbox.Click += new System.EventHandler(this.CustomAlgoTextbox_Click);
            this.CustomAlgoTextbox.TextChanged += new System.EventHandler(this.CustomAlgoTextbox_TextChanged);
            this.CustomAlgoTextbox.Enter += new System.EventHandler(this.CustomAlgoTextbox_Enter);
            // 
            // customAlgo
            // 
            this.customAlgo.AutoSize = true;
            this.customAlgo.Location = new System.Drawing.Point(23, 134);
            this.customAlgo.Name = "customAlgo";
            this.customAlgo.Size = new System.Drawing.Size(94, 24);
            this.customAlgo.TabIndex = 3;
            this.customAlgo.TabStop = true;
            this.customAlgo.Text = "Enda oma";
            this.customAlgo.UseVisualStyleBackColor = true;
            // 
            // sampleAlgo3
            // 
            this.sampleAlgo3.AutoSize = true;
            this.sampleAlgo3.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sampleAlgo3.Location = new System.Drawing.Point(23, 103);
            this.sampleAlgo3.Name = "sampleAlgo3";
            this.sampleAlgo3.Size = new System.Drawing.Size(322, 22);
            this.sampleAlgo3.TabIndex = 2;
            this.sampleAlgo3.TabStop = true;
            this.sampleAlgo3.Text = "A,2;B,3;C,4;D,5;B,-;E,7;D,-;E,+3;F,10";
            this.sampleAlgo3.UseVisualStyleBackColor = true;
            // 
            // sampleAlgo2
            // 
            this.sampleAlgo2.AutoSize = true;
            this.sampleAlgo2.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sampleAlgo2.Location = new System.Drawing.Point(23, 72);
            this.sampleAlgo2.Name = "sampleAlgo2";
            this.sampleAlgo2.Size = new System.Drawing.Size(322, 22);
            this.sampleAlgo2.TabIndex = 1;
            this.sampleAlgo2.TabStop = true;
            this.sampleAlgo2.Text = "A,4;B,3;C,6;D,5;C,+2;B,-;E,5;A,-;F,10";
            this.sampleAlgo2.UseVisualStyleBackColor = true;
            // 
            // sampleAlgo1
            // 
            this.sampleAlgo1.AutoSize = true;
            this.sampleAlgo1.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sampleAlgo1.Location = new System.Drawing.Point(23, 41);
            this.sampleAlgo1.Name = "sampleAlgo1";
            this.sampleAlgo1.Size = new System.Drawing.Size(322, 22);
            this.sampleAlgo1.TabIndex = 0;
            this.sampleAlgo1.TabStop = true;
            this.sampleAlgo1.Text = "A,2;B,3;A,-;C,4;B,+3;D,5;E,15;C,-;F,5";
            this.sampleAlgo1.UseVisualStyleBackColor = true;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(25, 211);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(104, 34);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Käivita";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(140, 211);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 34);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Puhasta";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arvutused";
            // 
            // simChart
            // 
            this.simChart.Location = new System.Drawing.Point(12, 265);
            this.simChart.Name = "simChart";
            this.simChart.Size = new System.Drawing.Size(1046, 365);
            this.simChart.TabIndex = 4;
            this.simChart.TabStop = false;
            // 
            // arvutusedLabel
            // 
            this.arvutusedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arvutusedLabel.Location = new System.Drawing.Point(533, 41);
            this.arvutusedLabel.Name = "arvutusedLabel";
            this.arvutusedLabel.Size = new System.Drawing.Size(435, 108);
            this.arvutusedLabel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 645);
            this.Controls.Add(this.arvutusedLabel);
            this.Controls.Add(this.simChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Failisüsteemi ühetasemelise indekseeritud paigutuse simulaator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton customAlgo;
        private System.Windows.Forms.RadioButton sampleAlgo3;
        private System.Windows.Forms.RadioButton sampleAlgo2;
        private System.Windows.Forms.RadioButton sampleAlgo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox simChart;
        private System.Windows.Forms.TextBox CustomAlgoTextbox;
        private System.Windows.Forms.Label arvutusedLabel;
    }
}

