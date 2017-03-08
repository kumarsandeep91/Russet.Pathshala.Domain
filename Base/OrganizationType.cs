using System.Collections.Generic;

namespace PathShala.Domain.Base
{
    public class OrganizationType : DomainObject
    {
        /// <summary>
        /// Gets or sets the name of the organization type.
        /// </summary>
        /// <value>
        /// the name of organization type.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the organization type.
        /// </summary>
        /// <value>
        /// the description of organization type.
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
                return Validate<OrganizationType>();
            }
        }

        #region navigation properties
        public virtual IList<Organization> Organizations { get; set; }
        #endregion
    }
}
