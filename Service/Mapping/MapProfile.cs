using AutoMapper;
using Core.DTOs;
using Core.Models;

namespace Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Address, AddressWithBusinessDto>().ReverseMap();
            CreateMap<Business, BusinessDto>().ReverseMap();
            CreateMap<Business, BusinessWithAddressDto>().ReverseMap();
            CreateMap<Business, BusinessWithProductsDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryWithProductsDto>().ReverseMap();
            CreateMap<Disease, DiseaseDto>().ReverseMap();
            CreateMap<Disease,DiseaseWithIndividualDto>().ReverseMap();
            CreateMap<Disease, DiseaseWithProductsDto>().ReverseMap();
            CreateMap<Individual, IndividualDto>().ReverseMap();
            CreateMap<Individual, IndividualWithDiseasesDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductWithBusinessesDto>().ReverseMap();
            CreateMap<Product, ProductWithComponentsDto>().ReverseMap();
            CreateMap<Product, ProductWithDiseasesDto>().ReverseMap();
            CreateMap<Product, ProductWithCategoriesDto>().ReverseMap();
        }
    }
}
