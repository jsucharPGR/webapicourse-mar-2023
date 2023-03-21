
using EmployeesApi.Domain;

namespace EmployeesApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // Startup ConfigureServices
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
<<<<<<< HEAD:EmployeesSolution/EmployeesApi/Program.cs

            builder.Services.AddScoped<DepartmentsLookup>();

=======
            builder.Services.AddScoped<DepartmentsLookup>();
>>>>>>> a685823a825ff9650b16a063c8fe0fe0426f92a1:instructor/EmployeesSolution/EmployeesApi/Program.cs
            var app = builder.Build();
            
            // Startup Configure
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}