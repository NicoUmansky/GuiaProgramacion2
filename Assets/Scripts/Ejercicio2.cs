using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public int n1, n2;

    void Start()
    {

        if (n1 != n2)
        {
            if (n1 > n2)
            {
                Debug.Log("El primer numero es más grande que el segundo");

            }
            else
            {
                while (n1 <= n2)
                {
                    Debug.Log(n1);
                    n1++;
                }
            }
        }
        else
        {
            Debug.Log("Son el mismo numero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
