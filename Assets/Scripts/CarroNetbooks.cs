using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroNetbooks : MonoBehaviour
{
    public GameObject inticon, Ntext, Carro1;
    public static bool check;

    void Start()
    {
        check = false;
    }   

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inticon.SetActive(true);
            Ntext.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Q))
            {
                check = true;
                Carro1.GetComponent<Animator>().Play("Carro1");
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inticon.SetActive(false);
            Ntext.SetActive(false);
            check = false;
        }
    }
}
