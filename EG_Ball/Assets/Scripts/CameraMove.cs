using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform PlayerTransform;
    // public Rigidbody PlayerRigidbody;
    // public List<Vector3> _velocitiesList = new List<Vector3>();
    public float SpeedRotation;
    public float SpeedCamera;
    public Joystick joystick;
    private float MoveHorizontal;

    // private void Start() {
    //     for (int i = 0; i < 10; i++)
    //     {
    //         _velocitiesList.Add(Vector3.zero);
    //     }
    // }

    // private void FixedUpdate() {
    //     _velocitiesList.Add(PlayerRigidbody.velocity);
    //     _velocitiesList.RemoveAt(0);
    // }

    private void Update() {
        MoveHorizontal = joystick.Horizontal;
        // Vector3 sumVector = Vector3.zero;

        // for (int i = 0; i < _velocitiesList.Count; i++)
        // {
        //     sumVector += _velocitiesList[i];
        // }
        transform.position = Vector3.Lerp(transform.position, PlayerTransform.position, Time.deltaTime * SpeedCamera);
        // transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(PlayerRigidbody.velocity), Time.deltaTime * SpeedRotation);
        transform.Rotate(0f, MoveHorizontal * SpeedRotation, 0f);
    }
}
