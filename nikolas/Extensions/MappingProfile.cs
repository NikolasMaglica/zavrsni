using AutoMapper;
using nikolas.Entities.DTO;
using nikolas.Entities.Models;

namespace nikolas.Extensions
{
    public class Imapper : Profile
    {
        public Imapper()
        {
            CreateMap<Vehicle_Type, Vehicle_TypeDto>();
            CreateMap<Vehicle, VehicleDto>();
            CreateMap<Vehicle_TypeCreation, Vehicle_Type>();
            CreateMap<Vehicle_TypeUpdate, Vehicle_Type>();
            CreateMap<User, UserDto>();
            CreateMap<UserCreation, User>();
            CreateMap<Order_MaterialForCreation, Order_Material>();
            CreateMap<Material_OfferCreation, Material_Offer>();
            CreateMap<Service_OfferCreation, Service_Offer>();

            CreateMap<OrderCreation, Order>();

            CreateMap<ServiceCreation, Service>();

            CreateMap<ClientCreation, Client>();

            CreateMap<Offer_StatusCreation, Offer_Status>();

            CreateMap<VehicleCreation, Vehicle>();
            CreateMap<VehicleDto, Vehicle>();
            CreateMap<Order_StatusForCreationDto, Order_Status>();
            CreateMap<Order_MaterialForCreation, Order_Material>();
            CreateMap<MaterialForCreation, Material>();
            CreateMap<Order_Material, Order_MaterialDto>();
            CreateMap<Order_MaterialUpdate, Order_Material>();
            CreateMap<OfferForCreation, Offer>();
            CreateMap<Offer, OfferDto>();
            CreateMap<OfferUpdate, Offer>();
            CreateMap<UserUpdate, User>();
            CreateMap<Material_Offer, Material_OfferDto>();
            CreateMap<Service_Offer, Service_OfferDto>();



        }
    }
}