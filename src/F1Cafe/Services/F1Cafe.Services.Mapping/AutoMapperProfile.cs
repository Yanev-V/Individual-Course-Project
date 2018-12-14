using AutoMapper;
using F1Cafe.Data.Models;
using F1Cafe.Models.InputModels.Drivers;
using F1Cafe.Models.InputModels.Teams;
using F1Cafe.Models.ViewModels.Drivers;
using F1Cafe.Models.ViewModels.Teams;
using System.Globalization;
using System.Linq;

namespace F1Cafe.Services.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Teams configuration
            this.CreateMap<CreateTeamInputModel, Team>();

            this.CreateMap<Team, TeamViewModel>()
                .ForMember(dest => dest.FirstDriverName, opt => opt.Ignore())
                .ForMember(dest => dest.SecondDriverName, opt => opt.Ignore());

            this.CreateMap<Team, TeamDetailsViewModel>()
                .ForMember(dest => dest.FirstDriver, opt => opt.MapFrom(src => src.Drivers.ElementAt(src.Drivers.Count() - 2)))
                .ForMember(dest => dest.SecondDriver, opt => opt.MapFrom(src => src.Drivers.ElementAt(src.Drivers.Count() - 1)))
                .ForMember(dest => dest.Car, opt => opt.MapFrom(src => src.Cars.ElementAt(src.Drivers.Count() - 1)));

            //Drivers configuration
            this.CreateMap<CreateDriverInputModel, Driver>();

            this.CreateMap<Driver, DriverViewModel>()
                .ForMember(dest => dest.TeamName, opt => opt.MapFrom(src => src.Team.Name));

            this.CreateMap<Driver, DriverDetailsViewModel>()
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)))
                .ForMember(dest => dest.TeamName, opt => opt.MapFrom(src => src.Team.Name));
        }
    }
}
