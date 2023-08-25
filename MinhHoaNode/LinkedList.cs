using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhHoaNode
{
    public class LinkedList
    {
        //1. 
        public NODE GetNode(int x)
        {
            try
            {
                NODE newNode = new NODE(x);
                return newNode;
            }
            catch (Exception)
            {
                return null; 
            }
        }

        //2. 
        public void CreatList(out LIST l)
        {
            l = new LIST();
        }

        // 3. Kiểm tra DSLK l có rổng
        public int IsEmpty(LIST l)
        {
            return l.Head == null ? 1 : 0;
        }

        // 4. Duyệt danh sách
        public void ProcessList(LIST l)
        {
            NODE current = l.Head;
            while (current != null)
            {
                Console.WriteLine(current.Data); 
                current = current.Next;
            }
        }

        // 5. Tìm nút có info là x
        public NODE Search(LIST l, int x)
        {
            NODE current = l.Head;
            while (current != null)
            {
                if (current.Data == x)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        // 6. Chèn nút (đã có) vào đầu DSLK đơn
        public void AddFirst(ref LIST l, NODE new_ele)
        {
            if (new_ele != null)
            {
                new_ele.Next = l.Head;
                l.Head = new_ele;
            }
        }
        // 7. Chèn một giá trị dữ liệu vào đầu DSLK đơn
        public NODE InsertHead(ref LIST l, int x) 
        {
            NODE new_ele = new NODE(x);
            if (new_ele != null)
            {
                new_ele.Next = l.Head;
                l.Head = new_ele;
            }
            return new_ele;
        }

        // 8. Chèn nút (đã có) vào Cuối DSLK đơn
        public void AddTail(ref LIST l, NODE new_ele)
        {
            if (new_ele != null)
            {
                if (l.Head == null)
                {
                    l.Head = new_ele;
                }
                else
                {
                    NODE current = l.Head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = new_ele;
                }
            }
        }

        // 9. Chèn một giá trị dữ liệu vào cuối DSLK đơn
        public NODE InsertTail(ref LIST l, int x)
        {
            NODE new_ele = new NODE(x);
            if (new_ele != null)
            {
                if (l.Head == null)
                {
                    l.Head = new_ele;
                }
                else
                {
                    NODE current = l.Head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = new_ele;
                }
            }
            return new_ele;
        }

        // 10. Chèn một nút (chưa có trước) vào sau nút do con trỏ q trỏ tới
        public void InsertAfter(ref LIST l, NODE q, int x)
        {
            if (q != null)
            {
                NODE new_ele = new NODE(x);
                if (new_ele != null)
                {
                    new_ele.Next = q.Next;
                    q.Next = new_ele;
                }
            }
        }

        // 11. Hủy nút đầu ra khỏi DSLK đơn
        public void RemoveHead(ref LIST l)
        {
            if (l.Head != null)
            {
                NODE temp = l.Head;
                l.Head = l.Head.Next;
                temp.Next = null; 
            }
        }

        // 12. Hủy nút ở vị trí sau nút do con trỏ q trỏ tới
        public void RemoveAfter(ref LIST l, NODE q)
        {
            if (q != null && q.Next != null)
            {
                NODE temp = q.Next;
                q.Next = q.Next.Next;
                temp.Next = null;
            }
        }

        // 13. Hủy nút có thành phần info là x
        public int RemoveNode(ref LIST l, int x)
        {
            if (l.Head == null)
                return 0;

            if (l.Head.Data == x)
            {
                RemoveHead(ref l);
                return 1;
            }

            NODE current = l.Head;
            while (current.Next != null && current.Next.Data != x)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                NODE temp = current.Next;
                current.Next = current.Next.Next;
                temp.Next = null;
                return 1;
            }
            return 0;
        }

        // 14. Hủy toàn bộ danh sách
        public void RemoveList(ref LIST l)
        {
            l.Head = null;
        }

    }
}
