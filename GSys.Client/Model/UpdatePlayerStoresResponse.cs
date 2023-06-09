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
    /// UpdatePlayerStoresResponse
    /// </summary>
    [DataContract(Name = "UpdatePlayerStoresResponse")]
    public partial class UpdatePlayerStoresResponse : IEquatable<UpdatePlayerStoresResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePlayerStoresResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePlayerStoresResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePlayerStoresResponse" /> class.
        /// </summary>
        /// <param name="stores">stores (required).</param>
        public UpdatePlayerStoresResponse(Dictionary<string, UpdatePlayerStoresResponseStore> stores = default(Dictionary<string, UpdatePlayerStoresResponseStore>))
        {
            // to ensure "stores" is required (not null)
            if (stores == null)
            {
                throw new ArgumentNullException("stores is a required property for UpdatePlayerStoresResponse and cannot be null");
            }
            this.Stores = stores;
        }

        /// <summary>
        /// Gets or Sets Stores
        /// </summary>
        [DataMember(Name = "stores", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, UpdatePlayerStoresResponseStore> Stores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdatePlayerStoresResponse {\n");
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
            return this.Equals(input as UpdatePlayerStoresResponse);
        }

        /// <summary>
        /// Returns true if UpdatePlayerStoresResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePlayerStoresResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePlayerStoresResponse input)
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
