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
            this.btnScanPorts = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.rotLeft = new System.Windows.Forms.Button();
            this.rotRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSensor = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetLine = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.getSamples = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lin1Right = new System.Windows.Forms.Button();
            this.lin1Left = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lin2Right = new System.Windows.Forms.Button();
            this.lin2Left = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linHome = new System.Windows.Forms.Button();
            this.linSweepLeft = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linLL = new System.Windows.Forms.Button();
            this.linRR = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.linRight = new System.Windows.Forms.Button();
            this.linLeft = new System.Windows.Forms.Button();
            this.rotLL = new System.Windows.Forms.Button();
            this.lin1LL = new System.Windows.Forms.Button();
            this.lin2LL = new System.Windows.Forms.Button();
            this.rotRR = new System.Windows.Forms.Button();
            this.lin2RR = new System.Windows.Forms.Button();
            this.lin1RR = new System.Windows.Forms.Button();
            this.Accelerometer = new System.Windows.Forms.GroupBox();
            this.boxForceZ = new System.Windows.Forms.TextBox();
            this.boxForceY = new System.Windows.Forms.TextBox();
            this.boxForceX = new System.Windows.Forms.TextBox();
            this.boxAngle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linSweepRight = new System.Windows.Forms.Button();
            this.rotStepRight = new System.Windows.Forms.Button();
            this.rotHome = new System.Windows.Forms.Button();
            this.rotStepLeft = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.boxLocation = new System.Windows.Forms.TextBox();
            this.boxRange = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSetDelay = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnSetLightDelay = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSetIntergrationTime = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.UDLines = new System.Windows.Forms.NumericUpDown();
            this.UDcm = new System.Windows.Forms.NumericUpDown();
            this.UDSamples = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Accelerometer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDcm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDSamples)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScanPorts
            // 
            this.btnScanPorts.Location = new System.Drawing.Point(93, 10);
            this.btnScanPorts.Name = "btnScanPorts";
            this.btnScanPorts.Size = new System.Drawing.Size(75, 23);
            this.btnScanPorts.TabIndex = 0;
            this.btnScanPorts.Text = "Scan Ports";
            this.btnScanPorts.UseVisualStyleBackColor = true;
            this.btnScanPorts.Click += new System.EventHandler(this.btnScanPorts_Click);
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
            this.serialPort1.BaudRate = 250000;
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
            // 
            // rotRight
            // 
            this.rotRight.Location = new System.Drawing.Point(158, 23);
            this.rotRight.Name = "rotRight";
            this.rotRight.Size = new System.Drawing.Size(23, 23);
            this.rotRight.TabIndex = 6;
            this.rotRight.Text = ">";
            this.rotRight.UseVisualStyleBackColor = true;
            this.rotRight.Click += new System.EventHandler(this.rotRight_Click);
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
            this.txtSensor.Size = new System.Drawing.Size(123, 153);
            this.txtSensor.TabIndex = 8;
            this.txtSensor.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetLine);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.getSamples);
            this.groupBox1.Controls.Add(this.txtSensor);
            this.groupBox1.Location = new System.Drawing.Point(238, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 279);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Light Sensor";
            // 
            // btnGetLine
            // 
            this.btnGetLine.Location = new System.Drawing.Point(29, 250);
            this.btnGetLine.Name = "btnGetLine";
            this.btnGetLine.Size = new System.Drawing.Size(75, 23);
            this.btnGetLine.TabIndex = 40;
            this.btnGetLine.Text = "Get Line";
            this.btnGetLine.UseVisualStyleBackColor = true;
            this.btnGetLine.Click += new System.EventHandler(this.btnGetLine_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(6, 208);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(123, 23);
            this.ClearButton.TabIndex = 29;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // getSamples
            // 
            this.getSamples.Location = new System.Drawing.Point(6, 179);
            this.getSamples.Name = "getSamples";
            this.getSamples.Size = new System.Drawing.Size(123, 23);
            this.getSamples.TabIndex = 9;
            this.getSamples.Text = "Take Samples";
            this.getSamples.UseVisualStyleBackColor = true;
            this.getSamples.Click += new System.EventHandler(this.getSamples_Click);
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
            this.lin1Right.Click += new System.EventHandler(this.lin1Right_Click);
            // 
            // lin1Left
            // 
            this.lin1Left.Location = new System.Drawing.Point(129, 52);
            this.lin1Left.Name = "lin1Left";
            this.lin1Left.Size = new System.Drawing.Size(23, 23);
            this.lin1Left.TabIndex = 10;
            this.lin1Left.Text = "<";
            this.lin1Left.UseVisualStyleBackColor = true;
            this.lin1Left.Click += new System.EventHandler(this.lin1Left_Click);
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
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sweep linear";
            // 
            // linHome
            // 
            this.linHome.Location = new System.Drawing.Point(110, 48);
            this.linHome.Name = "linHome";
            this.linHome.Size = new System.Drawing.Size(43, 23);
            this.linHome.TabIndex = 19;
            this.linHome.Text = "Home";
            this.linHome.UseVisualStyleBackColor = true;
            this.linHome.Click += new System.EventHandler(this.linHome_Click);
            // 
            // linSweepLeft
            // 
            this.linSweepLeft.Location = new System.Drawing.Point(81, 48);
            this.linSweepLeft.Name = "linSweepLeft";
            this.linSweepLeft.Size = new System.Drawing.Size(23, 23);
            this.linSweepLeft.TabIndex = 18;
            this.linSweepLeft.Text = "<";
            this.linSweepLeft.UseVisualStyleBackColor = true;
            this.linSweepLeft.Click += new System.EventHandler(this.linSweepLeft_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linLL);
            this.groupBox2.Controls.Add(this.linRR);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.linRight);
            this.groupBox2.Controls.Add(this.linLeft);
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
            this.groupBox2.Size = new System.Drawing.Size(220, 143);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual Control";
            // 
            // linLL
            // 
            this.linLL.Location = new System.Drawing.Point(101, 111);
            this.linLL.Name = "linLL";
            this.linLL.Size = new System.Drawing.Size(23, 23);
            this.linLL.TabIndex = 28;
            this.linLL.Text = "{";
            this.linLL.UseVisualStyleBackColor = true;
            this.linLL.Click += new System.EventHandler(this.linLL_Click);
            // 
            // linRR
            // 
            this.linRR.Location = new System.Drawing.Point(188, 111);
            this.linRR.Name = "linRR";
            this.linRR.Size = new System.Drawing.Size(23, 23);
            this.linRR.TabIndex = 27;
            this.linRR.Text = "}";
            this.linRR.UseVisualStyleBackColor = true;
            this.linRR.Click += new System.EventHandler(this.linRR_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Linear beide";
            // 
            // linRight
            // 
            this.linRight.Location = new System.Drawing.Point(159, 111);
            this.linRight.Name = "linRight";
            this.linRight.Size = new System.Drawing.Size(23, 23);
            this.linRight.TabIndex = 25;
            this.linRight.Text = ">";
            this.linRight.UseVisualStyleBackColor = true;
            this.linRight.Click += new System.EventHandler(this.linRight_Click);
            // 
            // linLeft
            // 
            this.linLeft.Location = new System.Drawing.Point(130, 111);
            this.linLeft.Name = "linLeft";
            this.linLeft.Size = new System.Drawing.Size(23, 23);
            this.linLeft.TabIndex = 24;
            this.linLeft.Text = "<";
            this.linLeft.UseVisualStyleBackColor = true;
            this.linLeft.Click += new System.EventHandler(this.linLeft_Click);
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
            this.lin1LL.Click += new System.EventHandler(this.lin1LL_Click);
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
            // rotRR
            // 
            this.rotRR.Location = new System.Drawing.Point(187, 23);
            this.rotRR.Name = "rotRR";
            this.rotRR.Size = new System.Drawing.Size(23, 23);
            this.rotRR.TabIndex = 18;
            this.rotRR.Text = "}";
            this.rotRR.UseVisualStyleBackColor = true;
            this.rotRR.Click += new System.EventHandler(this.rotRR_Click);
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
            this.lin1RR.Click += new System.EventHandler(this.lin1RR_Click);
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
            this.Accelerometer.Location = new System.Drawing.Point(379, 12);
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
            // linSweepRight
            // 
            this.linSweepRight.Location = new System.Drawing.Point(159, 48);
            this.linSweepRight.Name = "linSweepRight";
            this.linSweepRight.Size = new System.Drawing.Size(23, 23);
            this.linSweepRight.TabIndex = 23;
            this.linSweepRight.Text = ">";
            this.linSweepRight.UseVisualStyleBackColor = true;
            this.linSweepRight.Click += new System.EventHandler(this.linSweepRight_Click);
            // 
            // rotStepRight
            // 
            this.rotStepRight.Location = new System.Drawing.Point(159, 19);
            this.rotStepRight.Name = "rotStepRight";
            this.rotStepRight.Size = new System.Drawing.Size(23, 23);
            this.rotStepRight.TabIndex = 26;
            this.rotStepRight.Text = ">";
            this.rotStepRight.UseVisualStyleBackColor = true;
            this.rotStepRight.Click += new System.EventHandler(this.rotStepRight_Click);
            // 
            // rotHome
            // 
            this.rotHome.Location = new System.Drawing.Point(110, 19);
            this.rotHome.Name = "rotHome";
            this.rotHome.Size = new System.Drawing.Size(43, 23);
            this.rotHome.TabIndex = 25;
            this.rotHome.Text = "Home";
            this.rotHome.UseVisualStyleBackColor = true;
            this.rotHome.Click += new System.EventHandler(this.rotHome_Click);
            // 
            // rotStepLeft
            // 
            this.rotStepLeft.Location = new System.Drawing.Point(81, 19);
            this.rotStepLeft.Name = "rotStepLeft";
            this.rotStepLeft.Size = new System.Drawing.Size(23, 23);
            this.rotStepLeft.TabIndex = 24;
            this.rotStepLeft.Text = "<";
            this.rotStepLeft.UseVisualStyleBackColor = true;
            this.rotStepLeft.Click += new System.EventHandler(this.rotStepLeft_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Rotatie";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.linSweepLeft);
            this.groupBox3.Controls.Add(this.rotStepRight);
            this.groupBox3.Controls.Add(this.linHome);
            this.groupBox3.Controls.Add(this.rotHome);
            this.groupBox3.Controls.Add(this.linSweepRight);
            this.groupBox3.Controls.Add(this.rotStepLeft);
            this.groupBox3.Location = new System.Drawing.Point(12, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 82);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Functies";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.boxLocation);
            this.groupBox4.Controls.Add(this.boxRange);
            this.groupBox4.Location = new System.Drawing.Point(379, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 76);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scanner";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Location";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Range";
            // 
            // boxLocation
            // 
            this.boxLocation.Location = new System.Drawing.Point(55, 45);
            this.boxLocation.Name = "boxLocation";
            this.boxLocation.Size = new System.Drawing.Size(39, 20);
            this.boxLocation.TabIndex = 1;
            // 
            // boxRange
            // 
            this.boxRange.Location = new System.Drawing.Point(55, 19);
            this.boxRange.Name = "boxRange";
            this.boxRange.Size = new System.Drawing.Size(39, 20);
            this.boxRange.TabIndex = 0;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(27, 36);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(143, 51);
            this.btnScan.TabIndex = 30;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(99, 25);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 31;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnSetDelay
            // 
            this.btnSetDelay.Location = new System.Drawing.Point(149, 25);
            this.btnSetDelay.Name = "btnSetDelay";
            this.btnSetDelay.Size = new System.Drawing.Size(36, 20);
            this.btnSetDelay.TabIndex = 32;
            this.btnSetDelay.Text = "Set Delay";
            this.btnSetDelay.UseVisualStyleBackColor = true;
            this.btnSetDelay.Click += new System.EventHandler(this.btnSetDelay_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(99, 52);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown2.TabIndex = 33;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnSetLightDelay
            // 
            this.btnSetLightDelay.Location = new System.Drawing.Point(149, 52);
            this.btnSetLightDelay.Name = "btnSetLightDelay";
            this.btnSetLightDelay.Size = new System.Drawing.Size(36, 20);
            this.btnSetLightDelay.TabIndex = 34;
            this.btnSetLightDelay.Text = "Set";
            this.btnSetLightDelay.UseVisualStyleBackColor = true;
            this.btnSetLightDelay.Click += new System.EventHandler(this.btnSetLightDelay_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "linStepDelay";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "LightDelay";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "IntergrationTime";
            // 
            // btnSetIntergrationTime
            // 
            this.btnSetIntergrationTime.Location = new System.Drawing.Point(149, 78);
            this.btnSetIntergrationTime.Name = "btnSetIntergrationTime";
            this.btnSetIntergrationTime.Size = new System.Drawing.Size(36, 20);
            this.btnSetIntergrationTime.TabIndex = 38;
            this.btnSetIntergrationTime.Text = "Set";
            this.btnSetIntergrationTime.UseVisualStyleBackColor = true;
            this.btnSetIntergrationTime.Click += new System.EventHandler(this.btnSetIntergrationTime_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(99, 78);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown3.TabIndex = 37;
            this.numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(28, 94);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(142, 23);
            this.btnStopScan.TabIndex = 40;
            this.btnStopScan.Text = "Stahp";
            this.btnStopScan.UseVisualStyleBackColor = true;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(303, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 147);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 462);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(285, 23);
            this.progressBar1.TabIndex = 43;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Controls.Add(this.btnSetDelay);
            this.groupBox5.Controls.Add(this.numericUpDown2);
            this.groupBox5.Controls.Add(this.btnSetLightDelay);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.btnSetIntergrationTime);
            this.groupBox5.Controls.Add(this.numericUpDown3);
            this.groupBox5.Location = new System.Drawing.Point(379, 235);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(193, 109);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Timing";
            // 
            // UDLines
            // 
            this.UDLines.Location = new System.Drawing.Point(195, 41);
            this.UDLines.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.UDLines.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UDLines.Name = "UDLines";
            this.UDLines.Size = new System.Drawing.Size(51, 20);
            this.UDLines.TabIndex = 45;
            this.UDLines.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // UDcm
            // 
            this.UDcm.DecimalPlaces = 1;
            this.UDcm.Location = new System.Drawing.Point(195, 94);
            this.UDcm.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.UDcm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDcm.Name = "UDcm";
            this.UDcm.Size = new System.Drawing.Size(51, 20);
            this.UDcm.TabIndex = 47;
            this.UDcm.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // UDSamples
            // 
            this.UDSamples.Location = new System.Drawing.Point(196, 67);
            this.UDSamples.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.UDSamples.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UDSamples.Name = "UDSamples";
            this.UDSamples.Size = new System.Drawing.Size(51, 20);
            this.UDSamples.TabIndex = 48;
            this.UDSamples.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnScan);
            this.groupBox6.Controls.Add(this.UDSamples);
            this.groupBox6.Controls.Add(this.btnStopScan);
            this.groupBox6.Controls.Add(this.UDcm);
            this.groupBox6.Controls.Add(this.UDLines);
            this.groupBox6.Location = new System.Drawing.Point(22, 317);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(275, 139);
            this.groupBox6.TabIndex = 49;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Scan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 508);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Accelerometer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnScanPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "🐱 Scan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Accelerometer.ResumeLayout(false);
            this.Accelerometer.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDcm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDSamples)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScanPorts;
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
        private System.Windows.Forms.Button linHome;
        private System.Windows.Forms.Button linSweepLeft;
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
        private System.Windows.Forms.Button linSweepRight;
        private System.Windows.Forms.Button rotStepRight;
        private System.Windows.Forms.Button rotHome;
        private System.Windows.Forms.Button rotStepLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button getSamples;
        private System.Windows.Forms.Button linLL;
        private System.Windows.Forms.Button linRR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button linRight;
        private System.Windows.Forms.Button linLeft;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boxLocation;
        private System.Windows.Forms.TextBox boxRange;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSetDelay;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btnSetLightDelay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSetIntergrationTime;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button btnGetLine;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown UDLines;
        private System.Windows.Forms.NumericUpDown UDcm;
        private System.Windows.Forms.NumericUpDown UDSamples;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

