using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Destroyer : MonoBehaviour
{
    //Algum dos objetos devem ter Rigidbody isso acontecer
    //Collider afeta um outro objeto após sair da colisão
    private void OnTriggerExit(Collider other)
    {
        //Destrói o objeto inteiro
        Destroy(other.gameObject);
    }
}