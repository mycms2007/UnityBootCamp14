using UnityEngine;
//����Ƽ���� �����Ǵ� Ŭ���� ����� ��ũ��Ʈ�� �ۼ��մϴ�

//1. ����Ƽ�� Ʈ������ Ŭ���� ���
//Ʈ�������� ����Ƽ �����Ϳ��� ���� ������Ʈ�� ������ ��, 
//��� ���� ������Ʈ�� �⺻������ �ο��Ǵ� ������Ʈ�� �ǹ��մϴ�.

//�ش� ������Ʈ�� ��ġ(Position), ȸ��(Rotation), ũ��(Scale)�� ���� ������ ������ �ֽ��ϴ�.
//������Ʈ�� ����� ȣ���ϴ� GetComponent<T>�� ������� �ʰ� �ٷ� ����� �����մϴ�.

//�ش� Ŭ������ �������ִ� �Ӽ�(property)
//transform.position ->���� ������Ʈ�� ��ġ ������ �ǹ��մϴ�.
//Vector3 ������ ������, x,y,z���� ���� float

//transform.rotation -> ���� ������Ʈ�� ȸ�� ������ �ǹ��մϴ�.
//Quaternion ������ ������. x,y,z,w ���� float. �ε巯�� ȸ��.

//transfor.forward -> ���� ������Ʈ ������ ������ ��Ÿ���� ��.

//transform.up -> ���� ������Ʈ �������� ����� ��Ÿ���� ��

//transform.right -> ���� ������Ʈ �������� �������� ��Ÿ���� ��

//transform.eulerAngles -> ���� ������Ʈ�� ȸ�� ������ �ǹ��մϴ�.
//Vector3 ������ ������, x,y,z ���� float. �ܼ� ȸ��

//Tip �޼ҵ� () �ȿ� �ۼ��� ������ �ش� ����� ������ �� �������� ���� ���� ǥ��
//-> �Ķ����(parameter)


//�ش� Ŭ������ �������ִ� �ֿ� ����(�޼ҵ�)
//transform.LookAt(Transform target)
//������Ʈ�� �־��� Ÿ���� ���ϵ��� ���� ������Ʈ�� ȸ����Ű�� ���

//transform.Rotate(Vector3 eulerAngles)
//���޹��� ������ �������� ���� ������Ʈ�� ȸ����Ű�� ���

//trnasform.Translate(vector3 translation)
//�־��� ����(��)��ŭ ���� ������Ʈ�� �̵���Ű�� ���

public class sample3 : MonoBehaviour
{
    public GameObject go;

    //transform�� �̿��� ������Ʈ ����
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(go.transform.GetComponent<Sample4>().value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
