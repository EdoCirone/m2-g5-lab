using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab5_Es01 : MonoBehaviour
{
    public int number = 0;
    public int baSe = 0;
    public int multiple = 0;
    bool isEven(int a)
    {
        return a % 2 == 0;
    }
   
    bool isMultiple (int a , int b)
    {
        return a % b == 0;
    }


    // Start is called before the first frame update
    void Start()
    {

        isEven(number);
        isMultiple(baSe, multiple);

        if (isEven(number))
        {
            Debug.Log(" il numero " + number + "è pari");
        }
        else
        {
            Debug.Log("il numero" + number + " è dispari");
        }

        if (isMultiple(baSe, multiple))
        {
            Debug.Log("il numero " + multiple + "è multiplo di " + baSe);
        }
        else
        {
            Debug.Log("il numero " + multiple + " non è multiplo di " + baSe);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
