using Domain.Domain.DTO;
using Domain.Domain.Enums;
using Domain.Domain.Interfaces;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Main.Bussiness
{
    /// <summary>
    /// Ricardo Martinez.
    /// Bussiness Logic of the HeroVillian class
    /// </summary>
    public class HeroVillianBL : IHeroVillianBL
    {
        protected ISuperHeroVillianApiService _service;
        public HeroVillianBL(ISuperHeroVillianApiService service)
        {
            this._service = service;
        }

        /// <summary>
        /// Method for return the DTO 
        /// with the information of super person
        /// </summary>
        /// <param name="name">name of the super person</param>
        /// <returns></returns>
        public List<SuperPersonDTO> getByName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new Exception(string.Empty);

            var list = _service.getByName(name);            
            if (list.response == StatusEnum.error.ToString()) throw new Exception(list.error);
            return list.results.Select(s => new SuperPersonDTO { id = s.id, image = s.image.url, name = s.name, gender=s.appearance.gender, publisher=s.biography.publisher, fullname=s.biography.fullname }).ToList();
        }

        /// <summary>
        /// Method for return the Details of
        /// a super person
        /// </summary>
        /// <param name="id">id of the super person</param>
        /// <returns></returns>
        public Results getById(int id)
        {
            var list = _service.getById(id);
            if (list.response == StatusEnum.error.ToString()) throw new Exception(list.error);
            return list;
        }
    }
}
