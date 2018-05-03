using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf2_mintazh02
{
    internal class BinarisKeresofaNode<T, K> where K : IComparable
    {
        public BinarisKeresofaNode(T value, K comparator)
        {
            Value = value;
            Comparator = comparator;
        }

        public T Value { get; private set; }

        public K Comparator { get; private set; }

        public BinarisKeresofaNode<T, K> Bal { get; set; }

        public BinarisKeresofaNode<T, K> Jobb
        {
            get; set;
        }

        public int CompareTo(K other)
        {
            return this.Comparator.CompareTo(other);
        }

        public int CompareTo(BinarisKeresofaNode<T, K> other)
        {
            return this.Comparator.CompareTo(other.Comparator);
        }
    }
}