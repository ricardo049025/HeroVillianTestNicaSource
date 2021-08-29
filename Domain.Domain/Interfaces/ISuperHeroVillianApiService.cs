using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Interfaces
{
    /// <summary>
    /// Interfaces for implement methods
    /// of the webapiSuperHeroandApiService
    /// </summary>
    public interface ISuperHeroVillianApiService
    {
        Response getByName(string name);
        Results getById(int id);
    }
}
