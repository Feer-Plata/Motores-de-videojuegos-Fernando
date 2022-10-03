using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpeedControl : MonoBehaviour
{
    //Atributos
    public float Velocidad;
    // Update is called once per frame
    void Update()
    {
        if (Velocidad > 5)
        {
            Debug.Log("Mas despacio velocista");
        }
        if (Velocidad < 5) 
        {
            Debug.Log("Mas rapido anciano!");
        }
    }
}
