using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBoxes : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Parent;
    public Material MaterialA;
    public Material MaterialB;
    void Start()
    {  
        for (int i = -15; i < 15; i++)
        {
            for (int j = -15; j < 15; j++)
            {
                Instantiate(Prefab, new Vector3(i, 0, j), Quaternion.identity, Parent);
                if((i + j) % 2 == 0){
                    Prefab.GetComponent<MeshRenderer>().material = MaterialA;
                } else{
                    Prefab.GetComponent<MeshRenderer>().material = MaterialB;}
            }
        }        
    }
}
