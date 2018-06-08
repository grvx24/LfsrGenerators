using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFSR_Generators
{
    class Lfsr : IGenerators
    {
        public BitArray Register { get; private set; }
        int[] feedbackFunction;
        int length;

        public override string ToString()
        {
            char[] result = new char[Register.Length];

            for (int i = 0; i < Register.Length; i++)
            {
                result[i] = Register[i] ? '1' : '0';
            }

            return new string(result);
        }

        public Lfsr()
        {
            Register = new BitArray(8);
            length = 8;
            Random rng = new Random();

            for (int i = 0; i < length; i++)
            {
                Register[i] = rng.Next(0, 2) > 0;

            }

            FeedbackFunction();
        }

        public Lfsr(int length)
        {
            Register = new BitArray(length);
            this.length = length;
            Random rng = new Random();

            for (int i = 0; i < length; i++)
            {
                Register[i] = rng.Next(0, 2) > 0;

            }

            FeedbackFunction();
        }

        public byte[] GenerateBytes(int length)
        {
            bool[] result = new bool[length];
            throw new NotImplementedException();
        }

        public char[] GenerateBitsAsChars(int length)
        {
            throw new NotImplementedException();
        }

        public int[] GenerateIntegers(int length)
        {
            throw new NotImplementedException();
        }

        public void SetRegisterValues(BitArray array)
        {
            Register = new BitArray(array.Length);
            length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Register[i] = array[i];
            }

            FeedbackFunction();
        }

        public void NextStep()
        {
            bool temp = true;


            for (int i = 0; i < feedbackFunction.Length; i++)
            {
                temp ^= Register[feedbackFunction[i]];
            }


            for (int i = 1; i < Register.Count; i++)
            {
                Register[i - 1] = Register[i];
            }


            Register[Register.Count - 1] = temp;


        }
        public bool GetOutputBit()
        {
            return Register[0];
        }

        private void FeedbackFunction()
        {
            switch (length)
            {
                case 2:
                    feedbackFunction = new int[] { 0, length - 1 };
                    break;
                case 3:
                    feedbackFunction = new int[] { 0, length - 1 };
                    break;
                case 4:
                    feedbackFunction = new int[] { 0, length - 1 };
                    break;
                case 5:
                    feedbackFunction = new int[] { 0, 2 };
                    break;
                case 6:
                    feedbackFunction = new int[] { 0, length - 1 };
                    break;
                case 7:
                    feedbackFunction = new int[] { 0, length - 1 };
                    break;
                case 8:
                    feedbackFunction = new int[] { 0, 1, 6, 7 };
                    break;
                case 9:
                    feedbackFunction = new int[] { 0, 4 };
                    break;
                case 10:
                    feedbackFunction = new int[] { 0, 3 };
                    break;
                case 11:
                    feedbackFunction = new int[] { 0, 8, 10 };
                    break;
                case 12:
                    feedbackFunction = new int[] { 0, 3, 9, 10, 11 };
                    break;
                case 13:
                    feedbackFunction = new int[] { 0, 2, 4, 5, 6, 11 };
                    break;
                case 14:
                    feedbackFunction = new int[] { 0, 3, 4, 5 };
                    break;
                case 15:
                    feedbackFunction = new int[] { 0, 1, 13, 14 };
                    break;
                case 16:
                    feedbackFunction = new int[] { 0, 3, 6 };
                    break;
                case 17:
                    feedbackFunction = new int[] { 0, 6, 7, 8 };
                    break;
                case 18:
                    feedbackFunction = new int[] { 0, 1, 2, 8 };
                    break;
                case 19:
                    feedbackFunction = new int[] { 0, 1, 5, 18 };
                    break;
                case 20:
                    feedbackFunction = new int[] { 0, 1, 2, 8, 17, 19 };
                    break;

                default:
                    break;
            }
        }


    }
}
