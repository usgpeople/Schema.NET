﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Rigid connective tissue that comprises up the skeletal structure of the human body.
    /// </summary>
    public partial interface IBone : IAnatomicalStructure
    {
    }

    /// <summary>
    /// Rigid connective tissue that comprises up the skeletal structure of the human body.
    /// </summary>
    [DataContract]
    public partial class Bone : AnatomicalStructure, IBone, IEquatable<Bone>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Bone";

        /// <inheritdoc/>
        public bool Equals(Bone other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Bone);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
