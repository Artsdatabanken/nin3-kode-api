using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AutoMapper;
using NiN3.Core.Models;
using NiN3.Core.Models.DTOs;
using NiN3.Core.Models.Enums;

namespace NiN3.Infrastructure.Mapping.Profiles
{
    //Løsning: automapper
    public class AllProfiles : Profile
    {
        public readonly MapperConfiguration _config;
        public AllProfiles() {
           // ex : // .ForMember(dest => dest.FullName, opt => opt.ResolveUsing(src => src.Name + " Monroe"))
            // q: example of automapper with custom mapping
            //CreateMap<Models.>
            // todo: se custom mappings: https://medium.com/knowledge-pills/how-to-use-automapper-in-c-6f949402be05
            //CreateMap<Versjon, VersjonDto>();
            CreateMap<Versjon, VersjonDto>();
            CreateMap<NiN3.Core.Models.Type, TypeDto>()
                .ForMember(dest => dest.Navn, opt => opt.MapFrom(src => EnumUtil.ToDescription(src.Ecosystnivaa)+" "+ 
                EnumUtil.ToDescription(src.Typekategori)+" "+
                EnumUtil.ToDescriptionBlankIfNull(src.Typekategori2)))
                .ForPath(dest => dest.Kode.Id, opt => opt.MapFrom(src => src.Kode));

            /*CreateMap<NiN3.Core.Models.Type, KodeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Kode));*/
        }
    }
}
