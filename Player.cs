using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float velocidade = 10;
    public float rotacao = 100;

    //Função executada assim que o jogo começa
    //Chamada antes do primeiro frame do jogo
    void Start()
    {
        
    }

    //Função executada a cada frame do jogo em loop
    //Chamada uma vez por frame
    void Update()
    {
        //GetAxis pega o valor do input Vertical(vai de -1 a 1)
        float vertical = InputManager.GetMovementInput().y;
        float horizontal = InputManager.GetMovementInput().x;

        transform.Translate(0, 0, velocidade * Time.deltaTime * vertical);
        transform.Rotate(0, rotacao * Time.deltaTime * horizontal, 0);

        if (InputManager.GetFireInput())
        {
            Debug.Log("Atirou!"); //Inserir Função de atirar
        }

        if (InputManager.GetRunInput())
        {
            Debug.Log("Correndo!"); //Inserir Função de correr
        }
    }
}