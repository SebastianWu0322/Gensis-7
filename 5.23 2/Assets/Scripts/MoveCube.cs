using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    private void Update()
    {
        transform.position = new Vector3(10.0f * Mathf.Sin(0.3f * Time.time), 0.1f, 0.1f);
    }
}
