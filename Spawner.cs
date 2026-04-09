using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float horizontalLimit = 44;
    public Vector2 spawnInterval = new Vector2(1, 2);

    void Start()
    {
        //Função que chama outra função, mas com um atraso
        //Valor passado na função Invoke é em segundos
        //Cada vez que chamar a função Spawn, o atraso será um
        Invoke("Spawn", Random.Range(spawnInterval.x, spawnInterval.y));
    }

    void Spawn()
    {
        //Gera uma posição aleatória dentro do limite definido
        Vector3 spawnPosition = new Vector3(Random.Range(-horizontalLimit, horizontalLimit), transform.position.y, transform.position.z);

        //Instancia o prefab na posição gerada e com rotação
        Instantiate(prefab, spawnPosition, prefab.transform.rotation);
    }
}