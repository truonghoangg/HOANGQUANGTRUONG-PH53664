using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace HOANGQUANGTRUONG_PH53664.Models
{
    public class SanPham
    {
        [Key]
        public int MaSP { get; set; } 
        public string TenSP { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuongTon { get; set; }

        public SanPhamChiTiet sanPhamChiTiet { get; set; }
    }
}
