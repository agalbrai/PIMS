using Mapster;
using Model = Pims.Api.Models.Parcel;
using Entity = Pims.Dal.Entities;
using System;

namespace Pims.Api.Mapping.Parcel
{
    public class BuildingEvaluationMap : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Entity.BuildingEvaluation, Model.BuildingEvaluationModel>()
                .IgnoreNonMapped(true)
                .EnumMappingStrategy(EnumMappingStrategy.ByName)
                .Map(dest => dest.BuildingId, src => src.BuildingId)
                .Map(dest => dest.Date, src => src.Date)
                .Map(dest => dest.Key, src => src.Key)
                .Map(dest => dest.Value, src => src.Value)
                .Map(dest => dest.Note, src => src.Note)
                .Inherits<Entity.BaseEntity, Models.BaseModel>();


            config.NewConfig<Model.BuildingEvaluationModel, Entity.BuildingEvaluation>()
                .IgnoreNonMapped(true)
                .EnumMappingStrategy(EnumMappingStrategy.ByName)
                .Map(dest => dest.BuildingId, src => src.BuildingId)
                .Map(dest => dest.Date, src => src.Date)
                .Map(dest => dest.Key, src => src.Key)
                .Map(dest => dest.Value, src => src.Value)
                .Map(dest => dest.Note, src => src.Note)
                .Inherits<Models.BaseModel, Entity.BaseEntity>();
        }
    }
}