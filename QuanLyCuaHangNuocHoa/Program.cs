using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
using DataModel;
using BusinessLogicLayer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
// Add services to the container.
builder.Services.AddTransient<IDatabaseHelper, DatabaseHelper>();
builder.Services.AddTransient<IKhachHang, DAL_KhachHang>();
builder.Services.AddTransient<IKhachHang_BLL, BLL_KhachHang>();
builder.Services.AddTransient<INhanVien, DAL_NhanVien>();
builder.Services.AddTransient<INhanVien_BLL, BLL_NhanVien>();
builder.Services.AddTransient<INhaCungCap, DAL_NhaCungCap>();
builder.Services.AddTransient<INhaCungCap_BLL, BLL_NhaCungCap>();
builder.Services.AddTransient<ITheLoai, DAL_TheLoai>();
builder.Services.AddTransient<ITheLoai_BLL, BLL_TheLoai>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
