using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject ObjectPrefab;

    float spawnTime = 2.0f;
    float time = 0.0f;//�ð� üũ�� ����
    //�ð��� ���� ����ؼ�, ������ �����ϰ�
    //�� ������ ���� Ÿ�Ӻ��� Ŀ���� ������Ʈ ����
    //������ 0���� �ʱ�ȭ

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > spawnTime)
        {
            GameObject go = Instantiate(ObjectPrefab);
            time = 0.0f;


        }
    }
}
