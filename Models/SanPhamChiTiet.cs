using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HOANGQUANGTRUONG_PH53664.Models
{
    public class SanPhamChiTiet
    {
        [Key]
        public int MaSPCT { get; set; }
        [ForeignKey("sanPham")]
        public int MaSP { get; set; }
        public string MauSac { get; set; }
        public string KichThuoc { get; set; }
        public SanPham sanPham { get; set; }
    }
}
