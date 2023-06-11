using Meetup.BL.Interfaces;
using Meetup.BL.Services;
using Meetup.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meetup.BL
{
    public class ConfigureBL
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            //BL services
            services.AddSingleton<IMeetingBL, MeetingBL>();
            services.AddSingleton<IOptionBL, OptionBL>();

            //DAL service
            ConfigureDAL.ConfigureServices(services);

        }
    }
}
