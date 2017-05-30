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
            this.rotRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSensor = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lin1Right = new System.Windows.Forms.Button();
            this.lin1Left = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lin2Right = new System.Windows.Forms.Button();
            this.lin2Left = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Accelerometer = new System.Windows.Forms.GroupBox();
            this.boxForceZ = new System.Windows.Forms.TextBox();
            this.boxForceY = new System.Windows.Forms.TextBox();
            this.boxForceX = new System.Windows.Forms.TextBox();
            this.boxAngle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rotRR = new System.Windows.Forms.Button();
            this.lin2RR = new System.Windows.Forms.Button();
            this.lin1RR = new System.Windows.Forms.Button();
            this.rotLL = new System.Windows.Forms.Button();
            this.lin1LL = new System.Windows.Forms.Button();
            this.lin2LL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Accelerometer.SuspendLayout();
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
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // rotLeft
            // 
            this.rotLeft.Location = new System.Drawing.Point(129, 23);
            this.rotLeft.Name = "rotLeft";
            this.rotLeft.Size = new System.Drawing.Size(23, 23);
            this.rotLeft.TabIndex = 4;
            this.rotLeft.Text = "<";
            this.rotLeft.UseVisualStyleBackColor = true;
            this.rotLeft.Click += new System.EventHandler(this.rotLeft_Click);
            this.rotLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rotLeft_MouseDown);
            this.rotLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rotLeft_MouseUp);
            // 
            // rotRight
            // 
            this.rotRight.Location = new System.Drawing.Point(158, 23);
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
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rotatie";
            // 
            // txtSensor
            // 
            this.txtSensor.HideSelection = false;
            this.txtSensor.Location = new System.Drawing.Point(6, 19);
            this.txtSensor.Name = "txtSensor";
            this.txtSensor.ReadOnly = true;
            this.txtSensor.Size = new System.Drawing.Size(101, 163);
            this.txtSensor.TabIndex = 8;
            this.txtSensor.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSensor);
            this.groupBox1.Location = new System.Drawing.Point(340, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 191);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Light Sensor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Linear top";
            // 
            // lin1Right
            // 
            this.lin1Right.Location = new System.Drawing.Point(158, 52);
            this.lin1Right.Name = "lin1Right";
            this.lin1Right.Size = new System.Drawing.Size(23, 23);
            this.lin1Right.TabIndex = 12;
            this.lin1Right.Text = ">";
            this.lin1Right.UseVisualStyleBackColor = true;
            // 
            // lin1Left
            // 
            this.lin1Left.Location = new System.Drawing.Point(129, 52);
            this.lin1Left.Name = "lin1Left";
            this.lin1Left.Size = new System.Drawing.Size(23, 23);
            this.lin1Left.TabIndex = 10;
            this.lin1Left.Text = "<";
            this.lin1Left.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Linear bot";
            // 
            // lin2Right
            // 
            this.lin2Right.Location = new System.Drawing.Point(158, 81);
            this.lin2Right.Name = "lin2Right";
            this.lin2Right.Size = new System.Drawing.Size(23, 23);
            this.lin2Right.TabIndex = 16;
            this.lin2Right.Text = ">";
            this.lin2Right.UseVisualStyleBackColor = true;
            // 
            // lin2Left
            // 
            this.lin2Left.Location = new System.Drawing.Point(129, 81);
            this.lin2Left.Name = "lin2Left";
            this.lin2Left.Size = new System.Drawing.Size(23, 23);
            this.lin2Left.TabIndex = 14;
            this.lin2Left.Text = "<";
            this.lin2Left.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sweep";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rotLL);
            this.groupBox2.Controls.Add(this.lin1LL);
            this.groupBox2.Controls.Add(this.lin2LL);
            this.groupBox2.Controls.Add(this.rotRR);
            this.groupBox2.Controls.Add(this.lin2RR);
            this.groupBox2.Controls.Add(this.lin1RR);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rotLeft);
            this.groupBox2.Controls.Add(this.rotRight);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lin1Left);
            this.groupBox2.Controls.Add(this.lin2Right);
            this.groupBox2.Controls.Add(this.lin1Right);
            this.groupBox2.Controls.Add(this.lin2Left);
            this.groupBox2.Location = new System.Drawing.Point(12, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 134);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual Control";
            // 
            // Accelerometer
            // 
            this.Accelerometer.Controls.Add(this.boxForceZ);
            this.Accelerometer.Controls.Add(this.boxForceY);
            this.Accelerometer.Controls.Add(this.boxForceX);
            this.Accelerometer.Controls.Add(this.boxAngle);
            this.Accelerometer.Controls.Add(this.label9);
            this.Accelerometer.Controls.Add(this.label8);
            this.Accelerometer.Controls.Add(this.label7);
            this.Accelerometer.Controls.Add(this.label6);
            this.Accelerometer.Location = new System.Drawing.Point(481, 12);
            this.Accelerometer.Name = "Accelerometer";
            this.Accelerometer.Size = new System.Drawing.Size(114, 135);
            this.Accelerometer.TabIndex = 22;
            this.Accelerometer.TabStop = false;
            this.Accelerometer.Text = "Accelerometer";
            // 
            // boxForceZ
            // 
            this.boxForceZ.Location = new System.Drawing.Point(64, 105);
            this.boxForceZ.Name = "boxForceZ";
            this.boxForceZ.Size = new System.Drawing.Size(44, 20);
            this.boxForceZ.TabIndex = 7;
            // 
            // boxForceY
            // 
            this.boxForceY.Location = new System.Drawing.Point(64, 79);
            this.boxForceY.Name = "boxForceY";
            this.boxForceY.Size = new System.Drawing.Size(44, 20);
            this.boxForceY.TabIndex = 6;
            // 
            // boxForceX
            // 
            this.boxForceX.Location = new System.Drawing.Point(64, 53);
            this.boxForceX.Name = "boxForceX";
            this.boxForceX.Size = new System.Drawing.Size(44, 20);
            this.boxForceX.TabIndex = 5;
            // 
            // boxAngle
            // 
            this.boxAngle.Location = new System.Drawing.Point(64, 27);
            this.boxAngle.Name = "boxAngle";
            this.boxAngle.Size = new System.Drawing.Size(44, 20);
            this.boxAngle.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "g-force Z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "g-force Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "g-force X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Angle";
            // 
            // rotRR
            // 
            this.rotRR.Location = new System.Drawing.Point(187, 23);
            this.rotRR.Name = "rotRR";
            this.rotRR.Size = new System.Drawing.Size(23, 23);
            this.rotRR.TabIndex = 18;
            this.rotRR.Text = "}";
            this.rotRR.UseVisualStyleBackColor = true;
            // 
            // lin2RR
            // 
            this.lin2RR.Location = new System.Drawing.Point(187, 81);
            this.lin2RR.Name = "lin2RR";
            this.lin2RR.Size = new System.Drawing.Size(23, 23);
            this.lin2RR.TabIndex = 20;
            this.lin2RR.Text = "}";
            this.lin2RR.UseVisualStyleBackColor = true;
            // 
            // lin1RR
            // 
            this.lin1RR.Location = new System.Drawing.Point(187, 52);
            this.lin1RR.Name = "lin1RR";
            this.lin1RR.Size = new System.Drawing.Size(23, 23);
            this.lin1RR.TabIndex = 19;
            this.lin1RR.Text = "}";
            this.lin1RR.UseVisualStyleBackColor = true;
            // 
            // rotLL
            // 
            this.rotLL.Location = new System.Drawing.Point(100, 23);
            this.rotLL.Name = "rotLL";
            this.rotLL.Size = new System.Drawing.Size(23, 23);
            this.rotLL.TabIndex = 21;
            this.rotLL.Text = "{";
            this.rotLL.UseVisualStyleBackColor = true;
            this.rotLL.Click += new System.EventHandler(this.rotLL_Click);
            // 
            // lin1LL
            // 
            this.lin1LL.Location = new System.Drawing.Point(100, 52);
            this.lin1LL.Name = "lin1LL";
            this.lin1LL.Size = new System.Drawing.Size(23, 23);
            this.lin1LL.TabIndex = 22;
            this.lin1LL.Text = "{";
            this.lin1LL.UseVisualStyleBackColor = true;
            // 
            // lin2LL
            // 
            this.lin2LL.Location = new System.Drawing.Point(100, 81);
            this.lin2LL.Name = "lin2LL";
            this.lin2LL.Size = new System.Drawing.Size(23, 23);
            this.lin2LL.TabIndex = 23;
            this.lin2LL.Text = "{";
            this.lin2LL.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 512);
            this.Controls.Add(this.Accelerometer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnScan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Accelerometer.ResumeLayout(false);
            this.Accelerometer.PerformLayout();
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
        private System.Windows.Forms.Button rotRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtSensor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lin1Right;
        private System.Windows.Forms.Button lin1Left;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lin2Right;
        private System.Windows.Forms.Button lin2Left;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Accelerometer;
        private System.Windows.Forms.TextBox boxForceZ;
        private System.Windows.Forms.TextBox boxForceY;
        private System.Windows.Forms.TextBox boxForceX;
        private System.Windows.Forms.TextBox boxAngle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button rotLL;
        private System.Windows.Forms.Button lin1LL;
        private System.Windows.Forms.Button lin2LL;
        private System.Windows.Forms.Button rotRR;
        private System.Windows.Forms.Button lin2RR;
        private System.Windows.Forms.Button lin1RR;
    }
}

