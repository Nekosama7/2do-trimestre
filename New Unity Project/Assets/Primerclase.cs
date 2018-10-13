using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primerclase : MonoBehaviour
{
   class VeryVeryFirstClass
    {
        public int num;
    }

    private void Start()
    {
        VeryVeryFirstClass firstClass = new VeryVeryFirstClass();
        firstClass.num = 1;
    }
}



