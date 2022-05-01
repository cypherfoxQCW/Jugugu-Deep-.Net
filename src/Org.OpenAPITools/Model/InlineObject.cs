/* 
 * Jugugu密钥Fast模式
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// InlineObject
    /// </summary>
    [DataContract]
    public partial class InlineObject :  IEquatable<InlineObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject" /> class.
        /// </summary>
        /// <param name="phone">phone (required).</param>
        /// <param name="account">通过接入jugugu申请 (required).</param>
        /// <param name="secret">通过接入jugugu申请 (required).</param>
        /// <param name="time">int64类型 (required).</param>
        /// <param name="randomtoken">可以由sha256函数随机产生，避免2分钟内重复，可用时间+其他唯一参数作为种子，防止重放攻击 (required).</param>
        /// <param name="openid">项目方账户系统的唯一识别码，用于绑定登录jugugu系统 (required).</param>
        public InlineObject(string phone = default(string), string account = default(string), string secret = default(string), int time = default(int), string randomtoken = default(string), string openid = default(string))
        {
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new InvalidDataException("phone is a required property for InlineObject and cannot be null");
            }
            else
            {
                this.Phone = phone;
            }
            
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new InvalidDataException("account is a required property for InlineObject and cannot be null");
            }
            else
            {
                this.Account = account;
            }
            
            // to ensure "secret" is required (not null)
            if (secret == null)
            {
                throw new InvalidDataException("secret is a required property for InlineObject and cannot be null");
            }
            else
            {
                this.Secret = secret;
            }
            
            // to ensure "time" is required (not null)
            if (time == null)
            {
                throw new InvalidDataException("time is a required property for InlineObject and cannot be null");
            }
            else
            {
                this.Time = time;
            }
            
            // to ensure "randomtoken" is required (not null)
            if (randomtoken == null)
            {
                throw new InvalidDataException("randomtoken is a required property for InlineObject and cannot be null");
            }
            else
            {
                this.Randomtoken = randomtoken;
            }
            
            // to ensure "openid" is required (not null)
            if (openid == null)
            {
                throw new InvalidDataException("openid is a required property for InlineObject and cannot be null");
            }
            else
            {
                this.Openid = openid;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// 通过接入jugugu申请
        /// </summary>
        /// <value>通过接入jugugu申请</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }

        /// <summary>
        /// 通过接入jugugu申请
        /// </summary>
        /// <value>通过接入jugugu申请</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }

        /// <summary>
        /// int64类型
        /// </summary>
        /// <value>int64类型</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public int Time { get; set; }

        /// <summary>
        /// 可以由sha256函数随机产生，避免2分钟内重复，可用时间+其他唯一参数作为种子，防止重放攻击
        /// </summary>
        /// <value>可以由sha256函数随机产生，避免2分钟内重复，可用时间+其他唯一参数作为种子，防止重放攻击</value>
        [DataMember(Name="randomtoken", EmitDefaultValue=false)]
        public string Randomtoken { get; set; }

        /// <summary>
        /// 项目方账户系统的唯一识别码，用于绑定登录jugugu系统
        /// </summary>
        /// <value>项目方账户系统的唯一识别码，用于绑定登录jugugu系统</value>
        [DataMember(Name="openid", EmitDefaultValue=false)]
        public string Openid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Randomtoken: ").Append(Randomtoken).Append("\n");
            sb.Append("  Openid: ").Append(Openid).Append("\n");
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
            return this.Equals(input as InlineObject);
        }

        /// <summary>
        /// Returns true if InlineObject instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Randomtoken == input.Randomtoken ||
                    (this.Randomtoken != null &&
                    this.Randomtoken.Equals(input.Randomtoken))
                ) && 
                (
                    this.Openid == input.Openid ||
                    (this.Openid != null &&
                    this.Openid.Equals(input.Openid))
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
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Randomtoken != null)
                    hashCode = hashCode * 59 + this.Randomtoken.GetHashCode();
                if (this.Openid != null)
                    hashCode = hashCode * 59 + this.Openid.GetHashCode();
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
