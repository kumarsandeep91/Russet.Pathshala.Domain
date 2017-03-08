using PathShala.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathShala.Domain
{
    public class AreaServed : DomainObject
    {
        /// <summary>
        /// Gets or sets the name of the service area.
        /// </summary>
        /// <value>
        /// the service area name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the service area.
        /// </summary>
        /// <value>
        /// the description of the service area.
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
                return Validate<AreaServed>();
            }
        }

        #region navigation properties
        public virtual IList<Organization> Organizations { get; set; }
        #endregion
    }
}
