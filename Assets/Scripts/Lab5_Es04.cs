using System;
using UnityEngine;

public class Lab5_Es04 : MonoBehaviour
{
    public int lunghezza = 20;
    public int minimo = 10;
    public int massimo = 200;

   

    int[] GeneraArray(int lunghezza, int minimo, int massimo)
    {
        int[] myArray = new int[lunghezza];

        for (int i = 0; i < lunghezza; i++)
        {
            myArray[i] = UnityEngine.Random.Range(10, 100);
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

    int[] AumentaArray(int[] array)
    {
        if (array.Length <= minimo)
        {
            int[]nuovoarray = new int[minimo];

            for (int i = 0; i < array.Length; i++)
            {
                nuovoarray[i] = array[i];
            }

            for (int i = array.Length; i < nuovoarray.Length; i++)
            {
                nuovoarray[i] = UnityEngine.Random.Range(10, 100);
            }



            return nuovoarray; 

        }
        else
        {

            return array;
        }

    }

    int[] DiminuisciArray(int[] array) {

        if (array.Length >= massimo)
        {


            int[] nuovoarray = new int[massimo];

            for (int i = 0; i < nuovoarray.Length; i++)
            {
                nuovoarray[i] = array[i];
            }
            return nuovoarray;

        }
        else
        {
            return array;
        }



        }


        void Start()
{
     int[] mioArray = GeneraArray(lunghezza, minimo, massimo);
        Debug.Log("PrimoArray");
     StampaArray(mioArray);
     int[] nuovoArray = AumentaArray(mioArray);
     int[] ultimoArray = DiminuisciArray(nuovoArray);
        Debug.Log("secondo Array");
     StampaArray(ultimoArray);

}

void Update()
    {

    }
}