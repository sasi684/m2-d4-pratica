using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    [SerializeField] private int startNumber, amount;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= amount; i++)
        {
            Debug.Log(startNumber + i);
        }
    }
}
