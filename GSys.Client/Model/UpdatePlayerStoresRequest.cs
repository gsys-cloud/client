/*
 * api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = GSys.Client.Client.OpenAPIDateConverter;

namespace GSys.Client.Model
{
    /// <summary>
    /// UpdatePlayerStoresRequest
    /// </summary>
    [DataContract(Name = "UpdatePlayerStoresRequest")]
    public partial class UpdatePlayerStoresRequest : IEquatable<UpdatePlayerStoresRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePlayerStoresRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePlayerStoresRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePlayerStoresRequest" /> class.
        /// </summary>
        /// <param name="stores">stores (required).</param>
        public UpdatePlayerStoresRequest(Dictionary<string, UpdatePlayerStoresRequestStore> stores = default(Dictionary<string, UpdatePlayerStoresRequestStore>))
        {
            // to ensure "stores" is required (not null)
            if (stores == null)
            {
                throw new ArgumentNullException("stores is a required property for UpdatePlayerStoresRequest and cannot be null");
            }
            this.Stores = stores;
        }

        /// <summary>
        /// Gets or Sets Stores
        /// </summary>
        [DataMember(Name = "stores", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, UpdatePlayerStoresRequestStore> Stores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdatePlayerStoresRequest {\n");
            sb.Append("  Stores: ").Append(Stores).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePlayerStoresRequest);
        }

        /// <summary>
        /// Returns true if UpdatePlayerStoresRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePlayerStoresRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePlayerStoresRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Stores == input.Stores ||
                    this.Stores != null &&
                    input.Stores != null &&
                    this.Stores.SequenceEqual(input.Stores)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Stores != null)
                {
                    hashCode = (hashCode * 59) + this.Stores.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
