using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Clear button clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.inputDecimal.Text = "";
            this.inputBinary.Text = "";
            this.inputHex.Text = "";
            this.inputOctal.Text = "";
        }

        //Exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Convert button click
        private void btnConvert_Click(object sender, EventArgs e)
        {
            int _number = 0;
            if (int.TryParse(this.inputDecimal.Text,out _number))
            {
                this.inputBinary.Text = this._toBinary(_number);
                this.inputHex.Text = this._toHex(_number);
                this.inputOctal.Text = this._toOct(_number);
            }
        }


        //return binary number
        private string _toBinary(int _number)
        {
            if (_number <= 1)
            {
                return _number.ToString();
            }
            String result = "";
            while (_number >1)
            {
                int remainder = _number % 2;
                result = remainder.ToString() + result;
                _number /= 2;
            }
            return _number.ToString()+ result;
        }

        //return hex number
        private string _toHex(int _number)
        {
            return _number.ToString("x").ToUpper();
        }

        //return oct number
        private string _toOct(int _number)
        {
            int i = 1, j;
            int[] octalValue = new int[80];
            
            while (_number != 0)
            {
                octalValue[i++] = _number % 8;
                _number /= 8;
            }

            string result = "";
            for (j = i - 1; j > 0; j--)
            {
                result += octalValue[j];
            }
            return result;
        }
    }
}
