namespace _38ThreadingWindowsFormsDemo
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnStartT1 = new System.Windows.Forms.Button();
            this.btnResumeT1 = new System.Windows.Forms.Button();
            this.btnResumeT2 = new System.Windows.Forms.Button();
            this.btnStopT1 = new System.Windows.Forms.Button();
            this.btnStopT2 = new System.Windows.Forms.Button();
            this.btnPauseT2 = new System.Windows.Forms.Button();
            this.btnPauseT1 = new System.Windows.Forms.Button();
            this.btnStartT2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 381);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(543, 34);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(245, 381);
            this.listBox2.TabIndex = 1;
            // 
            // btnStartT1
            // 
            this.btnStartT1.Location = new System.Drawing.Point(290, 34);
            this.btnStartT1.Name = "btnStartT1";
            this.btnStartT1.Size = new System.Drawing.Size(237, 36);
            this.btnStartT1.TabIndex = 2;
            this.btnStartT1.Text = "Start T1";
            this.btnStartT1.UseVisualStyleBackColor = true;
            this.btnStartT1.Click += new System.EventHandler(this.btnStartT1_Click);
            // 
            // btnResumeT1
            // 
            this.btnResumeT1.Location = new System.Drawing.Point(290, 202);
            this.btnResumeT1.Name = "btnResumeT1";
            this.btnResumeT1.Size = new System.Drawing.Size(237, 36);
            this.btnResumeT1.TabIndex = 3;
            this.btnResumeT1.Text = "Resume T1";
            this.btnResumeT1.UseVisualStyleBackColor = true;
            this.btnResumeT1.Click += new System.EventHandler(this.btnResumeT1_Click);
            // 
            // btnResumeT2
            // 
            this.btnResumeT2.Location = new System.Drawing.Point(290, 244);
            this.btnResumeT2.Name = "btnResumeT2";
            this.btnResumeT2.Size = new System.Drawing.Size(237, 36);
            this.btnResumeT2.TabIndex = 4;
            this.btnResumeT2.Text = "Resume T2";
            this.btnResumeT2.UseVisualStyleBackColor = true;
            this.btnResumeT2.Click += new System.EventHandler(this.btnResumeT2_Click);
            // 
            // btnStopT1
            // 
            this.btnStopT1.Location = new System.Drawing.Point(290, 286);
            this.btnStopT1.Name = "btnStopT1";
            this.btnStopT1.Size = new System.Drawing.Size(237, 36);
            this.btnStopT1.TabIndex = 5;
            this.btnStopT1.Text = "Stop T1";
            this.btnStopT1.UseVisualStyleBackColor = true;
            this.btnStopT1.Click += new System.EventHandler(this.btnStopT1_Click);
            // 
            // btnStopT2
            // 
            this.btnStopT2.Location = new System.Drawing.Point(290, 328);
            this.btnStopT2.Name = "btnStopT2";
            this.btnStopT2.Size = new System.Drawing.Size(237, 36);
            this.btnStopT2.TabIndex = 6;
            this.btnStopT2.Text = "Stop T2";
            this.btnStopT2.UseVisualStyleBackColor = true;
            this.btnStopT2.Click += new System.EventHandler(this.btnStopT2_Click);
            // 
            // btnPauseT2
            // 
            this.btnPauseT2.Location = new System.Drawing.Point(290, 160);
            this.btnPauseT2.Name = "btnPauseT2";
            this.btnPauseT2.Size = new System.Drawing.Size(237, 36);
            this.btnPauseT2.TabIndex = 7;
            this.btnPauseT2.Text = "Pause T2";
            this.btnPauseT2.UseVisualStyleBackColor = true;
            this.btnPauseT2.Click += new System.EventHandler(this.btnPauseT2_Click);
            // 
            // btnPauseT1
            // 
            this.btnPauseT1.Location = new System.Drawing.Point(290, 118);
            this.btnPauseT1.Name = "btnPauseT1";
            this.btnPauseT1.Size = new System.Drawing.Size(237, 36);
            this.btnPauseT1.TabIndex = 8;
            this.btnPauseT1.Text = "Pause T1";
            this.btnPauseT1.UseVisualStyleBackColor = true;
            this.btnPauseT1.Click += new System.EventHandler(this.btnPauseT1_Click);
            // 
            // btnStartT2
            // 
            this.btnStartT2.Location = new System.Drawing.Point(290, 76);
            this.btnStartT2.Name = "btnStartT2";
            this.btnStartT2.Size = new System.Drawing.Size(237, 36);
            this.btnStartT2.TabIndex = 9;
            this.btnStartT2.Text = "Start T2";
            this.btnStartT2.UseVisualStyleBackColor = true;
            this.btnStartT2.Click += new System.EventHandler(this.btnStartT2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartT2);
            this.Controls.Add(this.btnPauseT1);
            this.Controls.Add(this.btnPauseT2);
            this.Controls.Add(this.btnStopT2);
            this.Controls.Add(this.btnStopT1);
            this.Controls.Add(this.btnResumeT2);
            this.Controls.Add(this.btnResumeT1);
            this.Controls.Add(this.btnStartT1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnStartT1;
        private System.Windows.Forms.Button btnResumeT1;
        private System.Windows.Forms.Button btnResumeT2;
        private System.Windows.Forms.Button btnStopT1;
        private System.Windows.Forms.Button btnStopT2;
        private System.Windows.Forms.Button btnPauseT2;
        private System.Windows.Forms.Button btnPauseT1;
        private System.Windows.Forms.Button btnStartT2;
    }
}

