using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf2_mintazh02
{
    internal class LancoltListaNode<T>
    {
        public LancoltListaNode(T value)
        {
            Value = value;
        }

        public T Value
        {
            get; set;
        }

        internal LancoltListaNode<T> Next
        { get; set; }
    }
}