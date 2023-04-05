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
    /// TradeRequestStore
    /// </summary>
    [DataContract(Name = "TradeRequestStore")]
    public partial class TradeRequestStore : IEquatable<TradeRequestStore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeRequestStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TradeRequestStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeRequestStore" /> class.
        /// </summary>
        /// <param name="blocks">blocks (required).</param>
        /// <param name="data">data (required).</param>
        /// <param name="player">player (required).</param>
        /// <param name="revision">revision (required).</param>
        /// <param name="store">store (required).</param>
        public TradeRequestStore(int blocks = default(int), System.IO.Stream data = default(System.IO.Stream), string player = default(string), long revision = default(long), string store = default(string))
        {
            this.Blocks = blocks;
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for TradeRequestStore and cannot be null");
            }
            this.Data = data;
            // to ensure "player" is required (not null)
            if (player == null)
            {
                throw new ArgumentNullException("player is a required property for TradeRequestStore and cannot be null");
            }
            this.Player = player;
            this.Revision = revision;
            // to ensure "store" is required (not null)
            if (store == null)
            {
                throw new ArgumentNullException("store is a required property for TradeRequestStore and cannot be null");
            }
            this.Store = store;
        }

        /// <summary>
        /// Gets or Sets Blocks
        /// </summary>
        [DataMember(Name = "blocks", IsRequired = true, EmitDefaultValue = true)]
        public int Blocks { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public System.IO.Stream Data { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", IsRequired = true, EmitDefaultValue = true)]
        public string Player { get; set; }

        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name = "revision", IsRequired = true, EmitDefaultValue = true)]
        public long Revision { get; set; }

        /// <summary>
        /// Gets or Sets Store
        /// </summary>
        [DataMember(Name = "store", IsRequired = true, EmitDefaultValue = true)]
        public string Store { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TradeRequestStore {\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
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
            return this.Equals(input as TradeRequestStore);
        }

        /// <summary>
        /// Returns true if TradeRequestStore instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeRequestStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeRequestStore input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Blocks == input.Blocks ||
                    this.Blocks.Equals(input.Blocks)
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Player == input.Player ||
                    (this.Player != null &&
                    this.Player.Equals(input.Player))
                ) && 
                (
                    this.Revision == input.Revision ||
                    this.Revision.Equals(input.Revision)
                ) && 
                (
                    this.Store == input.Store ||
                    (this.Store != null &&
                    this.Store.Equals(input.Store))
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
                hashCode = (hashCode * 59) + this.Blocks.GetHashCode();
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Player != null)
                {
                    hashCode = (hashCode * 59) + this.Player.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Revision.GetHashCode();
                if (this.Store != null)
                {
                    hashCode = (hashCode * 59) + this.Store.GetHashCode();
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
            // Blocks (int) minimum
            if (this.Blocks < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Blocks, must be a value greater than or equal to 0.", new [] { "Blocks" });
            }

            // Revision (long) minimum
            if (this.Revision < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Revision, must be a value greater than or equal to 0.", new [] { "Revision" });
            }

            yield break;
        }
    }

}