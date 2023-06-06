using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversation : MonoBehaviour
{
    //所有的对话内容存放处
    public List<string> content;
    //文本对象
    public Text text;

    //索引，用来逐个获取每段对话文本
    int index = 0;

    //Unity 自带函数，游戏运行时每帧执行大括号内的代码
    private void Update()
    {
        //如果文本对象没有被隐藏
        if (text.transform.parent.gameObject.activeInHierarchy)
        {
            //如果鼠标或者手指点击
            if (Input.GetMouseButtonDown(0))
            {
                //对话切换到下一段
                index++;
                //如果当前对话已经是最后一段内容了
                if (index >= content.Count)
                {
                    //把索引设置成第一段，为了再次开启对话
                    index = 0;
                    //对话结束，隐藏文本对象
                    text.transform.parent.gameObject.SetActive(false);
                }
                //把对话反映在文本对象上，以供显示在场景中
                text.text = content[index];
            }
        }
    }

    //用于开启对话功能的函数
    public void StartDialogue()
    {
        //场景内显示文本对象
        text.transform.parent.gameObject.SetActive(true);
        //把每段对话文本放到Text组件上
        text.text = content[index];
      

    }

}
