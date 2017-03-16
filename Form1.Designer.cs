namespace peeps
{
    partial class Roster
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
            this.button1 = new System.Windows.Forms.Button();
            this.SectionA = new System.Windows.Forms.Button();
            this.SectionB = new System.Windows.Forms.Button();
            this.SectionC = new System.Windows.Forms.Button();
            this.SectionD = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 159);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SectionA
            // 
            this.SectionA.Location = new System.Drawing.Point(13, 13);
            this.SectionA.Name = "SectionA";
            this.SectionA.Size = new System.Drawing.Size(119, 23);
            this.SectionA.TabIndex = 3;
            this.SectionA.Text = "SectionA";
            this.SectionA.UseVisualStyleBackColor = true;
            // 
            // SectionB
            // 
            this.SectionB.Location = new System.Drawing.Point(138, 13);
            this.SectionB.Name = "SectionB";
            this.SectionB.Size = new System.Drawing.Size(119, 23);
            this.SectionB.TabIndex = 4;
            this.SectionB.Text = "SectionB";
            this.SectionB.UseVisualStyleBackColor = true;
            // 
            // SectionC
            // 
            this.SectionC.Location = new System.Drawing.Point(263, 13);
            this.SectionC.Name = "SectionC";
            this.SectionC.Size = new System.Drawing.Size(119, 23);
            this.SectionC.TabIndex = 5;
            this.SectionC.Text = "SectioC";
            this.SectionC.UseVisualStyleBackColor = true;
            // 
            // SectionD
            // 
            this.SectionD.Location = new System.Drawing.Point(388, 13);
            this.SectionD.Name = "SectionD";
            this.SectionD.Size = new System.Drawing.Size(119, 23);
            this.SectionD.TabIndex = 6;
            this.SectionD.Text = "SectionD";
            this.SectionD.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Enabled = false;
            this.Clear.Location = new System.Drawing.Point(763, 13);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(119, 23);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Visible = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Export
            // 
            this.Export.Enabled = false;
            this.Export.Location = new System.Drawing.Point(638, 13);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(119, 23);
            this.Export.TabIndex = 8;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Visible = false;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(889, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Import";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Roster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 628);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.SectionD);
            this.Controls.Add(this.SectionC);
            this.Controls.Add(this.SectionB);
            this.Controls.Add(this.SectionA);
            this.Controls.Add(this.button1);
            this.Name = "Roster";
            this.Text = "Tiger Roster";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SectionA;
        private System.Windows.Forms.Button SectionB;
        private System.Windows.Forms.Button SectionC;
        private System.Windows.Forms.Button SectionD;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button button2;
    }
}

