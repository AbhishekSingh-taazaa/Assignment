using AutoMapper;
using PraticeApiForDStore.Entities;
using PraticeApiForDStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.ProfileClass
{
    public class ProductPriceProfile : Profile
    {
        public ProductPriceProfile()
        {
            this.CreateMap<ProductPrice, ProductPriceModel>().ReverseMap();
        }
    }
}
