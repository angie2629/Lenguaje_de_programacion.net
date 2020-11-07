using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CRUD
{
    class Validar_Cajas
    {
//--------------------------------------------- METODOS DE VALIDACION----------------------------------------- 

            //  validar si es vacio ------------------------------------------------------
            public Boolean Vacio(TextBox caja, ErrorProvider error, string mensajeError)
            {
                if (caja.Text == "")
                {
                    error.SetError(caja, mensajeError);
                    caja.Focus();
                    return true;
                }
                else
                {
                    error.Clear();
                    return false;
                }
            }
           //------------------------------------------------------------------------------

//--------------------------------------------- METODOS DE VALIDACION----------------------------------------- 

        // validar que sea tipo texto -----------------------------------------------------
        public Boolean TipoTexto(TextBox caja, ErrorProvider error, string mensajeError)
            {
                 // instanciamos clase regex y se crea objeto para asignar expresion o regla a cumplir
                 Regex formato = new Regex("^[a-zA-Z ]*$"); 

                if (!formato.IsMatch(caja.Text))

                {
                    error.SetError(caja, mensajeError);
                    caja.Focus();
                    return false;
                }
                else
                {
                    error.Clear();
                    return true;
                }

            }
        //-----------------------------------------------------------------------------------

//--------------------------------------------- METODOS DE VALIDACION----------------------------------------- 

        // validar que sea tipo numero ------------------------------------------------------
        public Boolean TipoNumero(TextBox caja, ErrorProvider error, string mensajeError)
            {
                Regex formato = new Regex("[0-9]{1,9}(\\.[0-9]{0,2})?$");
                if (formato.IsMatch(caja.Text))

                {
                    error.Clear();
                    return true;
                }
                else
                {
                    error.SetError(caja, mensajeError);
                    caja.Focus();
                    return false;
                }

            }
        //------------------------------------------------------------------------------------

//--------------------------------------------- METODOS DE VALIDACION----------------------------------------- 

        // validar que sea tipo correo ------------------------------------------------------- 
        public Boolean TipoCorreo(TextBox caja, ErrorProvider error, string mensajeError)
            {
                Regex formato = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
                if (!formato.IsMatch(caja.Text))

                {
                    error.SetError(caja, mensajeError);
                    caja.Focus();
                    return false;
                }
                else
                {
                    error.Clear();
                    return true;
                }
            }
        //-----------------------------------------------------------------------------------
        }
    }
