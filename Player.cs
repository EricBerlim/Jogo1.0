using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float velocidade = 40;
    //public float rotacao = 100; Carro
    public float horizontalLimite = 52; //Avião
    public Rigidbody bulletPrefab; //Modelo do projétil
    public float bulletSpeed = 50;

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
        float horizontal = InputManager.GetMovementInput().x;
        //float vertical = InputManager.GetMovementInput().y;
        
        //Avião
        transform.Translate(new Vector3(horizontal, 0, 0) * Time.deltaTime * velocidade);

        if (transform.position.x > horizontalLimite)
        {
            transform.position = new Vector3(horizontalLimite, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -horizontalLimite)
        {
            transform.position = new Vector3(-horizontalLimite, transform.position.y, transform.position.z);
        }

        if (InputManager.GetFireInput())
        {
            //Variável do tipo Rigidbody | Cópia do projétil
            Rigidbody newBullet = Instantiate(bulletPrefab, transform.position + new Vector3(0, 0, 1), Quaternion.identity);

            newBullet.linearVelocity = new Vector3(0, 0, bulletSpeed);
        }

        //Carro
        //transform.Translate(0, 0, velocidade * Time.deltaTime * vertical);
        //transform.Rotate(0, rotacao * Time.deltaTime * horizontal, 0);
    }
}