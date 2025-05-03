using System;
using UnityEngine;

public class Lab5_Es02 : MonoBehaviour
{
    public int lunghezza = 20;
    public int minimo = 10;
    public int massimo = 200;

    void Start()
    {
        int[] mioArray = GeneraArray(lunghezza, minimo, massimo);
        StampaArray(mioArray);
        TrovaMassimo(mioArray);
        TrovaMinimo(mioArray);
    }

    int[] GeneraArray(int lunghezza, int minimo, int massimo)
    {
        int[] myArray = new int[lunghezza];

        for (int i = 0; i < lunghezza; i++)
        {
            myArray[i] = UnityEngine.Random.Range(minimo, massimo);
        }

        return myArray;
    }

    void StampaArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }

    void TrovaMassimo(int[] tuoArray)
    {
        int numMassimo1 = int.MinValue;
        int numMassimo2 = int.MinValue;

        foreach (int numero in tuoArray)
        {
            if (numero > numMassimo1)
            {
                numMassimo2 = numMassimo1;
                numMassimo1 = numero;
            }
            else if (numero > numMassimo2)
            {
                numMassimo2 = numero;
            }
        }

        Debug.Log("I due numeri più alti sono: " + numMassimo1 + " e " + numMassimo2);
    }

    void TrovaMinimo(int[] tuoArray)
    {
        int numMinimo1 = int.MaxValue;
        int numMinimo2 = int.MaxValue;

        foreach (int numero in tuoArray)
        {
            if (numero < numMinimo1)
            {
                numMinimo2 = numMinimo1;
                numMinimo1 = numero;
            }
            else if (numero < numMinimo2)
            {
                numMinimo2 = numero;
            }
        }

        Debug.Log("I due numeri più bassi sono: " + numMinimo1 + " e " + numMinimo2);
    }

    void Update()
    {
        // Lasciato vuoto
    }
}