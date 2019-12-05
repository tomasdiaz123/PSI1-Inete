using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inete_DLL
{
    public class Playlist
    {
        // campos
        private string nome;
        private int qtdMusicas;
        Coleçoes_de_Playlist id;
        Coleçoes_de_Musica musica;
        DateTime data;
        // propriedades
        public DateTime Data
        {
            set { Data = value; }
            get { return data; }
        }
        public int ID
        {
            set { ID = id.Count; }
        }
        public string Nome
        {
            set
            {
                if (value == "") throw new Exception();
                else nome = value;
            }
            get { return nome; }
        }

        // construtor
        public Playlist(string n, int qtd, DateTime data)
        {
            this.Nome = n;
            if (qtd > 0)
            {
                this.musica.nome = n;
                this.musica = new Coleçoes_de_Musica();
            }
            else throw new Exception();
        }

        public bool AdicinarMusica(Musica m)
        {
            if (qtdMusicas < musica.Count) // há espaço?
            {
                // procurar repetidos 
                if (ProcMusica(m) == -1)
                {
                    musica.adicionar_musica(m);
                    qtdMusicas++;
                    return true;
                }
            }

            return false;
        }

        public double DuracaoTotal()
        {
            double soma = 0;

            foreach (Musica m in musica)
                soma += m.DuracaoMins;

            return soma;
        }

        //public Musica[] Musicas
        //{
        //    get { return musicas; }
        //}

        //métodos auxiliares
        private int ProcMusica(Musica m)
        {
            int idx;
            for (idx = 0; idx < qtdMusicas; idx++)
            {
                if (musica.contem_musica(m) == true)
                    return idx;
            }

            return -1;
        }

        // método auxiliar
        public Musica GetMusica(int index)
        {
            if (index < 0 || index >= qtdMusicas)
                throw new ArgumentException("indice inválido!");
            else
                return musica[index];
        }
    }
}
