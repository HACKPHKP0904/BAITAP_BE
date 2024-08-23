using Microsoft.Extensions.DependencyInjection;
using System;
using BE_07_24_DataAccess.DAL;
using BE_07_24_DataAccess.DALImpl;
using BE_07_24_DataAccess.DO;

namespace BE_07_24_ConsoleApp
{
    public class DependencyInjection
    {
        public void Dependency()
        {
            // Cấu hình DI
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Tạo service provider
            var serviceProvider = services.CreateBuilder();

            // Tạo scope
            using (var scope = serviceProvider.CreateScope())
            {
                var bookingService = scope.ServiceProvider.GetRequiredService<IBookingCreation>();
                var roomRepository = scope.ServiceProvider.GetRequiredService<IRoomRepository>();

                // Tạo phòng mới và thêm vào repository
                var room = new StandardRoom(101);
                roomRepository.UpdateRoom(room);

                // Tạo đặt phòng mới
                var booking = new Booking
                {
                    BookingId = 1,
                    CustomerName = "John Doe",
                    RoomNumber = 101,
                    CheckInDate = DateTime.Now,
                    CheckOutDate = DateTime.Now.AddDays(2)
                };

                try
                {
                    bookingService.CreateBooking(booking);
                    Console.WriteLine("Đặt phòng thành công.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Đăng ký các dịch vụ và interface
            services.AddScoped<IRoomRepository, RoomRepositoryService>();
            services.AddScoped<IBookingCreation, BookingService>();
            services.AddScoped<IBookingCancel, BookingService>();
            services.AddScoped<IBookingInfo, BookingService>();
        }
    }
}
