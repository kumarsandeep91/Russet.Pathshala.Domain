using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using PathShala.Domain.Achievements;
using PathShala.Domain.Communication;
using PathShala.Domain.Departments;
using PathShala.Domain.Employees;
using PathShala.Domain.Events;
using PathShala.Domain.Founders;
using PathShala.Domain.Funders;
using PathShala.Domain.Location;
using PathShala.Domain.Rating;
using System;
using System.Collections.Generic;

namespace PathShala.Domain.Base
{
    public class Organization : DomainObject
    {
        ///<summary>
        /// Gets or sets the name of the organization.
        ///</summary>
        ///<value>
        /// The name of the organization.
        ///</value>
        [NotNullValidator(ErrorMessage = "The Name can't be null or empty.")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the date that this organization was dissolved.
        /// </summary>
        /// <value>
        /// The dissolution date.
        /// </value>
        public DateTime? DissolutionDate { get; set; }

        /// <summary>
        /// Gets or sets The date that this organization was founded.
        /// </summary>
        /// <value>
        /// the founding date.
        /// </value>
        public DateTime? FoundingDate { get; set; }

        /// <summary>
        /// Gets or sets The official name of the organization, e.g. the registered company name.
        /// </summary>
        /// <value>
        /// the legal name.
        /// </value>
        public string LegalName { get; set; }

        /// <summary>
        /// Gets or sets An organization identifier that uniquely identifies a legal entity. e.g Reg. no etc.
        /// </summary>
        /// <value>
        /// the legal code.
        /// </value>
        public string LegalCode { get; set; }

        /// <summary>
        /// Gets or sets the Logo(image) of the organization.
        /// </summary>
        /// Ref: http://stackoverflow.com/questions/25400555/save-and-retrieve-image-binary-from-sql-server-using-entity-framework-6
        public byte[] Logo { get; set; }

        /// <summary>
        /// Gets or sets the name of the parent organization.
        /// </summary>
        /// <value>
        /// the name of parent organization.
        /// </value>
        public string ParentOrganization { get; set; }


        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Organization>();
            }
        }

        #region navigation properties
        public virtual Place FoundingLocation { get; set; }
        public virtual OrganizationType OrganizationType { get; set; }
        public virtual IList<Address> Addresses { get; set; }
        public virtual IList<Contact> Contacts { get; set; }
        public virtual IList<AreaServed> AreasServed { get; set; }
        public virtual IList<Award> Awards { get; set; }
        public virtual IList<Department> Departments { get; set; }
        public virtual IList<Employee> Employees { get; set; }
        public virtual IList<Event> Events { get; set; }
        public virtual IList<Founder> Founders { get; set; }
        public virtual IList<Funder> Funders { get; set; }
        public virtual IList<Review> Reviews { get; set; }
        #endregion
    }
}
