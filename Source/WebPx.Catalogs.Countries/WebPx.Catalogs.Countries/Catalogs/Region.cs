using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WebPx.Catalogs
{
    /// <summary>
    /// Class that provides information about a region in the world
    /// </summary>
    [DebuggerDisplay("Code = {Code}, Name = '{Name}'")]
    public class Region()
    {
        /// <summary>
        /// Gets the unique code for the region
        /// </summary>
        public int Code { get; init; }
        
        /// <summary>
        /// Gets the parent region if any
        /// </summary>
        public Region? Parent { get; internal set; }
        
        /// <summary>
        /// Gets the name of the region
        /// </summary>
        public string? Name { get; init; }

        /// <summary>
        /// Gets the list of countries in the region
        /// </summary>
        public Country[]? Countries { get; internal set; }
    }
}