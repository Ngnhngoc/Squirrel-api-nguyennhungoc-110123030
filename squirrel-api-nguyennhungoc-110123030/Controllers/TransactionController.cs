using Microsoft.AspNetCore.Mvc;
using squirrel_api_nguyennhungoc_110123030.Models; // Gọi đến thư mục Models

namespace squirrel_api_nguyennhungoc_110123030.Controllers
{
    [ApiController]
    [Route("api/giaodich")]
    public class TransactionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNapTien()
        {
            // Lấy dữ liệu từ DatabaseMock thay vì set cứng, sau đó dùng LINQ lọc "Nap tien"
            var ketQua = DatabaseMock.Transactions
                            .Where(t => t.LoaiGiaoDich == "Nap tien")
                            .ToList();

            return Ok(ketQua);
        }
    }
}