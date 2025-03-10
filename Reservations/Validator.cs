using System;
using System.Windows.Forms;

namespace GenericValidation
{
    public static class Validator
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        /// <summary>
        /// This Method() checks for null user input.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>A MessageBox containing meaningful instructions.</returns>
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            else return true;
        }
        /// <summary>
        /// This Method() checks for a decimal point within the textbox.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>A MessageBox containing meaningful instructions.</returns>
        public static bool ContainsDotSymbol(TextBox textBox)
        {
            if (textBox.Text.Contains("."))
            { return true; }
            else
            {
                MessageBox.Show(textBox.Tag + " must contain '.'.\n" +
                    "(ie. #.##)", Title);
                textBox.Focus();
                return false;
            }
        }
        /// <summary>
        /// This Method() checks for a decimal point within the textbox.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>A MessageBox containing meaningful instructions.</returns>
        public static bool ContainsAtSymbol(TextBox textBox)
        {
            if (textBox.Text.Contains("@"))
            { return true; }
            else
            {
                MessageBox.Show(textBox.Tag + " must be contain '@'.\n" +
                    "(ie. #.##)", Title);
                textBox.Focus();
                return false;
            }
        }
        /// <summary>
        /// This Method() uses TryParse to determine if the user input is a valid Integer. 
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>A MessageBox containing meaningful instructions.</returns>
        public static bool IsInt32(TextBox textBox)
        {
            if (Int32.TryParse(textBox.Text, out _))
            { return true; }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }
        /// <summary>
        /// This Method() uses TryParse to determine if the user input is a valid Decimal.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>A MessageBox containing meaningful instructions.</returns>
        public static bool IsDecimal(TextBox textBox)
        {
            if (Decimal.TryParse(textBox.Text, out _))
            { return true; }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }
        /// <summary>
        /// This Method() uses TryParse to determine if the user input is a valid Float.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>A MessageBox containing meaningful instructions.</returns>
        public static bool IsFloat(TextBox textBox)
        {
            if (float.TryParse(textBox.Text, out _))
            { return true; }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a float value.", Title);
                textBox.Focus();
                return false;
            }
        }
        /// <summary>
        /// This Method() uses TryParse to determine if the user input is a valid Double.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>A MessageBox containing meaningful instructions.</returns>
        public static bool IsDouble(TextBox textBox)
        {
            if (Double.TryParse(textBox.Text, out _))
                return true;
            else
            {
                MessageBox.Show(textBox.Tag + " must be a valid double value.", Title);
                textBox.Focus();
                return false;
            }
        }
        /// <summary>
        /// This Method() uses TryParse to determine if the user input is a valid DateTime.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>A MessageBox containing meaningful instructions.</returns>
        public static bool IsDateTime(TextBox textBox)
        {
            if (DateTime.TryParse(textBox.Text, out _))
            { return true; }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a valid date time value.", Title);
                textBox.Focus();
                return false;
            }
        }
        /// <summary>
        /// This Method() constrains user input within a specified range.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>A MessageBox containing meaningful instructions.</returns>
        public static bool IsInt32WithinRange(TextBox textBox, int min, int max)
        {
            int number = Convert.ToInt32(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// This Method() constrains user input within a specified range.
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>A MessageBox containing meaningful instructions.</returns>
        public static bool IsDecimalWithinRange(TextBox textBox, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// This Method() constrains user input within a specified range.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>A MessageBox containing meaningful instructions.</returns>
        public static bool IsIntFloatRange(TextBox textBox, float min, float max)
        {
            float number;
            float.TryParse(textBox.Text, out number);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// This Method() constrains user input within a specified range.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>A MessageBox containing meaningful instructions.</returns>
        public static bool IsDoubleWithinRange(TextBox textBox, double min, double max)
        {
            double number = Convert.ToDouble(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// This Method() constrains user input within a specified range.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>A MessageBox containing meaningful instructions.</returns>
        public static bool IsShortDateTimeWithinRange(TextBox textBox, DateTime min, DateTime max)
        {
            if (Convert.ToDateTime(textBox.Text) >= min && Convert.ToDateTime(textBox.Text) <= max)
            { return true; }
            else
            {
                MessageBox.Show(textBox.Tag + $" value must fall between \n" +
                    $"{min.ToShortDateString()} and {max.ToShortDateString()}.", Title);
                textBox.Focus();
                return false;
            }
        }
    }
}
