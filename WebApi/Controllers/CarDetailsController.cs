using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CarDetailsController : ApiController
    {
        // GET: api/CarDetails

            [HttpGet]
        public IEnumerable<CarStock> GetAllCarDetails()
        {
            CarStock ST = new CarStock();
            CarStock ST1 = new CarStock();
            List<CarStock> li = new List<CarStock>();

            ST.CarName = "Suzuki WaganoR";
            ST.CarPrice = "11 Lakh";
            ST.CarModel = "VXR";
            ST.CarColor = "Black";
            li.Add(ST);

            ST1.CarName = "Suzuki Swift";
            ST1.CarPrice = "14 Lakh";
            ST1.CarModel = "VXI";
            ST1.CarColor = "RED";

            li.Add(ST);
            li.Add(ST1);
            return li;
        }

        // GET: api/CarDetails/5
        public IEnumerable<CarStock> Get(int id)
        {
            CarStock ST = new CarStock();
            CarStock ST1 = new CarStock();
            List<CarStock> li = new List<CarStock>();
            if (id == 1)
            {
                ST.CarName = "Suzuki WaganoR";
                ST.CarPrice = "11 Lakh";
                ST.CarModel = "VXR";
                ST.CarColor = "Black";
                li.Add(ST);
            }
            else
            {
                ST1.CarName = "Suzuki Swift";
                ST1.CarPrice = "14 Lakh";
                ST1.CarModel = "VXI";
                ST1.CarColor = "RED";
                li.Add(ST1);
            }
            return li;
        }


        [HttpGet]
        public IEnumerable<CarsCategory> CarCategory()
        {
            CarsCategory CC = new CarsCategory();
            CarsCategory CC1 = new CarsCategory();
            List<CarsCategory> li = new List<CarsCategory>();

            CC.Category= "SUV";
            li.Add(CC);

            CC1.Category= "Sedan";
           
            li.Add(CC);
            li.Add(CC1);
            return li;
        }

        public IEnumerable<CarsBrands> CarBrand()
        {
            CarsBrands BR = new CarsBrands();
            CarsBrands  BR1 = new CarsBrands();
            List<CarsBrands> li = new List<CarsBrands>();

            BR.brandName= "Toyota";
            li.Add(BR);

            BR1.brandName= "Honda";

            li.Add(BR);
            li.Add(BR1);
            return li;
        }



        // POST: api/CarDetails
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CarDetails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CarDetails/5
        public void Delete(int id)
        {
        }
    }
}
