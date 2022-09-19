namespace MyWebProject.Infrastructure
{
    using Microsoft.EntityFrameworkCore;

    using MyWebProject.Infrastructure.Data;
    using MyWebProject.Infrastructure.Data.Models;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {

          using var scopedServices = app.ApplicationServices.CreateScope();

          var data = scopedServices.ServiceProvider.GetService<ApplicationDbContext>();

          data.Database.Migrate();

          SeedModels(data);

          return app;
            // app.ApplicationServices.GetService<ApplicationDbContext>()


           
        }

        private static void SeedModels(ApplicationDbContext data)
        {
            if (data.PhoneModels.Any())
            {
                return;
            }
            data.PhoneModels.AddRange(new[]
                                          {
                                              new PhoneModel{Model = "Apple"},
                                              new PhoneModel{Model = "Samsung"},
                                              new PhoneModel{Model = "Huawei"},
                                              new PhoneModel{Model = "Xiaomi."},
                                              new PhoneModel{Model = "Oppo"},
                                              new PhoneModel{Model = "Vivo."},
                                              new PhoneModel{Model = "Realme"},
                                              new PhoneModel{Model = "Motorola"},
                                              new PhoneModel{Model = "Honor"}
                                          });
            data.SaveChanges();
        }
    }
}
