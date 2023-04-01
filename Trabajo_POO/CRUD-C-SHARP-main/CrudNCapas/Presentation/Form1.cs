using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Attributes;
using Domain.Crud;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Variables A USAR
        Cpais PAIS = new Cpais();
        AttributesPeople attributes = new AttributesPeople();
        bool edit = false;
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void getData()
        {
            Cpais cPAIS = new Cpais();
            DvgDatos.DataSource = cPAIS.Mostrar();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            btnGuardar.Enabled = false;
            getData();
        }

        private void txtdescripterrri_Enter(object sender, EventArgs e)
        {
            if (textcodsalida.Text == "Codigo Salida") textcodsalida.Text = "";
        }

        private void txtdescripterri_Leave(object sender, EventArgs e)
        {
            if (textcodsalida.Text == "") textcodsalida.Text = "Codigo Salida";
        }

      
        //private void textIdTerritorio_Enter(object sender, EventArgs e)
        //{
        //    if (textCodigoPais.Text == "Codigo Pais") textCodigoPais.Text = "";
        //}

        //private void textIdTerritorio_Leave(object sender, EventArgs e)
        //{
        //    if (textCodigoPais.Text == "") textCodigoPais.Text = "Codigo Pais";
        //}
        
   
        private void txtpic_Enter(object sender, EventArgs e)
        {
          if (txtNombreP.Text == "Pais") txtNombreP.Text = "";
        }

        private void txtpic_Leave(object sender, EventArgs e)
        {
          if (txtNombreP.Text == "") txtNombreP.Text = "Pais";
         }

        private void ClearTextBoxs()
        {
            textCodigoPais.Text = "Codigo Pias";
            txtNombreP.Text = "Pais";
            textcodsalida.Text = "Codigo Salida";
         
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                //INSERTAR DATOS
                try
                {
                    attributes.Codigop = textCodigoPais.Text;
                    attributes.Pais = txtNombreP.Text;
                    attributes.Codigosalid = textcodsalida.Text;
                    PAIS.Insertar(attributes);
                    ClearTextBoxs();
                    getData();
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    MessageBox.Show("SE GUARDÓ UN REGISTRO DE FORMA EXITOSA", "INSERTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show( $"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }else if(edit == true)
            {
                //ACTUALIZAR DATOS
                try
                {
                    attributes.Codigop = textCodigoPais.Text;
                    attributes.Pais = txtNombreP.Text;
                    attributes.Codigosalid = textcodsalida.Text;
                    PAIS.Modificar(attributes);
                    ClearTextBoxs();
                    getData();
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    textCodigoPais.Enabled = true;
                    edit = false;
                    MessageBox.Show("SE ACTUALIZÓ UN REGISTRO DE FORMA EXITOSA", "MODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DvgDatos.SelectedRows.Count > 0)
            {
                textCodigoPais.Enabled = false;
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                edit = true;
                //LA CARGA DE DATOS
                textCodigoPais.Text = DvgDatos.CurrentRow.Cells[0].Value.ToString();
                txtNombreP.Text = DvgDatos.CurrentRow.Cells[1].Value.ToString();
                textcodsalida.Text = DvgDatos.CurrentRow.Cells[2].Value.ToString();
                
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar...") txtBuscar.Text = "";
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
                getData();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DvgDatos.SelectedRows.Count > 0)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("¿DESEAS ELIMINAR ESTE REGISTRO?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialog == DialogResult.Yes)
                {
                    try
                    {
                        attributes.Codigop =(DvgDatos.CurrentRow.Cells[0].Value.ToString());
                        PAIS.Eliminar(attributes);
                        getData();
                        MessageBox.Show("REGISTRO ELIMINADO CORRECTAMENTE", "ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Cpais cPersonas = new Cpais();
            DvgDatos.DataSource = cPersonas.Buscar(txtBuscar.Text);
        }

        private void txtSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNombreP_Enter(object sender, EventArgs e)
        {
            if (txtNombreP.Text == "Pais") txtNombreP.Text = "";
        }

        private void txtNombreP_Leave(object sender, EventArgs e)
        {
            if (txtNombreP.Text == "") txtNombreP.Text = "Pais";
        }

        private void textCodigoPais_Enter(object sender, EventArgs e)
        {
            if (textCodigoPais.Text == "Codigo Pais") textCodigoPais.Text = "";
        }

        private void textCodigoPais_Leave(object sender, EventArgs e)
        {
            if (textCodigoPais.Text == "") textCodigoPais.Text = "Codigo Pais";
        }

        private void textcodsalida_Enter(object sender, EventArgs e)
        {
            if (textcodsalida.Text == "Codigo Salida") textcodsalida.Text = "";
        }

        private void textcodsalida_Leave(object sender, EventArgs e)
        {
            if (textcodsalida.Text == "") textcodsalida.Text = "Codigo Salida";
        }
    }
}
