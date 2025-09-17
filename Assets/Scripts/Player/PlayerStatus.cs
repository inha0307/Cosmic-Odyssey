using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int maxHp = 100;
    public int maxMp = 50;

    public int CurrentHp { get; private set; }
    public int CurrentMp { get; private set; }

    void Awake()
    {
        CurrentHp = maxHp;
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
