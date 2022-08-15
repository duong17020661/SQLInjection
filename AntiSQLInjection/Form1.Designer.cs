namespace antiSQLInjection
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
        	this.txtInputSQL = new System.Windows.Forms.TextBox();
        	this.txtOutput = new System.Windows.Forms.TextBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.button6 = new System.Windows.Forms.Button();
        	this.button5 = new System.Windows.Forms.Button();
        	this.button4 = new System.Windows.Forms.Button();
        	this.button3 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.button7 = new System.Windows.Forms.Button();
        	this.button9 = new System.Windows.Forms.Button();
        	this.button8 = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// txtInputSQL
        	// 
        	this.txtInputSQL.Location = new System.Drawing.Point(14, 20);
        	this.txtInputSQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.txtInputSQL.Multiline = true;
        	this.txtInputSQL.Name = "txtInputSQL";
        	this.txtInputSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        	this.txtInputSQL.Size = new System.Drawing.Size(835, 212);
        	this.txtInputSQL.TabIndex = 0;
            this.txtInputSQL.Text = "select col1 from table1 where col1=null or 1=1";
        	// 
        	// txtOutput
        	// 
        	this.txtOutput.Location = new System.Drawing.Point(14, 258);
        	this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.txtOutput.Multiline = true;
        	this.txtOutput.Name = "txtOutput";
        	this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        	this.txtOutput.Size = new System.Drawing.Size(835, 129);
        	this.txtOutput.TabIndex = 1;
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(15, 512);
        	this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(565, 33);
        	this.button1.TabIndex = 2;
        	this.button1.Text = "where clause has been truncated with a comment";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// button6
        	// 
        	this.button6.Location = new System.Drawing.Point(589, 430);
        	this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.button6.Name = "button6";
        	this.button6.Size = new System.Drawing.Size(264, 115);
        	this.button6.TabIndex = 7;
        	this.button6.Text = "Check online article";
        	this.button6.UseVisualStyleBackColor = true;
        	this.button6.Click += new System.EventHandler(this.button6_Click);
        	// 
        	// button5
        	// 
        	this.button5.Location = new System.Drawing.Point(14, 676);
        	this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.button5.Name = "button5";
        	this.button5.Size = new System.Drawing.Size(566, 33);
        	this.button5.TabIndex = 6;
        	this.button5.Text = "where clause has been short-circuited";
        	this.button5.UseVisualStyleBackColor = true;
        	this.button5.Click += new System.EventHandler(this.button5_Click);
        	// 
        	// button4
        	// 
        	this.button4.Location = new System.Drawing.Point(14, 635);
        	this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.button4.Name = "button4";
        	this.button4.Size = new System.Drawing.Size(566, 33);
        	this.button4.TabIndex = 5;
        	this.button4.Text = "the addition of a union has enabled the reading of a second table or view";
        	this.button4.UseVisualStyleBackColor = true;
        	this.button4.Click += new System.EventHandler(this.button4_Click);
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(14, 594);
        	this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(566, 33);
        	this.button3.TabIndex = 4;
        	this.button3.Text = "an unintentional SQL statement has been added";
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.Click += new System.EventHandler(this.button3_Click);
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(15, 553);
        	this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(565, 33);
        	this.button2.TabIndex = 3;
        	this.button2.Text = "Stacking Queries";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	// 
        	// button7
        	// 
        	this.button7.Location = new System.Drawing.Point(589, 594);
        	this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.button7.Name = "button7";
        	this.button7.Size = new System.Drawing.Size(264, 114);
        	this.button7.TabIndex = 8;
        	this.button7.Text = "Email us(info@sqlparser.com) for a new feature";
        	this.button7.UseVisualStyleBackColor = true;
        	this.button7.Click += new System.EventHandler(this.button7_Click);
        	// 
        	// button9
        	// 
        	this.button9.Location = new System.Drawing.Point(15, 471);
        	this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.button9.Name = "button9";
        	this.button9.Size = new System.Drawing.Size(565, 33);
        	this.button9.TabIndex = 10;
        	this.button9.Text = "where clause always returns false";
        	this.button9.UseVisualStyleBackColor = true;
        	this.button9.Click += new System.EventHandler(this.Button9Click);
        	// 
        	// button8
        	// 
        	this.button8.Location = new System.Drawing.Point(15, 430);
        	this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.button8.Name = "button8";
        	this.button8.Size = new System.Drawing.Size(565, 33);
        	this.button8.TabIndex = 11;
        	this.button8.Text = "where clause always returns true";
        	this.button8.UseVisualStyleBackColor = true;
        	this.button8.Click += new System.EventHandler(this.Button8Click);
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(863, 731);
        	this.Controls.Add(this.button8);
        	this.Controls.Add(this.button9);
        	this.Controls.Add(this.button7);
        	this.Controls.Add(this.button6);
        	this.Controls.Add(this.button5);
        	this.Controls.Add(this.button4);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.txtOutput);
        	this.Controls.Add(this.txtInputSQL);
        	this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.Name = "Form1";
        	this.Text = "Anti SQL Injection demo";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;

        #endregion

        private System.Windows.Forms.TextBox txtInputSQL;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
    }
}

