using Meetup.DAL.Interfaces;
using Meetup.DAL.Services;
using Meetup.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meetup.DAL
{
    public class ConfigureDAL
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            
            //dal services
            services.AddSingleton<IMeetingDAL, MeetingDAL>();
            services.AddSingleton<IOptionDAL, OptionDAL>();
        }

       
    }
}
