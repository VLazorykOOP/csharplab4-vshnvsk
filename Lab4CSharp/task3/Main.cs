namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the first matrix:");
            uint size1_1 = Convert.ToUInt32(Console.ReadLine());;
            uint size1_2 = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Enter the size of the first matrix:");
            uint size2_1 = Convert.ToUInt32(Console.ReadLine()); ;
            uint size2_2 = Convert.ToUInt32(Console.ReadLine());

            MatrixLong matrix1 = new MatrixLong(size1_1, size1_2);
            MatrixLong matrix2 = new MatrixLong(size2_1, size2_2);

            Console.WriteLine("\nEnter elements for the first matrix:");
            matrix1.Input();

            Console.WriteLine("\nEnter elements for the second matrix:");
            matrix2.Input();

            Console.WriteLine("\nMatrix 1:");
            matrix1.Output();

            Console.WriteLine("\nMatrix 2:");
            matrix2.Output();

            Console.WriteLine("\nSum of matrices:");
            MatrixLong sum = matrix1 + matrix2;
            sum.Output();

            Console.WriteLine("\nDifference of matrices:");
            MatrixLong difference = matrix1 - matrix2;
            difference.Output();

            Console.WriteLine("\nMyltiplication of matrices:");
            MatrixLong myltiplication = matrix1 * matrix2;
            myltiplication.Output();

            Console.WriteLine("\nRemainder from division of matrices:");
            MatrixLong remainder = matrix1 % matrix2;
            remainder.Output();    

            Console.WriteLine("\nBitwise OR of matrices:");
            MatrixLong bitwiseOR = matrix1 | matrix2;
            bitwiseOR.Output();

            Console.WriteLine("\nBitwise AND of matrices:");
            MatrixLong bitwiseAND = matrix1 & matrix2;
            bitwiseAND.Output();

            Console.WriteLine("\nBitwise XOR of matrices:");
            MatrixLong bitwiseXOR = matrix1 ^ matrix2;
            bitwiseXOR.Output();

            Console.WriteLine("\nBitwise left shift of matrix 1 by matrix 2:");
            MatrixLong leftShift = matrix1 << matrix2;
            leftShift.Output();

            Console.WriteLine("\nBitwise right shift of matrix 1 by matrix 2:");
            MatrixLong rightShift = matrix1 >> matrix2;
            rightShift.Output();

            Console.WriteLine("\n\nEnter a scalar value:");
            long scalar = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("\nMatrix 1 + scalar:");
            MatrixLong sumScalar = matrix1 + scalar;
            sumScalar.Output();

            Console.WriteLine("\nMatrix 1 - scalar:");
            MatrixLong differenceScalar = matrix1 - scalar;
            differenceScalar.Output();

            Console.WriteLine("\nMatrix 1 * scalar:");
            MatrixLong myltScalar = matrix1 * scalar;
            myltScalar.Output();

            Console.WriteLine("\nMatrix 1 / scalar:");
            MatrixLong divisionScalar = matrix1 / scalar;
            divisionScalar.Output();

            Console.WriteLine("\nMatrix 1 % scalar:");
            MatrixLong moduloScalar = matrix1 % scalar;
            moduloScalar.Output();

            Console.WriteLine("\nMatrix 1 | scalar:");
            MatrixLong bitwiseORScalar = matrix1 | scalar;
            bitwiseORScalar.Output();

            Console.WriteLine("Matrix 1 & scalar:");
            MatrixLong bitwiseANDScalar = matrix1 & scalar;
            bitwiseANDScalar.Output();

            Console.WriteLine("\nMatrix 1 ^ scalar:");
            MatrixLong bitwiseXORScalar = matrix1 ^ scalar;
            bitwiseXORScalar.Output();

            Console.WriteLine("\nMatrix 1 << scalar:");
            MatrixLong leftShiftScalar = matrix1 << (int)scalar;
            leftShiftScalar.Output();

            Console.WriteLine("\nMatrix 1 >> scalar:");
            MatrixLong rightShiftScalar = matrix1 >> (int)scalar;
            rightShiftScalar.Output();

            Console.WriteLine("\nEquality of matrices: " + (matrix1 == matrix2));
            Console.WriteLine("Inequality of matrices: " + (matrix1 != matrix2));
            Console.WriteLine("Matrix 1 > Matrix 2: " + (matrix1 > matrix2));
            Console.WriteLine("Matrix 1 >= Matrix 2: " + (matrix1 >= matrix2));
            Console.WriteLine("Matrix 1 < Matrix 2: " + (matrix1 < matrix2));
            Console.WriteLine("Matrix 1 <= Matrix 2: " + (matrix1 <= matrix2));
        }
    }
}