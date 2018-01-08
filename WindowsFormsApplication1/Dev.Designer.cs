namespace WindowsFormsApplication1
{
    partial class Dev
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
            this.CurProb = new System.Windows.Forms.Button();
            this.SubProb = new System.Windows.Forms.Button();
            this.Sug = new System.Windows.Forms.Button();
            this.Solv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurProb
            // 
            this.CurProb.Location = new System.Drawing.Point(12, 12);
            this.CurProb.Name = "CurProb";
            this.CurProb.Size = new System.Drawing.Size(108, 23);
            this.CurProb.TabIndex = 0;
            this.CurProb.Text = "Current Problems";
            this.CurProb.UseVisualStyleBackColor = true;
            this.CurProb.Click += new System.EventHandler(this.CurProb_Click);
            // 
            // SubProb
            // 
            this.SubProb.Location = new System.Drawing.Point(12, 42);
            this.SubProb.Name = "SubProb";
            this.SubProb.Size = new System.Drawing.Size(108, 23);
            this.SubProb.TabIndex = 1;
            this.SubProb.Text = "Submit a Problem";
            this.SubProb.UseVisualStyleBackColor = true;
            this.SubProb.Click += new System.EventHandler(this.SubProb_Click);
            // 
            // Sug
            // 
            this.Sug.Location = new System.Drawing.Point(12, 72);
            this.Sug.Name = "Sug";
            this.Sug.Size = new System.Drawing.Size(108, 23);
            this.Sug.TabIndex = 2;
            this.Sug.Text = "Suggestion";
            this.Sug.UseVisualStyleBackColor = true;
            // 
            // Solv
            // 
            this.Solv.Location = new System.Drawing.Point(126, 12);
            this.Solv.Name = "Solv";
            this.Solv.Size = new System.Drawing.Size(108, 23);
            this.Solv.TabIndex = 3;
            this.Solv.Text = "Solve a Problem";
            this.Solv.UseVisualStyleBackColor = true;
            // 
            // Dev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Solv);
            this.Controls.Add(this.Sug);
            this.Controls.Add(this.SubProb);
            this.Controls.Add(this.CurProb);
            this.Name = "Dev";
            this.Text = "Dev";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CurProb;
        private System.Windows.Forms.Button SubProb;
        private System.Windows.Forms.Button Sug;
        private System.Windows.Forms.Button Solv;
    }
}