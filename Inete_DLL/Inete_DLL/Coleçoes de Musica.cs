using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Inete_DLL
{
    class Coleçoes_de_Musica : CollectionBase
    {
        public string nome;
        public Musica this[int idx]
        {
            set { List[idx] = value; }
            get { return (Musica)List[idx]; }
        }
        public void adicionar_musica(Musica musica)
        {
            List.Add(musica);
        }
        public void eliminar_musica(Musica musica)
        {
            List.Remove(musica);
        }
        public bool contem_musica(Musica musica)
        {
            return InnerList.Contains(musica);
        }
        public void copiar_musica(Musica musica, Playlist destino)
        {
            int idx;
            for (idx = 0; idx < this.Count; idx++)
            {
                destino.AdicinarMusica(musica);
            }
        }
    }
}
