using UnityEngine;
public class UnityInventory : MonoBehaviour
{
    public int gold = 300;
    public int ruby = 2;
    public int sapphire = 1;
    public int magicStone = 1;

    public bool HasRequiredMaterials(string[] materials)
    {
        // ���⼭ materials �迭�� �˻��ؼ� �κ��丮�� ���� �ִ��� �Ǵ�
        return true; // �ӽ÷� �׻� ���� ó��
    }

    public void ConsumeMaterials(string[] materials)
    {
        // ���� �κ��丮���� �ش� �ڿ��� �����ϴ� ���� �ۼ�
        Debug.Log("��� ���� �Ϸ�");
    }
    public bool UseResources(int level)
    {
        switch (level)
        {
            case 1:
                if (gold >= 100) { gold -= 100; return true; }
                break;
            case 2:
                if (gold >= 100 && ruby >= 1)
                {
                    gold -= 100; ruby -= 1;
                    return true;
                }
                break;
            case 3:
                if (gold >= 200 && sapphire >= 1 && magicStone >= 1)
                {
                    gold -= 200; sapphire -= 1; magicStone -= 1;
                    return true;
                }
                break;
        }
        return false;
    }
}