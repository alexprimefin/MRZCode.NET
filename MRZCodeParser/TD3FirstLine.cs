using System.Collections.Generic;

namespace MRZCodeParser
{
    internal class TD3FirstLine : MrzLine
    {
        internal TD3FirstLine(string value) : base(value)
        {
        }

        protected override string Pattern => "(P[A-Z0-9<]{1})([A-Z]{3})([A-Z0-9<]{39})";
        
        protected override IEnumerable<FieldType> FieldTypes => new[]
        {
            FieldType.DocumentType,
            FieldType.CountryCode,
            FieldType.PrimaryIdentifier,
        };
    }
}