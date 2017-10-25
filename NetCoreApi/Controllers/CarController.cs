using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace NetCoreApi.Controllers
{
    public class Car
    {
        [JsonProperty(PropertyName="id")]
        public int Id;

        [JsonProperty(PropertyName="brand")]
        public string Brand;

        [JsonProperty(PropertyName="model")]
        public string Model;

        [JsonProperty(PropertyName="horsePower")]
        public int HorsePower;

        [JsonProperty(PropertyName="price")]
        public int Price;

        [JsonProperty(PropertyName="nbSeats")]
        public int nbSeats;
    }

    public class CarController : Controller
    {
        public List<Car> _carList;

        public CarController()
        {
            _carList = new List<Car>();
            _carList.Add(new Car() { Id = 0, Brand = "Mercedes", Model = "SLS AMG", Price = 450000, HorsePower = 400, nbSeats = 2 });
            _carList.Add(new Car() { Id = 0, Brand = "Ford", Model = "Galaxy", Price = 75000, HorsePower = 250, nbSeats = 7 });
            _carList.Add(new Car() { Id = 0, Brand = "Renault", Model = "Laguna", Price = 25000, HorsePower = 200, nbSeats = 5 });
            _carList.Add(new Car() { Id = 0, Brand = "Fiat", Model = "Punto", Price = 20000, HorsePower = 200, nbSeats = 5 });
            _carList.Add(new Car() { Id = 0, Brand = "Audi", Model = "R8", Price = 200000, HorsePower = 400, nbSeats = 2 });
            _carList.Add(new Car() { Id = 0, Brand = "BMW", Model = "Serie 1", Price = 100000, HorsePower = 300, nbSeats = 5 });
            _carList.Add(new Car() { Id = 0, Brand = "Wolkswagen", Model = "Passat", Price = 80000, HorsePower = 300, nbSeats = 5 });
        }


        // GET: Car/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Car/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Car/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Car/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Car/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Car/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}