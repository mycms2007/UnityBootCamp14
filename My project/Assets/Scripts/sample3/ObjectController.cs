using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("mini simple skeleton demo");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.6f*Time.deltaTime, 0);

        //���Ϲ��� y���� 2���� ������ ���Ϲ��� �ı��ϴ� �ڵ�
        if (transform.position.y < -2)
        {
            Destroy(gameObject);
        }

        //�浹 ���� ó��
        //���� ���� �浹 ���� ���� ���
        Vector3 v1 = transform.position;
        Vector3 v2 = player.transform.position;

        Vector3 dir = v1 - v2;

        float d = dir.magnitude; //������ ũ�� �Ǵ� ���̸� �ǹ��մϴ�. (�� �� ������ �Ÿ��� ����� �� ����մϴ�.)

        float obj_r1 = 0.5f;
        float obj_r2 = 1.0f;

        //�� �� ������ �Ÿ��� d�� ���� ������ �������� �պ��� ũ�ٸ� �浹���� �ʴ� ��Ȳ
        if (d < obj_r1 + obj_r2)
        {
            Destroy (gameObject);
        }
    }
}