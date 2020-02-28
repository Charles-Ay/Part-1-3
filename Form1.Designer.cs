namespace Part_1_3
{
    partial class frmHeight
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblSubmit = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.lblTallest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(93, 80);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit Data";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "What is your name?:";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 28);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(93, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "How old are you?:";
            this.lblAge.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(147, 28);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 4;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 54);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(129, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "How tall are you(meters)   ";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(147, 54);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 7;
            // 
            // lblSubmit
            // 
            this.lblSubmit.AutoSize = true;
            this.lblSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmit.Location = new System.Drawing.Point(11, 127);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(0, 20);
            this.lblSubmit.TabIndex = 8;
            this.lblSubmit.Click += new System.EventHandler(this.lblSubmit_Click);
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLife.Location = new System.Drawing.Point(12, 150);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(0, 20);
            this.lblLife.TabIndex = 9;
            // 
            // lblTallest
            // 
            this.lblTallest.AutoSize = true;
            this.lblTallest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTallest.Location = new System.Drawing.Point(11, 172);
            this.lblTallest.Name = "lblTallest";
            this.lblTallest.Size = new System.Drawing.Size(0, 20);
            this.lblTallest.TabIndex = 10;
            // 
            // frmHeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 257);
            this.Controls.Add(this.lblTallest);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.lblSubmit);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSubmit);
            this.Name = "frmHeight";
            this.Text = "Height";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblSubmit;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Label lblTallest;
    }
}

