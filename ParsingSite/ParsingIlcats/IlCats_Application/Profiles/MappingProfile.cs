using AutoMapper;
using IlCats_Application.Features.CarModel.Models;
using IlCats_Domain.Entity.Car;
using System.Collections.Generic;

namespace IlCats_Application.Profiles
{
    public  class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ModelCar, ModelCar_Model>().ReverseMap();
        }
    }
}
