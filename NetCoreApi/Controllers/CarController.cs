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

    [Route("api/Car")]
    public class CarController : Controller
    {
        public List<Car> CarList;

        public CarController()
        {
            CarList = new List<Car>();

            CarList.Add(new Car() { Id = 0, Brand = "Mercedes", Model = "SLS AMG", Price = 450000, HorsePower = 400, nbSeats = 2 });
            CarList.Add(new Car() { Id = 1, Brand = "Ford", Model = "Galaxy", Price = 75000, HorsePower = 250, nbSeats = 7 });
            CarList.Add(new Car() { Id = 2, Brand = "Renault", Model = "Laguna", Price = 25000, HorsePower = 200, nbSeats = 5 });
            CarList.Add(new Car() { Id = 3, Brand = "Fiat", Model = "Punto", Price = 20000, HorsePower = 200, nbSeats = 5 });
            CarList.Add(new Car() { Id = 4, Brand = "Audi", Model = "R8", Price = 200000, HorsePower = 400, nbSeats = 2 });
            CarList.Add(new Car() { Id = 5, Brand = "BMW", Model = "Serie 1", Price = 100000, HorsePower = 300, nbSeats = 5 });
            CarList.Add(new Car() { Id = 6, Brand = "Wolkswagen", Model = "Passat", Price = 80000, HorsePower = 300, nbSeats = 5 });
        }

        [HttpGet]
        [Route("")]
        public List<Car> GetAll()
        {
            return CarList;
        }

        [HttpGet]
        [Route("{id:int}")]
        public Car GetById(int id)
        {
            var element = CarList.Where(e => e.Id == id).FirstOrDefault();
            return element;
        }

        [HttpPut]
        [Route("{id:int}")]
        public void Update(Car car)
        {
            CarList.Select(c => { c = car ; return c; }).ToList();
            return ;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public bool Delete(int id)
        {
            try
            {
                CarList.RemoveAt(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}