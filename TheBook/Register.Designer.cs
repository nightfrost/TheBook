namespace TheBook
{
    partial class Register
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
            this.regUsername = new System.Windows.Forms.TextBox();
            this.regRealName = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.regConfPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regRegister = new System.Windows.Forms.Button();
            this.regExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regUsername
            // 
            this.regUsername.Location = new System.Drawing.Point(24, 59);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(100, 20);
            this.regUsername.TabIndex = 0;
            // 
            // regRealName
            // 
            this.regRealName.Location = new System.Drawing.Point(205, 59);
            this.regRealName.Name = "regRealName";
            this.regRealName.Size = new System.Drawing.Size(100, 20);
            this.regRealName.TabIndex = 1;
            // 
            // regPassword
            // 
            this.regPassword.Location = new System.Drawing.Point(24, 131);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(100, 20);
            this.regPassword.TabIndex = 2;
            // 
            // regConfPassword
            // 
            this.regConfPassword.Location = new System.Drawing.Point(205, 131);
            this.regConfPassword.Name = "regConfPassword";
            this.regConfPassword.Size = new System.Drawing.Size(100, 20);
            this.regConfPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Real Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // regRegister
            // 
            this.regRegister.Location = new System.Drawing.Point(76, 185);
            this.regRegister.Name = "regRegister";
            this.regRegister.Size = new System.Drawing.Size(75, 23);
            this.regRegister.TabIndex = 8;
            this.regRegister.Text = "Register";
            this.regRegister.UseVisualStyleBackColor = true;
            this.regRegister.Click += new System.EventHandler(this.regRegister_Click);
            // 
            // regExit
            // 
            this.regExit.Location = new System.Drawing.Point(157, 185);
            this.regExit.Name = "regExit";
            this.regExit.Size = new System.Drawing.Size(75, 23);
            this.regExit.TabIndex = 9;
            this.regExit.Text = "Exit";
            this.regExit.UseVisualStyleBackColor = true;
            this.regExit.Click += new System.EventHandler(this.registerExit_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 227);
            this.Controls.Add(this.regExit);
            this.Controls.Add(this.regRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regConfPassword);
            this.Controls.Add(this.regPassword);
            this.Controls.Add(this.regRealName);
            this.Controls.Add(this.regUsername);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regUsername;
        private System.Windows.Forms.TextBox regRealName;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.TextBox regConfPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button regRegister;
        private System.Windows.Forms.Button regExit;
    }
}