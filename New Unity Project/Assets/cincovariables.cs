using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cincovariables : MonoBehaviour
{
    public int maicol, freddy, flover, chucho, checho;
    public float promedio;  


    public void Start()
    {
        maicol = 17;
        freddy = 38;
        flover = 21;
        chucho = 28;
        checho = 22;
        promedio = (maicol + freddy + flover + chucho + checho) / 5;

        print("El promedio es:" + promedio);

    }

    
}
