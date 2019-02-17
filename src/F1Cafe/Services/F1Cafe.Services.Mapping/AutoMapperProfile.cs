using AutoMapper;
using F1Cafe.Data.Models;
using F1Cafe.Models.InputModels.Drivers;
using F1Cafe.Models.InputModels.Teams;
using F1Cafe.Models.ViewModels.Drivers;
using F1Cafe.Models.ViewModels.Races;
using F1Cafe.Models.ViewModels.Schedules;
using F1Cafe.Models.ViewModels.Teams;
using F1Cafe.Models.ViewModels.Tracks;
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

            //Races configuration
            this.CreateMap<Race, RaceViewModel>()
                .ForMember(dest => dest.Start, opt => opt.MapFrom(src => src.Schedule.Practice1Start))
                .ForMember(dest => dest.End, opt => opt.MapFrom(src => src.Schedule.RaceStart))
                .ForMember(dest => dest.RaceWeekend, opt => opt.Ignore());

            this.CreateMap<Race, RaceDetailsViewModel>()
                .ForMember(dest => dest.Start, opt => opt.MapFrom(src => src.Schedule.Practice1Start))
                .ForMember(dest => dest.End, opt => opt.MapFrom(src => src.Schedule.RaceStart))
                .ForMember(dest => dest.RaceWeekend, opt => opt.Ignore())
                .ForMember(dest => dest.ScheduleId, opt => opt.MapFrom(src => src.ScheduleId))
                .ForMember(dest => dest.TrackId, opt => opt.MapFrom(src => src.TrackId));

            //Schedules configuration
            this.CreateMap<Schedule, ScheduleViewModel>()
                .ForMember(dest => dest.Practice1Start, opt => opt.MapFrom(src => src.Practice1Start.ToString("dd MMM", CultureInfo.InvariantCulture).ToUpper()))
                .ForMember(dest => dest.Practice2Start, opt => opt.MapFrom(src => src.Practice2Start.ToString("dd MMM", CultureInfo.InvariantCulture).ToUpper()))
                .ForMember(dest => dest.Practice3Start, opt => opt.MapFrom(src => src.Practice3Start.ToString("dd MMM", CultureInfo.InvariantCulture).ToUpper()))
                .ForMember(dest => dest.QualifyingStart, opt => opt.MapFrom(src => src.QualifyingStart.ToString("dd MMM", CultureInfo.InvariantCulture).ToUpper()))
                .ForMember(dest => dest.RaceStart, opt => opt.MapFrom(src => src.RaceStart.ToString("dd MMM", CultureInfo.InvariantCulture).ToUpper()));

            //Tracks configuration
            this.CreateMap<Track, TrackDetailsViewModel>()
                .ForMember(dest => dest.TrackRecord, opt => opt.MapFrom(src => src.TrackRecord.Value.ToString("mm:ss")))
                .ForMember(dest => dest.NumberOfLaps, opt => opt.Ignore());
        }
    }
}
