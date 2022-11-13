using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.AI;
using TMPro;

public class LogicaNPC : MonoBehaviour
{
    public GameObject panelNPCHablar, panelNPCMision, inticon, Player, MissionObjects, PanelGeneral, panelTimer, NPCMujer2;
    public TextMeshProUGUI textoObjetivoNPC;
    public GameObject[] objetivos;
    public int numDeObjetivos;
    public AudioSource HmmNPC, DiscoMusic, RelaxingMusic;
    public static bool check = false;
    public static bool check2 = false;
    public static bool check3 = false;
    public static bool check4 = false;
    public static bool checkMujer2 = false;
    [SerializeField] NPC1Data NPCOddChap, NPCMujer1Data, NPCMujer2Data, NPCHombre1Data;

    void Start()
    {
        numDeObjetivos = objetivos.Length;
        panelNPCHablar.SetActive(false);
        check = false;
        check2 = false;
        check3 = false;
        check4 = false;
        checkMujer2 = false;
        NPCOddChap.hasTalked = false;
        NPCMujer1Data.hasTalked = false;
        NPCMujer2Data.hasTalked = false;
        NPCHombre1Data.hasTalked = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (check == false)
        {
            if (col.gameObject.tag == "NPC")
            {
                inticon.SetActive(true);
                panelNPCHablar.SetActive(true);
            }
        }

        if (LogicaObjetivos.check3 == true)
        {
            if (col.gameObject.tag == "NPC")
            {
                inticon.SetActive(true);
                panelNPCHablar.SetActive(true);
                panelNPCMision.SetActive(false);
                PanelGeneral.SetActive(false);
            }
        }

        if (NPCMujer2Data.hasTalked == false)
        {
            if (col.gameObject.tag == "NPC2")
            {
                inticon.SetActive(true);
                panelNPCHablar.SetActive(true);

                NPCMujer2.GetComponent<Animator>().SetBool("isIdle", true);
                checkMujer2 = true;
            }
        }

        if (NPCHombre1Data.hasTalked == false)
        {
            if (col.gameObject.tag == "NPC3")
            {
                inticon.SetActive(true);
                panelNPCHablar.SetActive(true);
            }
        }

        if (NPCMujer1Data.hasTalked == false)
        {
            if (col.gameObject.tag == "NPC4")
            {
                inticon.SetActive(true);
                panelNPCHablar.SetActive(true);
            }
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (NPCOddChap.hasTalked == false)
        {
            if (col.gameObject.tag == "NPC")
            {
                if (check == false)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        HmmNPC.Play();
                        Player.GetComponent<FirstPersonController>().enabled = false;
                        inticon.SetActive(false);
                        panelNPCHablar.SetActive(false);
                        panelNPCMision.SetActive(true);
                        StartCoroutine(HablarConNPC1());
                        check = true;
                        NPCOddChap.hasTalked = true;
                    }
                }

                if (LogicaObjetivos.check3 == true)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        HmmNPC.Play();
                        Player.GetComponent<FirstPersonController>().enabled = false;
                        inticon.SetActive(false);
                        panelNPCHablar.SetActive(false);
                        PanelGeneral.SetActive(false);
                        panelNPCMision.SetActive(true);
                        StartCoroutine(HablarConNPC2());
                    }
                }
            }
        }
        
        if (NPCMujer2Data.hasTalked == false)
        {
            if (col.gameObject.tag == "NPC2")
            {
                NPCMujer2.GetComponent<Animator>().SetBool("isIdle", true);
                checkMujer2 = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    HmmNPC.Play();
                    Player.GetComponent<FirstPersonController>().enabled = false;
                    inticon.SetActive(false);
                    panelNPCHablar.SetActive(false);
                    PanelGeneral.SetActive(false);
                    panelNPCMision.SetActive(true);
                    StartCoroutine(HablarConNPC3());
                    NPCMujer2Data.hasTalked = true;
                }
            }
        }
        
        if (NPCHombre1Data.hasTalked == false)
        {
            if (col.gameObject.tag == "NPC3")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    HmmNPC.Play();
                    Player.GetComponent<FirstPersonController>().enabled = false;
                    inticon.SetActive(false);
                    panelNPCHablar.SetActive(false);
                    PanelGeneral.SetActive(false);
                    panelNPCMision.SetActive(true);
                    StartCoroutine(HablarConNPC4());
                    NPCHombre1Data.hasTalked = true;
                }
            }
        }

        if (NPCMujer1Data.hasTalked == false)
        {
            if (col.gameObject.tag == "NPC4")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    HmmNPC.Play();
                    Player.GetComponent<FirstPersonController>().enabled = false;
                    inticon.SetActive(false);
                    panelNPCHablar.SetActive(false);
                    PanelGeneral.SetActive(false);
                    panelNPCMision.SetActive(true);
                    StartCoroutine(HablarConNPC5());
                    NPCMujer1Data.hasTalked = true;
                }
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "NPC")
        {
            inticon.SetActive(false);
            panelNPCHablar.SetActive(false);
        }

        if (col.gameObject.tag == "NPC2")
        {
            inticon.SetActive(false);
            panelNPCHablar.SetActive(false);

            NPCMujer2.GetComponent<Animator>().SetBool("isIdle", false);
            checkMujer2 = false;
        }

        if (col.gameObject.tag == "NPC3")
        {
            inticon.SetActive(false);
            panelNPCHablar.SetActive(false);
        }

        if (col.gameObject.tag == "NPC4")
        {
            inticon.SetActive(false);
            panelNPCHablar.SetActive(false);
        }
    }

    IEnumerator HablarConNPC1()
    {
        textoObjetivoNPC.text = NPCOddChap.Dialogo1;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCOddChap.Dialogo2;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCOddChap.Dialogo3;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCOddChap.Dialogo4;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCOddChap.Dialogo5;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCOddChap.Dialogo6;
        yield return new WaitForSeconds(2.5f);

        panelNPCMision.SetActive(false);
        Player.GetComponent<FirstPersonController>().enabled = true;
        NPCOddChap.hasTalked = true;

        /*panelNPCMision.SetActive(false);
        Player.GetComponent<FirstPersonController>().enabled = true;
        MissionObjects.SetActive(true);
        PanelGeneral.SetActive(true);
        check2 = true;
        RelaxingMusic.Stop();
        DiscoMusic.Play();
        check3 = true;
        panelTimer.SetActive(true);*/
    }

    IEnumerator HablarConNPC2()
    {
        textoObjetivoNPC.text = "Party  Time!!!";
        yield return new WaitForSeconds(2.5f);
        Player.GetComponent<FirstPersonController>().enabled = true;
        check4 = true;
    }

    IEnumerator HablarConNPC3()
    {
        textoObjetivoNPC.text = NPCMujer2Data.Dialogo1;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCMujer2Data.Dialogo2;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCMujer2Data.Dialogo3;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCMujer2Data.Dialogo4;
        yield return new WaitForSeconds(2.5f);
        panelNPCMision.SetActive(false);
        Player.GetComponent<FirstPersonController>().enabled = true;
    }

    IEnumerator HablarConNPC4()
    {
        textoObjetivoNPC.text = NPCHombre1Data.Dialogo1;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCHombre1Data.Dialogo2;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCHombre1Data.Dialogo3;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCHombre1Data.Dialogo4;
        yield return new WaitForSeconds(2.5f);
        panelNPCMision.SetActive(false);
        Player.GetComponent<FirstPersonController>().enabled = true;
    }

    IEnumerator HablarConNPC5()
    {
        textoObjetivoNPC.text = NPCMujer1Data.Dialogo1;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCMujer1Data.Dialogo2;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCMujer1Data.Dialogo3;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCMujer1Data.Dialogo4;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCMujer1Data.Dialogo5;
        yield return new WaitForSeconds(2.5f);
        textoObjetivoNPC.text = NPCMujer1Data.Dialogo6;
        yield return new WaitForSeconds(2.5f);
        panelNPCMision.SetActive(false);
        Player.GetComponent<FirstPersonController>().enabled = true;
    }
}