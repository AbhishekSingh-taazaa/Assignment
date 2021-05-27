using AutoMapper;
using PraticeApiForDStore.Entities;
using PraticeApiForDStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.ProfileClass
{
    public class StaffProfile : Profile
    {
        public StaffProfile()
        {
            this.CreateMap<Staff, StaffModel>().ReverseMap();
            
            //.ForMember(x => x.AddressLine1, o => o.MapFrom(x => x.Address.AddressLine1))
            //    .ForMember(x => x.City, o => o.MapFrom(x => x.Address.City)).ReverseMap();

            this.CreateMap<Address, AddressModel>().ReverseMap();
            
            this.CreateMap<Role, RoleModel>().ReverseMap();
        }
    }
}
