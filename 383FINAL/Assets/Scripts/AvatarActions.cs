using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AvatarActions : MonoBehaviour
{

    [Tooltip("Turn speed in degrees per second")]
    public float turnSpeed = 100.0f;

    [Tooltip("Movement speed in meters per second (assumes 1 unit = 1 meter)")]
    public float moveSpeed = 10.0f;

    public float downSpeed = 10f;

    public GameObject ArCamera;
    public GameObject commonCamera;
    public Transform parent;

    private float turn = 0.0f;

 private float turn_Vertical=0.0f;

    private float move = 0.0f;

    private float down = 0.0f;

    private void setButtonCallbacks()
    {
        // Assumes each button has already been set with two triggers; a pointer down followed by a pointer up.
        GameObject.Find("Canvas/LeftButton").GetComponent<EventTrigger>().triggers[0].callback.AddListener((data) =>
        {
            Left();
        });
        GameObject.Find("Canvas/LeftButton").GetComponent<EventTrigger>().triggers[1].callback.AddListener((data) => { Stop(); });
        GameObject.Find("Canvas/RightButton").GetComponent<EventTrigger>().triggers[0].callback.AddListener((data) => { Right(); });
        GameObject.Find("Canvas/RightButton").GetComponent<EventTrigger>().triggers[1].callback.AddListener((data) => { Stop(); });
        GameObject.Find("Canvas/ForwardButton").GetComponent<EventTrigger>().triggers[0].callback.AddListener((data) => { Forward(); });
        GameObject.Find("Canvas/ForwardButton").GetComponent<EventTrigger>().triggers[1].callback.AddListener((data) => { Stop(); });
      //  GameObject.Find("Canvas/DropButton").GetComponent<EventTrigger>().triggers[0].callback.AddListener((data) => { Drop(); });
        GameObject.Find("Canvas/DropButton").GetComponent<EventTrigger>().triggers[1].callback.AddListener((data) => { Stop(); });
    }

    public void Update()
    {
       
           parent.transform.rotation *= Quaternion.AngleAxis(turn * turnSpeed * Time.deltaTime, Vector3.up);
              parent.transform.rotation *= Quaternion.AngleAxis(turn_Vertical * turnSpeed * Time.deltaTime, Vector3.right);
           parent.transform.position += move * moveSpeed * parent.transform.forward;
           parent.transform.position += down * downSpeed * -parent.transform.up;
      
    }

  

    public void Left()
    {
        turn = -1.0f;
    }
    public void Right()
    {
        turn = 1.0f;
    }
    public void Forward()
    {
        move = 1.0f;
    }


public void Retreat()
    {
        move = -1f;
    }

    public void Down()
    {
        down = 1.0f;
    }

    public void Up()
    {
        down = -1.0f;
    }


public void LookUp()
{
    turn_Vertical=-1.0f;
}

public void LookDown()
{
    turn_Vertical=1.0f;
}


    bool once;

    public void ChangeCamera()
    {
        if (!once)
        {
            ArCamera.SetActive(true);
            commonCamera.SetActive(false);
            once = true;
        }
        else
        {
            commonCamera.SetActive(true);
            ArCamera.SetActive(false);
            once = false;
        }
    }

    public void Stop()
    {
        turn = 0.0f;
        turn_Vertical=0.0f;
        move = 0.0f;
        down = 0.0f;
    }

}