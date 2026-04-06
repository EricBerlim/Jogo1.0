using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    Vector2 movementInput;
    bool fireInput;
    bool runInput;

    //Função chamada 1 frame antes do Start
    void Awake()
    {
        //Garante que só exista uma instância do InputManager
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void LateUpdate()
    {
        fireInput = false; //Reseta o input a cada frame
    }

    //Ao apertar um botão do OnMove, vai chamar essa função
    public void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }

    //Quando pressionar o botão, vai chamar essa função
    public void OnFire(InputValue value)
    {
        fireInput = value.isPressed;
    }

    public void OnRun(InputValue value)
    {
        runInput = value.isPressed;
    }

    //Funções estáticas para pegar o valor dos inputs
    public static Vector2 GetMovementInput()
    {
        return instance.movementInput;
    }

    public static bool GetFireInput()
    {
        return instance.fireInput;
    }

    public static bool GetRunInput()
    {
        return instance.runInput;
    }
}