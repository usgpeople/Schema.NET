namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place...
    /// </summary>
    [DataContract]
    public class OpeningHoursSpecification : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OpeningHoursSpecification";

        /// <summary>
        /// The closing hour of the place or service on the given day(s) of the week.
        /// </summary>
        [DataMember(Name = "closes", Order = 2)]
        public TimeSpan? Closes { get; set; }

        /// <summary>
        /// The day of the week for which these opening hours are valid.
        /// </summary>
        [DataMember(Name = "dayOfWeek", Order = 3)]
        public DayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// The opening hour of the place or service on the given day(s) of the week.
        /// </summary>
        [DataMember(Name = "opens", Order = 4)]
        public TimeSpan? Opens { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 5)]
        public DateTimeOffset? ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 6)]
        public DateTimeOffset? ValidThrough { get; set; }
    }
}