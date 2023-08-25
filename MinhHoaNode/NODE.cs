    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhHoaNode
{
    public class NODE
    {
        public int Data { get; set; }  
        public NODE Next { get; set; }

        // Hàm tạo
        public NODE(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
