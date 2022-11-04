using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueUI;
    [SerializeField] TextMeshProUGUI textoDelDialogo;
    [SerializeField] TextMeshProUGUI textoBoton;
    [SerializeField] bool hasTalked;
    [SerializeField] string[] frasesDialogo;
    [SerializeField] int posicionFrase;
    

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Al entrar activa la UI de diálogo
        if (other.gameObject.CompareTag("NPC"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            frasesDialogo = other.gameObject.GetComponent<NPCBehaviour>().data.dialoguePhrases;
            if (!hasTalked)
            {
                textoDelDialogo.text = "Hola forastero!";
                dialogueUI.SetActive(true);
            }
            else
            {
                textoDelDialogo.text = "Ya hemos hablado suficiente...";
                dialogueUI.SetActive(true);
                textoBoton.text = "Cerrar";
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Al salir desactiva la UI de diálogo
        if (other.gameObject.CompareTag("NPC"))
        {
            dialogueUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void NextPhrase()
    {
        if (posicionFrase < frasesDialogo.Length)
        {
            textoDelDialogo.text = frasesDialogo[posicionFrase];
            posicionFrase++;

            if (posicionFrase == frasesDialogo.Length)
            {
                textoBoton.text = "Cerrar";
            }
        }

        else
        {
            dialogueUI.SetActive(false);
            hasTalked = true;
        }
    }
}
