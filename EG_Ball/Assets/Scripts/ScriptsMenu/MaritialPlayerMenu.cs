using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaritialPlayerMenu : MonoBehaviour
{
    // public Renderer Renderer;

    // public void ChangeMatirialMenu(Material matirial){
    //     Renderer.material = matirial;
        
    // }

    public void SetIntMat(int i){
        PlayerPrefs.SetInt("IndexMat", i);
    }
}
