using MainSite.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MainSite.Models.DataContext
{
    static public class SeedData
    {
        static public void Initial(this IApplicationBuilder builder)
        {
            using (var scope = builder.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<HEZZALDBContext>();

                InitialSetting(db);
            }
        }
        private static void InitialSetting(HEZZALDBContext db)
        {
            if (!db.Settings.Any())
            {
                db.Settings.Add(new Setting
                {
                    Slogan = "Qulağınız cana gəlsin!",
                    Address = "Koroğlu Rəhimov 22",
                    Email = "info@hezz.al",
                    PhoneNumber = "+994557505358",
                    Facebook = "gurbanov",
                    Twitter = "gurbanlee",
                    Instagram = "gurbanlee"
                });
                db.SaveChanges();
            }
        }
    }
}
