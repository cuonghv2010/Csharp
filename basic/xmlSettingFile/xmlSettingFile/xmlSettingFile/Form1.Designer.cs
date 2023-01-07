namespace xmlSettingFile
{
    partial class Form1
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxElement1 = new System.Windows.Forms.TextBox();
            this.lbElement1 = new System.Windows.Forms.Label();
            this.lbElement2 = new System.Windows.Forms.Label();
            this.tbxElement2 = new System.Windows.Forms.TextBox();
            this.tbxElement3 = new System.Windows.Forms.TextBox();
            this.lbElement3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(196, 93);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(390, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxElement1
            // 
            this.tbxElement1.Location = new System.Drawing.Point(365, 171);
            this.tbxElement1.Name = "tbxElement1";
            this.tbxElement1.Size = new System.Drawing.Size(100, 23);
            this.tbxElement1.TabIndex = 2;
            // 
            // lbElement1
            // 
            this.lbElement1.AutoSize = true;
            this.lbElement1.Location = new System.Drawing.Point(202, 179);
            this.lbElement1.Name = "lbElement1";
            this.lbElement1.Size = new System.Drawing.Size(55, 15);
            this.lbElement1.TabIndex = 3;
            this.lbElement1.Text = "Element1";
            // 
            // lbElement2
            // 
            this.lbElement2.AutoSize = true;
            this.lbElement2.Location = new System.Drawing.Point(202, 232);
            this.lbElement2.Name = "lbElement2";
            this.lbElement2.Size = new System.Drawing.Size(55, 15);
            this.lbElement2.TabIndex = 4;
            this.lbElement2.Text = "Element2";
            // 
            // tbxElement2
            // 
            this.tbxElement2.Location = new System.Drawing.Point(365, 232);
            this.tbxElement2.Name = "tbxElement2";
            this.tbxElement2.Size = new System.Drawing.Size(100, 23);
            this.tbxElement2.TabIndex = 5;
            // 
            // tbxElement3
            // 
            this.tbxElement3.Location = new System.Drawing.Point(365, 295);
            this.tbxElement3.Name = "tbxElement3";
            this.tbxElement3.Size = new System.Drawing.Size(100, 23);
            this.tbxElement3.TabIndex = 7;
            // 
            // lbElement3
            // 
            this.lbElement3.AutoSize = true;
            this.lbElement3.Location = new System.Drawing.Point(202, 295);
            this.lbElement3.Name = "lbElement3";
            this.lbElement3.Size = new System.Drawing.Size(55, 15);
            this.lbElement3.TabIndex = 6;
            this.lbElement3.Text = "Element3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxElement3);
            this.Controls.Add(this.lbElement3);
            this.Controls.Add(this.tbxElement2);
            this.Controls.Add(this.lbElement2);
            this.Controls.Add(this.lbElement1);
            this.Controls.Add(this.tbxElement1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoad;
        private Button btnSave;
        private TextBox tbxElement1;
        private Label lbElement1;
        private Label lblElement2;
        private TextBox tbxElement2;
        private Label lbElement2;
        private TextBox tbxElement3;
        private Label lbElement3;
    }
}