using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakaleApi.Models;
using MakaleApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MakaleApi.Services.MongoRepository;

namespace MakaleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakalelerController : BaseMongoController<Makale>
    {
        public MakalelerController(MakaleService makale) : base(makale)
        {
        }
    }
}