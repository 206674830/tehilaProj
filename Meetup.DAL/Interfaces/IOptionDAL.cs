using Meetup.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meetup.DAL.Interfaces
{
    public interface IOptionDAL
    {
        List<City> GetCities();
    }
}
