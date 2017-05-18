namespace CT_test_app
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
            this.components = new System.ComponentModel.Container();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.rotLeft = new System.Windows.Forms.Button();
            this.rotCenter = new System.Windows.Forms.Button();
            this.rotRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(93, 10);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan Ports";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 39);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(93, 39);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // cboPorts
            // 
            this.cboPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(12, 12);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(75, 21);
            this.cboPorts.TabIndex = 3;
            // 
            // rotLeft
            // 
            this.rotLeft.Location = new System.Drawing.Point(64, 102);
            this.rotLeft.Name = "rotLeft";
            this.rotLeft.Size = new System.Drawing.Size(23, 23);
            this.rotLeft.TabIndex = 4;
            this.rotLeft.Text = "<";
            this.rotLeft.UseVisualStyleBackColor = true;
            this.rotLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rotLeft_MouseDown);
            this.rotLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rotLeft_MouseUp);
            // 
            // rotCenter
            // 
            this.rotCenter.Location = new System.Drawing.Point(93, 102);
            this.rotCenter.Name = "rotCenter";
            this.rotCenter.Size = new System.Drawing.Size(23, 23);
            this.rotCenter.TabIndex = 5;
            this.rotCenter.UseVisualStyleBackColor = true;
            // 
            // rotRight
            // 
            this.rotRight.Location = new System.Drawing.Point(122, 102);
            this.rotRight.Name = "rotRight";
            this.rotRight.Size = new System.Drawing.Size(23, 23);
            this.rotRight.TabIndex = 6;
            this.rotRight.Text = ">";
            this.rotRight.UseVisualStyleBackColor = true;
            this.rotRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rotRight_MouseDown);
            this.rotRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rotRight_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "rotatie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rotRight);
            this.Controls.Add(this.rotCenter);
            this.Controls.Add(this.rotLeft);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnScan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button rotLeft;
        private System.Windows.Forms.Button rotCenter;
        private System.Windows.Forms.Button rotRight;
        private System.Windows.Forms.Label label1;
    }
}

