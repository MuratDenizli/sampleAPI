using AutoMapper;
using sampleAPI.Dtos.Character;

namespace sampleAPI
{
    public class AutoMapperProfile:Profile 
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto>();
            CreateMap<AddCharacterDto,Character>();
        }
    }
}