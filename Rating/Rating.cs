using PathShala.Domain.Base;
using PathShala.Domain.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathShala.Domain.Rating
{
    public class Rating : DomainObject
    {
        /// <summary>
        /// Gets or sets the title/name of the rating.
        /// </summary>
        /// <value>
        /// the name or title.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the rating.
        /// </summary>
        /// <value>
        /// the description.
        /// </value>
        public string Description { get; set; }
        
        /// <summary>
        /// Gets or sets The highest value allowed in this rating system.
        /// </summary>
        /// <value>
        /// the best rating.
        /// </value>
        public int BestRating { get; set; }

        /// <summary>
        /// Gets or sets The rating for the content.
        /// </summary>
        /// <value>
        /// the rating value.
        /// </value>
        public int RatingValue { get; set; }

        /// <summary>
        /// Gets or sets The lowest value allowed in this rating system.
        /// </summary>
        /// <value>
        /// the lowest value
        /// </value>
        public int WorstRating { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Rating>();
            }
        }

        #region navigation properties
        public virtual Person Auther { get; set; }
        #endregion
    }
}
