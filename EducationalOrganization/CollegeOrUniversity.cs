using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathShala.Domain.EducationalOrganization
{
    public class CollegeOrUniversity : EducationalOrganization
    {
        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<CollegeOrUniversity>();
            }
        }
    }
}
