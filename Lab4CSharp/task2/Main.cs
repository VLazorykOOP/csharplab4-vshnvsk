namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the first vector:");
            uint size1 = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Enter the size of the second vector:");
            uint size2 = Convert.ToUInt32(Console.ReadLine());

            VectorLong matrix1 = new VectorLong(size1);
            VectorLong matrix2 = new VectorLong(size2);

            Console.WriteLine("\nEnter elements for the first vector:");
            matrix1.Input();

            Console.WriteLine("\nEnter elements for the second vector:");
            matrix2.Input();

            Console.WriteLine("\nVector 1:");
            matrix1.Display();

            Console.WriteLine("\nVector 2:");
            matrix2.Display();

            Console.WriteLine("\nSum of vectors:");
            VectorLong sum = matrix1 + matrix2;
            sum.Display();

            Console.WriteLine("\nDifference of vectors:");
            VectorLong difference = matrix1 - matrix2;
            difference.Display();

            Console.WriteLine("\nMyltiplication of vectors:");
            VectorLong myltiplication = matrix1 * matrix2;
            myltiplication.Display();

            Console.WriteLine("\nRemainder from division of vectors:");
            VectorLong remainder = matrix1 % matrix2;
            remainder.Display();

            Console.WriteLine("\nBitwise OR of vectors:");
            VectorLong bitwiseOR = matrix1 | matrix2;
            bitwiseOR.Display();

            Console.WriteLine("\nBitwise AND of vectors:");
            VectorLong bitwiseAND = matrix1 & matrix2;
            bitwiseAND.Display();

            Console.WriteLine("\nBitwise XOR of vectors:");
            VectorLong bitwiseXOR = matrix1 ^ matrix2;
            bitwiseXOR.Display();

            Console.WriteLine("\nBitwise left shift of vector 1 by vector 2:");
            VectorLong leftShift = matrix1 << matrix2;
            leftShift.Display();

            Console.WriteLine("\nBitwise right shift of vector 1 by vector 2:");
            VectorLong rightShift = matrix1 >> matrix2;
            rightShift.Display();

            Console.WriteLine("\n\nEnter a scalar value:");
            long scalar = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("\nVector 1 + scalar:");
            VectorLong sumScalar = matrix1 + scalar;
            sumScalar.Display();

            Console.WriteLine("\nVector 1 - scalar:");
            VectorLong differenceScalar = matrix1 - scalar;
            differenceScalar.Display();

            Console.WriteLine("\nVector 1 * scalar:");
            VectorLong myltScalar = matrix1 * scalar;
            myltScalar.Display();

            Console.WriteLine("\nVector 1 / scalar:");
            VectorLong divisionScalar = matrix1 / scalar;
            divisionScalar.Display();

            Console.WriteLine("\nVector 1 % scalar:");
            VectorLong moduloScalar = matrix1 % scalar;
            moduloScalar.Display();

            Console.WriteLine("\nVector 1 | scalar:");
            VectorLong bitwiseORScalar = matrix1 | scalar;
            bitwiseORScalar.Display();

            Console.WriteLine("Vector 1 & scalar:");
            VectorLong bitwiseANDScalar = matrix1 & scalar;
            bitwiseANDScalar.Display();

            Console.WriteLine("\nVector 1 ^ scalar:");
            VectorLong bitwiseXORScalar = matrix1 ^ scalar;
            bitwiseXORScalar.Display();

            Console.WriteLine("\nVector 1 << scalar:");
            VectorLong leftShiftScalar = matrix1 << scalar;
            leftShiftScalar.Display();

            Console.WriteLine("\nVector 1 >> scalar:");
            VectorLong rightShiftScalar = matrix1 >> scalar;
            rightShiftScalar.Display();

            Console.WriteLine("\nEquality of vectors: " + (matrix1 == matrix2));
            Console.WriteLine("Inequality of vectors: " + (matrix1 != matrix2));
            Console.WriteLine("Vector 1 > Vector 2: " + (matrix1 > matrix2));
            Console.WriteLine("Vector 1 >= Vector 2: " + (matrix1 >= matrix2));
            Console.WriteLine("Vector 1 < Vector 2: " + (matrix1 < matrix2));
            Console.WriteLine("Vector 1 <= Vector 2: " + (matrix1 <= matrix2));
        }
    }
}
