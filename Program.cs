using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;
            bool listCreated = false;

            SingleLinkedList list = new SingleLinkedList();

            while (listCreated == false)
            {
                listCreated = list.CreateList();
            }

            while (true)
            {
                Console.WriteLine("1. Display the list");
                Console.WriteLine("2. Count the number of nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in an empty list/Insert in the beginning");
                Console.WriteLine("5. Insert a node at the end of the list");
                Console.WriteLine("6. Insert node after specified node");
                Console.WriteLine("7. Insert node before specified node");
                Console.WriteLine("8. Insert node at given position");
                Console.WriteLine("9. Delete first node");
                Console.WriteLine("10. Delete last node");
                Console.WriteLine("11. Delete any node");
                Console.WriteLine("12. Reverse the list");
                Console.WriteLine("13. Bubbelsort by exchanging data");
                Console.WriteLine("14. Bubbelsort by exchanging link");
                Console.WriteLine("15. Merge Sort");
                Console.WriteLine("16. Insert Cycle");
                Console.WriteLine("17. Detect Cycle");
                Console.WriteLine("18. Remove Cycle");
                Console.WriteLine("19. Quit");

                Console.WriteLine("Please enter your choice:");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                if (choice == 19)
                {
                    break;
                }

                try
                {

                    switch (choice)
                    {
                        case 1:
                            list.DisplayList();
                            break;
                        case 2:
                            list.CountNodes();
                            break;
                        case 3:
                            Console.Write("Enter the element to be search: ");
                            x = Convert.ToInt32(Console.ReadLine());
                            list.Search(x);
                            break;
                        case 4:
                            Console.Write("Enter the element to be inserted: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            list.InsertInBeginning(data);
                            break;
                        case 5:
                            Console.Write("Enter the element to be inserted: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            list.InsertAtEnd(data);
                            break;
                        case 6:
                            Console.Write("Enter the element to be inserted: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the element after which to insert: ");
                            x = Convert.ToInt32(Console.ReadLine());
                            list.InsertAfter(data, x);
                            break;
                        case 7:
                            Console.Write("Enter the element to be inserted: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the element before which to insert: ");
                            x = Convert.ToInt32(Console.ReadLine());
                            list.InsertBefore(data, x);
                            break;
                        case 8:
                            Console.Write("Enter the element to be inserted: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the postition which to insert: ");
                            k = Convert.ToInt32(Console.ReadLine());
                            list.InsertAtPosition(data, k);
                            break;
                        case 9:
                            list.DeleteFirstNode();
                            break;
                        case 10:
                            list.DeleteLastNode();
                            break;
                        case 11:
                            Console.Write("Enter the element to be deleted: ");
                            x = Convert.ToInt32(Console.ReadLine());
                            list.DeleteNode(x);
                            break;
                        case 12:
                            list.ReverseList();
                            break;
                        case 13:
                            list.BubbleSortExData();
                            break;
                        case 14:
                            list.BubbleSortExLinks();
                            break;
                        case 15:
                            list.MergeSort();
                            break;
                        case 16:
                            Console.WriteLine("Enter element at which the cycle has to be inserted");
                            x = Convert.ToInt32(Console.ReadLine());
                            list.InsertCycle(x);
                            break;
                        case 17:
                            if (list.HasCycle())
                            {
                                Console.WriteLine("List has a cycle");
                            }
                            else
                            {
                                Console.WriteLine("List does not have a cycle");
                            }
                            break;
                        case 18:
                            list.RemoveCycle();
                            break;
                        default:
                            Console.WriteLine("Choice not available");
                            break;
                    }

                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
            Console.WriteLine("end of loop");
        }
    }
}
