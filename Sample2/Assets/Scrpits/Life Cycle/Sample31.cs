using UnityEngine;

//������Ʈ ĳ�̿� ���Ͽ�(Object cashing)

//ĳ��(Cashe)?
//���� ���Ǵ� �����ͳ� ���� �̸� �����صδ� �ӽ� ���

//ĳ�� ��� �ǵ�
//1. �ð� ������ : ���� �ֱٿ� ���� ���� �ٽ� ���� ���ɼ��� ����.
//2. ���� ������ : �ֱٿ� ������ �ּҿ� ������ �ּ��� ������ ���� ���ɼ��� ����.
public class Sample31 : MonoBehaviour
{
    Rigidbody rb;
    Vector3 pos;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //ĳ��(cashing)
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(pos * 5); //�����Ӹ��� ȣ��
    }
}
