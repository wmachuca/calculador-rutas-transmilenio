using Proyecto.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Principal : Form
    {

        int estaciones = 148;
        int tiempoAparicion = 125;
        
        Estaciones estObj = new Estaciones();
        Dijkstra djk;
        int origen, destino; 

        public Principal()
        {
            InitializeComponent();
            djk = new Dijkstra(this.estaciones);
            cboOrigen.DataSource = new BindingSource(estObj.getEstaciones(), null);
            cboOrigen.DisplayMember = "Value";
            cboOrigen.ValueMember = "Key";
            cboDestino.DataSource = new BindingSource(estObj.getEstaciones(), null);
            cboDestino.DisplayMember = "Value";
            cboDestino.ValueMember = "Key";
        }

        private void limpiarEstaciones() 
        {
            CheckBox cb;
            for (int i = 0; i < estaciones; i++) 
            {
                cb = (CheckBox)Controls.Find("est" + i, true)[0];
                cb.CheckState = CheckState.Unchecked;
            }
        }

        private void marcarEstacion(int id, bool check)
        {
            CheckBox cb = (CheckBox)Controls.Find("est" + id, true)[0];
            if (check)
            {
                cb.CheckState = CheckState.Checked;
            }
            else {
                cb.CheckState = CheckState.Indeterminate;
            }
            
        }

        private void btnBuscarRuta_Click(object sender, EventArgs e)
        {
            int loop = 0;
            string result = "", dest = "";
            origen = Int32.Parse(((KeyValuePair<string, string>)cboOrigen.SelectedItem).Key);
            destino = Int32.Parse(((KeyValuePair<string, string>)cboDestino.SelectedItem).Key);
            djk.calcular(origen);
            lbxCalculados.Items.Clear();
            foreach (Distancia res in djk.distancia)
            {
                if (res.getValor() != 999)
                {
                    dest = estObj.estaciones[loop.ToString()];
                    result = "Origen: " + estObj.estaciones[origen.ToString()] + "\tDestino: " + dest.PadRight(32, ' ') + " \tCosto: " + res.getValor();
                }
                else 
                {
                    result = "No hay conexion entre las estaciones de " + estObj.estaciones[origen.ToString()] + " y " + estObj.estaciones[loop.ToString()];
                }
                lbxCalculados.Items.Add(result);
                loop++;
            }
            lbxCalculados.SetSelected(destino, true);
        }

        private void lbxCalculados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxCalculados.SelectedItems.Count != 0 && djk.distancia[0] != null) {
                int seleccionado = lbxCalculados.SelectedIndex;
                trazarRuta(seleccionado);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void trazarRuta(int index) {
            this.limpiarEstaciones();
            bool final = false;
            int[] invertir = new int[this.estaciones];
            int tiempo = djk.distancia[index].getValor(), tmp;
            int padre = djk.distancia[index].getPadre();
            int paradas = 0;
            txtResultadoParadas.Text = "";
            Dictionary<string, string> estaciones = estObj.getEstaciones();
            marcarEstacion(index, true);
            marcarEstacion(origen, true);
            for (int i = 0; i < this.estaciones; i++)
            {
                invertir[i] = 9999;
            }
            while (!final) {
                paradas++;
                if (padre == this.origen)
                {
                    final = true;
                }
                else 
                {
                    invertir[paradas - 1] = padre;
                    padre = djk.distancia[padre].getPadre();
                }
            }
            Array.Reverse(invertir);
            txtResultadoParadas.AppendText("Origen: " + estaciones[origen.ToString()]);
            txtResultadoParadas.AppendText(Environment.NewLine);
            int cnt = 1;
            foreach (int p in invertir)
            {
                if (p != 9999)
                {
                    System.Threading.Thread.Sleep(this.tiempoAparicion);
                    this.marcarEstacion(p, false);
                    txtResultadoParadas.AppendText("Parada " + cnt + ": " + estaciones[p.ToString()]);
                    txtResultadoParadas.AppendText(Environment.NewLine);
                    cnt++;
                }
            }
            lblResultadoParadas.Text = paradas.ToString();
            lblResultadoOrigen.Text = estaciones[this.origen.ToString()];
            lblResultadoDestino.Text = estaciones[index.ToString()];
            tmp = tiempo / 60;
            if (tiempo != 999)
            {
                lblResultadoTiempo.Text = tmp.ToString("00") + ":" + (tiempo - (tmp * 60)).ToString("00") + ":00";
                txtResultadoParadas.AppendText("Parada " + cnt + ": " + estaciones[index.ToString()]);
            }
            else 
            {
                lblResultadoTiempo.Text = "-";
                txtResultadoParadas.AppendText("No existe ruta hasta la estacion de " + estaciones[index.ToString()]);
            }

            

        }
    }
}
