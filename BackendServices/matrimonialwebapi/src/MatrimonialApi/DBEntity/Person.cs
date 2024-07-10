using MatrimonialApi.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MatrimonialApi.DBEntity
{
    public partial class Person
    {
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        public string Height { get; set; }

        /// <summary>
        /// Gets or Sets BodyComplexion
        /// </summary>
        public string BodyComplexion { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        public enum GenderEnum
        {
            /// <summary>
            /// Enum MaleEnum for male
            /// </summary>
            [EnumMember(Value = "male")]
            MaleEnum = 0,
            /// <summary>
            /// Enum FemaleEnum for female
            /// </summary>
            [EnumMember(Value = "female")]
            FemaleEnum = 1
        }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        public GenderEnum? Gender { get; set; }

        /// <summary>
        /// Gets or Sets ZodiacSign
        /// </summary>
        public enum ZodiacSignEnum
        {
            /// <summary>
            /// Enum AriesMeaEnum for Aries (Meṣa)
            /// </summary>
            [EnumMember(Value = "Aries (Meṣa)")]
            AriesMeaEnum = 0,
            /// <summary>
            /// Enum TaurusVabhaEnum for Taurus (Vṛṣabha)
            /// </summary>
            [EnumMember(Value = "Taurus (Vṛṣabha)")]
            TaurusVabhaEnum = 1,
            /// <summary>
            /// Enum GeminiMithunaEnum for Gemini (Mithuna)
            /// </summary>
            [EnumMember(Value = "Gemini (Mithuna)")]
            GeminiMithunaEnum = 2,
            /// <summary>
            /// Enum LeoSihaEnum for Leo (Siṃha)
            /// </summary>
            [EnumMember(Value = "Leo (Siṃha)")]
            LeoSihaEnum = 3
        }

        /// <summary>
        /// Gets or Sets ZodiacSign
        /// </summary>
        public ZodiacSignEnum? ZodiacSign { get; set; }

        /// <summary>
        /// Gets or Sets IsBride
        /// </summary>
        public bool? IsBride { get; set; }

        /// <summary>
        /// Gets or Sets IsGroom
        /// </summary>
        public bool? IsGroom { get; set; }

        /// <summary>
        /// Gets or Sets ImageURL
        /// </summary>
        public string ImageURL { get; set; }

        /// <summary>
        /// Gets or Sets BiodataURL
        /// </summary>
        public string BiodataURL { get; set; }

        /// <summary>
        /// Gets or Sets Religion
        /// </summary>
        public enum ReligionEnum
        {
            /// <summary>
            /// Enum HinduEnum for Hindu
            /// </summary>
            [EnumMember(Value = "Hindu")]
            HinduEnum = 0
        }

        /// <summary>
        /// Gets or Sets Religion
        /// </summary>
        public ReligionEnum? Religion { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        public PersonContact Contact { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        public PersonAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets Occupation
        /// </summary>

        public PersonOccupation Occupation { get; set; }

        /// <summary>
        /// Gets or Sets MatchPreferance
        /// </summary>

        public PersonMatchPreferance MatchPreferance { get; set; }

        /// <summary>
        /// Gets or Sets EducationalQualification
        /// </summary>

        public List<Education> EducationalQualification { get; set; }

        /// <summary>
        /// Gets or Sets Relative
        /// </summary>

        public List<Relative> Relative { get; set; }
    }

}
