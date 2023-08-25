using MinhHoaNode;
using System.Text;

/// <summary>
/// 2212460 Hoàng Đức Thành
/// 2212451 Nguyễn Hoàng Sang
/// 2212465 Lê Khánh Thiện
/// 2212371 Nguyễn Hiệp Hoàng
/// </summary>
public class Program
{

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        LinkedList linkedListFunctions = new LinkedList();
        LIST myList;
        // tạo danh sách rỗng
        linkedListFunctions.CreatList(out myList);

        int choice;
        do
        {
            Console.WriteLine("----- MENU -----");
            Console.WriteLine("1. Tạo nút mới");
            Console.WriteLine("2. Thêm nút vào đầu danh sách");
            Console.WriteLine("3. Thêm nút vào cuối danh sách");
            Console.WriteLine("4. Xóa nút ở đầu danh sách");
            Console.WriteLine("5. Tìm nút có giá trị x trong danh sách");
            Console.WriteLine("6. Duyệt và hiển thị danh sách");
            Console.WriteLine("7. Chèn một nút sau một nút cho trước");
            Console.WriteLine("8. Xóa một nút có giá trị cụ thể");
            Console.WriteLine("9. Xóa toàn bộ danh sách");
            Console.WriteLine("10. Kiểm tra danh sách có rỗng không");
            Console.WriteLine("11. Chèn nút (đã có) vào Cuối DSLK đơn");
            Console.WriteLine("12. Chèn nút (đã có) vào Đầu DSLK đơn");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn một hành động: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = -1;
            }

            switch (choice)
            {
                case 1:
                    RunGetNodeFunc();
                    break;
                case 2:
                    RunInsertHeadFunc(linkedListFunctions, myList);
                    break;
                case 3:
                    RunInsertTailFunc(linkedListFunctions, myList);
                    break;
                case 4:
                    RunRemoveNodeFunc(linkedListFunctions, myList);
                    break;
                case 5:
                    RunSearchFunc(linkedListFunctions, myList);
                    break;
                case 6:
                    PrintList(linkedListFunctions, myList);
                    break;
                case 7:
                    RunInsertAfterNodeFunc(linkedListFunctions, myList);
                    break;
                case 8:
                    RunRemoveNodeFunc(linkedListFunctions, myList);
                    break;
                case 9:
                    linkedListFunctions.RemoveList(ref myList);
                    Console.WriteLine("Các nodes trong danh sách đã bị xóa");
                    break;
                case 10:
                    var flag = linkedListFunctions.IsEmpty(myList);
                    if (flag == 1)
                        Console.WriteLine("Danh sách đang rỗng");
                    else
                        Console.WriteLine("Danh sách không rỗng");

                    break;
                case 11:
                    RunAddTailFunc(linkedListFunctions, myList);
                    break;
                case 12:
                    RunAddFirstFunc(linkedListFunctions, myList);
                    break;

                case 0:
                    Console.WriteLine("Cảm ơn đã sử dụng!");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }

            if (choice != 0)
            {
                Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                Console.ReadKey();
                Console.Clear();
            }
        } while (choice != 0);
    }


    static void RunGetNodeFunc()
    {
        LinkedList list = new LinkedList();
        NODE newNode = list.GetNode(5);

        if (newNode != null)
        {
            Console.WriteLine($"Đã tạo nút mới với dữ liệu: {newNode.Data}");
        }
        else
        {
            Console.WriteLine("Không thể tạo nút mới.");
        }
    }


    //Chèn một giá trị dữ liệu vào đầu DSLK đơn
    static void RunInsertHeadFunc(LinkedList linkedList, LIST list)
    {
        Console.Write("Nhập giá trị cho nút mới: ");
        int value;
        if (int.TryParse(Console.ReadLine(), out value))
        {
            linkedList.InsertHead(ref list, value);
            Console.WriteLine($"Đã thêm nút có giá trị {value} vào đầu danh sách.");
        }
        else
        {
            Console.WriteLine("Giá trị không hợp lệ!");
        }
    }
    //Chèn một giá trị dữ liệu vào cuối DSLK đơn
    static void RunInsertTailFunc(LinkedList linkedList, LIST list)
    {
        Console.Write("Nhập giá trị cho nút mới: ");
        int value;
        if (int.TryParse(Console.ReadLine(), out value))
        {
            linkedList.InsertTail(ref list, value);
            Console.WriteLine($"Đã thêm nút có giá trị {value} vào cuối danh sách.");
        }
        else
        {
            Console.WriteLine("Giá trị không hợp lệ!");
        }
    }


    // Tìm nút có info là x
    static void RunSearchFunc(LinkedList linkedList, LIST list)
    {
        Console.Write("Nhập giá trị cần tìm: ");
        int value;
        if (int.TryParse(Console.ReadLine(), out value))
        {
            NODE foundNode = linkedList.Search(list, value);
            if (foundNode != null)
            {
                Console.WriteLine($"Tìm thấy nút có giá trị {value} trong danh sách.");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy nút có giá trị {value}.");
            }
        }
        else
        {
            Console.WriteLine("Giá trị không hợp lệ!");
        }
    }

    //Chèn một nút (chưa có trước) vào sau nút do con trỏ q trỏ tới
    static void RunInsertAfterNodeFunc(LinkedList linkedList, LIST list)
    {
        Console.Write("Nhập giá trị cần tìm (nút để chèn sau): ");
        int value;
        if (int.TryParse(Console.ReadLine(), out value))
        {
            NODE foundNode = linkedList.Search(list, value);
            if (foundNode != null)
            {
                Console.Write("Nhập giá trị cho nút mới: ");
                int newValue;
                if (int.TryParse(Console.ReadLine(), out newValue))
                {
                    linkedList.InsertAfter(ref list, foundNode, newValue);
                    Console.WriteLine($"Đã chèn nút có giá trị {newValue} sau nút có giá trị {value}.");
                }
                else
                {
                    Console.WriteLine("Giá trị không hợp lệ!");
                }
            }
            else
            {
                Console.WriteLine($"Không tìm thấy nút có giá trị {value}.");
            }
        }
        else
        {
            Console.WriteLine("Giá trị không hợp lệ!");
        }
    }
    // Hủy nút đầu ra khỏi DSLK đơn
    static void RunRemoveNodeFunc(LinkedList linkedList, LIST list)
    {
        Console.Write("Nhập giá trị của nút cần xóa: ");
        int value;
        if (int.TryParse(Console.ReadLine(), out value))
        {
            if (linkedList.RemoveNode(ref list, value) == 1)
            {
                Console.WriteLine($"Đã xóa nút có giá trị {value} khỏi danh sách.");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy nút có giá trị {value}.");
            }
        }
        else
        {
            Console.WriteLine("Giá trị không hợp lệ!");
        }
    }
    static void RunAddTailFunc(LinkedList linkedList, LIST list)
    {
        Console.Write("Nhập giá trị cho nút mới: ");
        int value;
        if (int.TryParse(Console.ReadLine(), out value))
        {
            NODE newNode = linkedList.GetNode(value);
            linkedList.AddTail(ref list, newNode);
            Console.WriteLine($"Đã thêm nút có giá trị {value} vào cuối danh sách.");
        }
        else
        {
            Console.WriteLine("Giá trị không hợp lệ!");
        }
    }

    static void RunAddFirstFunc(LinkedList linkedList, LIST list)
    {
        Console.Write("Nhập giá trị cho nút mới: ");
        int value;
        if (int.TryParse(Console.ReadLine(), out value))
        {
            NODE newNode = linkedList.GetNode(value);
            linkedList.AddFirst(ref list, newNode);
            Console.WriteLine($"Đã thêm nút có giá trị {value} vào đầu danh sách.");
        }
        else
        {
            Console.WriteLine("Giá trị không hợp lệ!");
        }
    }

    static void PrintList(LinkedList linkedList, LIST list)
    {
        Console.WriteLine("Danh sách hiện tại:");
        linkedList.ProcessList(list);
    }
}
