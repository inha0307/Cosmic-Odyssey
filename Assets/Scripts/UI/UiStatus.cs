using UnityEngine;
using UnityEngine.UI;

public class UiStatus : MonoBehaviour
{
    public PlayerStatus status;
    public Slider hpSlider;
    public Slider mpSlider;

    void Start()
    {
        if (status != null)
        {
            hpSlider.maxValue = status.maxHp;
            mpSlider.maxValue = status.maxMp;
        }
    }

    void Update()
    {
        if (status != null)
        {
            hpSlider.value = status.CurrentHp;
            mpSlider.value = status.CurrentMp;
        }
    }
}
