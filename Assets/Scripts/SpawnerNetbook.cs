using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerNetbook : MonoBehaviour
{
    public GameObject netbook;

    void Update()
    {
        if (CarroNetbooks.check == true)
        {
            Instantiate(netbook, transform.position, Quaternion.identity);
            CarroNetbooks.check = false;
        }
    }
}
