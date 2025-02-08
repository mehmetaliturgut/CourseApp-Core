using AutoMapper;
using Free.Course.Services.Catalog.Dtos;
using Free.Course.Services.Catalog.Models;


namespace Free.Course.Services.Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping() 
        {
            CreateMap<Free.Course.Services.Catalog.Models.Course,CourseDto>().ReverseMap();
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<Feature,FeatureDto>().ReverseMap();

            CreateMap<Free.Course.Services.Catalog.Models.Course, CourseCreateDto>().ReverseMap();
            CreateMap<Free.Course.Services.Catalog.Models.Course, CourseUpdateDto>().ReverseMap();
        }

    }
}
