using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebPx.Catalogs
{
    /// <summary>
    /// Class that defines the basic information about a country with the ISO 3166 Numeric, Alpha-2 and Alpha-3 Codes
    /// </summary>
    public class Country() 
    {
        /// <summary>
        /// Creates an instance of the <see cref="Country"/> class by passing all initializable values
        /// </summary>
        /// <param name="id">A guid value for the id in string format</param>
        /// <param name="code">The numeric code for the country</param>
        /// <param name="name">The name for the country</param>
        /// <param name="codeA2">The Alpha-2 Code</param>
        /// <param name="codeA3">The Alpha-3 Code</param>
        internal Country(string id, int code, string name, string codeA2, string codeA3) : this()
        {
            Id = new Guid(id);
            Code = code;
            Name = name;
            CodeA2 = codeA2;
            CodeA3 = codeA3;
        }

        /// <summary>
        /// Gets a global unique id to identified the country, used specially for database sync
        /// </summary>
        [Key]
        public Guid Id { get; init; }

        /// <summary>
        /// Gets the ISO 3166 númeric code 
        /// </summary>
        [Required]
        public int Code { get; init;}

        /// <summary>
        /// Gets the ISO 3166 Name, currently supporting English names
        /// </summary>
        [Required, MinLength(1), MaxLength(60)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Gets the ISO 3166 Alpha-2 Code
        /// </summary>
        [Required, MinLength(2), MaxLength(2)]
        public string CodeA2 { get; init; } = null!;

        /// <summary>
        /// Gets the ISO 3166 Alpha-3 Code
        /// </summary>
        [Required, MinLength(2), MaxLength(3)]
        public string CodeA3 { get; init; } = null!;
    }
}