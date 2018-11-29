using AutoMapper;
using DrawIt.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawIt.Models
{
    public class WordMappingProfile : Profile 
    {
        public WordMappingProfile()
        {
            CreateMap<WordDto, Word>()
               .ForMember(dest => dest.wordEng, opt =>
               opt.MapFrom(dest => dest.wordEng))
               .ForMember(dest => dest.wordNl, opt =>
               opt.MapFrom(dest => dest.wordNl)).ReverseMap();
        }
    }
}
