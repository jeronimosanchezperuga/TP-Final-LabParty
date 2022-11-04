using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashylights : MonoBehaviour
{
    public GameObject light1, light2, light3, light4, light5, light6, light7, light8, light9, light10, light11;
    private int i = 0;
   
    void Start()
    {
        StartCoroutine(LightSequence1());
        StartCoroutine(LightSequence2());
        StartCoroutine(LightSequence3());
        StartCoroutine(LightSequence4());
        StartCoroutine(LightSequence5());
        StartCoroutine(LightSequence6());
        StartCoroutine(LightSequence7());
        StartCoroutine(LightSequence8());
        StartCoroutine(LightSequence9());
        StartCoroutine(LightSequence10());
        StartCoroutine(LightSequence11());
    }

    IEnumerator LightSequence1()
    {
        while (i == 0)
        {
            light1.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            light1.SetActive(false);
            yield return new WaitForSeconds(0.3f);
        }
    }

    IEnumerator LightSequence2()
    {
        while (i == 0)
        {
            light2.SetActive(true);
            yield return new WaitForSeconds(0.45f);
            light2.SetActive(false);
            yield return new WaitForSeconds(0.45f);
        }
    }

    IEnumerator LightSequence3()
    {
        while (i == 0)
        {
            light3.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            light3.SetActive(false);
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator LightSequence4()
    {
        while (i == 0)
        {
            light4.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            light4.SetActive(false);
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator LightSequence5()
    {
        while (i == 0)
        {
            light5.SetActive(true);
            yield return new WaitForSeconds(0.6f);
            light5.SetActive(false);
            yield return new WaitForSeconds(0.6f);
        }
    }

    IEnumerator LightSequence6()
    {
        while (i == 0)
        {
            light6.SetActive(true);
            yield return new WaitForSeconds(0.18f);
            light6.SetActive(false);
            yield return new WaitForSeconds(0.18f);
        }
    }

    IEnumerator LightSequence7()
    {
        while (i == 0)
        {
            light7.SetActive(true);
            yield return new WaitForSeconds(0.35f);
            light7.SetActive(false);
            yield return new WaitForSeconds(0.35f);
        }
    }
    IEnumerator LightSequence8()
    {
        while (i == 0)
        {
            light8.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            light8.SetActive(false);
            yield return new WaitForSeconds(0.3f);
        }
    }

    IEnumerator LightSequence9()
    {
        while (i == 0)
        {
            light9.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            light9.SetActive(false);
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator LightSequence10()
    {
        while (i == 0)
        {
            light10.SetActive(true);
            yield return new WaitForSeconds(0.62f);
            light10.SetActive(false);
            yield return new WaitForSeconds(0.62f);
        }
    }

    IEnumerator LightSequence11()
    {
        while (i == 0)
        {
            light11.SetActive(true);
            yield return new WaitForSeconds(0.21f);
            light11.SetActive(false);
            yield return new WaitForSeconds(0.21f);
        }
    }
}
