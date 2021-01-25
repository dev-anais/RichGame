using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{

    public Text txtName;
    public Text txtContent;

    Queue<string> sentences = new Queue<string>();

    public void Begin(Conversation info){
        sentences.Clear();

        txtName.text = info.name;

        foreach(var sentence in info.sentences){
            sentences.Enqueue(sentence);
        }

        Next();
    }

    public void Next(){
        if(sentences.Count == 0){
            End();
            return;
        }

        txtContent.text = sentences.Dequeue();
    }
    private void End(){
        txtContent.text = string.Empty;

    }
}
