using AutoMapper;
using Business.Dtos.Model;
using Business.Request.Model;
using Business.Responses.Model;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class ModelMapperProfiles : Profile
    {
        public ModelMapperProfiles()
        {
            CreateMap<AddModelRequest, Model>();
            CreateMap<Model, AddModelResponse>();
            CreateMap<Model, ModelListItemDto>();
            CreateMap<List<Model>, GetModelListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));
        }
    }
}
