using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{

    public Conversation conversation;

    //Unity �Դ����������ڼ�����������Ƿ��нӴ�
    private void OnTriggerEnter(Collider other)
    {
        //�����ǰ����Ӵ�����tagΪPlayer������ʱ
        if(other.CompareTag("Player"))
        {
            //�����Ի�
            conversation.StartDialogue();
        }
    }
}
