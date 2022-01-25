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
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sendButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.exchangeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputNumericUpDown)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 110);
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
            this.exchangeGroupBox.Location = new System.Drawing.Point(19, 154);
            this.exchangeGroupBox.Name = "exchangeGroupBox";
            this.exchangeGroupBox.Size = new System.Drawing.Size(210, 106);
            this.exchangeGroupBox.TabIndex = 3;
            this.exchangeGroupBox.TabStop = false;
            this.exchangeGroupBox.Text = "Обмен данными";
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
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(7, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(56, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Принятое";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(104, 46);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 3;
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
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(10, 77);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(194, 23);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // IOControlSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 275);
            this.Controls.Add(this.exchangeGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "IOControlSample";
            this.Text = "Панель управления RS-232";
            this.groupBox1.ResumeLayout(false);
            this.exchangeGroupBox.ResumeLayout(false);
            this.exchangeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputNumericUpDown)).EndInit();
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
    }
}

