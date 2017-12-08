namespace WirelessManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.macLabel = new System.Windows.Forms.Label();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.authLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.macAddress = new System.Windows.Forms.Label();
            this.quality = new System.Windows.Forms.Label();
            this.authType = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(186, 176);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(226, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // macLabel
            // 
            this.macLabel.AutoSize = true;
            this.macLabel.Location = new System.Drawing.Point(226, 46);
            this.macLabel.Name = "macLabel";
            this.macLabel.Size = new System.Drawing.Size(73, 13);
            this.macLabel.TabIndex = 2;
            this.macLabel.Text = "MAC-address:";
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(226, 76);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(97, 13);
            this.qualityLabel.TabIndex = 3;
            this.qualityLabel.Text = "Connection quality:";
            // 
            // authLabel
            // 
            this.authLabel.AutoSize = true;
            this.authLabel.Location = new System.Drawing.Point(226, 106);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(101, 13);
            this.authLabel.TabIndex = 4;
            this.authLabel.Text = "Authentication type:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(342, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 13);
            this.name.TabIndex = 5;
            // 
            // macAddress
            // 
            this.macAddress.AutoSize = true;
            this.macAddress.Location = new System.Drawing.Point(342, 46);
            this.macAddress.Name = "macAddress";
            this.macAddress.Size = new System.Drawing.Size(0, 13);
            this.macAddress.TabIndex = 6;
            // 
            // quality
            // 
            this.quality.AutoSize = true;
            this.quality.Location = new System.Drawing.Point(342, 76);
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(0, 13);
            this.quality.TabIndex = 7;
            // 
            // authType
            // 
            this.authType.AutoSize = true;
            this.authType.Location = new System.Drawing.Point(345, 106);
            this.authType.Name = "authType";
            this.authType.Size = new System.Drawing.Size(0, 13);
            this.authType.TabIndex = 8;
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(229, 167);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 9;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(348, 166);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 10;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.authType);
            this.Controls.Add(this.quality);
            this.Controls.Add(this.macAddress);
            this.Controls.Add(this.name);
            this.Controls.Add(this.authLabel);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.macLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 250);
            this.MinimumSize = new System.Drawing.Size(450, 250);
            this.Name = "Form1";
            this.Text = "Network Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label macLabel;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label macAddress;
        private System.Windows.Forms.Label quality;
        private System.Windows.Forms.Label authType;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
    }
}

