using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab5_Ext_Es02 : MonoBehaviour
{

   private Color Colore = Color.red;


    void ColorChange(Color a)
    {

        GetComponent<Renderer>().material.color = a;


    }

    // Start is called before the first frame update
    void Start()
    {
     ColorChange(Colore);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
