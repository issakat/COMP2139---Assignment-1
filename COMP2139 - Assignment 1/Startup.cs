using COMP2139___Assignment_1.Data;
using Microsoft.EntityFrameworkCore;

namespace COMP2139___Assignment_1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configure services, add dependencies, etc.
            services.AddDbContext<BookingDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        public void Configure(IApplicationBuilder app)
        {
            // Configure middleware, set up routing, etc.
        }


    }
}