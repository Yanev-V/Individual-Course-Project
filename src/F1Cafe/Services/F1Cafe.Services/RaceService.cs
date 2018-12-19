using AutoMapper;
using F1Cafe.Services.Contracts;
using F1Cafe.Web.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace F1Cafe.Services
{
    public class RaceService : BaseService, IRaceService
    {
        public RaceService(F1CafeDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }
    }
}
