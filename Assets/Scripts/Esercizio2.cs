using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[4];
        int somma = 0, prodotto = 1;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(1, 5);
            somma += array[i];
            prodotto *= array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        Debug.Log("La somma dell'array è " + somma + ", mentre il prodotto è " + prodotto);
        
    }
}
