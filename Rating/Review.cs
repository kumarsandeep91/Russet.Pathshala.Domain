using PathShala.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathShala.Domain.Rating
{
    public class Review : DomainObject
    {
        /// <summary>
        /// Gets or sets the name or title of the review.
        /// </summary>
        /// <value>
        /// the name or title.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the review.
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
                return Validate<Review>();
            }
        }

        #region
        public virtual Rating ReviewRating { get; set; }
        #endregion
    }
}
