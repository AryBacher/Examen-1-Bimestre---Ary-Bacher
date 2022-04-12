using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PesosAExtranjero : MonoBehaviour
{
    public string letra;
    public float monto;
    float invertido;
    // Start is called before the first frame update
    void Start()
    {
        if (monto < 1000)
        {
            Debug.Log("El Monto Mínimo es $1000");
        }

        else
        {
            switch (letra)
            {
                case "d":
                    invertido = monto * 0.0089f;
                    Debug.Log("$" + monto + " pesos argentinos equivalen a " + invertido + " dolares");
                    break;
                case "r":
                    invertido = monto * 0.042f;
                    Debug.Log("$" + monto + " pesos argentinos equivalen a " + invertido + " reales");
                    break;
                case "e":
                    invertido = monto * 0.0082f;
                    Debug.Log("$" + monto + " pesos argentinos equivalen a " + invertido + " euros");
                    break;
                default:
                    Debug.Log("Opción de Moneda Extranjera no Valida");
                    break;

            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
