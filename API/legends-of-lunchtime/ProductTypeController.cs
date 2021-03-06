﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ErrorReaper.Api.Filters;

namespace LegendsOfLunchtime.Api
{
    public class ProductTypeController : ApiController
    {
        [HttpGet]
        [Route("legends-of-lunchtime/product-types")]
        [UnhandledExceptionFilter]
        public IEnumerable<DataTransferObjects.ProductType> GetAll()
        {
            return new Managers.ProductTypeManager().GetAll();
        }

        [HttpPost]
        [Route("legends-of-lunchtime/product-type")]
        [Authorize]
        public DataTransferObjects.ProductType Post(DataTransferObjects.ProductType productType)
        {
            return new Managers.ProductTypeManager().Create(productType);
        }

        [HttpPut]
        [Route("legends-of-lunchtime/product-type")]
        [Authorize]
        public DataTransferObjects.ProductType Put(DataTransferObjects.ProductType productType)
        {
            return new Managers.ProductTypeManager().Update(productType);
        }

        [HttpDelete]
        [Route("legends-of-lunchtime/product-type/{id}")]
        [Authorize]
        public void Delete(Guid id)
        {
            new Managers.ProductTypeManager().Delete(id);
        }
    }
}
