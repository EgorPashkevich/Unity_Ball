using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMatirial : MonoBehaviour
{
    private int _index;
    public List<Material> ListMatirialsPlayer = new List<Material>();
    private Renderer _renderer;
    private void Start() {
        _renderer = GetComponent<Renderer>();
    }
   
    void Update()
    {
            _index = PlayerPrefs.GetInt("IndexMat"); 
            GetMatirialPlayer(_index);
    }

    public void GetMatirialPlayer(int i){
        _renderer.material = ListMatirialsPlayer[i];
    }
}
