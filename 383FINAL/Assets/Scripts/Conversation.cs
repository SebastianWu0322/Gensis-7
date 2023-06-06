using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversation : MonoBehaviour
{
    public List<string> content;
    public Text text;

    int index = 0;

    private void Update()
    {
        if (text.transform.parent.gameObject.activeInHierarchy)
        {
            if (Input.GetMouseButtonDown(0))
            {
                index++;
                if (index >= content.Count)
                {
                    index = 0;
                    text.transform.parent.gameObject.SetActive(false);
                }
                text.text = content[index];
            }
        }
    }

    public void StartDialogue()
    {
        text.transform.parent.gameObject.SetActive(true);
        text.text = content[index];
      

    }

}
