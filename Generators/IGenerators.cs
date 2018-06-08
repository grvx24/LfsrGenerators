using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFSR_Generators
{
    public interface IGenerators
    {
        byte[] GenerateBytes(int length);
        
        char[] GenerateBitsAsChars(int length);

        Int32[] GenerateIntegers(int length);
    }
}
