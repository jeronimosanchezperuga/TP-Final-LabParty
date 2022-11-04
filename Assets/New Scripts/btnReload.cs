using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnReload : MonoBehaviour
{
    public static bool checkFade = false;
    public GameObject LevelChanger;

    void Start()
    {
        checkFade = false;
        LevelChanger.SetActive(false);
    }

    public void ActivateFadeLoseScene()
    {
        LevelChanger.SetActive(true);
        checkFade = true;
    }
}
