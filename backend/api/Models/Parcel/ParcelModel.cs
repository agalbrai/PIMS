using System.Collections.Generic;

namespace Pims.Api.Models.Parcel
{
    public class ParcelModel : PropertyModel
    {
        #region Properties
        public string PID { get; set; }

        public int? PIN { get; set; }

        public float LandArea { get; set; }

        public string LandLegalDescription { get; set; }

        public string Municipality { get; set; }

        public string Zoning { get; set; }

        public string ZoningPotential { get; set; }

        public IEnumerable<ParcelEvaluationModel> Evaluations { get; set; } = new List<ParcelEvaluationModel>();

        public IEnumerable<ParcelBuildingModel> Buildings { get; set; } = new List<ParcelBuildingModel>();
        #endregion
    }
}
