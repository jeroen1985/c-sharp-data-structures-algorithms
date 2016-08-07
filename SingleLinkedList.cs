using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p;
            if(start == null)
            {
                Console.WriteLine("list is empty");
                return;
            }

            Console.Write("list is: ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + "    ");
                p = p.link;
            }
            Console.WriteLine();
        }

        public bool CreateList()
        {
            int i, data;
            int n = 0;

            Console.WriteLine("Enter the number of nodes: ");

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            if(n == 0)
            {
                return true;
            }
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the element to be inserted: ");
                try
                {
                    data = Convert.ToInt32(Console.ReadLine());
                    InsertAtEnd(data);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
            return true;
        }

        public void CountNodes()
        {
            Node p;
            int count = 0;
            if (start == null)
            {
                Console.WriteLine("list is empty (Count 0) ");
                return;
            }

            p = start;
            while (p != null)
            {
                count++;
                p = p.link;
            }
            Console.WriteLine("list count is " + count);
        }

        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            while(p != null)
            {
                if(p.info == x)
                {
                    break;
                }
                position++;
                p = p.link;
            }
            if(p == null)
            {
                Console.WriteLine(x + " not found in list");
                return false;
            }
            else
            {
                Console.WriteLine(x + " is found at position " + position);
                return true;
            }
        }

        public void InsertInBeginning(int data)
        {
            Node p;
            Node temp = new Node(data);

            if (start == null)
            {
                start = temp;
                Console.WriteLine(data + " added to new list");
            }
            else
            {
                p = start;
                temp.link = p;
                start = temp;
                Console.WriteLine(data + " added at the begining of a list");
            }
        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            if (start == null)
            {
                start = temp;
                return;
            }

            p = start;
            while (p.link != null)
            {
                p = p.link;
            }

            p.link = temp;
        }

        public void InsertAfter(int data, int x)
        {
            Node temp;

            if (start == null)
            {
                Console.WriteLine("list is empty");
                return;
            }

            Node p = start;
            while (p.link != null)
            {
                if (p.info == x)
                {
                    break;
                }
                p = p.link;
            }

            if (p.link == null)
            {
                Console.WriteLine(x + "not presented in the list");
            }
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertBefore(int data, int x)
        {
            Node temp;

            if(start == null)
            {
                Console.WriteLine("list is empty");
                return;
            }

            if(start.info == x)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            while(p.link != null)
            {
                if(p.link.info == x)
                {
                    break;
                }
                p = p.link;
            }

            if (p.link == null)
            {
                Console.WriteLine(x + "not presented in the list");
            }
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertAtPosition(int data, int k)
        {
            Node p;
            Node temp;
            
            if (start == null)
            {
                Console.WriteLine("list is empty");
                return;
            }

            if (k == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

           
            p = start;
            int i; ;

            for (i = 1; i < k-1 && p.link != null; i++)
            {
                p = p.link;
            }

            if (p == null)
            {
                Console.Write(i + "you can only insert at this line");
            }
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if (start == null)
            {
                return;
            }
            start = start.link;
        }

        public void DeleteLastNode()
        {
            if (start == null)
            {
                return;
            }

            if (start.link == null)
            {
                start = null;
                return;
            }

            Node p = start;
            while(p.link.link != null)
            {
                p = p.link;
            }
            p.link = null;

        }

        public void DeleteNode(int x)
        {
            if (start == null)
            {
                Console.Write("List is empty");
                return;
            }

            if (start.info == x)
            {
                start = start.link;
                return;
            }

            Node p = start;

            while (p.link != null)
            {
                if (p.link.info == x)
                {
                    break;                   
                }
                p = p.link;
            }

            if (p.link == null)
            {
                Console.Write("value" + x + "doesn't exist in list");
            }
            else
            {
                p.link = p.link.link;
            }
        }
    
        public void ReverseList()
        {
            Node next;
            Node prev = null;
            Node p = start;
            while (p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }
            start = prev;
        }

        public void BubbleSortExData()
        {
            Node end, q, p;

            for(end = null; end != start.link; end = p)
            {
                for (p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if(p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }

        public void BubbleSortExLinks()
        {
            Node end, r, p, q, temp;

            for (end = null; end != start.link; end = p)
            {
                for (r = p = start; p.link != end;r = p, p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        p.link = q.link;
                        q.link = p;
                        if(p != start)
                        {
                            r.link = q;
                        }
                        else
                        {
                            start = q;
                        }
                        temp = p;
                        p = q;
                        q = temp;
                    }
                }
            }
        }

        public void MergeSort()
        {
            start = MergeSortRec(start);
        }

        private Node MergeSortRec(Node listStart)
        {
            if(listStart == null || listStart.link == null)
            {
                return listStart;
            }

            Node start1 = listStart;
            Node start2 = DivideList(listStart);
            start1 = MergeSortRec(start1);
            start2 = MergeSortRec(start2);
            Node startM = Merge2(start1, start2);
            return startM;
        }

        private Node DivideList(Node p)
        {
            Node q = p.link.link;
            while (q != null && q.link != null)
            {
                p = p.link;
                q = q.link.link;

            }
            Node start2 = p.link;
            p.link = null;
            return start2;
        }

        private Node Merge2(Node p1, Node p2)
        {
            Node startM;

            if(p1.info <= p2.info)
            {
                startM = p1;
                p1 = p1.link;
            }
            else
            {
                startM = p2;
                p2 = p2.link;
            }

            Node pM = startM;

            while(p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pM.link = p1;
                    pM = pM.link;
                    p1 = p1.link;
                }
                else
                {
                    pM.link = p2;
                    pM = pM.link;
                    p2 = p2.link;
                }
            }

            if(p1 == null)
            {
                pM.link = p2;
            }
            else
            {
                pM.link = p1;
            }
            return startM;
        }

        public void InsertCycle(int x)
        {
            if(start == null)
            {
                return;
            }

            Node p = start, px = null, prev = null;

            while(p != null)
            {
                if(p.info == x)
                {
                    px = p;
                }
                prev = p;
                p = p.link;
            }
            if(px != null)
            {
                prev.link = px;
            }
            else
            {
                Console.WriteLine(x + "not in list");
            }
        }

        public bool HasCycle()
        {
            if(FindCyclce() == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private Node FindCyclce()
        {
            if(start == null || start.link == null)
            {
                return null;
            }

            Node slowR = start, fastR = start;

            while(fastR != null && fastR.link != null)
            {
                slowR = slowR.link;
                fastR = fastR.link.link;
                if (slowR == fastR)
                {
                    return slowR;
                }
            }
            return null;
        }

        public void RemoveCycle()
        {
            Node c = FindCyclce();
            if (c == null)
            {
                return;
            }
            Console.WriteLine("Node at which the cycle was detected is " + c.info);

            Node p = c, q = c;
            int lenCycle = 0;
            do
            {
                lenCycle++;
                q = q.link;
            } while (p != q);
            Console.WriteLine("Length of cycle is " + lenCycle);

            int lenRemList = 0;
            p = start;
            while (p != q)
            {
                lenRemList++;
                p = p.link;
                q = q.link;
            }
            Console.WriteLine("Number of nodes not included in the cycle " + lenRemList);

            int lenList = lenCycle + lenRemList;
            Console.WriteLine("Lengt of the list is " + lenList);

            p = start;
            for(int i = 1; i <= lenList-1; i++)
            {
                p = p.link;
            }
            p.link = null;
        }
    }
}
