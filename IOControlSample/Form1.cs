using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;// Предоставляет классы, позволяющие осуществлять взаимодействие с системными процессами, журналами событий и счетчиками производительности.
using System.IO.Ports;// Представляет ресурс последовательного порта.

namespace IOControlSample
{
    public partial class IOControlSample : Form
    {
        private delegate void UpdateIntFieldDelegate(int value); // Объявим делегат как поле класса нашей формы.
        private static BindingList<int> baudRateList = new BindingList<int>() // Статическая фцнкция для задания скорости работы порта.
        {
            150,300,600,1200,2400,9600,57600,115200,256000 // Перечень некоторых стандартных скоростей.
        };
        private static int[] dataBitsList = { 8, 7, 6, 5 }; // Статическая функция для перечня количества преедаваемых бит.
        private static ParityItem[] paritylist = new ParityItem[] { // Объявление и инициализация массива с вариантами чётности.
            new ParityItem(Parity.None, "Не использовать"),
            new ParityItem(Parity.Odd, "Нечётный"),
            new ParityItem(Parity.Even, "Чётный"),
            new ParityItem(Parity.Mark, "Всегда 1"),
            new ParityItem(Parity.Space, "Всегда 0")
        };

        private static StopBitsItem[] stopBitsList = new StopBitsItem[] { // Объявление и инициализация массива с вариантами количества стоповых битов.
         new StopBitsItem (StopBits.Two, "2"),
         new StopBitsItem (StopBits.One, "1")
        };


        /// <summary>
        /// Инициализзцаия формы и её содержимого.
        /// </summary>
        public IOControlSample()
        {
            InitializeComponent();
            UpdateUIState(); // Защита от дурака.
              // Конфигурация порта.
            baudRateComboBox.DataSource = baudRateList; // Запись в комбобокс списка скоростей из функции static BindingList<int>.
            dataBitsComboBox.DataSource = dataBitsList; // Запись в комбобокс списка числа передаваемых бит из функции static int[] dataBitsList.
            parityComboBox.DataSource = paritylist;     // Указание источника записи списка с битом проверки на чётность.
            stopBitsComboBox.DataSource = stopBitsList; // Указание источника записи списка с количеством стоповых бит.
            parityComboBox.ValueMember = "Value"; // Исопльзовать в качестве действительного значения свойство "Value" объекта списка.
            parityComboBox.DisplayMember = "Caption"; // Исопльзовать в качестве действительного значения свойство "Caption" объекта списка.
            stopBitsComboBox.ValueMember = "Value";
            stopBitsComboBox.DisplayMember = "Caption";
              // Запись принятых значений.
            serialPort_RS232.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler); // Событие - полученые данных.
            serialPort_RS232.ErrorReceived += new SerialErrorReceivedEventHandler(ErrorReceivedHandler);
        }
        /// <summary>
        /// Обработчик кнопки "Открыть".
        /// </summary>
        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                //serialPort_RS232.PortName = portNameComboBox.Text;
                //serialPort_RS232.BaudRate = int.Parse(baudRateComboBox.Text);
                //serialPort_RS232.DataBits = (int)dataBitsComboBox.SelectedItem;
                //serialPort_RS232.Parity = (Parity)parityComboBox.SelectedValue;
                //serialPort_RS232.StopBits = (StopBits)stopBitsComboBox.SelectedValue;
                serialPort_RS232.Open(); //Открытие порта.
                connectButton.Enabled = false;
                disconnectButton.Enabled = true;
                exchangeGroupBox.Enabled = true;
                settingsGroupBox.Enabled = false;
            }
            catch(SystemException exeption)
            {
                Debug.WriteLine(exeption.Message); // Сообщение об ошибке.
                ShowErrorDialog(exeption.Message); // Сообщение об ошибке.
            }
            UpdateUIState();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_RS232.Close(); // Закрытие порта.
            }
            catch(System.IO.IOException exeption)
            {
                Debug.Fail(exeption.Message); // Сообщение об ошибке.
                throw exeption;
            }
            UpdateUIState();
        }
        /// <summary>
        /// Вывод сообщения об ошибке.
        /// </summary>
        public void ShowErrorDialog(string message) 
        {
            MessageBox.Show(this, message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Сообщение об ошибке.
        }
        /// <summary>
        /// Активация и дезактивация элементов интрфейса.
        /// </summary>
        private void UpdateUIState()
        {
            if (serialPort_RS232.IsOpen) // Если порт открыт, то:
            {
                connectButton.Enabled = false; // Деактивировать кнопку.
                disconnectButton.Enabled = true; // Активировать кнопку.
                exchangeGroupBox.Enabled = true; // Активировать кнопку.
                settingsGroupBox.Enabled = true; // Активация контейнера с параметрами порта.
            }
            else
            {
                connectButton.Enabled = true;
                disconnectButton.Enabled = false;
                exchangeGroupBox.Enabled = false;
                settingsGroupBox.Enabled = false;
            }
        }
        /// <summary>
        /// Обновление списка доступных портов.
        /// </summary>
        private void UpdatePortList()
        {
            var portNames = SerialPort.GetPortNames();
            portNameComboBox.Items.Clear();
            portNameComboBox.Items.AddRange(portNames);
        }

        private void sendButton_Click(object sender, EventArgs e) // Обработчик кнопки "Отправить".
        {
            try
            {
                byte value = Decimal.ToByte(outputNumericUpDown.Value); // Считывание значения с формы.
                byte[] buffer = { value }; // Объявление массива с одним значением.
                serialPort_RS232.Write(buffer, 0, 1); // Записываем указанное число байтов в последовательный порт, используя данные из буфера.
            }
            catch(Exception exception)
            {
                ShowErrorDialog(exception.Message); // Выдача сообщения об ошибке.
            }
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e) // Функция для приема данных.
        {
            SerialPort serialPort = (SerialPort)sender; // Сохранение указателя на экземпляр SerialPort, вызвавший событие.
            int value = serialPort.ReadByte(); // Приравнивание переменной "value" значения полученного байта.
            if (value == -1) return; // Получен символ конца потока.
            serialPort.DiscardInBuffer(); // WARNING: Очистка входного буфера.
                                          // NOTE: Частое обновление данных может негативно сказаться на производи-тельности интерфейса и вызвать повышенную загрузку ЦП.
            UpdateADCValue(value);
        }
        private void ErrorReceivedHandler(object sender, SerialErrorReceivedEventArgs e) // Функция для выдачи ошибки при приёме.
        {
            Debug.Fail(e.ToString());
            //TODO: Сообщение в statusStrip.
        }
        private void UpdateADCValue(int value) // Описание метода обновления поля принимаемых данных.
        {
            if (inputTextBox.InvokeRequired)
            {
                var d = new UpdateIntFieldDelegate(UpdateADCValue);
                // Используем BeginInvoke (асинхронный) вместо Invoke (синхронный) для предотвращения взаимной блокировки потоков.
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
        /// <summary>
        /// Обновление портов каждый раз при распахивании списка
        /// </summary>
        private void portNameComboBox_DropDown(object sender, EventArgs e)
        {
            UpdatePortList();
        }
    }
}