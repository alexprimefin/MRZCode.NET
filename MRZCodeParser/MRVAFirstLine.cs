using System.Collections.Generic;

namespace MRZCodeParser
{
    internal class MRVAFirstLine : MrzLine
    {
        internal MRVAFirstLine(string value) : base(value)
        {
        }

        protected override string Pattern => "(V[A-Z0-9<]{1})([A-Z]{3})([A-Z0-9<]{39})";

        protected override IEnumerable<FieldType> FieldTypes => new[]
        {
            FieldType.DocumentType,
            FieldType.CountryCode,
            FieldType.PrimaryIdentifier,
        };
    }
}