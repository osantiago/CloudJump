using System;

namespace CloudJump
{
    class Program
    {
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            int jumps = 0;
            int position = 0;

            // traverse array
            while (position < c.Length - 1)
            {
                // if position is second to last element, make one last jump
                if (position == c.Length - 2)
                {
                    jumps++;
                    position++;
                    break;
                }

                // if thunder (value 1) exists 2 spots past the position, make one jump advancing 1 spot
                if (c[position + 2] == 1)
                {
                    jumps++;
                    position++;
                }
                // otherwise make a jump and advance two places
                else
                {
                    jumps++;
                    position += 2;
                }
            }

            return jumps;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 0, 0, 1, 0, 0, 1, 0 };


            int result = jumpingOnClouds(arr);

            Console.WriteLine(result);
        }
    }
}
