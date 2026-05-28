var builder = WebApplication.CreateBuilder(args);

// Đăng ký dịch vụ Controller (bắt buộc phải có để chạy được TransactionController)
builder.Services.AddControllers(); 

var app = builder.Build();

// Bỏ qua bước HTTPS Redirection để tránh lỗi port trên Codespace
// Map (định tuyến) các endpoint tới Controller của bạn
app.MapControllers(); 

app.Run();