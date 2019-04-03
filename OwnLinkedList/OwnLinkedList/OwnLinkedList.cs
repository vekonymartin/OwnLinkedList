using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnLinkedList
{
    //=================
    // LINKED LIST >>https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=netframework-4.7.2
    //=================
    class OwnLinkedList <T>
    {
        private ListItem head;

        //=================
        // NESTED CLASSES >> https://msdn.microsoft.com/en-us/library/ms173120.aspx
        //=================
        class ListItem
        {
            public T contain;
            public ListItem next;
        }

        public void InsertToTheBeginning(T item)
        {
            ListItem n_ew = new ListItem();
            n_ew.contain = item;
            n_ew.next = head;

            head = n_ew;
        }

        public void InsertToTheEnd(T item)
        {

        }

        public void InsertInToNPlaces(T item)
        {

        }

        public void DeleteFromTheBeggining(T itme)
        {

        }

        public void DeleteFromTheEnd(T item)
        {

        }

        public void DeleteFromNPlaces(T item)
        {

        }

        public void EmancipateTheList()
        {

        }

        public void Admittance()
        {
            ListItem p = head;

            while (p != null)
            {
                Process(p);
                p = p.next;
            }
        }

        private void Process(ListItem item)
        {
            Console.WriteLine(item.contain);
        }
    }
}
