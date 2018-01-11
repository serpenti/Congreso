using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Congreso_Final
{
    public static class Validacion
    {
        public static void validarEnteroPos(KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)) || (e.KeyChar == 8) || (e.KeyChar == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public static void validarDouble(KeyPressEventArgs e, TextBox textbox)
        {
            if (((Char.IsNumber(e.KeyChar)) && !((textbox.SelectionStart == 0) && (textbox.Text.Contains("-")))) || (e.KeyChar == 8) || (e.KeyChar == 13) || ((e.KeyChar == 45) && ((textbox.SelectionStart == 0) && (!textbox.Text.Contains("-")))) || ((e.KeyChar == 46) && !(((textbox.SelectionStart == 0) && (textbox.Text.Contains("-"))) || (textbox.Text.Contains(".")))))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public static void validarLetra(KeyPressEventArgs e, TextBox textbox)
        {
            if ((Char.IsLetter(e.KeyChar)) || (e.KeyChar == 8) || (e.KeyChar == 13) || ((e.KeyChar == 32) && !(textbox.SelectionStart == 0)))
            {
                if ((textbox.Text.Length == 0) || (textbox.Text.Last() == ' '))
                    e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
                else if (textbox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public static void validarLetra2(KeyPressEventArgs e, TextBox textbox)
        {
            if ((Char.IsLetter(e.KeyChar)) || (e.KeyChar == 8) || (e.KeyChar == 13) || (e.KeyChar == 44) || (e.KeyChar == 46) || ((e.KeyChar == 32) && !(textbox.SelectionStart == 0)))
            {
                if (textbox.Text.Length == 0)
                    e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
                else if (textbox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public static void validarDireccion(KeyPressEventArgs e, TextBox textbox)
        {
            if ((Char.IsNumber(e.KeyChar)) || (Char.IsLetter(e.KeyChar)) || (e.KeyChar == 8) || (e.KeyChar == 13) || ((e.KeyChar == 32) && !(textbox.SelectionStart == 0)) || ((e.KeyChar == 44) && !(textbox.SelectionStart == 0)) || ((e.KeyChar == 46) && !(textbox.SelectionStart == 0)))
            {
                if ((textbox.Text.Length == 0) || (textbox.Text.Last() == ' '))
                    e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
                else if (textbox.Text.Length > 0)
                    e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public static void validarCorreo(KeyPressEventArgs e, TextBox textbox)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsNumber(e.KeyChar)) || (e.KeyChar == 8) || ((e.KeyChar == 46) && (textbox.SelectionStart > 0)) || ((e.KeyChar == 64) && (textbox.SelectionStart > 0)) || ((e.KeyChar == 95) && (textbox.SelectionStart > 0)))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public static void validarRFC(KeyPressEventArgs e, TextBox textbox)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))
            {
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public static void validarUserCon(KeyPressEventArgs e, TextBox textbox)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public static void validarTelefono(KeyPressEventArgs e, TextBox textbox)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
