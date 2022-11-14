using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public ListGolds ListGolds;
    public Transform Player;
    public Gold ClosestGold;
    void Update()
    {   
        transform.position = Player.transform.position + new Vector3(0f, 0.25f, 0f);;

        ClosestGold = ListGolds.GetClosest(transform.position);
        Debug.DrawLine(transform.position, ClosestGold.transform.position);

        transform.rotation = Quaternion.LookRotation(ClosestGold.transform.position - transform.position);
        
    }
}
