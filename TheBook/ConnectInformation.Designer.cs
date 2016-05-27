namespace TheBook
{
    partial class ConnectInformation
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
            this.SRVTxtBox = new System.Windows.Forms.TextBox();
            this.DBTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TestConnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SRVTxtBox
            // 
            this.SRVTxtBox.Location = new System.Drawing.Point(112, 54);
            this.SRVTxtBox.Name = "SRVTxtBox";
            this.SRVTxtBox.Size = new System.Drawing.Size(100, 20);
            this.SRVTxtBox.TabIndex = 0;
            // 
            // DBTxtBox
            // 
            this.DBTxtBox.Location = new System.Drawing.Point(112, 128);
            this.DBTxtBox.Name = "DBTxtBox";
            this.DBTxtBox.Size = new System.Drawing.Size(100, 20);
            this.DBTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database";
            // 
            // TestConnButton
            // 
            this.TestConnButton.Location = new System.Drawing.Point(240, 204);
            this.TestConnButton.Name = "TestConnButton";
            this.TestConnButton.Size = new System.Drawing.Size(90, 37);
            this.TestConnButton.TabIndex = 4;
            this.TestConnButton.Text = "Test Connection";
            this.TestConnButton.UseVisualStyleBackColor = true;
            this.TestConnButton.Click += new System.EventHandler(this.TestConnButton_Click);
            // 
            // ConnectInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 253);
            this.Controls.Add(this.TestConnButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DBTxtBox);
            this.Controls.Add(this.SRVTxtBox);
            this.Name = "ConnectInformation";
            this.Text = "ConnectInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SRVTxtBox;
        private System.Windows.Forms.TextBox DBTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TestConnButton;
    }
}