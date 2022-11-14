using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noise : MonoBehaviour
{
    public float Force;
    void Update()
    {
        float y = Mathf.PerlinNoise(transform.position.x + 2.5f + Time.time / 5, transform.position.z + 2.5f) * 2f;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
    private void OnTriggerEnter(Collider other) {
        other.GetComponent<Rigidbody>().AddForce(Vector3.up * Force);
    }
}
