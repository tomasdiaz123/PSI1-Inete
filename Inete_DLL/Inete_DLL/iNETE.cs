using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inete_DLL
{
    public class iNETE
    {
        // campos
        Coleçoes_de_Playlist playlist;
        private int qtdPlaylist;

        // construtor
        public iNETE(int qtd)
        {
            qtdPlaylist = 0;
            if (qtd > 0)
                this.playlist = new Coleçoes_de_Playlist();
            else throw new Exception();
        }

        public bool AdicionarPlaylist(Playlist p)
        {
            if (qtdPlaylist < playlist.Count) // há espaço?
            {
                // procurar repetidos 
                if (ProcPlaylist(p.Nome) == -1)
                {
                    playlist.contem_playlist(p);
                    qtdPlaylist++;
                    return true;
                }
            }

            return false;
        }

        public bool AdicionarPlaylist(Playlist p, int i)
        {
            int idx;
            if (qtdPlaylist < playlist.Count) // há espaço?
            {
                // procurar repetidos 
                if (ProcPlaylist(p.Nome) == -1)
                {
                    // arranjar espaço
                    for (idx = qtdPlaylist; idx >= i; idx--)
                        playlist[idx] = playlist[idx - 1];
                    // inserir
                    playlist[i] = p;
                    qtdPlaylist++;
                    return true;
                }
            }

            return false;
        }

        public Playlist[] PlaylistsDuracaoMinima(double min)
        {
            Playlist[] listas = new Playlist[qtdPlaylist];
            int idx = 0;

            foreach (Playlist p in playlist)
            {
                if (p.DuracaoTotal() >= min)
                {
                    listas[idx] = p; // ficaria mais seguro clonar a playlist e as músicas
                    idx++;
                }
            }

            return listas;
        }

        // métodos auxiliares
        private int ProcPlaylist(string n)
        {
            int idx;
            for (idx = 0; idx < qtdPlaylist; idx++)
            {
                if (playlist[idx].Nome == n)
                    return idx;
            }

            return -1;
        }

        // método auxiliar
        public Playlist GetPlaylist(int index)
        {
            if (index < 0 || index > qtdPlaylist)
                throw new ArgumentException("indice inválido!");
            else
                return playlist[index];
        }
    }
}
