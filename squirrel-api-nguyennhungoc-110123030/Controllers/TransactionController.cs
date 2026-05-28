using Microsoft.AspNetCore.Mvc;
using squirrel_api_nguyennhungoc_110123030.Models;
using System.Collections.Generic;
using System.Linq;

namespace squirrel_api_nguyennhungoc_110123030.Controllers
{
    [Route("api/giaodich")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNapTienTransactions()
        {
            // Bước 3: Khởi tạo danh sách cứng gồm 5 dòng giao dịch mẫu
            var transactions = new List<Transaction>
            {
                new Transaction { Id = 1, SoTaiKhoan = "1023456789", SoTien = 500000, LoaiGiaoDich = "Nap tien" },
                new Transaction { Id = 2, SoTaiKhoan = "1023456789", SoTien = 200000, LoaiGiaoDich = "Rut tien" },
                new Transaction { Id = 3, SoTaiKhoan = "1098765432", SoTien = 1000000, LoaiGiaoDich = "Nap tien" },
                new Transaction { Id = 4, SoTaiKhoan = "1098765432", SoTien = 150000, LoaiGiaoDich = "Rut tien" },
                new Transaction { Id = 5, SoTaiKhoan = "1055566677", SoTien = 300000, LoaiGiaoDich = "Nap tien" }
            };

            // Bước 4: Sử dụng biểu thức LINQ để lọc điều kiện LoaiGiaoDich là "Nap tien"
            var napTienList = transactions.Where(t => t.LoaiGiaoDich == "Nap tien").ToList();

            // Trả về danh sách kết quả dưới dạng chuỗi JSON kèm HTTP Status Code 200 OK
            return Ok(napTienList);
        }
    }
}