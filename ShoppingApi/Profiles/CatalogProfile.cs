using AutoMapper;
using Microsoft.Extensions.Configuration;
using ShoppingApi.Domain;
using ShoppingApi.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApi.Profiles
{
    public class CatalogProfile : Profile
    {
       

        public CatalogProfile(ConfigurationForMapper config)
        {
            // ShoppingItem -> GetCatalogResponseSummaryItem
            CreateMap<ShoppingItem, GetCatalogResponseSummaryItem>()
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => 
                src.Cost * 1.5M)); // TODO: Fix this.

            CreateMap<PostCatalogRequest, ShoppingItem>()
                .ForMember(dest => dest.InInventory, opt => opt.MapFrom(src => true));
        }
    }
}
