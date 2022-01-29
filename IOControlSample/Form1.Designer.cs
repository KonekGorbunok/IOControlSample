namespace IOControlSample
{
    partial class IOControlSample
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
            this.components = new System.ComponentModel.Container();
            this.serialPort_RS232 = new System.IO.Ports.SerialPort(this.components);
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exchangeGroupBox = new System.Windows.Forms.GroupBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.outputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.parityLabel = new System.Windows.Forms.Label();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.portNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.exchangeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputNumericUpDown)).BeginInit();
            this.settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectButton.Location = new System.Drawing.Point(6, 51);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Открыть";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disconnectButton.Location = new System.Drawing.Point(135, 51);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 1;
            this.disconnectButton.Text = "Закрыть";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.disconnectButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление портом.";
            // 
            // exchangeGroupBox
            // 
            this.exchangeGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exchangeGroupBox.Controls.Add(this.sendButton);
            this.exchangeGroupBox.Controls.Add(this.outputNumericUpDown);
            this.exchangeGroupBox.Controls.Add(this.inputTextBox);
            this.exchangeGroupBox.Controls.Add(this.lbl1);
            this.exchangeGroupBox.Controls.Add(this.lbl0);
            this.exchangeGroupBox.Location = new System.Drawing.Point(12, 154);
            this.exchangeGroupBox.Name = "exchangeGroupBox";
            this.exchangeGroupBox.Size = new System.Drawing.Size(217, 106);
            this.exchangeGroupBox.TabIndex = 3;
            this.exchangeGroupBox.TabStop = false;
            this.exchangeGroupBox.Text = "Обмен данными";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(10, 77);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(194, 23);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // outputNumericUpDown
            // 
            this.outputNumericUpDown.Location = new System.Drawing.Point(104, 18);
            this.outputNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.outputNumericUpDown.Name = "outputNumericUpDown";
            this.outputNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.outputNumericUpDown.TabIndex = 4;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(104, 46);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(7, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(56, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Принятое";
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Location = new System.Drawing.Point(7, 20);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(83, 13);
            this.lbl0.TabIndex = 0;
            this.lbl0.Text = "Передаваемое";
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.stopBitsComboBox);
            this.settingsGroupBox.Controls.Add(this.parityComboBox);
            this.settingsGroupBox.Controls.Add(this.dataBitsComboBox);
            this.settingsGroupBox.Controls.Add(this.baudRateComboBox);
            this.settingsGroupBox.Controls.Add(this.portNameComboBox);
            this.settingsGroupBox.Controls.Add(this.stopBitsLabel);
            this.settingsGroupBox.Controls.Add(this.parityLabel);
            this.settingsGroupBox.Controls.Add(this.dataBitsLabel);
            this.settingsGroupBox.Controls.Add(this.baudRateLabel);
            this.settingsGroupBox.Controls.Add(this.portNameLabel);
            this.settingsGroupBox.Location = new System.Drawing.Point(266, 12);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(253, 247);
            this.settingsGroupBox.TabIndex = 4;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Параметры порта";
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(126, 185);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.stopBitsComboBox.TabIndex = 9;
            // 
            // parityComboBox
            // 
            this.parityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Location = new System.Drawing.Point(126, 139);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(121, 21);
            this.parityComboBox.TabIndex = 8;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Location = new System.Drawing.Point(126, 95);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.dataBitsComboBox.TabIndex = 7;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(126, 54);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.baudRateComboBox.TabIndex = 6;
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(126, 13);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.portNameComboBox.TabIndex = 5;
            this.portNameComboBox.DropDown += new System.EventHandler(this.portNameComboBox_DropDown);
            // 
            // stopBitsLabel
            // 
            this.stopBitsLabel.AutoSize = true;
            this.stopBitsLabel.Location = new System.Drawing.Point(6, 188);
            this.stopBitsLabel.Name = "stopBitsLabel";
            this.stopBitsLabel.Size = new System.Drawing.Size(88, 13);
            this.stopBitsLabel.TabIndex = 4;
            this.stopBitsLabel.Text = "Стоповые биты:";
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Location = new System.Drawing.Point(6, 142);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(58, 13);
            this.parityLabel.TabIndex = 3;
            this.parityLabel.Text = "Чётность:";
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Location = new System.Drawing.Point(6, 98);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(68, 13);
            this.dataBitsLabel.TabIndex = 2;
            this.dataBitsLabel.Text = "Бит данных:";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(6, 57);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(80, 13);
            this.baudRateLabel.TabIndex = 1;
            this.baudRateLabel.Text = "Бит в секунду:";
            // 
            // portNameLabel
            // 
            this.portNameLabel.AutoSize = true;
            this.portNameLabel.Location = new System.Drawing.Point(6, 16);
            this.portNameLabel.Name = "portNameLabel";
            this.portNameLabel.Size = new System.Drawing.Size(35, 13);
            this.portNameLabel.TabIndex = 0;
            this.portNameLabel.Text = "Порт:";
            // 
            // IOControlSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 275);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.exchangeGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "IOControlSample";
            this.Text = "Панель управления RS-232";
            this.groupBox1.ResumeLayout(false);
            this.exchangeGroupBox.ResumeLayout(false);
            this.exchangeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputNumericUpDown)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort_RS232;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox exchangeGroupBox;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.NumericUpDown outputNumericUpDown;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Label portNameLabel;
    }
}

