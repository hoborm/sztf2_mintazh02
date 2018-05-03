using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf2_mintazh02
{
    internal class BinarisKeresofa<T, K> : IEnumerable<T> where K : IComparable, ICollection<T>
    {
        private BinarisKeresofaNode<T, K> root;
        private int count;

        public int Count { get; set; }

        public void Beszur(BinarisKeresofaNode<T, K> ujtag)
        {
            if (root == null)
            {
                root = ujtag;
            }
            else
            {
                Beszur(this.root, ujtag);
            }
        }

        public void Beszur(T ujtag, K comparator)
        {
            this.Beszur(root, new BinarisKeresofaNode<T, K>(ujtag, comparator));
        }

        public void Beszur(BinarisKeresofaNode<T, K> root, BinarisKeresofaNode<T, K> ujtag)
        {
            if (root == null)
            {
                root = ujtag;
            }
            else if (0 > root.CompareTo(ujtag))
            {
                Beszur(root.Bal, ujtag);
            }
            else
            {
                Beszur(root.Jobb, ujtag);
            }
        }

        public void InOrder(BinarisKeresofaNode<T, K> root)
        {
            if (root != null)
            {
                InOrder(root.Bal);
                Console.WriteLine(root.Value);
                InOrder(root.Jobb);
            }
        }
    }
}