using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int counter = 1;
        int countermax = 100;
        while (counter <= countermax)
        {
            Debug.Log(counter);
            counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
