using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // •Ï”‚ğ‰Šú‰»‚·‚é
        int[] array = new int[5];
        array[0] = 1;
        array[1] = 9;
        array[2] = 8;
        array[3] = 7;
        array[4] = 2;
        for (int a = 0; a < 5; a++)
        {
            Debug.Log(array[a]);
        }
        for (int b = 4; b >= 0; b--)
        {
            Debug.Log(array[b]);
        }
    }

        // Update is called once per frame
        void Update()
    {

    }
}