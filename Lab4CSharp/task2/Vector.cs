using System;

namespace Task2
{
    class VectorLong
    {
        private long[] IntArray;
        private uint size;
        private int codeError;
        private static uint num_v1;

        //Constructors
        public VectorLong()
        {
            size = 1;
            IntArray = new long[size];
            IntArray[0] = 0;
            num_v1++;
        }

        public VectorLong(uint size)
        {
            this.size = size;
            IntArray = new long[size];

            for(int i = 0; i < size; i++)
            {
                IntArray[i] = 0;
            }

            num_v1++;
        }

        public VectorLong(uint size, long initValue)
        {
            this.size = size;
            IntArray = new long[size];

            for (int i = 0; i < size; i++)
            {
                IntArray[i] = initValue;
            }

            num_v1++;
        }

        //Destructor
        ~VectorLong()
        {
            Console.WriteLine("Destructor");
        }

        //Methods
        public void Input()
        {
            Console.WriteLine("Enter element: ");
            for(int i = 0; i < size; i++)
            {
                Console.Write($"Index {i}: ");
                IntArray[i] = Convert.ToInt64(Console.ReadLine());
            }
        }

        public void Display()
        {
            Console.WriteLine("Vector elements: ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Index: {i}: \t{IntArray[i]}");
            }
        }

        public void AssignValue(long value)
        {
            for (int i = 0; i < size; i++)
            {
                IntArray[i] = value;
            }
        }

        public static uint CountVectors()
        {
            return num_v1;
        }

        //Properties
        public uint Size
        {
            get { return size; }
        }

        public int CodeError
        {
            get { return codeError; }
            set { codeError = value; }
        }

        //Indexer
        public long this[int index]
        {
            get
            {
                if(index < 0 || index >= size)
                {
                    codeError = -1;
                    return 0;
                }
                else
                {
                    codeError = 0;
                    return IntArray[index];
                }
            }

            set
            {
                if (index >=0 && index < size)
                {
                    IntArray[index] = value;
                }
                else
                {
                    codeError = -1;
                }
            }
        }

        //Overload
        public static VectorLong operator ++(VectorLong vector)
        {
            for (int i = 0; i < vector.size; i++)
            {
                vector.IntArray[i]++;
            }
            return vector;
        }

        public static VectorLong operator --(VectorLong vector)
        {
            for (int i = 0; i < vector.size; i++)
            {
                vector.IntArray[i]--;
            }
            return vector;
        }

        public static bool operator true(VectorLong vector)
        {
            foreach(long element in vector.IntArray)
            {
                if(element != 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator false(VectorLong vector)
        {
            foreach (long element in vector.IntArray)
            {
                if (element == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator !(VectorLong vector)
        {
            return vector.size != 0;
        }

        public static VectorLong operator ~(VectorLong vector)
        {
            for(int i = 0; i < vector.size; i++)
            {
                vector.IntArray[i] = ~vector.IntArray[i];
            }
            return vector;
        }

        //Arithmetic operations
        // + Addition
        public static VectorLong operator +(VectorLong v1, VectorLong v2)
        {
            uint maxSize = Math.Max(v1.size, v2.size);
            VectorLong result = new VectorLong(maxSize);

            for(int i = 0; i < maxSize; i++)
            {
                result[i] = (i < v1.Size ? v1[i] : 0) + (i < v2.Size ? v2[i] : 0);
            }

            return result;
        }

        public static VectorLong operator +(VectorLong v, long scalar)
        {
            VectorLong result = new VectorLong(v.Size);

            for(int i = 0; i < v.Size; i++)
            {
                result[i] = v[i] + scalar;
            }

            return result;
        }

        // - Subtraction
        public static VectorLong operator -(VectorLong v1, VectorLong v2)
        {
            uint maxSize = Math.Max(v1.size, v2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                result[i] = (i < v1.Size ? v1[i] : 0) - (i < v2.Size ? v2[i] : 0);
            }

            return result;
        }

        public static VectorLong operator -(VectorLong v, long scalar)
        {
            VectorLong result = new VectorLong(v.Size);

            for (int i = 0; i < v.Size; i++)
            {
                result[i] = v[i] - scalar;
            }

            return result;
        }

        // * Multiplication
        public static VectorLong operator *(VectorLong v1, VectorLong v2)
        {
            uint maxSize = Math.Max(v1.size, v2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                result[i] = (i < v1.Size ? v1[i] : 0) * (i < v2.Size ? v2[i] : 0);
            }

            return result;
        }

        public static VectorLong operator *(VectorLong v, long scalar)
        {
            VectorLong result = new VectorLong(v.Size);

            for (int i = 0; i < v.Size; i++)
            {
                result[i] = v[i] * scalar;
            }

            return result;
        }

        // / Division
        public static VectorLong operator /(VectorLong v1, VectorLong v2)
        {
            uint maxSize = Math.Max(v1.size, v2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                result[i] = (i < v1.Size ? v1[i] : 0) / (i < v2.Size ? v2[i] : 0);
            }

            return result;
        }

        public static VectorLong operator /(VectorLong v, long scalar)
        {
            VectorLong result = new VectorLong(v.Size);

            for (int i = 0; i < v.Size; i++)
            {
                result[i] = v[i] / scalar;
            }

            return result;
        }

        // % Modulo
        public static VectorLong operator %(VectorLong v1, VectorLong v2)
        {
            uint maxSize = Math.Max(v1.size, v2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                result[i] = (i < v1.Size ? v1[i] : 0) % (i < v2.Size ? v2[i] : 0);
            }

            return result;
        }

        public static VectorLong operator %(VectorLong v, long scalar)
        {
            VectorLong result = new VectorLong(v.Size);

            for (int i = 0; i < v.Size; i++)
            {
                result[i] = v[i] % scalar;
            }

            return result;
        }

        // | Bitwise OR
        public static VectorLong operator |(VectorLong v1, VectorLong v2)
        {
            uint maxSize = Math.Max(v1.size, v2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                result[i] = (i < v1.Size ? v1[i] : 0) | (i < v2.Size ? v2[i] : 0);
            }

            return result;
        }

        public static VectorLong operator |(VectorLong v, long scalar)
        {
            VectorLong result = new VectorLong(v.Size);

            for (int i = 0; i < v.Size; i++)
            {
                result[i] = v[i] | scalar;
            }

            return result;
        }

        // ^ Bitwise XOR
        public static VectorLong operator ^(VectorLong v1, VectorLong v2)
        {
            uint maxSize = Math.Max(v1.size, v2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                result[i] = (i < v1.Size ? v1[i] : 0) ^ (i < v2.Size ? v2[i] : 0);
            }

            return result;
        }

        public static VectorLong operator ^(VectorLong v, long scalar)
        {
            VectorLong result = new VectorLong(v.Size);

            for (int i = 0; i < v.Size; i++)
            {
                result[i] = v[i] ^ scalar;
            }

            return result;
        }

        // & Bitwise AND
        public static VectorLong operator &(VectorLong v1, VectorLong v2)
        {
            uint maxSize = Math.Max(v1.size, v2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                result[i] = (i < v1.Size ? v1[i] : 0) & (i < v2.Size ? v2[i] : 0);
            }

            return result;
        }

        public static VectorLong operator &(VectorLong v, long scalar)
        {
            VectorLong result = new VectorLong(v.Size);

            for (int i = 0; i < v.Size; i++)
            {
                result[i] = v[i] & scalar;
            }

            return result;
        }

        // >> Bitwise Right Shift
        public static VectorLong operator >>(VectorLong v1, VectorLong v2)
        {
            uint maxSize = Math.Max(v1.size, v2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                result[i] = (i < v1.Size ? v1[i] : 0) >> (i < v2.Size ? (int)v2[i] : 0);
            }

            return result;
        }

        public static VectorLong operator >>(VectorLong v, long scalar)
        {
            VectorLong result = new VectorLong(v.Size);

            for (int i = 0; i < v.Size; i++)
            {
                result[i] = v[i] >> (int)scalar;
            }

            return result;
        }

        // << Bitwise Left Shift
        public static VectorLong operator <<(VectorLong v1, VectorLong v2)
        {
            uint maxSize = Math.Max(v1.size, v2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                result[i] = (i < v1.Size ? v1[i] : 0) << (i < v2.Size ? (int)v2[i] : 0);
            }

            return result;
        }

        public static VectorLong operator <<(VectorLong v, long scalar)
        {
            VectorLong result = new VectorLong(v.Size);

            for (int i = 0; i < v.Size; i++)
            {
                result[i] = v[i] << (int)scalar;
            }

            return result;
        }


        // == Equality
        public static bool operator ==(VectorLong v1, VectorLong v2) 
        {
            if (v1.size != v2.size)
            {
                return false;
            }
            for (int i = 0; i < v1.size; i++)
            {
                if (v1[i] != v2[i])
                {
                    return false;
                }
            }
            return true;
        }

        // != Inequality
        public static bool operator !=(VectorLong v1, VectorLong v2)
        {
            return !(v1 == v2);
        }

        // > Greater than
        public static bool operator >(VectorLong v1, VectorLong v2)
        {
            for (int i = 0; i < v1.size; i++)
            {
                if (v1[i] <= v2[i])
                {
                    return false;
                }
            }
            return true;
        }

        // >= Greater than or equal to
        public static bool operator >=(VectorLong v1, VectorLong v2)
        {
            for (int i = 0; i < v1.size; i++)
            {
                if (v1[i] < v2[i])
                {
                    return false;
                }
            }
            return true;
        }

        // < Less than
        public static bool operator <(VectorLong v1, VectorLong v2)
        {
            for (int i = 0; i < v1.size; i++)
            {
                if (v1[i] >= v2[i])
                {
                    return false;
                }
            }
            return true;
        }

        // <= Less than or equal to
        public static bool operator <=(VectorLong v1, VectorLong v2)
        {
            for (int i = 0; i < v1.size; i++)
            {
                if (v1[i] > v2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}