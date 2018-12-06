using AutoMapper;
using F1Cafe.Web.Data;

namespace F1Cafe.Services
{
    public abstract class BaseService
    {
        protected BaseService(
            F1CafeDbContext dbContext,
            IMapper mapper)
        {
            this.DbContext = dbContext;
            this.Mapper = mapper;
        }

        public F1CafeDbContext DbContext { get; private set; }

        public IMapper Mapper { get; private set; }
    }
}
