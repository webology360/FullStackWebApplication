using AutoMapper;
using MatrimonialApi.Models;
using MatrimonialApi.DBEntity;

namespace MatrimonialApi.Utilities
{
    /// <summary>
    /// Represents the AutoMapper profile for mapping between models and database entities.
    /// </summary>
    public class AutomapperProfileMapping : Profile
    {
        /// <summary>
        /// // Map from Entity to DTO.
        /// </summary>
        public AutomapperProfileMapping()
        {
            CreateMap<CreateAdmin, AdminDTO>();
            CreateMap<AdminDTO, CreateAdmin>();
            CreateMap<UserDTO, User>();
            CreateMap<User,UserDTO>();
        }
    }
}
