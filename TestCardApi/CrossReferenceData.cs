using System.Collections.Generic;

namespace TestCardApi
{
    class CrossReferenceData
    {
        public int CardId { get; set; }
        public List<int> ReverseReferences { get; set; } = new List<int>();
    }
}
