using Model = Pims.Api.Models;

namespace Pims.Api.Areas.Admin.Models.Parcel
{
    public class AddressModel : Model.BaseModel
    {
        #region Properties
        public int Id { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string AdministrativeArea { get; set; }

        public string ProvinceId { get; set; }

        public string Province { get; set; }

        public string Postal { get; set; }
        #endregion
    }
}
