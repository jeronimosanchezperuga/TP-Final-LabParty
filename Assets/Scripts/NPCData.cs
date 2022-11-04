using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NPCDataSO", menuName = "NPC Data")]
public class NPCData : ScriptableObject
{
    public string[] dialoguePhrases;
    public bool hasTalked;
}
