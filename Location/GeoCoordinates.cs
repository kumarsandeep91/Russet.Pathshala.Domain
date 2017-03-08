using PathShala.Domain.Base;

namespace PathShala.Domain.Location
{
    public class GeoCoordinates : DomainObject
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<GeoCoordinates>();
            }
        }

        #region navigation properties

        #endregion
    }
}
