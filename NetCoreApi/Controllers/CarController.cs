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
    }
}