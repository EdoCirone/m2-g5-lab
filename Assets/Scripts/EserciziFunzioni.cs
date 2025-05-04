using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EserciziFunzioni : MonoBehaviour
{
    public int lunghezzaarray = 10;
    public int minimonumeroarray = 0;
    public int massimonumeroarray = 100;
    int[] GeneraArray()
    {

        int[] nuovoarray = new int[20]; 
       
        for (int i = 0; i < nuovoarray.Length; i++)
       
        {
            int x = Random.Range(0, 100);
            nuovoarray[i] = x;
        }

        return nuovoarray;
    }

    int[] GeneraArray(int lunghezza)
    {

        int[] nuovoarray = new int[lunghezza];

        for (int i = 0; i < nuovoarray.Length; i++)

        {
            int x = Random.Range(0, 100);
            nuovoarray[i] = x;
        }

        return nuovoarray;
    }

    int[] GeneraArray(int lunghezza, int massimo,  int minimo)
    {

        int[] nuovoarray = new int[lunghezza];

        for (int i = 0; i < nuovoarray.Length; i++)

        {
            int x = Random.Range(massimo, minimo);
            nuovoarray[i] = x;
        }

        return nuovoarray;
    }

    void StampaArray( int[] nuovoarray)
    {
       for (int i = 0;i < nuovoarray.Length;i++)
        {
            Debug.Log(nuovoarray[i]);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

       int [] mioarray = GeneraArray( lunghezzaarray, massimonumeroarray, minimonumeroarray);
        StampaArray(mioarray);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
