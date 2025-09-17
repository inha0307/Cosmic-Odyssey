using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int maxMp = 50;
    public int CurrentMp { get; private set; }

    void Awake()
    {
        CurrentMp = maxMp;
    }

    public bool ConsumeMp(int amount)
    {
        if (CurrentMp >= amount)
        {
            CurrentMp -= amount;
            return true;
        }
        return false;
    }
}
