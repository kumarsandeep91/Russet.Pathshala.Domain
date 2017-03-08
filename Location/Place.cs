using PathShala.Domain.Base;
using PathShala.Domain.Communication;
using PathShala.Domain.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathShala.Domain.Location
{
    public class Place : DomainObject
    {
        /// <summary>
        /// Gets or sets the name of the place.
        /// </summary>
        /// <value>
        /// the name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the place.
        /// </summary>
        /// <value>
        /// the description.
        /// </value>
        public string Description { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Place>();
            }
        }

        #region navigation properties
        public virtual IList<Rating.Rating> Ratings { get; set; }
        public virtual IList<Review> Reviews { get; set; }
        public virtual Address Address { get; set; }
        public virtual IList<Contact> Contacts { get; set; }
        public virtual GeoCoordinates GeoCoordinates { get; set; }
        #endregion
    }
}
