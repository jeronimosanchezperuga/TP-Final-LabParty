using UnityEngine;

[CreateAssetMenu(fileName = "New NPC1Data", menuName = "NPC1Data")]

public class NPC1Data : ScriptableObject
{
    [SerializeField] private string dialogo1, dialogo2, dialogo3, dialogo4, dialogo5, dialogo6;
   public bool hasTalked;

    public string Dialogo1 { get { return dialogo1; } }
    public string Dialogo2 { get { return dialogo2; } }
    public string Dialogo3 { get { return dialogo3; } }
    public string Dialogo4 { get { return dialogo4; } }
    public string Dialogo5 { get { return dialogo5; } }
    public string Dialogo6 { get { return dialogo6; } }
}
