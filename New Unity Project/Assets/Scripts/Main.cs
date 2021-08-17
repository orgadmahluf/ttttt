using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool IsPrime(int num)
    {
        if (num < 0) throw new System.ArithmeticException();
        for(int i=2; i<num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}
