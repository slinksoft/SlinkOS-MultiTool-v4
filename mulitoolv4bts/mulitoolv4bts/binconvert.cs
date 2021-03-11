using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace slinkosmtv4
{
    public partial class dataConversion : Form
    {
        public dataConversion()
        {
            InitializeComponent();
        }

        private void converttoB_Click(object sender, EventArgs e)
        {
            binI.Text = tobinaryy(asciiI.Text);
        }


        public string tobinaryy(string datr)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char C in datr.ToCharArray())
            {
                sb.Append(Convert.ToString(C, 2).PadLeft(8, '0'));
            }

            return sb.ToString();
        }

        public string tostringg(string datr)
        {
            List<Byte> byteList = new List<Byte>();
            for (int i = 0; i < datr.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(datr.Substring(i, 8), 2));
            }

            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        private void converttoA_Click(object sender, EventArgs e)
        {
            asciiI.Text = tostringg(binI.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asciiI.Text = "Hello World!";
            binI.Text = "010010000110010101101100011011000110111100100000010101110110111101110010011011000110010000100001";
        }

        private void binconvert_Load(object sender, EventArgs e)
        {
            asciiI.Text = "Hello World!";
            binI.Text = "010010000110010101101100011011000110111100100000010101110110111101110010011011000110010000100001";
            asciiI2.Text = "Hello World!";
            hexI.Text = "48656c6c6f20576f726c6421";
            signedDataType.SelectedIndex = 0;
            unsignedDataType.SelectedIndex = 0;
        }


        private void binaryBase_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (binaryBase.Text != "")
                {
                    if (signedDataType.SelectedIndex == 0)
                    {
                        int a = Convert.ToInt32(binaryBase.Text, 2);
                        octaBase.Text = Convert.ToString(a, 8);
                        decimalBase.Text = Convert.ToString(a, 10);
                        hexBase.Text = Convert.ToString(a, 16);
                    }
                    else if (signedDataType.SelectedIndex == 1)
                    {
                        Int64 a = Convert.ToInt64(binaryBase.Text, 2);
                        octaBase.Text = Convert.ToString(a, 8);
                        decimalBase.Text = Convert.ToString(a, 10);
                        hexBase.Text = Convert.ToString(a, 16);
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error: Please make sure the binary value is not too big or small!"
                    + "(Limit for 32 bit values: -2147483648 - 2147483647. Limit for 64 bit values: "
                    + "-9223372036854775808 - 9223372036854775807.)", "Error");
            }
        }

        private void binaryBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 48 || e.KeyChar == 49 || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void octaBase_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (octaBase.Text != "")
                {
                    if (signedDataType.SelectedIndex == 0)
                    {
                        int a = Convert.ToInt32(octaBase.Text, 8);
                        binaryBase.Text = Convert.ToString(a, 2);
                        decimalBase.Text = Convert.ToString(a, 10);
                        hexBase.Text = Convert.ToString(a, 16);
                    }
                    else if (signedDataType.SelectedIndex == 1)
                    {
                        Int64 a = Convert.ToInt64(octaBase.Text, 8);
                        binaryBase.Text = Convert.ToString(a, 2);
                        decimalBase.Text = Convert.ToString(a, 10);
                        hexBase.Text = Convert.ToString(a, 16);
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error: Please makre sure the base 8 (Octa) value is not too big or small!"
                    + "(Limit for 32 bit values: -2147483648 - 2147483647. Limit for 64 bit values: "
                    + "-9223372036854775808 - 9223372036854775807.)", "Error");
            }
        }

        private void octaBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 48; i < 56; i++)
            {
                if (e.KeyChar == i || e.KeyChar == 8)
                {
                    e.Handled = false;
                    break;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void pointDecimal_TextChanged(object sender, EventArgs e)
        {
            /*
             * Code from https://stackoverflow.com/questions/21244252/convert-float-to-its-binary-representation-using-memorystream
             * The code uses BitConverter to convert every number into individual bits and store them into an array. Using a nested
             * foreach-for loop, each bit is converted into a binary representation and is appeneded into a string on every execution
             * of the loop.
             */
            if (point32Decimal.Text != "")
            {
                try
                {
                    if (point32Decimal.Text == "-")
                        point32Decimal.Text = "-1";
                    else if (point32Decimal.Text == ".")
                        point32Decimal.Text = ".1";
                    float f = float.Parse(point32Decimal.Text);
                    StringBuilder sb = new StringBuilder();
                    Byte[] ba = BitConverter.GetBytes(f);
                    foreach (Byte b in ba)
                        for (int i = 0; i < 8; i++)
                        {
                            sb.Insert(0, ((b >> i) & 1) == 1 ? "1" : "0");
                        }
                    string s = sb.ToString();
                    string r = s.Substring(0, 1) + " " + s.Substring(1, 8) + " " + s.Substring(9); //sign exponent mantissa
                    thirtyTwoPointRepresenation.Text = r;
                }
                catch (Exception ex)
                {
                    if (ex is OverflowException || ex is FormatException)
                        MessageBox.Show("Error: Please make sure the floating point number is in a correct format!"
                            + " Do not have more than one negative signs or decimal points! If you are trying to"
                            + "represent a bigger point number, try using the 64 bit (double data type) converter"
                            + " instead!", "Error");
                }
            }
            
        }

        private void decimalBase_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decimalBase.Text != "")
                {
                    if (signedDataType.SelectedIndex == 0)
                    {
                        if (decimalBase.Text == "-")
                            decimalBase.Text = "-1";
                        int a = Convert.ToInt32(decimalBase.Text, 10);
                        binaryBase.Text = Convert.ToString(a, 2);
                        octaBase.Text = Convert.ToString(a, 8);
                        hexBase.Text = Convert.ToString(a, 16);
                    }
                    else if (signedDataType.SelectedIndex == 1)
                    {
                        if (decimalBase.Text == "-")
                            decimalBase.Text = "-1";
                        Int64 a = Convert.ToInt64(decimalBase.Text, 10);
                        binaryBase.Text = Convert.ToString(a, 2);
                        octaBase.Text = Convert.ToString(a, 8);
                        hexBase.Text = Convert.ToString(a, 16);
                    }
                }
            }
            catch (Exception except)
            {
                if (except is OverflowException || except is FormatException)
                MessageBox.Show("Error: Please makre sure the base 10 (Decimal) value is not too big. Make sure there is only"
                 + " one negative sign and the format is correct if converting a negative value! (Limit for 32 bit values: " 
                 +"-2147483648 - 2147483647. Limit for 64 bit values: -9223372036854775808 - 9223372036854775807.)", "Error");
            }
        }

        private void hexBase_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (hexBase.Text != "")
                {
                    if (signedDataType.SelectedIndex == 0)
                    {
                        int a = Convert.ToInt32(hexBase.Text, 16);
                        binaryBase.Text = Convert.ToString(a, 2);
                        octaBase.Text = Convert.ToString(a, 8);
                        decimalBase.Text = Convert.ToString(a, 10);
                    }
                    else if (signedDataType.SelectedIndex == 1)
                    {
                        Int64 a = Convert.ToInt64(hexBase.Text, 16);
                        binaryBase.Text = Convert.ToString(a, 2);
                        octaBase.Text = Convert.ToString(a, 8);
                        decimalBase.Text = Convert.ToString(a, 10);
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error: Please makre sure the base 16 (Hex) value is not too big or small!"
                    + "(Limit for 32 bit values: -2147483648 - 2147483647. Limit for 64 bit values: "
                    + "-9223372036854775808 - 9223372036854775807.)", "Error");
            }
        }

        private void decimalBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 48; i < 58; i++)
            {
                if (e.KeyChar == i || e.KeyChar == 8 || e.KeyChar == 45)
                {
                    e.Handled = false;
                    break;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void hexBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 48; i < 58; i++)
            {

                if (e.KeyChar == i || e.KeyChar == 8 || e.KeyChar == 97 || e.KeyChar == 98 || e.KeyChar == 99
                    || e.KeyChar == 100 || e.KeyChar == 101 || e.KeyChar == 102)
                {
                    e.Handled = false;
                    break;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void thirtyTwoPointRepresenation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void point32Decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 48; i < 58; i++)
            {
                if (e.KeyChar == i || e.KeyChar == 8 || e.KeyChar == 45 || e.KeyChar == 46)
                {
                    e.Handled = false;
                    break;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void point64Decimal_TextChanged(object sender, EventArgs e)
        {
            /*
             * Code from https://stackoverflow.com/questions/21244252/convert-float-to-its-binary-representation-using-memorystream
             * The code uses BitConverter to convert every number into individual bits and store them into an array. Using a nested
             * foreach-for loop, each bit is converted into a binary representation and is appeneded into a string on every execution
             * of the loop.
             */
            if (point64Decimal.Text != "")
            {
                try
                {
                    if (point64Decimal.Text == "-")
                        point64Decimal.Text = "-1";
                    else if (point64Decimal.Text == ".")
                        point64Decimal.Text = ".1";
                    double d = double.Parse(point64Decimal.Text);
                    StringBuilder sb = new StringBuilder();
                    Byte[] ba = BitConverter.GetBytes(d);
                    foreach (Byte b in ba)
                        for (int i = 0; i < 8; i++)
                        {
                            sb.Insert(0, ((b >> i) & 1) == 1 ? "1" : "0");
                        }
                    string s = sb.ToString();
                    string r = s.Substring(0, 1) + " " + s.Substring(1, 8) + " " + s.Substring(9); //sign exponent mantissa
                    sixtyFourPointRepresenation.Text = r;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error: Please make sure the floating point number is in a correct format!"
                        + "Do not have more than one negative signs or decimal points!", "Error");
                }
            }
        }

        private void point64Decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 48; i < 58; i++)
            {
                if (e.KeyChar == i || e.KeyChar == 8 || e.KeyChar == 45 || e.KeyChar == 46)
                {
                    e.Handled = false;
                    break;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void sixtyFourPointRepresenation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void unsignedBinary_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (unsignedBinary.Text != "")
                {
                    if (unsignedDataType.SelectedIndex == 0)
                    {
                        uint a = Convert.ToUInt32(unsignedBinary.Text, 2);
                        unsignedOcta.Text = Convert.ToString(a, 8);
                        unsignedDecimal.Text = Convert.ToString(a, 10);
                        unsignedHex.Text = Convert.ToString(a, 16);
                    }
                    else if (unsignedDataType.SelectedIndex == 1)
                    {
                        UInt64 a = Convert.ToUInt64(unsignedBinary.Text, 2);
                        unsignedOcta.Text = Convert.ToString((long)a, 8);
                        unsignedDecimal.Text = Convert.ToString((long)a, 10);
                        unsignedHex.Text = Convert.ToString((long)a, 16);
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error: Please make sure the binary value is not too big or small!"
                    + " (Limit for 32 bit values: 0 - 4294967295. Limit for 64 bit values: "
                    + "0 - 18446744073709551615. If you are converting close to 18446744073709551615 on 64 bit, "
                    + "the tool may glitch a bit due to your computer converting such a huge number. A lot of "
                    + "switches are turning on and off at a very fast rate... so conversion can succeed sometimes or "
                    + "fail.)", "Error");
            }
        }

        private void unsignedOcta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (unsignedOcta.Text != "")
                {
                    if (unsignedDataType.SelectedIndex == 0)
                    {
                        uint a = Convert.ToUInt32(unsignedOcta.Text, 8);
                        unsignedBinary.Text = Convert.ToString(a, 2);
                        unsignedDecimal.Text = Convert.ToString(a, 10);
                        unsignedHex.Text = Convert.ToString(a, 16);
                    }
                    else if (unsignedDataType.SelectedIndex == 1)
                    {
                        UInt64 a = Convert.ToUInt64(unsignedOcta.Text, 8);
                        unsignedBinary.Text = Convert.ToString((long)a, 2);
                        unsignedDecimal.Text = Convert.ToString((long)a, 10);
                        unsignedHex.Text = Convert.ToString((long)a, 16);
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error: Please makre sure the base 8 (Octa) value is not too big or small!"
                    + " (Limit for 32 bit values: 0 - 4294967295. Limit for 64 bit value: "
                    + "0 - 18446744073709551615. If you are converting close to 18446744073709551615 on 64 bit, "
                    + "the tool may glitch a bit due to your computer converting such a huge number. A lot of "
                    + "switches are turning on and off at a very fast rate... so conversion can succeed sometimes or "
                    + "fail.)", "Error");
            }
        }

        private void unsignedDecimal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (unsignedDecimal.Text != "")
                {
                    if (unsignedDataType.SelectedIndex == 0)
                    {
                        uint a = Convert.ToUInt32(unsignedDecimal.Text, 10);
                        unsignedOcta.Text = Convert.ToString(a, 8);
                        unsignedBinary.Text = Convert.ToString(a, 2);
                        unsignedHex.Text = Convert.ToString(a, 16);
                    }
                    else if (unsignedDataType.SelectedIndex == 1)
                    {
                        ulong a = Convert.ToUInt64(unsignedDecimal.Text, 10);
                        unsignedOcta.Text = Convert.ToString((long) a, 8);
                        unsignedBinary.Text = Convert.ToString((long) a, 2);
                        unsignedHex.Text = Convert.ToString((long) a, 16);
                    }
                }
            }
            catch (Exception except)
            {
                if (except is OverflowException || except is FormatException)
                    MessageBox.Show("Error: Please makre sure the base 10 (Decimal) value is not too big or small!"
                    + " (Limit for 32 bit value: 0 - 4294967295. Limit for 64 bit values: "
                    + "0 - 18446744073709551615. If you are converting close to 18446744073709551615 on 64 bit, "
                    + "the tool may glitch a bit due to your computer converting such a huge number. A lot of "
                    + "switches are turning on and off at a very fast rate... so conversion can succeed sometimes or "
                    + "fail.)", "Error");
            }
        }

        private void unsignedHex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (unsignedHex.Text != "")
                {
                    if (unsignedDataType.SelectedIndex == 0)
                    {
                        uint a = Convert.ToUInt32(unsignedHex.Text, 16);
                        unsignedOcta.Text = Convert.ToString(a, 8);
                        unsignedDecimal.Text = Convert.ToString(a, 10);
                        unsignedBinary.Text = Convert.ToString(a, 2);
                    }
                    else if (unsignedDataType.SelectedIndex == 1)
                    {
                        UInt64 a = Convert.ToUInt64(unsignedHex.Text, 16);
                        unsignedOcta.Text = Convert.ToString((long)a, 8);
                        unsignedDecimal.Text = Convert.ToString((long)a, 10);
                        unsignedBinary.Text = Convert.ToString((long)a, 2);
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error: Please makre sure the base 16 (Hex) value is not too big or small!"
                    + " (Limit for 32 bit values: 0 - 4294967295. Limit for 64 bit values: "
                    + "0 - 18446744073709551615. If you are converting close to 18446744073709551615 on 64 bit, "
                    + "the tool may glitch a bit due to your computer converting such a huge number. A lot of "
                    + "switches are turning on and off at a very fast rate... so conversion can succeed sometimes or "
                    + "fail.)", "Error");
            }
        }

        private void signedDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            binaryBase.Text = "";
            octaBase.Text = "";
            decimalBase.Text = "";
            hexBase.Text = "";
        }

        private void unsignedBinary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 48 || e.KeyChar == 49 || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void unsignedOcta_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 48; i < 56; i++)
            {
                if (e.KeyChar == i || e.KeyChar == 8)
                {
                    e.Handled = false;
                    break;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void unsignedDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 48; i < 58; i++)
            {
                if (e.KeyChar == i || e.KeyChar == 8)
                {
                    e.Handled = false;
                    break;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void unsignedHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 48; i < 58; i++)
            {

                if (e.KeyChar == i || e.KeyChar == 8 || e.KeyChar == 97 || e.KeyChar == 98 || e.KeyChar == 99
                    || e.KeyChar == 100 || e.KeyChar == 101 || e.KeyChar == 102)
                {
                    e.Handled = false;
                    break;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void unsignedDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            unsignedBinary.Text = "";
            unsignedOcta.Text = "";
            unsignedDecimal.Text = "";
            unsignedHex.Text = "";
        }

        private void asciiToHex_Click(object sender, EventArgs e)
        {
            hexI.Text = tohexx(asciiI2.Text);
        }

        private void hexToAscii_Click(object sender, EventArgs e)
        {
            string containhex = hexI.Text.Replace(" ", "");
            hexI.Text = containhex;
            asciiI2.Text = tostringgForHex(hexI.Text);
        }

        public string tohexx(string asciistring)
        {
            string hex = "";
            foreach (char c in asciistring)
            {
                int tmp = c;
                hex += string.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }

            return hex;
        }

        public string tostringgForHex(string hexvalue)
        {
            string strvalue = "";
            while (hexvalue.Length > 0)
            {
                strvalue += System.Convert.ToChar(System.Convert.ToUInt32(hexvalue.Substring(0, 2), 16)).ToString();
                hexvalue = hexvalue.Substring(2, hexvalue.Length - 2);
            }

            return strvalue;
        }

        private void clearHex_Click(object sender, EventArgs e)
        {
            asciiI2.Text = "Hello World!";
            hexI.Text = "48656c6c6f20576f726c6421";
        }


    }
}
