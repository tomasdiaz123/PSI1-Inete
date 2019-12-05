using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Inete_DLL
{
    class Coleçoes_de_Playlist : CollectionBase
    {
        public Playlist this[int idx]
        {
            set { List[idx] = value; }
            get { return (Playlist)List[idx]; }
        }
        public void adicionar_playlist(Playlist playlist)
        {
            List.Add(playlist);
        }
        public void eliminar_playlist(Playlist playlist)
        {
            List.Remove(playlist);
        }
        public bool contem_playlist(Playlist playlist)
        {
            return InnerList.Contains(playlist);
        }
        public void copiar_playlist(Coleçoes_de_Playlist destino)
        {
            int idx;
            for (idx = 0; idx < this.Count; idx++)
                destino[idx] = this[idx];
        }
    }
}
