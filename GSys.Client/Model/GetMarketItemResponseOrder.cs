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
    /// GetMarketItemResponseOrder
    /// </summary>
    [DataContract(Name = "GetMarketItemResponseOrder")]
    public partial class GetMarketItemResponseOrder : IEquatable<GetMarketItemResponseOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMarketItemResponseOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetMarketItemResponseOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMarketItemResponseOrder" /> class.
        /// </summary>
        /// <param name="owner">owner (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="quantity">quantity (required).</param>
        public GetMarketItemResponseOrder(string owner = default(string), long price = default(long), long quantity = default(long))
        {
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new ArgumentNullException("owner is a required property for GetMarketItemResponseOrder and cannot be null");
            }
            this.Owner = owner;
            this.Price = price;
            this.Quantity = quantity;
        }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", IsRequired = true, EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = true)]
        public long Price { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public long Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetMarketItemResponseOrder {\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as GetMarketItemResponseOrder);
        }

        /// <summary>
        /// Returns true if GetMarketItemResponseOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of GetMarketItemResponseOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMarketItemResponseOrder input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
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
                if (this.Owner != null)
                {
                    hashCode = (hashCode * 59) + this.Owner.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Price.GetHashCode();
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
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
            // Price (long) minimum
            if (this.Price < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Price, must be a value greater than or equal to 0.", new [] { "Price" });
            }

            // Quantity (long) minimum
            if (this.Quantity < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 0.", new [] { "Quantity" });
            }

            yield break;
        }
    }

}