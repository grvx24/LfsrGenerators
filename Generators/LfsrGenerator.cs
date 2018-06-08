using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFSR_Generators
{
    abstract class LfsrGenerator : IGenerators
    {

        public Lfsr[] Registers { get; set; }


        public LfsrGenerator()
        {
        }

        public LfsrGenerator(Lfsr[] registers)
        {
            this.Registers = registers;
        }

        public void ChangeRegister(Lfsr register, int registerIndex)
        {
            if(registerIndex > Registers.Length-1)
            {
                throw new ArgumentException("Niepoprawny indeks rejestru!");
            }else
            {
                Registers[registerIndex] = register;
            }
        }

        protected abstract bool GenerateOneBit();
        protected virtual void NextStep()
        {
            foreach (var r in Registers)
            {
                r.NextStep();
            }
        }

        public virtual byte[] GenerateBytes(int length)
        {
            bool[] result = new bool[length * 8];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = GenerateOneBit();
                NextStep();
            }

            return SeriesConverter.BoolToByteArray(result);
        }

        public virtual Int32[] GenerateIntegers(int length)
        {
            bool[] result = new bool[length * 32];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = GenerateOneBit();
                NextStep();
            }

            return SeriesConverter.BoolToInt32(result);
        }
        public virtual char[] GenerateBitsAsChars(int length)
        {
            char[] result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = SeriesConverter.BoolToChar(GenerateOneBit());
                NextStep();
            }

            return result;
        }

    }
}
