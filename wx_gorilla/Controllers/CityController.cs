using com.wechat.gorilla.DbContexts;
using com.wechat.gorilla.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase {
        private CityContext _cityContext;
        public CityController(CityContext cityContext) {
            this._cityContext = cityContext;
        }
        [HttpGet]
        public IList<City> Get(int province_id) {
            IList<City> result = null;
            if (province_id > 0) {
                result = _cityContext.City.Where(A => A.fk_province_id == province_id).ToList();
            } else {
                result = new List<City>();
            }

            return result;
            
        }
    }
}
