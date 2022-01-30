using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace IOControlSample
{
    /// <summary>
    /// Класс для выбора количества стоповых битов.
    /// </summary>
    public class StopBitsItem : IOControlSample
    {
        public StopBits Value { get; set; }
        public string Caption { get; set; }
        public StopBitsItem(StopBits value, string caption)
        {
            Value = value;
            Caption = caption;
        }
    }
}
