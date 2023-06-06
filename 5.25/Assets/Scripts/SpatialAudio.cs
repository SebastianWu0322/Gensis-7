using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpatialAudio : MonoBehaviour
{
    public GameObject source;
    public float maxVolume = 1.0f;
    public float speedOfSound = 330.0f;
    private Vector3 prevDisplacement;
    void Update()
    {

        Vector3 displacement = source.transform.position - this.transform.position;
        float distance = displacement.magnitude;
        Vector3 velocity = (displacement - prevDisplacement) / Time.deltaTime; 
        prevDisplacement = displacement; 
        Vector3 direction = Vector3.Normalize(displacement); 
        float relativeSpeed = Vector3.Dot(velocity,direction);
        //source,GetComponent<AudioSource>(),volume = maxVolume / (distance);
        source.GetComponent<AudioSource>().pitch = (speedOfSound + relativeSpeed) /(speedOfSound - relativeSpeed);
    }
}