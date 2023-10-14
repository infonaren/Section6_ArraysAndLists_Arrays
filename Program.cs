using System;


namespace Section6_ArraysAndLists_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            foreach ( var number in numbers)
                Console.WriteLine("The original array elements: "+number);

            // Length => This gives the size of the array.
            Console.WriteLine("The length of the array is: {0}",numbers.Length);

            // IndexOf() finds the position of element in the array.
            var index = Array.IndexOf(numbers, 2);
            Console.WriteLine("Index of 2: "+index);

            // Clear() => Sets a range of elements in the Array to zero, to false, or to null,
            // depending on the element type.
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Copy() => Copies a range of elements from an Array starting at the first element
            // and pastes them into another Array starting at the first element.
            var arrayTwo = new int[3];
            Array.Copy(numbers, arrayTwo, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var number in arrayTwo)
                Console.WriteLine(number);

            // Sort() => Sorts the elements in an entire one-dimensional Array using the 
            // IComparable implementation of each element of the Array.
            // array: The one-dimensional array to sort.

            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Reverse()
            // Reverses the order of the elements in a one-dimensional Array or in a portion of the Array.

            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);

        }
    }
}
