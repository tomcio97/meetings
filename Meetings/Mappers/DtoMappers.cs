using AutoMapper;
using Meetings.Domain.Dtos;
using Meetings.Domain.Entities;

namespace Meetings.Mappers
{
    public class DtoMappers : Profile
    {
        public DtoMappers()
        {
            CreateMap<MeetingEntity, MeetingForListDto>();
            CreateMap<ParticipantEntity, ParticipantForListDto>();
            CreateMap<MeetingForCreatedDto, MeetingEntity>();
            CreateMap<ParticipantForCreatedDto, ParticipantEntity>();
        }
    }
}
