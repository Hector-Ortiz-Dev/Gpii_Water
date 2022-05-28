using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gpi_Water.Conexion
{
    public class Valid
    {
        #region Eventos keypress
        public void AlfaNum(KeyPressEventArgs e) //No Espacios, no simbolos, no minusculas
        {
            if (Char.IsLetter(e.KeyChar) && Char.IsUpper(e.KeyChar))
                e.Handled = false;
            else if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void Letras(KeyPressEventArgs e) //Solo letras
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void Num(KeyPressEventArgs e) //No letras, no espacios, no simbolos
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void NumF(KeyPressEventArgs e) //No letras, no espacios, no simbolos Numeros float
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == '.')
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void LetNum(KeyPressEventArgs e) //Letras, numeros, no espacios
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        #endregion

        #region Validaciones booleanas
        public static bool flotante(ErrorProvider error, RJCodeAdvance.RJControls.RJTextBox textBox)
        {
            if (textBox.Texts == "")
            {
                error.SetError(textBox, "Campo requerido");
                return true;
            }
            else if (!double.TryParse(textBox.Texts, out var parsedNumber))
            {
                error.SetError(textBox, "No es un formato valido");
                return true;
            }

            error.SetError(textBox, "");
            return false;
        }

        public static bool mayorEdad(ErrorProvider error, RJCodeAdvance.RJControls.RJDatePicker timePicker)
        {
            var date = DateTime.Now;
            int año = date.Year; //Año actual
            int añoNac = timePicker.Value.Year; //Año registrado
            int mayorEdad = año - añoNac; //obtiene la edad 
            if (mayorEdad < 18) //Verifica si tiene 18
            {
                error.SetError(timePicker, "Solo se acepta usuarios mayores de edad");
                return true;
            }
            error.SetError(timePicker, "");
            return false;
        }

        public static bool UsuarioEmpleado(ErrorProvider error, RJCodeAdvance.RJControls.RJTextBox nick)
        {
            List<string> nicks = Empleado.get_usuarios();

            if (nick.Texts == "")
            {
                error.SetError(nick, "Este campo esta vacio");
                return true;
            }
            else if (nicks.Contains(nick.Texts))
            {
                error.SetError(nick, "El nick ya existe, intente mas tarde");
                return true;
            }
            error.SetError(nick, "");
            return false;
        }

        public static bool UsuarioCliente(ErrorProvider error, RJCodeAdvance.RJControls.RJTextBox nick)
        {
            List<string> nicks = Cliente.get_usuarios();

            if (nick.Texts == "")
            {
                error.SetError(nick, "Este campo esta vacio");
                return true;
            }
            else if (nicks.Contains(nick.Texts))
            {
                error.SetError(nick, "El nick ya existe, intente mas tarde");
                return true;
            }
            error.SetError(nick, "");
            return false;
        }

        public static bool CurpCliente(ErrorProvider error, RJCodeAdvance.RJControls.RJTextBox curp)
        {
            List<string> curps = Cliente.get_curps();

            if (curp.Texts == "")
            {
                error.SetError(curp, "Este campo esta vacio");
                return true;
            }
            else if (curp.Texts.Length != 18)
            {
                error.SetError(curp, "El tamaño de caracteres debe ser de 18");
                return true;
            }
            else if (curps.Contains(curp.Texts))
            {
                error.SetError(curp, "El curp ya se encuentra registrado");
                return true;
            }
            error.SetError(curp, "");
            return false;
        }

        public static bool RfcCliente(ErrorProvider error, RJCodeAdvance.RJControls.RJTextBox rfc)
        {
            List<string> rfcs = Cliente.get_rfcs();

            if (rfc.Texts == "")
            {
                error.SetError(rfc, "Este campo esta vacio");
                return true;
            }
            else if (rfc.Texts.Length != 13)
            {
                error.SetError(rfc, "El tamaño de caracteres debe ser de 13");
                return true;
            }
            else if (rfcs.Contains(rfc.Texts))
            {
                error.SetError(rfc, "El rfc ya se encuentra registrado");
                return true;
            }
            error.SetError(rfc, "");
            return false;
        }

        public static bool ModCurpCliente(ErrorProvider error, RJCodeAdvance.RJControls.RJTextBox curp)
        {
            if (curp.Texts == "")
            {
                error.SetError(curp, "Este campo esta vacio");
                return true;
            }
            else if (curp.Texts.Length != 18)
            {
                error.SetError(curp, "El tamaño de caracteres debe ser de 18");
                return true;
            }
            error.SetError(curp, "");
            return false;
        }

        public static bool ModRfcCliente(ErrorProvider error, RJCodeAdvance.RJControls.RJTextBox rfc)
        {
            if (rfc.Texts == "")
            {
                error.SetError(rfc, "Este campo esta vacio");
                return true;
            }
            else if (rfc.Texts.Length != 13)
            {
                error.SetError(rfc, "El tamaño de caracteres debe ser de 13");
                return true;
            }
            error.SetError(rfc, "");
            return false;
        }

        public static bool nombre(ErrorProvider error, RJCodeAdvance.RJControls.RJTextBox nombre)
        {
            if (nombre.Texts == "")
            {
                error.SetError(nombre, "Este campo esta vacio");
                return true;
            }
            error.SetError(nombre, "");
            return false;
        }

        public static bool celdasLlenas(DataGridView dgv, int indexDgv)
        {
            for (int j = 0; j < dgv.ColumnCount; j++)
            {
                if (dgv.Rows[indexDgv].Cells[j].Value == DBNull.Value)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool cellCurpRfc(DataGridView dgv, int indexDgv)
        {
            if (dgv.Rows[indexDgv].Cells["curp"].Value.ToString().Length != 18 ||
                dgv.Rows[indexDgv].Cells["rfc"].Value.ToString().Length != 13)
            {
                return false;
            }
            return true;
        }

        public static bool cellCurpDate(DataGridView dgv, int indexDgv)
        {
            if (dgv.Rows[indexDgv].Cells["curp"].Value.ToString().Length != 18 ||
                dgv.Rows[indexDgv].Cells["f_nac"].Value.ToString().Length != 10)
            {
                return false;
            }
            return true;
        }

        public static bool email(ErrorProvider error, RJCodeAdvance.RJControls.RJTextBox email)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email.Texts, sFormato))
            {
                if (Regex.Replace(email.Texts, sFormato, String.Empty).Length == 0)
                {
                    error.SetError(email, "");
                    return false;
                }
                else
                {
                    error.SetError(email, "Correo incorrecto");
                    return true;
                }
            }
            error.SetError(email, "Correo incorrecto");
            return true;
        }

        public static bool ComboValid(ErrorProvider error, RJCodeAdvance.RJControls.RJComboBox combo)
        {
            if (combo.Texts == "")
            {
                error.SetError(combo, "Este campo esta vacio");
                return true;
            }
            error.SetError(combo, "");
            return false;
        }
        #endregion
    }
}
