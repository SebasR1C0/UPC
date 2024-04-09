using System;
using System.Collections;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class frmArreglos : Form
    {
        //Array arrayUsuarios = Array.CreateInstance(typeof(Usuarios), 3);
        Array arrayUsuarios;

        //lleva el control de cuantos elementos se van registrando en el arreglo
        int index = 0;

        public frmArreglos()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            //se valida que no se pueda ingresar más usuarios de los definidos
            if (index < nudCantidadUsuarios.Value)
            {   
                /*
                Usuarios user = new Usuarios()
                {
                    Nombres = txtNombres.Text,
                    ApellidoPaterno = txtApePaterno.Text,
                    ApellidoMaterno = txtApeMaterno.Text,
                    DNI = txtDNI.Text,
                    Edad = (int)nudEdad.Value
                };
                */
                
                Usuarios user = new Usuarios();
                user.Nombres = txtNombres.Text.Trim();
                user.ApellidoPaterno = txtApePaterno.Text.Trim();
                user.ApellidoMaterno = txtApeMaterno.Text.Trim();
                user.DNI = txtDNI.Text.Trim();
                user.Edad = (int)nudEdad.Value;
                
                //se inserta el objeto al arreglo
                arrayUsuarios.SetValue(user, index);

                //se actualiza la cantidad de usuarios agregados en el arreglo
                lblCantUsuarios.Text = (index + 1).ToString();
                index++;
            }
            else
            {
                MessageBox.Show("El arreglo ya tiene " + index.ToString() + " usuario(s) registrados.", "Arreglos");
            }
        }

        private void MostrarUsuarios()
        {
            lvUsuarios.Items.Clear();
            for (int i = 0; i < index; i++)
            {
                Usuarios userTemporal = (Usuarios)arrayUsuarios.GetValue(i);

                ListViewItem item = new ListViewItem(userTemporal.Nombres);
                item.SubItems.Add(userTemporal.ApellidoPaterno);
                item.SubItems.Add(userTemporal.ApellidoMaterno);
                item.SubItems.Add(userTemporal.Edad.ToString());
                item.SubItems.Add(userTemporal.DNI);

                lvUsuarios.Items.Add(item);
            }
        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {   
            this.MostrarUsuarios();
        }

        private void btnOrdenarPor_Click(object sender, EventArgs e)
        {

            string compararPor = cbOrdenarPor.Items[cbOrdenarPor.SelectedIndex].ToString();
            string formaOrdenamiento = cbFormaOrdenamiento.Items[cbFormaOrdenamiento.SelectedIndex].ToString();

            IComparer metodoComparacion = new MetodoComparacion(compararPor, formaOrdenamiento);
            
            Array.Sort(arrayUsuarios, metodoComparacion);
            lvUsuarios.Items.Clear();
            this.MostrarUsuarios();
        }

        private void frmArreglos_Load(object sender, EventArgs e)
        {
            cbOrdenarPor.SelectedIndex = 0;
            cbFormaOrdenamiento.SelectedIndex = 0;
            btnAgregarUsuario.Enabled = false;
            txtDNI.MaxLength = 8;
        }

        private void btnDefinirCantidadUsuarios_Click(object sender, EventArgs e)
        {
            //arrayUsuarios = Array.CreateInstance(typeof(Usuarios), Convert.ToInt32(nudCantidadUsuarios.Value));
            //arrayUsuarios = Array.CreateInstance(typeof(Usuarios), (int)nudCantidadUsuarios.Value);

            arrayUsuarios = Array.CreateInstance(typeof(Usuarios), Convert.ToInt32(nudCantidadUsuarios.Value));

            lblMensaje.Text = "Cantidad de usuarios a registrar definido";
            btnDefinirCantidadUsuarios.Enabled = false;
            nudCantidadUsuarios.Enabled = false;
            btnAgregarUsuario.Enabled = true;
            
            //MessageBox.Show(arrayUsuarios.GetLength(0).ToString(), "Arreglos");
        }

        private bool criterioBusqueda(Usuarios user)
        {
            return user.Nombres.Equals(txtValorBusqueda.Text.Trim());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Usuarios[] resultado = Array.FindAll((Usuarios[])arrayUsuarios, p => p.Nombres.Equals(txtValorBusqueda.Text.Trim()));
            Usuarios[] resultado = Array.FindAll((Usuarios[])arrayUsuarios, criterioBusqueda);

            //Usuarios[] resultado = Array.FindAll((Usuarios[])arrayUsuarios, criterioBusqueda);
            //Usuarios[] resultado = Array.FindAll((Usuarios[])arrayUsuarios, u => u.Nombres.Equals(txtValorBusqueda.Text));
            //Usuarios[] resultado = Array.FindAll((Usuarios[])arrayUsuarios, u => u.DNI.Equals(txtValorBusqueda.Text));

            lvResultado.Items.Clear();
            for (int i = resultado.GetLowerBound(0); i <= resultado.GetUpperBound(0); i++)
            {
                Usuarios user = (Usuarios)resultado.GetValue(i);
                ListViewItem item = new ListViewItem(user.Nombres);
                item.SubItems.Add(user.ApellidoPaterno);
                item.SubItems.Add(user.ApellidoMaterno);
                item.SubItems.Add(user.Edad.ToString());
                item.SubItems.Add(user.DNI);

                lvResultado.Items.Add(item);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Array.Clear(arrayUsuarios, 0, arrayUsuarios.Length - 1);
            Array.Clear(arrayUsuarios, 0, arrayUsuarios.Length);
            
            index = 0;
        }
    }

    public class MetodoComparacion : IComparer
    {
        private string compararPor;
        private string formaOrdenamiento;
        public MetodoComparacion(string compararPor, string formaOrdenamiento)
        {
            this.compararPor = compararPor;
            this.formaOrdenamiento = formaOrdenamiento;
        }

        int IComparer.Compare(object x, object y)
        {
            if (this.compararPor == "Edad")
            {
                int result = 0;

                if (x != null && y != null)
                {
                    //if (((Usuarios)(x)).Edad == ((Usuarios)(y)).Edad)
                    if ((x as Usuarios).Edad == (y as Usuarios).Edad)
                    {
                        result = 0;
                    }


                    if (formaOrdenamiento.Equals("Ascendente"))
                    {
                        if ((x as Usuarios).Edad > (y as Usuarios).Edad)
                        {
                            result = 1;
                        }
                        else
                        {
                            result = -1;
                        }
                    }
                    else
                    {
                        if ((x as Usuarios).Edad < (y as Usuarios).Edad)
                        {
                            result = 1;
                        }
                        else
                        {
                            result = -1;
                        }
                    }


                }

                return result;

            }

            if (this.compararPor == "DNI")
            {
                int result = 0;

                if (x != null && y != null)
                {
                    if (Int32.Parse((x as Usuarios).DNI) == Int32.Parse((y as Usuarios).DNI))
                    {
                        result = 0;
                    }


                    if (formaOrdenamiento.Equals("Ascendente"))
                    {
                        if (Int32.Parse((x as Usuarios).DNI) > Int32.Parse((y as Usuarios).DNI))
                        {
                            result = 1;
                        }
                        else
                        {
                            result = -1;
                        }
                    }
                    else
                    {
                        if (Int32.Parse((x as Usuarios).DNI) < Int32.Parse((y as Usuarios).DNI))
                        {
                            result = 1;
                        }
                        else
                        {
                            result = -1;
                        }
                    }
                }

                return result;

            }

            return 0;

        }
    }
}
