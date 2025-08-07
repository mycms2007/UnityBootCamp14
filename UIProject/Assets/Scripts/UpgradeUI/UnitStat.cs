using UnityEngine;

public class UnitStat : MonoBehaviour
{
    public int atk = 10;
    public int def = 5;

    // 강화 시 증가량
    public int atkPerUpgrade = 5;
    public int defPerUpgrade = 2;

    public void Upgrade()
    {
        atk += atkPerUpgrade;
        def += defPerUpgrade;
    }
}

