using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour,Interactable
{
    static public int cou = 0;
    [SerializeField] Dialog dialog;

    public void Interact()
    {
     Dialogmanager.Instance.ShowDialog(dialog);
    }
    

}
