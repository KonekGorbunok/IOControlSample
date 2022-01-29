using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports; // Представляет ресурс последовательного порта.

namespace IOControlSample
{
    /// <summary>
    /// Класс для бита проверки на чётность.
    /// </summary>
    public class ParityItem
    {
        public Parity Value { get; set; }
        public string Caption { get; set; }
        public ParityItem(Parity value, string caption)
        {
            Value = value;
            Caption = caption;
        }
    }
}
