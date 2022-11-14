using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{   
    public float SpeedRotate;

    void Update()
    {
        transform.Rotate(0f, SpeedRotate * Time.deltaTime, 0f);
    }
}
