﻿using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OYASAR.CodeGenerator.WinApp
{
    public class TextBoxStreamWriter : TextWriter
    {
        TextBox _output = null;

        public TextBoxStreamWriter(TextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);
            _output.AppendText(value.ToString()); // When character data is written, append it to the text box.
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
