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
                while (n2 <= n1)
                {
                    Debug.Log(n2);
                    n2++;
                }
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
