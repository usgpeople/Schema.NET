namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of blood vessel that specifically carries blood away from the heart.
    /// </summary>
    [DataContract]
    public class Artery : Vessel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Artery";
    }
}