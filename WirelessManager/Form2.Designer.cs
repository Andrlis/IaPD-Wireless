namespace WirelessManager
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pwdLabel = new System.Windows.Forms.Label();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.networkLabel = new System.Windows.Forms.Label();
            this.networkName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Location = new System.Drawing.Point(12, 32);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(56, 13);
            this.pwdLabel.TabIndex = 0;
            this.pwdLabel.Text = "Password:";
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Location = new System.Drawing.Point(75, 32);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.PasswordChar = '*';
            this.pwdTextBox.Size = new System.Drawing.Size(167, 20);
            this.pwdTextBox.TabIndex = 1;
            this.pwdTextBox.UseWaitCursor = true;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(92, 58);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // networkLabel
            // 
            this.networkLabel.AutoSize = true;
            this.networkLabel.Location = new System.Drawing.Point(12, 9);
            this.networkLabel.Name = "networkLabel";
            this.networkLabel.Size = new System.Drawing.Size(50, 13);
            this.networkLabel.TabIndex = 3;
            this.networkLabel.Text = "Network:";
            // 
            // networkName
            // 
            this.networkName.AutoSize = true;
            this.networkName.Location = new System.Drawing.Point(72, 9);
            this.networkName.Name = "networkName";
            this.networkName.Size = new System.Drawing.Size(0, 13);
            this.networkName.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 91);
            this.Controls.Add(this.networkName);
            this.Controls.Add(this.networkLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.pwdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(270, 130);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 130);
            this.Name = "Form2";
            this.Text = "Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label networkLabel;
        private System.Windows.Forms.Label networkName;
    }
}