/* 
 * QueryBuilderApi
 *
 * Active Query Builder Web API lets create, analyze and modify SQL queries for different database servers using RESTful HTTP requests to a cloud-based service. It requires SQL execution context (information about database schema and used database server) to be stored under the registered account at https://webapi.activequerybuilder.com/.
 *
 * OpenAPI spec version: 1.1.8
 * Contact: support@activedbsoft.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WebApi.ActiveQueryBuilder.Model
{
    /// <summary>
    /// Returns transformed SQL text in case of successful transformation. Otherwise returns error message.
    /// </summary>
    [DataContract]
    public partial class TransformResult :  IEquatable<TransformResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransformResult" /> class.
        /// </summary>
        /// <param name="Sql">Transformed SQL text..</param>
        /// <param name="Totals">Transformed SQL text for totals..</param>
        /// <param name="Error">Error message text..</param>
	public TransformResult() {}
        public TransformResult(string Sql = null, string Totals = null, string Error = null)
        {
            this.Sql = Sql;
            this.Totals = Totals;
            this.Error = Error;
        }
        
        /// <summary>
        /// Transformed SQL text.
        /// </summary>
        /// <value>Transformed SQL text.</value>
        [DataMember(Name="sql", EmitDefaultValue=false)]
        public string Sql { get; set; }
        /// <summary>
        /// Transformed SQL text for totals.
        /// </summary>
        /// <value>Transformed SQL text for totals.</value>
        [DataMember(Name="totals", EmitDefaultValue=false)]
        public string Totals { get; set; }
        /// <summary>
        /// Error message text.
        /// </summary>
        /// <value>Error message text.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransformResult {\n");
            sb.Append("  Sql: ").Append(Sql).Append("\n");
            sb.Append("  Totals: ").Append(Totals).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TransformResult);
        }

        /// <summary>
        /// Returns true if TransformResult instances are equal
        /// </summary>
        /// <param name="other">Instance of TransformResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransformResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sql == other.Sql ||
                    this.Sql != null &&
                    this.Sql.Equals(other.Sql)
                ) && 
                (
                    this.Totals == other.Totals ||
                    this.Totals != null &&
                    this.Totals.Equals(other.Totals)
                ) && 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Sql != null)
                    hash = hash * 59 + this.Sql.GetHashCode();
                if (this.Totals != null)
                    hash = hash * 59 + this.Totals.GetHashCode();
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                return hash;
            }
        }
    }

}
