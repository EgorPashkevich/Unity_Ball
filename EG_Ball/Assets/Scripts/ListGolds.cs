using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListGolds : MonoBehaviour
{
    public List<Gold> _listGolds = new List<Gold>();
    public GameObject Gold;
    public Transform ScriptListGold;
    public Text TextGold;

    private void Start() {
        
        for (int i = 0; i < 50; i++)
        {
            Vector3 positionGold = new Vector3(Mathf.Floor(Random.Range(-15f, 15f)), 10f, Mathf.Floor(Random.Range(-15f, 15f)));
            GameObject newGold = Instantiate(Gold, positionGold, Quaternion.identity, ScriptListGold);
            _listGolds.Add(newGold.GetComponent<Gold>());
        }
        ChangeText();

        
    }
    public void CollectGold(Gold gold){
        _listGolds.Remove(gold);
        Destroy(gold.gameObject);

        ChangeText();
    }
    void ChangeText(){
        TextGold.text = "Осталось: " + _listGolds.Count.ToString();
    }

    public Gold GetClosest(Vector3 point){

        float minDistance = Mathf.Infinity;
        Gold closestGold = null;
        for (int i = 0; i < _listGolds.Count; i++)
        {
            float distance = Vector3.Distance(point, _listGolds[i].transform.position);
            if(distance < minDistance){
            minDistance = distance;
            closestGold = _listGolds[i];
            }
        }
        return closestGold;
    }
}
