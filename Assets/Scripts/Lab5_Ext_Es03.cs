using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Lab5_Ext_Es03 : MonoBehaviour
{

    public Material[] listacolori;
    private string nomecolore;

    void Changecolor (Material[] listacolori )
    {

        if (listacolori.Length > 0)
        {
            int x = Random.Range (0, listacolori.Length);
            GetComponent<Renderer>().material = listacolori[x];

        }
        else
        {
            Debug.Log("non ci sono materiali nella lista");
        }

    }

    void Changecolor(Material[] listacolori, string stringa)
    {

        if (listacolori.Length > 0)
        {
            int x = Random.Range(0, listacolori.Length);
            GetComponent<Renderer>().material = listacolori[x];
            Debug.Log( stringa + listacolori[x].name);
        }
        else
        {
            Debug.Log("non ci sono materiali nella lista");
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        nomecolore = ("il nome del colore è");
        Changecolor(listacolori, nomecolore);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
