using AutoMapper;
using PraticeApiForDStore.Entities;
using PraticeApiForDStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.ProfileClass
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product, ProductModel>().ForMember(x => x.Category_Name, o => o.MapFrom(x=> x.ProductCategory.Category_Name)).ReverseMap();
            this.CreateMap<ProductPrice, ProductPriceModel>().ReverseMap();
            this.CreateMap<Inventory, InventoryModel>();
            
        }
    }
}
