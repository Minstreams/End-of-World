using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRandom : MonoBehaviour
{
    private static int[] lastResult = new int[10];
    public static int Range(int a, int b)
    {
        if (b >= 10)
        {
            return Random.Range(a, b);
        }
        int output;
        do
        {
            output = Random.Range(a, b);
        } while (lastResult[b] == output);

        lastResult[b] = output;
        return output;
    }
}
