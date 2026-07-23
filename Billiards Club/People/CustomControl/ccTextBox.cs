using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Billiards_Club.People.CustomControl
{
    public partial class ccTextBox : TextBox
    {
        [Category("Data"), Description("Is this field Required")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsRequired { get; set; }
       
        public enum InputTypeEnum { TextInput, NumberInput }
        [Category("Data"), Description("Type of input for this field ")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public InputTypeEnum InputType { get; set; } = InputTypeEnum.TextInput;

        public ccTextBox()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        bool _IsNumeric()
        {
            foreach (char c in this.Text.Trim())
            {
                if (!char.IsDigit(c))
                    return false;

            }
            return true;
        }
        public bool IsValid()
        {
            if (IsRequired)
            {
                if (Text.Trim().Length == 0)
                {
                    return false;
                }
            }
            if (InputType == InputTypeEnum.NumberInput)
            {
                return _IsNumeric();
            }

            return true;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (InputType == InputTypeEnum.NumberInput)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }
    }
}
