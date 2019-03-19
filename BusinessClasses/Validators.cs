using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessClasses
{
    // a class for having different validator methods
    public static class Validators
    {
        // check if the data is provided by the user or not
        public static bool IsProvided(Control ctr)
        {
            bool result = true;
            if (ctr.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox txb = (TextBox)ctr;
                if (txb.Text == "")
                {
                    result = false;
                    MessageBox.Show(txb.Tag + " should be provided.", "Entry Error");
                    txb.Focus();
                    return result;
                }
            }
            else if (ctr.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox cmb = (ComboBox)ctr;
                if (cmb.SelectedIndex == -1)
                {
                    result = false;
                    MessageBox.Show(cmb.Tag + " should be provided.", "Entry Error");
                    cmb.Focus();
                    return result;
                }
            }
            return result;
        }


        // check if the data is a decimal number
        public static bool IsDecimal(TextBox txt)
        {
            bool result = true;
            try
            {
                Convert.ToDecimal(txt.Text);
                return result;
            }
            catch (FormatException)
            {
                result = false;
                MessageBox.Show("The value for " + txt.Tag + " should be a decimal number.", "Enrty Error");
                txt.Focus();
                return result;
            }
        }


        // check if the data is an integer number
        public static bool IsInteger(TextBox txt)
        {
            bool result = true;
            try
            {
                Convert.ToInt32(txt.Text);
                return result;
            }
            catch (FormatException)
            {
                result = false;
                MessageBox.Show("The value for " + txt.Tag + " should be an integer number.", "Enrty Error");
                txt.Focus();
                return result;
            }
        }


        // check if the data is in a specific range
        public static bool IsWithinRange(DateTimePicker dtp, DateTime min, DateTime max)
        {
            bool accept = true;

            DateTime time = Convert.ToDateTime(dtp.Value);

            TimeSpan tsMin = time.Subtract(min);
            int minDays = tsMin.Days;

            TimeSpan tsMax = time.Subtract(max);
            int maxDays = tsMax.Days;

            if (minDays < 0)
            {
                MessageBox.Show("The shipped date should be after than the order date.");
                accept = false;
                dtp.Focus();
            }
                
            if (maxDays > 0)
            {
                MessageBox.Show("The shipped date should be before the required date.");
                accept = false;
                dtp.Focus();
            }
            return accept;
        }
    }
}
