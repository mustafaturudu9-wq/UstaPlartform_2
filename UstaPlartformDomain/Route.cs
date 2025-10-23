using System;
using System.Collections;         
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UstaPlartform.Domain
{
    // IEnumerable<(int X, int Y)> arayüzünü uygular
    public class Route : IEnumerable<(int X, int Y)>
    {
        private readonly List<(int X, int Y)> _koordinatlar = new List<(int X, int Y)>();

        // Koleksiyon başlatıcı ('new Route { {1, 5} }') için bu 'Add' metodu zorunlu
        public void Add(int X, int Y)
        {
            _koordinatlar.Add((X, Y));
        }

        public IEnumerator<(int X, int Y)> GetEnumerator()
        {
            return _koordinatlar.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            // Yukarıdaki generic metodu çağırması yeterlidir
            return this.GetEnumerator();
        }
    }
}