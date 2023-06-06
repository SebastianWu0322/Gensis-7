using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroTrack : MonoBehaviour
{
    private Gyroscope gyro;

    private bool gyroSupported;

    // Start is called before the first frame update
    void Start()
    {
        // ensure this code is only used if there is actually
        // a gyroscope.
        gyroSupported = SystemInfo.supportsGyroscope;
        if (gyroSupported)
        {
            // Get hold of the system gyroscope.
            gyro = Input.gyro;
            // Switch it on.
            gyro.enabled = true;
        }

        Debug.Log(gyroSupported);
Debug.Log(gyro);

    }

    // Update is called once per frame
    void Update()
    {
        if (gyroSupported)
        {
            // Map the gyro rotation into the same coordinate system as the unity camera.
            transform.parent.transform.rotation = Quaternion.Euler(90, 0, 90) * gyro.attitude * Quaternion.Euler(180, 180, 0);
        }
    }
}