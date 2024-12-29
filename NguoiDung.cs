using System;
using System.Collections.Generic;

#nullable disable

namespace ThuVienOnline.Models
{
    public partial class NguoiDung
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public DateTime Ngaysinh { get; set; }
        public bool GioiTinh { get; set; }
        public string Anh { get; set; }
        public string Diachi { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
