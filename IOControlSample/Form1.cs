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

namespace IOControlSample
{
    public partial class IOControlSample : Form
    {
        public IOControlSample()
        {
            InitializeComponent();
            UpdateUIState();//Защита от дурака
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_RS232.Open();//Открытие порта
            }
            catch(SystemException exeption)
            {
                Debug.WriteLine(exeption.Message);// Сообщение об ошибке
                ShowErrorDialog(exeption.Message);//Сообщение об ошибке
            }
            UpdateUIState();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_RS232.Close();//Закрытие порта
            }
            catch(System.IO.IOException exeption)
            {
                Debug.Fail(exeption.Message);//Сообщение об ошибке
                throw exeption;
            }
            UpdateUIState();
        }
        public void ShowErrorDialog(string message)//Функция сообщения об ошибке
        {
            MessageBox.Show(this, message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);//Сообщение об ошибке
        }
        private void UpdateUIState()//Активация и дезактивация кнопок
        {
            if (serialPort_RS232.IsOpen)//Если порт открыт, то:
            {
                connectButton.Enabled = false;//Деактивировать
                disconnectButton.Enabled = true;//Активировать
                exchangeGroupBox.Enabled = true;
            }
            else
            {
                connectButton.Enabled = true;
                disconnectButton.Enabled = false;
                exchangeGroupBox.Enabled = false;
            }
        }
    }
}