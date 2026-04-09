using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bullet : MonoBehaviour
{
    //Quando entrar em colisão com o alvo
    private void onTriggerEnter(Collider other)
    {
        //Se houver colisão com algum objeto com tag Obstacle
        if (other.CompareTag("Obstacle"))
        {
            Destroy(gameObject); //Objeto será destruído
        }
    }
}