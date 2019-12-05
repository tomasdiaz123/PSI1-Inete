using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Inete_DLL
{
    public class Musica : CollectionBase
    {
        //campos
        private string titulo;
        private string artista;
        private Generos genero;
        private double duracao;

        // propriedades
        public string Artista
        {
            set
            {
                if (value == "") throw new Exception();
                else artista = value;
            }
            get { return artista; }
        }

        public string Titulo
        {
            set
            {
                if (value == "") throw new Exception();
                else titulo = value;
            }
            get { return titulo; }
        }

        public Generos Genero
        {
            set { genero = value; }
            get { return genero; }
        }

        public int DuracaoSegs
        {
            set
            {
                if (value < 1) throw new Exception();
                else
                {
                    duracao = value / 60.0;
                }
            }
        }

        // construtor
        public Musica(string t, string a, int d, Generos g)
        {
            this.Titulo = t;
            this.Artista = a;
            this.DuracaoSegs = d;
            this.Genero = g;
        }

        // métodos
        public int Duracao()
        {
            return (int)(duracao * 60);
        }

        // propriedade auxiliar
        public double DuracaoMins
        {
            get { return duracao; }
        }
    }
}
