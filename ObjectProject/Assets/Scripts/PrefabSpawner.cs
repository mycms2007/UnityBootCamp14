using UnityEngine;
//1.�������� ���� ����Ѵ�
//2.������ ������Ʈ�� ���� ������ ���ο��� ������.
//3.���� �Ŀ� �ı��� ���� ������ �ð��� ������.

//�ش� ��ũ��Ʈ�� ���� ������Ʈ�� �����ϸ�, ������ �����ϰ� ���� �ð� �� �ı��ϵ���
//ó���մϴ�.  ����)�������� ����� �Ǿ����� �� �ش� �۾� ����, �ƴ� ��� ��� �޽����� �ȳ��մϴ�.


public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefab;
    private GameObject spawned;
    public float delay = 3.0f;


    void Start()
    {
        if (prefab != null)
        {
            spawned = Instantiate(prefab);
            //�����ڵ� = Instantiate()
            //1. Instantiate(prefab); �ش� �������� ������ �°� ��ġ�� ȸ�� �� ���� �����ǰ� �����˴ϴ�.
            //2. Instantiate(prefab, transform.position, Quaternion identity_;
            // -->�ش� �������� �����ϰ�, ��ġ�� ȸ�� ���� ������� ������Ʈ�� ��ġ�� ȸ�� ���� �����մϴ�.
            //3. Instantiate(prefab, parent);
            // ������Ʈ�� �����ϰ� �� ������Ʈ�� ������ ��ġ�� �ڽ����ν� ����մϴ�.
            //4. Instantiate(prefab, position, quaternion, parent);

            spawned.name = "������ ������Ʈ";
            //������ ������Ʈ�� �̸��� �����ϴ� �ڵ�.

            spawned.AddComponent<Rigidbody>();

            Debug.Log(spawned.name + "�� �����Ǿ����ϴ�.");
           
        }
        else
        {
            Debug.LogWarning("��ϵ� �������� ���� �����ϴ�.");
            Destroy(spawned, delay); //delay �ð� ���� ������Ʈ �ı�.
        }


    }
}
