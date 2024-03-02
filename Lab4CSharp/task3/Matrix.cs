namespace Task3
{
    class MatrixLong
    {
        public long[,] LongArray;
        public uint n, m;
        public int codeError;
        public static int num_m;

        public MatrixLong()
        {
            n = m = 1;
            LongArray = new long[n, m];
            LongArray[0, 0] = 0;
            num_m++;
        }

        public MatrixLong(uint n, uint m)
        {
            this.n = n;
            this.m = m;
            LongArray = new long[n, m];
            num_m++;
        }

        public MatrixLong(uint n, uint m, long value)
        {
            this.n = n;
            this.m = m;
            LongArray = new long[n, m];
            for (uint i = 0; i < n; i++)
            {
                for (uint j = 0; j < m; j++)
                {
                    LongArray[i, j] = value;
                }
            }
            num_m++;
        }

        ~MatrixLong()
        {
            Console.WriteLine("Destructer");
        }

        //Methods
        public void Input()
        {
            Console.WriteLine("Enter element: ");
            for (uint i = 0; i < n; i++)
            {
                for (uint j = 0; j < m; j++)
                {
                    Console.Write("Index [{0},{1}]: ", i, j);
                    LongArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Output()
        {
            Console.WriteLine("Matrix element: ");
            for (uint i = 0; i < n; i++)
            {
                for (uint j = 0; j < m; j++)
                {
                    Console.Write(LongArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int CountMatrix()
        {
            return num_m;
        }

        //Properties
        public uint Rows
        {
            get { return n; }
        }

        public uint Columns
        {
            get { return m; }
        }

        public int CodeError
        {
            get { return codeError; }
            set { codeError = value; }
        }

        //Indexers
        public long this[uint i, uint j]
        {
            get
            {
                if (i < n && j < m)
                {
                    return LongArray[i, j];
                }
                else
                {
                    codeError = -1;
                    return 0;
                }
            }

            set
            {
                if (i < n && j < m)
                {
                    LongArray[i, j] = value;
                }
                else
                {
                    codeError = -1;
                }
            }
        }

        public long this[uint k]
        {
            get
            {
                uint i = k / m;
                uint j = k % m;
                if (i < n && j < m)
                {
                    return LongArray[i, j];
                }
                else
                {
                    codeError = -1;
                    return 0;
                }
            }

            set
            {
                uint i = k / m;
                uint j = k % m;
                if (i < n && j < m)
                {
                    LongArray[i, j] = value;
                }
                else
                {
                    codeError = -1;
                }
            }
        }

        //Overloads
        public static MatrixLong operator ++(MatrixLong matrix)
        {
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    matrix.LongArray[i, j]++;
                }
            }
            return matrix;
        }

        public static MatrixLong operator --(MatrixLong matrix)
        {
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    matrix.LongArray[i, j]--;
                }
            }
            return matrix;
        }

        public static bool operator true(MatrixLong matrix)
        {
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    if (matrix.LongArray[i, j] != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(MatrixLong matrix)
        {
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    if (matrix.LongArray[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator !(MatrixLong matrix)
        {
            return matrix.n != 0 || matrix.m != 0;
        }

        public static MatrixLong operator ~(MatrixLong matrix)
        {
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    matrix.LongArray[i, j] = ~matrix.LongArray[i, j];
                }
            }
            return matrix;
        }

        //Arithmetic operations
        // + Addition
        public static MatrixLong operator +(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for addition");
            }

            MatrixLong result = new MatrixLong(matrix1.n, matrix1.m);
            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

        public static MatrixLong operator +(MatrixLong matrix, long scalar)
        {
            MatrixLong result = new MatrixLong(matrix.n, matrix.m);
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    result[i, j] = matrix[i, j] + scalar;
                }
            }
            return result;
        }

        // - Subtraction
        public static MatrixLong operator -(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for substraction");
            }

            MatrixLong result = new MatrixLong(matrix1.n, matrix1.m);
            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;
        }

        public static MatrixLong operator -(MatrixLong matrix, long scalar)
        {
            MatrixLong result = new MatrixLong(matrix.n, matrix.m);
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    result[i, j] = matrix[i, j] - scalar;
                }
            }
            return result;
        }

        // * Multiplication
        public static MatrixLong operator *(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for myltiplication");
            }

            MatrixLong result = new MatrixLong(matrix1.n, matrix1.m);
            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    result[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }
            return result;
        }

        public static MatrixLong operator *(MatrixLong matrix, long scalar)
        {
            MatrixLong result = new MatrixLong(matrix.n, matrix.m);
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }

        // / Division
        public static MatrixLong operator /(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for division");
            }

            MatrixLong result = new MatrixLong(matrix1.n, matrix1.m);
            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    result[i, j] = matrix1[i, j] / matrix2[i, j];
                }
            }
            return result;
        }

        public static MatrixLong operator /(MatrixLong matrix, long scalar)
        {
            MatrixLong result = new MatrixLong(matrix.n, matrix.m);
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    result[i, j] = matrix[i, j] / scalar;
                }
            }
            return result;
        }

        // % Modulo
        public static MatrixLong operator %(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for modulo");
            }

            MatrixLong result = new MatrixLong(matrix1.n, matrix1.m);
            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    result[i, j] = matrix1[i, j] % matrix2[i, j];
                }
            }
            return result;
        }

        public static MatrixLong operator %(MatrixLong matrix, long scalar)
        {
            MatrixLong result = new MatrixLong(matrix.n, matrix.m);
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    result[i, j] = matrix[i, j] % scalar;
                }
            }
            return result;
        }

        // | Bitwise OR
        public static MatrixLong operator |(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for bitwise OR operation");
            }

            MatrixLong result = new MatrixLong(matrix1.n, matrix1.m);
            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    result[i, j] = matrix1[i, j] | matrix2[i, j];
                }
            }
            return result;
        }

        public static MatrixLong operator |(MatrixLong matrix, long scalar)
        {
            MatrixLong result = new MatrixLong(matrix.n, matrix.m);
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    result[i, j] = matrix[i, j] | scalar;
                }
            }
            return result;
        }

        // ^ Bitwise XOR
        public static MatrixLong operator ^(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for bitwise XOR operation");
            }

            MatrixLong result = new MatrixLong(matrix1.n, matrix1.m);
            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    result[i, j] = matrix1[i, j] ^ matrix2[i, j];
                }
            }
            return result;
        }

        public static MatrixLong operator ^(MatrixLong matrix, long scalar)
        {
            MatrixLong result = new MatrixLong(matrix.n, matrix.m);
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    result[i, j] = matrix[i, j] ^ scalar;
                }
            }
            return result;
        }

        // & Bitwise AND
        public static MatrixLong operator &(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for bitwise AND operation");
            }

            MatrixLong result = new MatrixLong(matrix1.n, matrix1.m);
            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    result[i, j] = matrix1[i, j] & matrix2[i, j];
                }
            }
            return result;
        }

        public static MatrixLong operator &(MatrixLong matrix, long scalar)
        {
            MatrixLong result = new MatrixLong(matrix.n, matrix.m);
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    result[i, j] = matrix[i, j] & scalar;
                }
            }
            return result;
        }

        // >> Bitwise Right Shift
        public static MatrixLong operator >>(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for bitwise right shift operation");
            }

            MatrixLong result = new MatrixLong(matrix1.n, matrix1.m);
            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    result[i, j] = matrix1[i, j] >> (int)matrix2[i, j];
                }
            }
            return result;
        }

        public static MatrixLong operator >>(MatrixLong matrix, int scalar)
        {
            MatrixLong result = new MatrixLong(matrix.n, matrix.m);
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    result[i, j] = matrix[i, j] >> scalar;
                }
            }
            return result;
        }

        // << Bitwise Left Shift
        public static MatrixLong operator <<(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for bitwise left shift operation");
            }

            MatrixLong result = new MatrixLong(matrix1.n, matrix1.m);
            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    result[i, j] = matrix1[i, j] << (int)matrix2[i, j];
                }
            }
            return result;
        }

        public static MatrixLong operator <<(MatrixLong matrix, int scalar)
        {
            MatrixLong result = new MatrixLong(matrix.n, matrix.m);
            for (uint i = 0; i < matrix.n; i++)
            {
                for (uint j = 0; j < matrix.m; j++)
                {
                    result[i, j] = matrix[i, j] << scalar;
                }
            }
            return result;
        }

        // == Equality
        public static bool operator ==(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (ReferenceEquals(matrix1, matrix2)) return true;

            if ((object)matrix1 == null || (object)matrix2 == null) return false;

            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m) return false;

            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j]) return false;
                }
            }

            return true;
        }

        // != Inequality
        public static bool operator !=(MatrixLong matrix1, MatrixLong matrix2)
        {
            return !(matrix1 == matrix2);
        }

        // > Greater than
        public static bool operator >(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for comparison");
            }

            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    if (matrix1[i, j] <= matrix2[i, j]) return false;
                }
            }

            return true;
        }

        // >= Greater than or equal to
        public static bool operator >=(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for comparison");
            }

            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    if (matrix1[i, j] < matrix2[i, j]) return false;
                }
            }

            return true;
        }

        // < Less than
        public static bool operator <(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for comparison");
            }

            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    if (matrix1[i, j] > matrix2[i, j]) return false;
                }
            }

            return true;
        }

        // <= Less than or equal to
        public static bool operator <=(MatrixLong matrix1, MatrixLong matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                throw new ArgumentException("Matrices must have the same dimensions for comparison");
            }

            for (uint i = 0; i < matrix1.n; i++)
            {
                for (uint j = 0; j < matrix2.m; j++)
                {
                    if (matrix1[i, j] >= matrix2[i, j]) return false;
                }
            }

            return true;
        }
    }
}