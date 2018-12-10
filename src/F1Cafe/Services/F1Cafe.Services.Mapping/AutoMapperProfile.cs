using AutoMapper;
using F1Cafe.Data.Models;
using F1Cafe.Models.InputModels.Drivers;
using F1Cafe.Models.InputModels.Teams;
using F1Cafe.Models.ViewModels.Drivers;
using F1Cafe.Models.ViewModels.Teams;

namespace F1Cafe.Services.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<CreateTeamInputModel, Team>();
            this.CreateMap<Team, TeamViewModel>();

            this.CreateMap<CreateDriverInputModel, Driver>();
            this.CreateMap<Driver, DriverViewModel>()
                .ForMember(dest => dest.TeamName, opt => opt.MapFrom(src => src.Team.Name));
        }
    }
}
