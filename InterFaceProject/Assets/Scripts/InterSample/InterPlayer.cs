using UnityEngine;
using UnityEngine.UI;

public class InterPlayer : MonoBehaviour
{
    //�ν����� ������ ���ٰ���(���� ������ ���� ����)
    //�ܺο��� ���ٺҰ�(�Ժη� �� ��������� �뵵)
    [SerializeField] private ScriptableObject attackObject;

    private IAttackStrategy strategy;

    private void Awake()
    {
        strategy = attackObject as IAttackStrategy;

        if(strategy == null )
        {
            Debug.LogError("���� ����� �������� �ʾҽ��ϴ�!");
        }
    }


    public void ActionPerformed(GameObject target)
    {
        strategy?.Attack(target);
        //Nullable<T>or T?�� Value�� ���� null ����� ���� ����
    }

}
