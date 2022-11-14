using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float HorixonvalMove;
    private float VerticalMove;
    public Transform CameraCenter;
    public float Speed;
    public float ForseSpeed;
    public float VelocityUpForward;
    public bool _boolUp;
    public bool _boolForward;
    public ListGolds ListGolds;
    public Joystick joystick;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.maxAngularVelocity = Speed;
    }

    private void FixedUpdate() {
        HorixonvalMove = joystick.Horizontal;
        VerticalMove = joystick.Vertical;
        _rigidbody.AddTorque(CameraCenter.right * VerticalMove * ForseSpeed);       
        _rigidbody.AddTorque(-CameraCenter.forward * HorixonvalMove * ForseSpeed);
        if(_boolUp){
            if(HorixonvalMove != 0 || VerticalMove != 0){
                _rigidbody.AddForce(Vector3.up * VerticalMove * 2.5f, ForceMode.Impulse);
                _rigidbody.AddForce(Vector3.left * HorixonvalMove * 2.5f, ForceMode.Impulse);
            }
        }
        if(_boolForward){
            _rigidbody.AddForce(CameraCenter.forward * VerticalMove * VelocityUpForward, ForceMode.Impulse);       
            _rigidbody.AddForce(CameraCenter.right * HorixonvalMove * VelocityUpForward, ForceMode.Impulse);
            } 
    }
    private void OnCollisionStay(Collision other) {
        _boolForward = false;
        Vector3 normal = other.contacts[0].normal;

        float dot = Vector3.Dot(normal, Vector3.up);
        if(dot < 0.65){
            _boolUp = true;
        }
    }
    private void OnCollisionExit(Collision other) {
        _boolUp = false;
        _boolForward = true;
    }
    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<Gold>()){
            ListGolds.CollectGold(other.GetComponent<Gold>());
        }
    }
}
