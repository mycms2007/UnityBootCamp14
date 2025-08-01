using UnityEngine;
//�ﰢ �Լ�
//����Ƽ���� �������ִ� �ﰢ�Լ��� �ַ� ȸ��, ī�޶� ����, �, �����ӿ� ���� ǥ������ ���˴ϴ�.

//Ư¡) ������ �������� ����մϴ�. 1���� = �� 57��
//���� ȸ��


public class Tfunction : MonoBehaviour
{

    //���
    //Sin(Radian) : �־��� ������ Y��ǥ (���� ���� ��ġ)
    //Cos(Radian) : �־��� ������ X��ǥ (���� ���� ��ġ)
    //Tan(Radian) : �־��� ������ ���� (Y/X)
   public void CircleRotate()
    {
        float angle = Time.time * 90f;
        float radian = angle*Mathf.Deg2Rad; //���� �ش� ���� �����ָ� �������� ��ȯ�˴ϴ�.

        var x = Mathf.Cos(radian) * 5.0f;
        var y = Mathf.Sin(radian) * 5.0f;

        transform.position = new Vector3(x, y, 0);
    }

    public void ButterFly()
    {
        float t = Time.time * 2;
        float x = Mathf.Sin(t) * 2;
        float y = Mathf.Sin(t * 2f) * 2 * 2;

        transform.position = new Vector3(x,y, 0);
    }

    //Time.time : �������� ���۵� ���������� �ð�
    //Time.deltaTiem : �������� �����ϰ� ������ �ð�
    private void Wave()
    {
        var offset = Mathf.Sin(Time.time * 2.0f) * 0.5f;
        transform.position = pos + Vector3.up * offset;
    }

    Vector3 pos;  //��ǥ(��ġ)



    private void Start()
    {
        pos = transform.position;   //������ �� ������Ʈ�� ��ġ ����
    }
    void Update()
    {

        //���콺 ���� Ŭ�� ���� ���� CircleRoate ȣ��
        if (Input.GetMouseButton(0))
        {
            CircleRotate(); 
        }
        if (Input.GetMouseButton(1))
        {
            Wave();
        }
        if (Input.GetMouseButton(2))
        {
            ButterFly();
        }
    }
}

