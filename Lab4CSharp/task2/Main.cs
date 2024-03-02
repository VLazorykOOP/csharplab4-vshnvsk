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

            VectorLong vector1 = new VectorLong(size1);
            VectorLong vector2 = new VectorLong(size2);

            Console.WriteLine("\nEnter elements for the first vector:");
            vector1.Input();

            Console.WriteLine("\nEnter elements for the second vector:");
            vector2.Input();

            Console.WriteLine("\nVector 1:");
            vector1.Display();

            Console.WriteLine("\nVector 2:");
            vector2.Display();

            Console.WriteLine("\nSum of vectors:");
            VectorLong sum = vector1 + vector2;
            sum.Display();

            Console.WriteLine("\nDifference of vectors:");
            VectorLong difference = vector1 - vector2;
            difference.Display();

            Console.WriteLine("\nMyltiplication of vectors:");
            VectorLong myltiplication = vector1 * vector2;
            myltiplication.Display();

            Console.WriteLine("\nRemainder from division of vectors:");
            VectorLong remainder = vector1 % vector2;
            remainder.Display();

            Console.WriteLine("\nBitwise OR of vectors:");
            VectorLong bitwiseOR = vector1 | vector2;
            bitwiseOR.Display();

            Console.WriteLine("\nBitwise AND of vectors:");
            VectorLong bitwiseAND = vector1 & vector2;
            bitwiseAND.Display();

            Console.WriteLine("\nBitwise XOR of vectors:");
            VectorLong bitwiseXOR = vector1 ^ vector2;
            bitwiseXOR.Display();

            Console.WriteLine("\nBitwise left shift of vector 1 by vector 2:");
            VectorLong leftShift = vector1 << vector2;
            leftShift.Display();

            Console.WriteLine("\nBitwise right shift of vector 1 by vector 2:");
            VectorLong rightShift = vector1 >> vector2;
            rightShift.Display();

            Console.WriteLine("\n\nEnter a scalar value:");
            long scalar = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("\nVector 1 + scalar:");
            VectorLong sumScalar = vector1 + scalar;
            sumScalar.Display();

            Console.WriteLine("\nVector 1 - scalar:");
            VectorLong differenceScalar = vector1 - scalar;
            differenceScalar.Display();

            Console.WriteLine("\nVector 1 * scalar:");
            VectorLong myltScalar = vector1 * scalar;
            myltScalar.Display();

            Console.WriteLine("\nVector 1 / scalar:");
            VectorLong divisionScalar = vector1 / scalar;
            divisionScalar.Display();

            Console.WriteLine("\nVector 1 % scalar:");
            VectorLong moduloScalar = vector1 % scalar;
            moduloScalar.Display();

            Console.WriteLine("\nVector 1 | scalar:");
            VectorLong bitwiseORScalar = vector1 | scalar;
            bitwiseORScalar.Display();

            Console.WriteLine("Vector 1 & scalar:");
            VectorLong bitwiseANDScalar = vector1 & scalar;
            bitwiseANDScalar.Display();

            Console.WriteLine("\nVector 1 ^ scalar:");
            VectorLong bitwiseXORScalar = vector1 ^ scalar;
            bitwiseXORScalar.Display();

            Console.WriteLine("\nVector 1 << scalar:");
            VectorLong leftShiftScalar = vector1 << scalar;
            leftShiftScalar.Display();

            Console.WriteLine("\nVector 1 >> scalar:");
            VectorLong rightShiftScalar = vector1 >> scalar;
            rightShiftScalar.Display();

            Console.WriteLine("\nEquality of vectors: " + (vector1 == vector2));
            Console.WriteLine("Inequality of vectors: " + (vector1 != vector2));
            Console.WriteLine("Vector 1 > Vector 2: " + (vector1 > vector2));
            Console.WriteLine("Vector 1 >= Vector 2: " + (vector1 >= vector2));
            Console.WriteLine("Vector 1 < Vector 2: " + (vector1 < vector2));
            Console.WriteLine("Vector 1 <= Vector 2: " + (vector1 <= vector2));
        }
    }
}
