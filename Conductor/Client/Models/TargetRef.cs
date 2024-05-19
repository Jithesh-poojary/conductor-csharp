/*
 * Copyright 2024 Conductor Authors.
 * <p>
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * <p>
 * http://www.apache.org/licenses/LICENSE-2.0
 * <p>
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations under the License.
 */
using System.IO;
using Newtonsoft.Json.Converters;
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Conductor.Client.Models
{
    /// <summary>
    /// The object over which access is being granted or removed
    /// </summary>
    [DataContract]
    public partial class TargetRef : IEquatable<TargetRef>, IValidatableObject
    {
        /// <summary>
        /// Defines Id
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IdEnum
        {
            /// <summary>
            /// Enum IdentifierofthetargeteGnameincaseitsaWORKFLOWDEF for value: Identifier of the target e.g. `name` in case it's a WORKFLOW_DEF
            /// </summary>
            [EnumMember(Value = "Identifier of the target e.g. `name` in case it's a WORKFLOW_DEF")]
            IdentifierofthetargeteGnameincaseitsaWORKFLOWDEF = 1
        }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public IdEnum Id { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum WORKFLOWDEF for value: WORKFLOW_DEF
            /// </summary>
            [EnumMember(Value = "WORKFLOW_DEF")]
            WORKFLOWDEF = 1,
            /// <summary>
            /// Enum TASKDEF for value: TASK_DEF
            /// </summary>
            [EnumMember(Value = "TASK_DEF")]
            TASKDEF = 2,
            /// <summary>
            /// Enum APPLICATION for value: APPLICATION
            /// </summary>
            [EnumMember(Value = "APPLICATION")]
            APPLICATION = 3,
            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            [EnumMember(Value = "USER")]
            USER = 4,
            /// <summary>
            /// Enum SECRET for value: SECRET
            /// </summary>
            [EnumMember(Value = "SECRET")]
            SECRET = 5,
            /// <summary>
            /// Enum TAG for value: TAG
            /// </summary>
            [EnumMember(Value = "TAG")]
            TAG = 6,
            /// <summary>
            /// Enum DOMAIN for value: DOMAIN
            /// </summary>
            [EnumMember(Value = "DOMAIN")]
            DOMAIN = 7
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetRef" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="type">type (required).</param>
        public TargetRef(IdEnum id = default(IdEnum), TypeEnum type = default(TypeEnum))
        {
            this.Id = id;
            this.Type = type;
        }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TargetRef {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TargetRef);
        }

        /// <summary>
        /// Returns true if TargetRef instances are equal
        /// </summary>
        /// <param name="input">Instance of TargetRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TargetRef input)
        {
            if (input == null)
                return false;

            return (this.Id == input.Id || this.Id.Equals(input.Id)) &&
                (this.Type == input.Type || this.Type.Equals(input.Type));
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
