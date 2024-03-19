using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanBenchmarks
{

    public class SpanExample
    {
        //Span<char> _span;
        //Memory<char> _memory;
        
        public string GetLastWord(string sentence)
        {
            var lastSpaceIndex = sentence.LastIndexOf(" ", StringComparison.Ordinal);
            return sentence.Substring(lastSpaceIndex + 1);
        }

        public string GetLastWordWithSpanBAD(string sentence) 
        {
            var span = sentence.AsSpan();
            var lastSpaceIndex = span.LastIndexOf(' ');
            return span.Slice(lastSpaceIndex + 1).ToString();
        }

        public ReadOnlySpan<char> GetLastWordWithSpanGOOD(string sentence) // ReadOnlySpan<char> sentence)
        {
            var span = sentence.AsSpan();
            var lastSpaceIndex = span.LastIndexOf(' ');

            var val = span.Slice(lastSpaceIndex + 1);
            val.
            return span.Slice(lastSpaceIndex + 1);
        }
    }
}
