using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    class Dijkstra
    {
        public Distancia[] distancia;
        public int[,] costo;
        public string[] recorrido;
        private int nodos;

        public Dijkstra(int size)
        {
            this.distancia = new Distancia[size];
            this.costo = new int[size, size];
            this.recorrido = new string[size];
            this.nodos = size;
            this.cargarMatriz();
        }

        public void calcular(int origen)
        {
            int[] flag = new int[nodos];
            int i, minpos = 0, k, c, minimo, inc;
            int[] historial = new int[9999];

            for (i = 0; i < this.nodos; i++)
            {
                flag[i] = 0;
                this.distancia[i] = new Distancia();
                this.distancia[i].setPadre(origen);
                this.distancia[i].setValor(this.costo[origen, i]);
            }
            i--;
            c = 1;
            inc = 1;
            historial[0] = origen;
            while (c <= this.nodos)
            {
                minimo = 99;
                for (k = 0; k < this.nodos; k++)
                {
                    if (this.distancia[k].getValor() < minimo && flag[k] != 1)
                    {
                        minimo = this.distancia[i].getValor();
                        minpos = k;
                    }
                }
                flag[minpos] = 1;
                c++;
                for (k = 0; k < this.nodos; k++)
                {
                    if (this.distancia[minpos].getValor() + this.costo[minpos, k] < this.distancia[k].getValor() && flag[k] != 1) {
                        this.distancia[k].setValor(this.distancia[minpos].getValor() + this.costo[minpos, k]);
                        this.distancia[k].setPadre(minpos);
                    }
                }
            }
        }

        private void cargarMatriz()
        {
            string line;
            int contador = 0;
            string rutaRelativa = @"Proyecto\Resources\DB\matriz.txt";
            string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaRelativa);

            if (File.Exists(rutaCompleta))
            {
                using (StreamReader file = new StreamReader(@"M:\Users\wmachuca\Documents\GitHub\calculador-rutas-transmilenio\Proyecto\Resources\DB\matriz.txt"))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        char[] delimiters = new char[] { '\t' };
                        string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < parts.Length; i++)
                        {
                            costo[contador, i] = Int32.Parse(parts[i]);
                        }
                        contador++;
                    }
                    file.Close();
                }
            } else
            {
                Console.WriteLine($"El archivo no existe en la ruta: {rutaCompleta}");
            }
            
                
        }
    }
}
