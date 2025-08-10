namespace Lecture3_Exercise1
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
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.col2011 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2012 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2013 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2014 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalary
            // 
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col2011,
            this.col2012,
            this.col2013,
            this.col2014});
            this.dgvSalary.Location = new System.Drawing.Point(53, 107);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.RowHeadersWidth = 62;
            this.dgvSalary.RowTemplate.Height = 28;
            this.dgvSalary.Size = new System.Drawing.Size(646, 231);
            this.dgvSalary.TabIndex = 0;
            // 
            // col2011
            // 
            this.col2011.HeaderText = "2011";
            this.col2011.MinimumWidth = 8;
            this.col2011.Name = "col2011";
            this.col2011.Width = 150;
            // 
            // col2012
            // 
            this.col2012.HeaderText = "2012";
            this.col2012.MinimumWidth = 8;
            this.col2012.Name = "col2012";
            this.col2012.Width = 150;
            // 
            // col2013
            // 
            this.col2013.HeaderText = "2013";
            this.col2013.MinimumWidth = 8;
            this.col2013.Name = "col2013";
            this.col2013.Width = 150;
            // 
            // col2014
            // 
            this.col2014.HeaderText = "2014";
            this.col2014.MinimumWidth = 8;
            this.col2014.Name = "col2014";
            this.col2014.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(834, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(834, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2011;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2012;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2013;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2014;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

