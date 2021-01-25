using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationTrigger : MonoBehaviour
{
    public Conversation info;

    public void Trigger(){
        var manager = FindObjectOfType<DialogManager>();
        manager.Begin(info);
    }
}
