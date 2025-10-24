using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    [SerializeField] private int index, num;

    // Start is called before the first frame update
    void Start()
    {
        while (index > 0)
        {
            Debug.Log(++num);
            index--;
        }
        
    }
}
