using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf2_mintazh02
{
    internal enum BolygoTipusok
    { Bolygo, Csillag, Aszteroida }

    internal class LancoltLista<T> : IEnumerable<T>
    {
        public LancoltListaNode<T> Head
        {
            get;
            private set;
        }

        public LancoltListaNode<T> Tail
        {
            get;
            private set;
        }

        public int Count
        { get; set; }

        public void Add(LancoltListaNode<T> ujtag)
        {
            LancoltListaNode<T> current = Head;

            Type egitestTipus = ujtag.GetType();

            while (current.Next != null && current.GetType() != egitestTipus)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                ujtag.Next = current.Next;
                current.Next = ujtag;
            }
            else
            {
                if (current == null)
                {
                    Head = ujtag;
                }
                else

                {
                    current.Next = ujtag;
                }
            }
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LancoltListaNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}