using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncontrarElementoEnArray : MonoBehaviour
{
    public GameObject[] arrayDeMesas;

    // Start is called before the first frame update
    void Start()
    {
        //2. Asignar todos los objetos tageados como "Mesa" en el array.
        arrayDeMesas = GameObject.FindGameObjectsWithTag("Mesa");
        AsignarElScriptMesa();
    }

    // Update is called once per frame
    void Update()
    {
        //4. Invocar la función al presionar la letra "Q".
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //DisableObjecsInArray();
            DestruirMesasConBoolTrue();
        }
    }

    // 3. Crear una función que desactive todos los elementos del array
    void DisableObjecsInArray()
    {
        for (int i = 0; i < arrayDeMesas.Length; i++)
        {
            arrayDeMesas[i].SetActive(false);
        }
    }

    /* 5. Crear una función que asigne a todos los elementos del array
    el script "Mesa". Establecer el valor de la variable "destructible" aleatoriamente. */
    void AsignarElScriptMesa()
    {
        foreach (GameObject go in arrayDeMesas)
        {
            go.AddComponent<Mesa>();
            go.GetComponent<Mesa>().destructible = Random.Range(0, 2) == 0;
        }
    }

    /* 6. Crear una función que destruya el elemento del array que contenga un
    script "Mesa" cuya variable booleana "destructible" sea true (crear el script "Mesa"). */
    void DestruirMesasConBoolTrue()
    {
        foreach (GameObject go in arrayDeMesas)
        {
            if (go.GetComponent<Mesa>().destructible)
            {
                Destroy(go);
            }
        }
    }
}
