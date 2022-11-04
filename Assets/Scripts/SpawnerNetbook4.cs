using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerNetbook4 : MonoBehaviour
{
    public GameObject netbook;

    void Update()
    {
        if (CarroNetbooks4.check == true)
        {
            Instantiate(netbook, transform.position, Quaternion.identity);
            CarroNetbooks4.check = false;
        }
    }
}
