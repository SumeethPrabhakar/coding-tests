using System.Collections.Generic;

namespace Interfaces
{
    public interface INumericSequenceCalculator
    {
        List<uint> GetPostiveDivisors(uint input);
        List<int> GetMostCommonNumberIntheSequence(List<int> sequence);
    }
}