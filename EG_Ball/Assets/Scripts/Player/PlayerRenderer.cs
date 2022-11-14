using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRenderer : MonoBehaviour
{
    private int _index;
    private Renderer _renderer;
    public List<Material> ListMatPlayer = new List<Material>();
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _index = PlayerPrefs.GetInt("IndexMat");
        GetMatirialPlayer(_index);
    }
    public void GetMatirialPlayer(int i){
        _renderer.material = ListMatPlayer[i];
    }
}
