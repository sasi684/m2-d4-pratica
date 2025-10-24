using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    [SerializeField] private int num = 30;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < num; i++)
        {
            if (i % 3 == 0)
            {
                if (i % 5 == 0)
                    Debug.Log("FizzBuzz");
                else
                    Debug.Log("Fizz");
            }
            else if (i % 5 == 0)
                Debug.Log("Buzz");
            else
                Debug.Log(i);
        }
    }
}
