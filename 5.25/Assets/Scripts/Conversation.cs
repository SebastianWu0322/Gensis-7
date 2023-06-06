using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversation : MonoBehaviour
{
    //���еĶԻ����ݴ�Ŵ�
    public List<string> content;
    //�ı�����
    public Text text;

    //���������������ȡÿ�ζԻ��ı�
    int index = 0;

    //Unity �Դ���������Ϸ����ʱÿִ֡�д������ڵĴ���
    private void Update()
    {
        //����ı�����û�б�����
        if (text.transform.parent.gameObject.activeInHierarchy)
        {
            //�����������ָ���
            if (Input.GetMouseButtonDown(0))
            {
                //�Ի��л�����һ��
                index++;
                //�����ǰ�Ի��Ѿ������һ��������
                if (index >= content.Count)
                {
                    //���������óɵ�һ�Σ�Ϊ���ٴο����Ի�
                    index = 0;
                    //�Ի������������ı�����
                    text.transform.parent.gameObject.SetActive(false);
                }
                //�ѶԻ���ӳ���ı������ϣ��Թ���ʾ�ڳ�����
                text.text = content[index];
            }
        }
    }

    //���ڿ����Ի����ܵĺ���
    public void StartDialogue()
    {
        //��������ʾ�ı�����
        text.transform.parent.gameObject.SetActive(true);
        //��ÿ�ζԻ��ı��ŵ�Text�����
        text.text = content[index];
      

    }

}
