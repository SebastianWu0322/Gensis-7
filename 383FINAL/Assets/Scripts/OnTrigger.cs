using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{

    public Conversation conversation;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            conversation.StartDialogue();
        }
    }
}
