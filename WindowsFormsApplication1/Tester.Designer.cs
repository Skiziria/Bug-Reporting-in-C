namespace WindowsFormsApplication1
{
    partial class Tester
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
            this.CurrentProb = new System.Windows.Forms.Button();
            this.SubmitProb = new System.Windows.Forms.Button();
            this.Sug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentProb
            // 
            this.CurrentProb.Location = new System.Drawing.Point(12, 12);
            this.CurrentProb.Name = "CurrentProb";
            this.CurrentProb.Size = new System.Drawing.Size(108, 23);
            this.CurrentProb.TabIndex = 0;
            this.CurrentProb.Text = "Current Problems";
            this.CurrentProb.UseVisualStyleBackColor = true;
            this.CurrentProb.Click += new System.EventHandler(this.CurrentProb_Click);
            // 
            // SubmitProb
            // 
            this.SubmitProb.Location = new System.Drawing.Point(12, 41);
            this.SubmitProb.Name = "SubmitProb";
            this.SubmitProb.Size = new System.Drawing.Size(108, 23);
            this.SubmitProb.TabIndex = 1;
            this.SubmitProb.Text = "Submit a Problem";
            this.SubmitProb.UseVisualStyleBackColor = true;
            this.SubmitProb.Click += new System.EventHandler(this.SubmitProb_Click);
            // 
            // Sug
            // 
            this.Sug.Location = new System.Drawing.Point(12, 71);
            this.Sug.Name = "Sug";
            this.Sug.Size = new System.Drawing.Size(108, 23);
            this.Sug.TabIndex = 2;
            this.Sug.Text = "Suggestion";
            this.Sug.UseVisualStyleBackColor = true;
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 251);
            this.Controls.Add(this.Sug);
            this.Controls.Add(this.SubmitProb);
            this.Controls.Add(this.CurrentProb);
            this.Name = "Tester";
            this.Text = "Tester";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CurrentProb;
        private System.Windows.Forms.Button SubmitProb;
        private System.Windows.Forms.Button Sug;
    }
}