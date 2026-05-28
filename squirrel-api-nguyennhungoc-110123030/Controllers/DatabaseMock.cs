namespace squirrel_api_nguyennhungoc_110123030.Models
{
    public static class DatabaseMock
    {
        // Danh sách này đóng vai trò như một bảng trong CSDL
        public static List<Transaction> Transactions = new List<Transaction>
        {
            new Transaction { Id = 1, SoTaiKhoan = "1023456789", SoTien = 500000, LoaiGiaoDich = "Nap tien" },
            new Transaction { Id = 2, SoTaiKhoan = "1098765432", SoTien = 100000, LoaiGiaoDich = "Rut tien" },
            new Transaction { Id = 3, SoTaiKhoan = "1098765432", SoTien = 1000000, LoaiGiaoDich = "Nap tien" },
            new Transaction { Id = 4, SoTaiKhoan = "1055566677", SoTien = 200000, LoaiGiaoDich = "Rut tien" },
            new Transaction { Id = 5, SoTaiKhoan = "1055566677", SoTien = 300000, LoaiGiaoDich = "Nap tien" }
        };
    }
}