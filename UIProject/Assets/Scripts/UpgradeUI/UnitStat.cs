using UnityEngine;

public class UnitStat : MonoBehaviour
{
    public int atk = 10;
    public int def = 5;

    // ��ȭ �� ������
    public int atkPerUpgrade = 5;
    public int defPerUpgrade = 2;

    public void Upgrade()
    {
        atk += atkPerUpgrade;
        def += defPerUpgrade;
    }
}

