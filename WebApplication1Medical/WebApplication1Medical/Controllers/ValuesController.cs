﻿using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using static ObjectBloodTest.ObjectBloodTest;

namespace WebApplication1Medical.Controllers
{
    public class ValuesController : ApiController
    {
        ConnectToDAL MedicalBL = new ConnectToDAL();
       
        // GET api/values
        [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
        [HttpGet]
        [Route("api/Medicals")]
        public IHttpActionResult GetMedical()
        {
            return Ok(MedicalBL.getMedicalsFromBL());
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        // Add             
        [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
        [HttpPost]
        [Route("api/Insert")]
        public IHttpActionResult Post([FromBody]ObjectCalculate value)
        {
            return Ok(MedicalBL.Calculate(value));
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
