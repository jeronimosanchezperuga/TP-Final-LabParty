using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerNetbook3 : MonoBehaviour
{
    public GameObject netbook;

    void Update()
    {
        if (CarroNetbooks3.check == true)
        {
            Instantiate(netbook, transform.position, Quaternion.identity);
            CarroNetbooks3.check = false;
        }
    }
}
