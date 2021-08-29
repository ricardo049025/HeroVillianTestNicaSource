using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Main.Bussiness;
using Application.Main.Services;
using System.Configuration;
using HeroVillianApplication.Models;
using Domain.Domain.Interfaces;
using Domain.Model;

namespace HeroVillianApplication.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        private string endpoint = ConfigurationManager.AppSettings["endpoint"];
        private readonly IHeroVillianBL service;
        private readonly ISuperHeroVillianApiService heroBl; 

        public HomeController()
        {
            heroBl = new SuperHeroVillianApiService(endpoint);
            service = new HeroVillianBL(heroBl);
            
        }

        public ActionResult Index(string name)
        {
            try
            {
                var dto =  service.getByName(name);
                SuperPerson spdto = new SuperPerson("success",dto);                
                ViewBag.Message = String.Format("Results ({0}):", dto.Count.ToString());
                return View(spdto);
            }
            catch (Exception ex)
            {
                SuperPerson spdto = new SuperPerson("error", new List<Domain.Domain.DTO.SuperPersonDTO>());
                ViewBag.Message = String.Format("Results ({0}): {1}", 0, ex.Message.ToString());                
                return View(spdto);
            }
            
        }

        public ActionResult Details(int id)
        {
            try
            {

                Results result = service.getById(id);
                DetailPerson spdto = new DetailPerson("success", result);                

                return View(spdto);
            }
            catch (Exception)
            {
                return RedirectToAction("PageNotFound", "Error");
            }

        }

    }
}