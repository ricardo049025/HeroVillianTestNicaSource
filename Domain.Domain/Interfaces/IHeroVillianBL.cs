using Domain.Domain.DTO;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Interfaces
{
    /// <summary>
    /// Generic Interface
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <remarks>Autor: Ricardo Martinez</remarks>

    public interface IHeroVillianBL
    {
        List<SuperPersonDTO> getByName(string name);
        Results getById(int id);

    }
}
