using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meetup.BL;
using Meetup.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Meetup.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //db in memory
            services.AddDbContext<MeetupDBContext>(opt => opt.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()),
                ServiceLifetime.Singleton, ServiceLifetime.Singleton);

            ConfigureBL.ConfigureServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                
            });

            var dbcontext = app.ApplicationServices.GetService<MeetupDBContext>();
            AddContextData(dbcontext);
        }

        private static void AddContextData(MeetupDBContext context)
        {
            string[] meetingsNames =new string[] {
                "ישיבת עבודה","פגישת מחזור","ישיבה שנתית","תכנון פרויקט  WEB חדש","הקמת צוותים חדשים","תכנון ראיונות עבודה","פגישה עסקית","ישיבה שבועית",
                "תדרוך מתכנתים","תדרוך חודשי","הקמת פרויקט חברתי","פגישה עם בנק הפועלים","הרמת כוסית","בדיקות אתר חדש","הקמת צוותים חדשים","דיון רב משתתפים","דיון על העלאת דרגה",
                "דיון על העלאת משכורות","תדרוך ראשי צוות","העברת מחשבים לאגף ב'","פגישה עם מעצב הפנים"};
            //participants
            List < Participant > participantList = new List<Participant>();
            participantList.Add(new Participant() { Id = 1, FirstName = "דוד", LastName = "כהן", Mobile = "0456789098", Email = "fff@gmail.com" });
            participantList.Add(new Participant() { Id = 2, FirstName = "משה", LastName = "לוי", Mobile = "0456789098", Email = "fff@gmail.com" });
            participantList.Add(new Participant() { Id = 3, FirstName = "חיים", LastName = "שוורץ", Mobile = "66666666777", Email = "jnjjj@gmail.com" });
            participantList.Add(new Participant() { Id = 4, FirstName = "יצחק", LastName = "וינר", Mobile = "898987966", Email = "vtvvgg@gmail.com" });
            participantList.Add(new Participant() { Id = 5, FirstName = "שרה", LastName = "זילבר", Mobile = "0456789098", Email = "yyuut@gmail.com" });
            participantList.Add(new Participant() { Id = 6, FirstName = "רבקה", LastName = "מוזס", Mobile = "66666666777", Email = "jnjjj@gmail.com" });
            participantList.Add(new Participant() { Id = 7, FirstName = "רחל", LastName = "ויזל", Mobile = "898987966", Email = "vtvvgg@gmail.com" });
            participantList.Add(new Participant() { Id = 8, FirstName = "לאה", LastName = "סגל", Mobile = "0456789098", Email = "yyuut@gmail.com" });

            //cities
            List<City> citiesList = new List<City>();
            citiesList.Add(new City() { Id = 1, Name = "ירושלים" });
            citiesList.Add(new City() { Id = 2, Name = "בני ברק" });
            citiesList.Add(new City() { Id = 3, Name = "תל אביב" });
            citiesList.Add(new City() { Id = 4, Name = "חיפה" });

           
            for (int i = 0,j=0,k=0,n = 0; i < 50; i++)
            {
                var meeting1 = new Meeting() { Id = i+1, Name = meetingsNames[n++], Date = DateTime.Now, City = citiesList[k], CityId = citiesList[k++].Id};
                meeting1.Participants.AddRange(participantList);
                meeting1.Participants.AddRange(participantList);
                meeting1.Participants.AddRange(participantList);
                meeting1.Participants.AddRange(participantList);
                j = j == 8 ? 0 : j;
                k = k == 4 ? 0 : k;
                n = n == meetingsNames.Length ? 0 : n;
                context.Meetings.Add(meeting1);
            }


          
            context.SaveChanges();

        }
    }
}
