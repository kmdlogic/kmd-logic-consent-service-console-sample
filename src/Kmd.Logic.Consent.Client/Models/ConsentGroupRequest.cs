// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Consent.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ConsentGroupRequest
    {
        /// <summary>
        /// Initializes a new instance of the ConsentGroupRequest class.
        /// </summary>
        public ConsentGroupRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConsentGroupRequest class.
        /// </summary>
        public ConsentGroupRequest(string name, string keyFormat = default(string), IList<string> scopes = default(IList<string>), IList<ConsentGroupMemberRequest> members = default(IList<ConsentGroupMemberRequest>))
        {
            Name = name;
            KeyFormat = keyFormat;
            Scopes = scopes;
            Members = members;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keyFormat")]
        public string KeyFormat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scopes")]
        public IList<string> Scopes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<ConsentGroupMemberRequest> Members { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Members != null)
            {
                foreach (var element in Members)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}