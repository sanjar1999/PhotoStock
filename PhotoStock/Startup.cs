using DAL;
using DTOs.Services;
using Microsoft.EntityFrameworkCore;

namespace PhotoStock
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup( IConfiguration configuration )
        {
            Configuration = configuration;
        }
        public void ConfigureServices( IServiceCollection services )
        {
            services.AddControllers();
            services.AddDbContext<ApplicationContext>( opt =>
                   opt.UseSqlServer( Configuration.GetConnectionString( "DefaultConnection" ) ) );

            services.AddTransient<ITextServices, TextService>();
            services.AddTransient<IPhotoServices, PhotoServices>();
            services.AddTransient<IAuthorServices, AuthorServices>();
        }


        public void Configure( IApplicationBuilder app, IWebHostEnvironment env )
        {
            if ( env.IsDevelopment() )
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors( x => x
                .SetIsOriginAllowed( origin => true )
                .AllowAnyMethod()
                .AllowAnyHeader() );

            app.UseRouting();
            app.UseEndpoints( endpoints =>
            {
                endpoints.MapControllers();
            } );
        }
    }
}