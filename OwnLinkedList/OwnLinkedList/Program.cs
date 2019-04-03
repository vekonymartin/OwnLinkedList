using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region INT List
            OwnLinkedList<int> myList1 = new OwnLinkedList<int>();
            myList1.InsertToTheBeginning(1);
            myList1.InsertToTheBeginning(3);
            myList1.InsertToTheBeginning(4);
            myList1.InsertToTheBeginning(5);

            myList1.Admittance();
            #endregion
            
            Console.WriteLine(new string('=',10));
            // ===========================================================
            #region STRING List
            OwnLinkedList<string> myList2 = new OwnLinkedList<string>();

            myList2.InsertToTheBeginning("New York");
            myList2.InsertToTheBeginning("Budapest");
            myList2.InsertToTheBeginning("London");
            myList2.InsertToTheBeginning("Vein");

            myList2.Admittance();
            #endregion

            Console.WriteLine(new string('=', 10));
            // ===========================================================
            #region OWN TYPE List
            OwnLinkedList<Human> myList3 = new OwnLinkedList<Human>();

            myList3.InsertToTheBeginning(new Human() { Name = "Smith" });
            myList3.InsertToTheBeginning(new Human() { Name = "George" });
            myList3.InsertToTheBeginning(new Human() { Name = "Sophie" });
            myList3.InsertToTheBeginning(new Human() { Name = "Mary" });

            myList3.Admittance();

            Console.WriteLine(new string('=', 10));

            OwnLinkedList<HumanRegistry<string, Human>> myList4 = new OwnLinkedList<HumanRegistry<string, Human>>();

            myList4.InsertToTheBeginning(new HumanRegistry<string, Human>("HUN-15",new Human() { Name= "Martin"}));
            myList4.InsertToTheBeginning(new HumanRegistry<string, Human>("ENG-12", new Human() { Name = "Tom" }));
            myList4.InsertToTheBeginning(new HumanRegistry<string, Human>("USA-11", new Human() { Name = "Emma" }));

            myList4.Admittance();
            #endregion

            Console.ReadLine(); // Console.ReadKey();
        }
    }
}
