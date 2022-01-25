using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;//Представляет ресурс последовательного порта.

namespace IOControlSample
{
    public partial class IOControlSample : Form
    {
        private delegate void UpdateIntFieldDelegate(int value);//Объявим делегат как поле класса нашей формы.
        public IOControlSample()
        {
            InitializeComponent();
            UpdateUIState();//Защита от дурака.
            serialPort_RS232.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            serialPort_RS232.ErrorReceived += new SerialErrorReceivedEventHandler(ErrorReceivedHandler);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_RS232.Open();//Открытие порта.
            }
            catch(SystemException exeption)
            {
                Debug.WriteLine(exeption.Message);// Сообщение об ошибке.
                ShowErrorDialog(exeption.Message);//Сообщение об ошибке.
            }
            UpdateUIState();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_RS232.Close();//Закрытие порта.
            }
            catch(System.IO.IOException exeption)
            {
                Debug.Fail(exeption.Message);//Сообщение об ошибке.
                throw exeption;
            }
            UpdateUIState();
        }
        public void ShowErrorDialog(string message)//Функция сообщения об ошибке.
        {
            MessageBox.Show(this, message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);//Сообщение об ошибке.
        }
        private void UpdateUIState()//Активация и дезактивация кнопок.
        {
            if (serialPort_RS232.IsOpen)//Если порт открыт, то:
            {
                connectButton.Enabled = false;//Деактивировать кнопку.
                disconnectButton.Enabled = true;//Активировать кнопку.
                exchangeGroupBox.Enabled = true;//Активировать кнопку.
            }
            else
            {
                connectButton.Enabled = true;
                disconnectButton.Enabled = false;
                exchangeGroupBox.Enabled = false;
            }
        }

        private void sendButton_Click(object sender, EventArgs e)//Обработчик кнопки "Отправить".
        {
            try
            {
                byte value = Decimal.ToByte(outputNumericUpDown.Value);//Считывание значения с формы.
                byte[] buffer = { value };//Объявление массива с одним значением.
                serialPort_RS232.Write(buffer, 0, 1);//Записываем указанное число байтов в последовательный порт, используя данные из буфера.
            }
            catch(Exception exception)
            {
                ShowErrorDialog(exception.Message);//Выдача сообщения об ошибке.
            }
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)//Функция для приема данных.
        {
            SerialPort serialPort = (SerialPort)sender;//Сохранение указателя на экземпляр SerialPort, вызвавший событие.
            int value = serialPort.ReadByte();//Приравнивание переменной "value" значения полученного байта.
            if (value == -1) return;//Получен символ конца потока.
            serialPort.DiscardInBuffer();// WARNING: Очистка входного буфера.
                                         // NOTE: Частое обновление данных может негативно сказаться на производи-тельности интерфейса и вызвать повышенную загрузку ЦП.
            UpdateADCValue(value);
        }
        private void ErrorReceivedHandler(object sender, SerialErrorReceivedEventArgs e)//Функция для выдачи ошибки при приёме.
        {
            Debug.Fail(e.ToString());
            //TODO: Сообщение в statusStrip.
        }
        private void UpdateADCValue(int value)//Описание метода обновления поля принимаемых данных.
        {
            if (inputTextBox.InvokeRequired)
            {
                var d = new UpdateIntFieldDelegate(UpdateADCValue);
                //Используем BeginInvoke (асинхронный) вместо Invoke (синхронный) для предотвращения взаимной блокировки потоков.
                inputTextBox.BeginInvoke(d, new object[] { value });
            }
            else
            {
                inputTextBox.Text = Convert.ToString(value);
            }
        }
        public class ExchangeData
        {
            [ReadOnly(true)]
            [DisplayName("Значение АЦП")]
            public byte Input { get; set; }

            [DisplayName("Значение выхода")]
            public byte Output { get; set; }
        }
    }
}