using HOANGQUANGTRUONG_PH53664.Models;
using Microsoft.EntityFrameworkCore;

namespace HOANGQUANGTRUONG_PH53664.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
