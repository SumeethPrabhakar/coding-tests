using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces;

public class NumericSequenceCalculator : INumericSequenceCalculator
{
    /// <summary>
    /// Returns the Most common Number in the givrn sequence
    /// Logic : First group the sequence elements to get the total elements occurance in the list
    ///         order by descending the based on occurances. Select top element in the list. In case of tie, return both.
    /// </summary>
    /// <param name="sequence"></param>
    /// <returns></returns>
    public List<int> GetMostCommonNumberIntheSequence(List<int> sequence)
    {
        if (sequence == null || sequence.Count == 0)
            throw new ArgumentException("Sequence is null or empty");

        var maximumOccurence = 0;
        return sequence.GroupBy(i => i).Select(g => new { i = g.Key, count = g.Count() }).OrderByDescending(x => x.count).TakeWhile(x =>
        {
            if (x.count == maximumOccurence || maximumOccurence == 0)
            {
                maximumOccurence = x.count;
                return true;
            }
            return false;
        })
    .Select(x => x.i).ToList();
    }

    /// <summary>
    /// Returns all postive divisors for the given input.
    /// Logic: Loop from 1 to the half of the given number(it makes sense not loop after that, since we are looking for positive integer).
    ///        At last add it the given input
    /// </summary>
    /// <param name="inputValue">unsigned integer</param>
    /// <returns>List of unsigned integer which are divisor for the givrn input</returns>
    public List<uint> GetPostiveDivisors(uint inputValue)
    {
        var positiveDivisors = new List<uint>();
        var maxValue = inputValue / 2;
        for (uint i = 1; i < maxValue; ++i)
        {
            if (inputValue % i == 0)
            {
                positiveDivisors.Add(i);
            }

        }
        positiveDivisors.Add(inputValue);
        return positiveDivisors;
    }
}