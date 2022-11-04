using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool keyAdquired = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Puerta"))
        {
            Debug.Log(other.gameObject);
            //comunicarse con el script de la puerta y activar apertura de puerta
            //solo si tengo la llave (keyscript no es null)
            if (keyAdquired)
            {
                Debug.Log(other.gameObject);
                other.GetComponent<RotateBothDirections>().UseDoor();
            }
            
        }

        if (other.gameObject.CompareTag("Key"))
        {
            
            //cambio el bool para indicar que tengo la llave
            keyAdquired = true;
            Destroy(other.gameObject);
            //TODO
            //actualizar UI para mostrar el item
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Puerta"))
        {
            //comunicarse con el script de la puerta y activar apertura de puerta
            other.GetComponent<RotateBothDirections>().UseDoor();
        }
    }

}
