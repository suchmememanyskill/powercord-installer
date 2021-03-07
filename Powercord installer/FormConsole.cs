using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powercord_installer
{
    public class FormConsole
    {
        public RichTextBox Console { get; set; }
        private delegate void SafeCallDelegate(string text);

        public FormConsole(RichTextBox console)
        {
            Console = console;
        }

        public void WriteLine(string text)
        {
            if (Console.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteLine);
                Console.Invoke(d, new object[] { text });
            }
            else
            {
                Console.Text += $"{text}\n";
            }
        }
    }
}
