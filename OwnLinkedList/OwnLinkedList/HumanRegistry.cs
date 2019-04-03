using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnLinkedList
{
    class HumanRegistry <TKey, TValue>
    {
        TKey key;
        TValue value;

        public HumanRegistry(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }

        public override string ToString()
        {
            return $"{key} - {value}";
        }
    }
}
