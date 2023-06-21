using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AutoMapper;

namespace NiN3.Core.Models.DTOs.Profiles
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
        }
    }
}
