using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Mover : MonoBehaviour
{
    public float velocidade = 10;
    
    void Update()
    {
        //Space pode ser referente ao Mundo ou ao Objeto
        transform.Translate(Vector3.back * velocidade * Time.deltaTime, Space.World);
    }
}