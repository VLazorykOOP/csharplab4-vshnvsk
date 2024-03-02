using System;

namespace Task2
{
    class VectorLong
    {
        private long[] IntVector;
        private uint size;
        private int codeError;
        private static uint num_v1;

        //Constructors
        public VectorLong()
        {
            size = 1;
            IntVector = new long[size];
            IntVector[0] = 0;
            num_v1++;
        }

        public VectorLong(uint size)
        {
            this.size = size;
            IntVector = new long[size];

            for(int i = 0; i < size; i++)
            {
                IntVector[i] = 0;
            }

            num_v1++;
        }

        public VectorLong(uint size, long initValue)
        {
            this.size = size;
            IntVector = new long[size];

            for (int i = 0; i < size; i++)
            {
                IntVector[i] = initValue;
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
                IntVector[i] = Convert.ToInt64(Console.ReadLine());
            }
        }

        public void Display()
        {
            Console.WriteLine("Vector elements: ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Index: {i}: \t{IntVector[i]}");
            }
        }

        public void AssignValue(long value)
        {
            for (int i = 0; i < size; i++)
            {
                IntVector[i] = value;
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
                    return IntVector[index];
                }
            }

            set
            {
                if (index >=0 && index < size)
                {
                    IntVector[index] = value;
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
                vector.IntVector[i]++;
            }
            return vector;
        }

        public static VectorLong operator --(VectorLong vector)
        {
            for (int i = 0; i < vector.size; i++)
            {
                vector.IntVector[i]--;
            }
            return vector;
        }

        public static bool operator true(VectorLong vector)
        {
            foreach(long element in vector.IntVector)
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
            foreach (long element in vector.IntVector)
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
                vector.IntVector[i] = ~vector.IntVector[i];
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