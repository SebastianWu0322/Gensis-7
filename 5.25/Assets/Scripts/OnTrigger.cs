using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{

    public Conversation conversation;

    //Unity 自带函数，用于检测俩个物体是否有接触
    private void OnTriggerEnter(Collider other)
    {
        //如果当前物体接触到了tag为Player的物体时
        if(other.CompareTag("Player"))
        {
            //开启对话
            conversation.StartDialogue();
        }
    }
}
