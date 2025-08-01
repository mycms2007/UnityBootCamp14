using UnityEngine;
//�߿� Ŭ���� Mathf
//����Ƽ���� ���� �������� �����Ǵ� ��ƿ��Ƽ Ŭ����
//���� ���߿��� ���� �� �ִ� ���� ���꿡 ���� ���� �޼ҵ�� ����� ����.

//ex)���� �޼ҵ� : static Ű����� ������ �ش� �޼ҵ�� Ŭ������. �޼ҵ��()
//              ���� ����� �����մϴ�. Mathf.Abs(-5);

public class MathfSample : MonoBehaviour
{
    //�⺻������ ���Ǵ� �޼ҵ�
    float abs = 5;
    float ceil = 4.1f;
    float floor = 4.6f;
    float round = 4.5f;
    float clamp;
    float clamp01;
    float pow =2;
    float sqrt =4;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Mathf.Abs(abs)); //���밪(absolute number)
        Debug.Log(Mathf.Ceil(ceil));    //�ø�(�Ҽ����� ������� ���� �ø� ó���մϴ�.
        Debug.Log(Mathf.Floor(floor));  //����(�Ҽ����� ������� ���� ���� ó���մϴ�.
        Debug.Log(Mathf.Round(round));  //�ݿø�(4���ϸ� ������ 5�̻��̸� �ø��ϴ�.)
        Debug.Log(Mathf.Clamp(7, 0, 4)); //���� ���޹����� =7, �ּ�=0, �ִ�=4, ���>
                                         //��, �ּ�, �ִ�, ������ ���� �Է��մϴ�.
        Debug.Log(Mathf.Clamp01(5));     //���� ���޹�����=5,�ּ�=5,�ִ�=1 ����� �ּڰ�0 �Ǵ� �ִ밪 1�� ó��
                                         //�ۼ�Ʈ ������ ���� ó���� �� ���� ���Ǵ� �ڵ�
                                         //�ּ� �ִ� ������ ���� 0�� 1�� �����˴ϴ�.
                                         //Clamp vs Clamp01
                                         //Clamp  :  ü��, ����, �ӵ� ���� �ɷ�ġ ���信���� ���� ����
                                         //Clamp01:  ����(�ۼ�Ʈ), ���� ��(t), ���� ��(���򿡼��� ����)

        Debug.Log("����"+Mathf.Pow(pow, 2));   //��, ���� ��(����)�� ���޹޾� �ش� ���� �ŵ������� ���.
        Debug.Log("������" + Mathf.Pow(pow, 0.5f)); //Mathf.Sqrt()�� ����ϴ� �ź��� ������ �ſ� ����.
        Debug.Log("������ ������ ��� ���� ���� ���·� ���." + Mathf.Pow(pow, -2f));
        Debug.Log(Mathf.Sqrt(sqrt));    //���� ���޹޾� �ش� ���� �������� ����մϴ�.




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
