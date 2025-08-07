using UnityEngine;
public class UnityInventory : MonoBehaviour
{
    public int gold = 300;
    public int ruby = 2;
    public int sapphire = 1;
    public int magicStone = 1;

    public bool HasRequiredMaterials(string[] materials)
    {
        // 여기서 materials 배열을 검사해서 인벤토리에 전부 있는지 판단
        return true; // 임시로 항상 성공 처리
    }

    public void ConsumeMaterials(string[] materials)
    {
        // 실제 인벤토리에서 해당 자원을 차감하는 로직 작성
        Debug.Log("재료 차감 완료");
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