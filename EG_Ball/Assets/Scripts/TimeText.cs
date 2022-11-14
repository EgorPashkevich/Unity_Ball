using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    public Text TextTime;
    void Update()
    {
        TextTime.text = "Time: " + Time.time.ToString("0.00");
    }
}
