namespace STUDENT_INPUT_OP
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
            this.lblrollnumber = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblpercentage = new System.Windows.Forms.Label();
            this.txtrollnumber = new System.Windows.Forms.TextBox();
            this.txtpercentage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblrollnumber
            // 
            this.lblrollnumber.AutoSize = true;
            this.lblrollnumber.Location = new System.Drawing.Point(97, 74);
            this.lblrollnumber.Name = "lblrollnumber";
            this.lblrollnumber.Size = new System.Drawing.Size(79, 16);
            this.lblrollnumber.TabIndex = 0;
            this.lblrollnumber.Text = "Roll number";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(97, 166);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 16);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // lblpercentage
            // 
            this.lblpercentage.AutoSize = true;
            this.lblpercentage.Location = new System.Drawing.Point(97, 258);
            this.lblpercentage.Name = "lblpercentage";
            this.lblpercentage.Size = new System.Drawing.Size(77, 16);
            this.lblpercentage.TabIndex = 2;
            this.lblpercentage.Text = "Percentage";
            // 
            // txtrollnumber
            // 
            this.txtrollnumber.Location = new System.Drawing.Point(245, 68);
            this.txtrollnumber.Name = "txtrollnumber";
            this.txtrollnumber.Size = new System.Drawing.Size(235, 22);
            this.txtrollnumber.TabIndex = 3;
            // 
            // txtpercentage
            // 
            this.txtpercentage.Location = new System.Drawing.Point(245, 252);
            this.txtpercentage.Name = "txtpercentage";
            this.txtpercentage.Size = new System.Drawing.Size(235, 22);
            this.txtpercentage.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(245, 160);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(235, 22);
            this.txtname.TabIndex = 5;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(245, 342);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(103, 55);
            this.btnwrite.TabIndex = 6;
            this.btnwrite.Text = "WRITE";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(377, 342);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(103, 55);
            this.btnread.TabIndex = 7;
            this.btnread.Text = "READ";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpercentage);
            this.Controls.Add(this.txtrollnumber);
            this.Controls.Add(this.lblpercentage);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblrollnumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrollnumber;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblpercentage;
        private System.Windows.Forms.TextBox txtrollnumber;
        private System.Windows.Forms.TextBox txtpercentage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnread;
    }
}

