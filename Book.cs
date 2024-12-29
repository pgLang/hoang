using System;
using System.Collections.Generic;


namespace ThuVienOnline.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string TheLoai { get; set; }
        public string BookName { get; set; }
        public string TacGia { get; set; }
        public string Anh { get; set; }
        public DateTime NgayPh { get; set; }
        public int SoTrang { get; set; }
        public string Mota { get; set; }
    }

    public enum TheLoai
    {
    Truyện_Tranh,
    Tài_Liệu,
    Sách_Giáo_Khoa
        
    }
}
