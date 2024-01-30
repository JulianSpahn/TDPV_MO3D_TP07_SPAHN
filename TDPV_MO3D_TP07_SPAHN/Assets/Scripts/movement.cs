using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        // Movimiento horizontal (izquierda-derecha)
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcula la dirección del movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);

        // Mueve el objeto en la dirección calculada
        transform.Translate(movimiento * velocidad * Time.deltaTime);
    }
}
