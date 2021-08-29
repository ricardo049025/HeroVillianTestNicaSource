using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Domain.Domain.Interfaces;
using Domain.Model;
using System.Net.Http.Headers;
using RestSharp;
using Newtonsoft.Json;
using Application.Main.Helpers;
using Domain.Domain.Enums;

namespace Application.Main.Services
{

    
    /// <summary>
    /// Ricardo Martinez
    /// Class for call external web api
    /// </summary>
    public class SuperHeroVillianApiService : ISuperHeroVillianApiService
    {
        #region Properties of the class

        private readonly RestClient client;
        private string _url { set; get; }

        #endregion

        #region Constructor 
        public SuperHeroVillianApiService(string url)
        {
            this._url = url;            

            client = new RestClient(this._url);
        }

        #endregion

        #region Methods
        /// <summary>
        /// Method for return a super heroe or villian 
        /// by the name
        /// </summary>
        /// <param name="name">Name of villian or hero to search</param>
        /// <returns></returns>
        public Response getByName(string name)
        {
            var request = new RestRequest(String.Format("search/{0}",name), Method.GET);            
            string queryResult = client.Execute<string>(request).Data;
            return  HelperUtility<Response>.convertJsonToObject(queryResult);                      
            
        }

        /// <summary>
        /// Method for return a villian or super heroe
        /// by the id
        /// </summary>
        /// <param name="id">Id of the super hero or villian</param>
        /// <returns></returns>
        public Results getById(int id)
        {
            var request = new RestRequest(String.Format("{0}",id), Method.GET);
            string queryResult = client.Execute<string>(request).Data;
            return HelperUtility<Results>.convertJsonToObject(queryResult);
        }

        #endregion
    }
}
