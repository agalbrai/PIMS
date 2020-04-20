using Mapster;
using Model = Pims.Api.Areas.Admin.Models.Parcel;
using Entity = Pims.Dal.Entities;

namespace Pims.Api.Areas.Admin.Mapping.Parcel
{
    public class PartialBuildingMap : IRegister
    {

        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Entity.Building, Model.PartialBuildingModel>()
                .IgnoreNonMapped(true)
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.LocalId, src => src.LocalId)
                .Map(dest => dest.Description, src => src.Description)
                .Map(dest => dest.Latitude, src => src.Latitude)
                .Map(dest => dest.Longitude, src => src.Longitude)
                .Inherits<Entity.BaseEntity, Api.Models.BaseModel>();
        }
    }
}