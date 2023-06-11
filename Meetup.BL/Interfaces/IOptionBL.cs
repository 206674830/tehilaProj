using Meetup.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meetup.BL.Interfaces
{
    public interface IOptionBL
    {
        List<City> GetCities();
    }
}
