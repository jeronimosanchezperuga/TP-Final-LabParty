using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerNetbook2 : MonoBehaviour
{
    public GameObject netbook;

    void Update()
    {
        if (CarroNetbooks2.check == true)
        {
            Instantiate(netbook, transform.position, Quaternion.identity);
            CarroNetbooks2.check = false;
        }
    }
}
