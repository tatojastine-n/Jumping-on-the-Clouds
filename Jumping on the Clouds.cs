using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int jumpingOnClouds(List<int> c)
    {
        int jumps = 0;
        int position = 0;
        int n = c.Count;
        
        while (position < n - 1)
        {
            if (position + 2 < n && c[position + 2] == 0)
            {
                position += 2;
            }
            else
            {
                position += 1;
            }
            jumps++;
        }
        
        return jumps;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

        int result = Result.jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
