using AutoMapper;

namespace DH.Simplify.API.AutoMapper
{
    /// <summary>
    /// AutoMapper Configuration
    /// </summary>
    public class AutoMapperConfiguration
    {
        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            return config;
        }
    }
}
