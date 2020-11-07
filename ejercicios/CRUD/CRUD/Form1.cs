using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;//Manejo de archivos 
using System.IO; // Escritura lectura 

namespace CRUD
{
    public partial class Form1 : Form
    {

        // Declarar objetos ------------------------------------------------------- 
        //ArrayList listaAlumnos = new ArrayList();

        // creado el objeto listaAlumnos --> array --------------------------------
        List<Alumno> listaAlumnos = new List<Alumno>();

        //creo un objeto de validacion intanciando la clase Validar_Cajas----------
        Validar_Cajas validacion = new Validar_Cajas(); 

        
        public Form1()
        //-------------------------------------------------------------------------------------------------------------------
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------------------------------------------------

        
        private void Form1_Load(object sender, EventArgs e)
        //-------------------------------------------------------------------------------------------------------------------
        {
            // cuando se abra lea el archivo y lo muestre 
            // cargar  los datos del xml
            // generar una lista con esos datos
            // mostrar esa lista en el DG

            listaAlumnos.Clear();

            if (File.Exists("C:/net/listaAlumnos.xml"))
            {

                XmlSerializer codigicador = new XmlSerializer(typeof(List<Alumno>));
                FileStream leerXml = File.OpenRead("C:/net/listaAlumnos.xml");
                listaAlumnos = (List<Alumno>)codigicador.Deserialize(leerXml);
                leerXml.Close();
            }
            dgresultados.DataSource = null;
            dgresultados.DataSource = listaAlumnos;
        }
        //-------------------------------------------------------------------------------------------------------------------

        
        private void btnagregar_Click(object sender, EventArgs e)
        //-------------------------------------------------------------------------------------------------------------------
        {
            //Codigo para agregar un alumno y validar-------------------------------
            if (!validacion.Vacio(txtcodigo, ErrorProvider, "El codigo no puede ser vacio"))
                if (validacion.TipoNumero(txtcodigo, ErrorProvider, "El Codigo en numerico"))
                    if (!validacion.Vacio(txtnombre, ErrorProvider, "El nombre no puede ser vacio"))
                        if (validacion.TipoTexto(txtnombre, ErrorProvider, "Debe digitar texto"))
                            if (!validacion.Vacio(txtcorreo, ErrorProvider, "El correo  no puede ser vacio"))
                                if (validacion.TipoCorreo(txtcorreo, ErrorProvider, "El correo no  cumple con el formato"))
                                    if (!validacion.Vacio(txtnota1, ErrorProvider, "La nota no puede ser vacio"))
                                        if (validacion.TipoNumero(txtnota1, ErrorProvider, "Debe ser Numerico"))
                                            if (!validacion.Vacio(txtnota2, ErrorProvider, "La nota no puede ser vacio"))
                                                if (validacion.TipoNumero(txtnota2, ErrorProvider, "Debe ser Numerico"))
                                                    if (!validacion.Vacio(txtnota3, ErrorProvider, "La nota no puede ser vacio"))
                                                        if (validacion.TipoNumero(txtnota3, ErrorProvider, "Debe ser Numerico"))
                                                            if (!validacion.Vacio(txtnota4, ErrorProvider, "La nota no puede ser vacio"))
                                                                if (validacion.TipoNumero(txtnota4, ErrorProvider, "Debe ser Numerico"))
                                                                {
                                                                    if (!ExisteCodigo(Convert.ToInt32(txtcodigo.Text)))
                                                                    {
                                                                        insertarDatos();
                                                                        LimpiarCajar();
                                                                        ErrorProvider.Clear();
                                                                    }
                                                                    else
                                                                    {
                                                                        ErrorProvider.SetError(txtcodigo, "El Codigo ya existe");
                                                                        txtcodigo.Focus();
                                                                        return;
                                                                    }

                                                                }
         }
        //-------------------------------------------------------------------------------------------------------------------
 
        private void btnguardar_Click(object sender, EventArgs e)
        //-------------------------------------------------------------------------------------------------------------------
        {
            //Boton guardar XML en el MENU---------------------------------------------
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("E:/net/listaAlumnos.xml");
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
        
        }
        //-------------------------------------------------------------------------------------------------------------------

        private void btnsubir_informacion_Click(object sender, EventArgs e)
        //-------------------------------------------------------------------------------------------------------------------
        {
            // cargar  los datos del xml ----------------------------------------
            // generar una lista con esos datos ---------------------------------
            // mostrar esa lista en el DG ---------------------------------------

            listaAlumnos.Clear();
            XmlSerializer codigicador = new XmlSerializer(typeof(List<Alumno>));
            FileStream leerXml = File.OpenRead("E:/net/listaAlumnos.xml");
            listaAlumnos = (List<Alumno>)codigicador.Deserialize(leerXml);
            leerXml.Close();

            dgresultados.DataSource = null;
            dgresultados.DataSource = listaAlumnos;

        }
        //-------------------------------------------------------------------------------------------------------------------
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // evento cerrar formulario 
        {
            //---------------------------------------------------------------------------------------------------------------
            // cuando se cierra se guarde la informacion 
            // crear nuestro archivo xml ....
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("E:/net/listaAlumnos.xml");
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
        }
        //-------------------------------------------------------------------------------------------------------------------

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //-------------------------------------------------------------------------------------------------------------------
            // Borrar Datos del  Estudiante 

            DialogResult confirmarBorrar = MessageBox.Show("Esta seguro de borrar", "Confirmar Borrada",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (confirmarBorrar == DialogResult.OK)
            {
                Alumno myAlumno = obtenerDatos(Convert.ToInt32(txtcodigo.Text));
                listaAlumnos.Remove(myAlumno);

                dgresultados.DataSource = null;
                dgresultados.DataSource = listaAlumnos;

                // activar los botones

                btneditar.Enabled = false;
                btneliminar.Enabled = false;
                txtcodigo.Enabled = true;
                LimpiarCajar();
            }
        }
        //-------------------------------------------------------------------------------------------------------------------


        private void btnbuscar_Click(object sender, EventArgs e)
        {
         //-------------------------------------------------------------------------------------------------------------------
            // vamos a buscar a un alumno por el codigo ------------------------------------------
            // valido que no este vacia ---------------------------------------------------------

            if (!validacion.Vacio(txtcodigo, ErrorProvider, "Para buscar debe haber un codigo"))
                if (validacion.TipoNumero(txtcodigo, ErrorProvider, "El Codigo es numerico"))
                {
                    // validar que existe
                    if (ExisteCodigo(Convert.ToInt32(txtcodigo.Text)))
                    {
                        Alumno myAlumno = obtenerDatos(Convert.ToInt32(txtcodigo.Text));
                        txtnombre.Text = myAlumno.Nombre;
                        txtcorreo.Text = myAlumno.Correo;
                        txtnota1.Text = myAlumno.Nota1.ToString();
                        txtnota2.Text = myAlumno.Nota2.ToString();
                        txtnota3.Text = myAlumno.Nota3.ToString();
                        txtnota4.Text = myAlumno.Nota4.ToString();

                        // activar los botones

                        btneditar.Enabled = true;
                        btneliminar.Enabled = true;
                        txtcodigo.Enabled = false;

                    }
                    else
                    {
                        ErrorProvider.SetError(txtcodigo, "El Codigo no existe en la lineas");
                        txtcodigo.Focus();
                        LimpiarCajar2();
                        return;


                    }
                }

        }
        //-------------------------------------------------------------------------------------------------------------------

        private void btnsalir_Click(object sender, EventArgs e)
        {
        //-------------------------------------------------------------------------------------------------------------------
            Application.Exit();
        }
        //-------------------------------------------------------------------------------------------------------------------

        private void btneditar_Click(object sender, EventArgs e)
        {
            //-------------------------------------------------------------------------------------------------------------------

            // Editar Datos  y hace las validaciones
           
            if (!validacion.Vacio(txtnombre, ErrorProvider, "El nombre no puede ser vacio"))
                if (validacion.TipoTexto(txtnombre, ErrorProvider, "Debe digitar texto"))
                    if (!validacion.Vacio(txtcorreo, ErrorProvider, "El correo  no puede ser vacio"))
                        if (validacion.TipoCorreo(txtcorreo, ErrorProvider, "El correo no  cumple con el formato"))
                            if (!validacion.Vacio(txtnota1, ErrorProvider, "La nota no puede ser vacio"))
                                if (validacion.TipoNumero(txtnota1, ErrorProvider, "Debe ser Numerico"))
                                    if (!validacion.Vacio(txtnota2, ErrorProvider, "La nota no puede ser vacio"))
                                        if (validacion.TipoNumero(txtnota2, ErrorProvider, "Debe ser Numerico"))
                                            if (!validacion.Vacio(txtnota3, ErrorProvider, "La nota no puede ser vacio"))
                                                if (validacion.TipoNumero(txtnota3, ErrorProvider, "Debe ser Numerico"))
                                                    if (!validacion.Vacio(txtnota4, ErrorProvider, "La nota no puede ser vacio"))
                                                        if (validacion.TipoNumero(txtnota4, ErrorProvider, "Debe ser Numerico"))
                                                            guardarCambios();



        }
        //-------------------------------------------------------------------------------------------------------------------

        private void LimpiarCajar()
        {
        //-------------------------------------------------------------------------------------------------------------------
            //Metodos-----------------
            txtcodigo.Clear();
            txtnombre.Clear();
            txtcorreo.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtnota4.Clear();

            txtcodigo.Focus();
        }
        //-------------------------------------------------------------------------------------------------------------------

        private void LimpiarCajar2()
        {
            //-------------------------------------------------------------------------------------------------------------------
            //Metodos-----------------
            txtcodigo.Clear();
            txtnombre.Clear();
            txtcorreo.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtnota4.Clear();

            txtcodigo.Focus();
        }
        //-------------------------------------------------------------------------------------------------------------------

        private void verArreglo()
        {
        //-------------------------------------------------------------------------------------------------------------------
            // Metodo o funcion para ver el array en consola

            foreach (Alumno itemAlumno in listaAlumnos)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine(itemAlumno.Codigo);
                Console.WriteLine(itemAlumno.Nombre);
                Console.WriteLine(itemAlumno.Codigo);
                Console.WriteLine(itemAlumno.Nota1);
                Console.WriteLine(itemAlumno.Nota2);
                Console.WriteLine(itemAlumno.Nota3);
                Console.WriteLine(itemAlumno.Nota4);
                Console.WriteLine(itemAlumno.NotaFinal);
                Console.WriteLine(itemAlumno.NotaConcepto);
                Console.WriteLine("----------------------");
            }
        }
        //-------------------------------------------------------------------------------------------------------------------

        private void insertarDatos()
        {
            //-------------------------------------------------------------------------------------------------------------------

            // --------------------------------- AGREGAR UN ALUMNO -----------------------------------------------------------
            //  creamos un objeto Alumno y a sus propiedades les asignamos los valores de las cajas de texto
            //  agregemos este objeto a la lista
            // visualizamos la lista el el grid 

            // instancio la clase Alumno y creo el objeto objetoAlumno 
            Alumno objetoAlumno = new Alumno();  

            // Desde los elemementos del formulario creo el alumno nuevo----------------------------------
            objetoAlumno.Codigo = Convert.ToInt32(txtcodigo.Text);
            objetoAlumno.Nombre = txtnombre.Text;
            objetoAlumno.Correo = txtcorreo.Text;
            objetoAlumno.Nota1 = Convert.ToDouble(txtnota1.Text);
            objetoAlumno.Nota2 = Convert.ToDouble(txtnota2.Text);
            objetoAlumno.Nota3 = Convert.ToDouble(txtnota3.Text);
            objetoAlumno.Nota4 = Convert.ToDouble(txtnota4.Text);

            //Calculamos el resto ------------------------------------------------------------------------
            objetoAlumno.NotaFinal = (objetoAlumno.Nota1 + objetoAlumno.Nota2 + objetoAlumno.Nota3 + objetoAlumno.Nota4) / 4;
            if (objetoAlumno.NotaFinal >= 3.5)
            {
                objetoAlumno.NotaConcepto = "Aprobado";
            }
            else
            {
                objetoAlumno.NotaConcepto = "Reprobado";
            }
            //---------------------------------------------------------------------------------------------

            // Agrego el objeto alumno al arreglo ---------------------------------------------------------
            listaAlumnos.Add(objetoAlumno);

            // Alimento el DataGrid o visualizo en DG el arreglo ------------------------------------------
            dgresultados.DataSource = null;
            dgresultados.DataSource = listaAlumnos;

        }
        //-------------------------------------------------------------------------------------------------------------------

        private Boolean ExisteCodigo(int codigo)
        {
        //-------------------------------------------------------------------------------------------------------------------
            // validar que el nuevo codigo no exista en la lista ---------------------------------
            // retornar un false o true ----------------------------------------------------------

            foreach (Alumno myAlumno in listaAlumnos)
            {
                if (myAlumno.Codigo == codigo)
                    return true;
            }
            return false;
        }
        // traemos el objeto de un alumno ---------------------------------------------------------
        // Retorna un aobjeto alumnos de la lista con el codigo de la caja de texto ---------------
        private Alumno obtenerDatos(int codigo)
        {
            foreach (Alumno myAlumno in listaAlumnos)
            {
                if (myAlumno.Codigo == codigo)
                    return myAlumno;
            }
            return null;
        }
        //-------------------------------------------------------------------------------------------------------------------

        private void guardarCambios()
        {
        //-------------------------------------------------------------------------------------------------------------------
            // Metodo crea un objeto alumno con el " con el codigo que esta en  caja texto "
            // como el objeto es de la lista actualiza los valores 
            Alumno myAlumno = obtenerDatos(Convert.ToInt32(txtcodigo.Text));
            myAlumno.Nombre = txtnombre.Text;
            myAlumno.Correo = txtcorreo.Text;
            myAlumno.Nota1 = Convert.ToDouble(txtnota1.Text);
            myAlumno.Nota2 = Convert.ToDouble(txtnota2.Text);
            myAlumno.Nota3 = Convert.ToDouble(txtnota3.Text);
            myAlumno.Nota4 = Convert.ToDouble(txtnota4.Text);
            //----------------------------------- calculamos el resto 
            myAlumno.NotaFinal = (myAlumno.Nota1 + myAlumno.Nota2 + myAlumno.Nota3 + myAlumno.Nota4) / 4;
            if (myAlumno.NotaFinal >= 3.5)
            {
                myAlumno.NotaConcepto = "Aprobado";
            }
            else
            {
                myAlumno.NotaConcepto = "Reprobado";
            }

            dgresultados.DataSource = null;
            dgresultados.DataSource = listaAlumnos;

            // activar los botones

            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            txtcodigo.Enabled = true;
            LimpiarCajar();
        }
        //-------------------------------------------------------------------------------------------------------------------
    }
}
