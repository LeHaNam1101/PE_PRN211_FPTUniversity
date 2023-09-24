namespace Question2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //register for services
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Instructor}/{action=List}"
                    );
            });
            // start your application
            app.Run();
        }
    }
}
