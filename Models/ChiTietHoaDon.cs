namespace HOANGQUANGTRUONG_PH53664.Models
{
    public class ChiTietHoaDon
    {
        public int MaCTHD { get; set; }
        public int MaHD { get; set; }
        public int MaSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }
}
