using UnityEngine;
using UnityEngine.UI;

public class DataStorage : MonoBehaviour
{
    public Slider speed;

    public Toggle largeBall;

    public Dropdown ballColor;

    public void Update()
    {
        DataMutator.Instance.speed = speed.value;
        DataMutator.Instance.largeBall = largeBall.isOn;
        DataMutator.Instance.ballColor = ballColor.value;
    }
}