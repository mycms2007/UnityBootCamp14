using JetBrains.Annotations;
using UnityEngine;


//Attribute : [AddComponentMenu("")]ó�� Ŭ������ �Լ�, ���� �տ� �ٴ� []���� Attribute(�Ӽ�)
//�����Ϳ� ���� Ȯ���̳� ����� ���� �� ���ۿ��� �����Ǵ� ��ɵ�.
//��� ���� : ����ڰ� �����͸� �� ����������, ���������� ����ϱ� ���ؼ� ���.

//1.AddComponentMenu("�׷��̸�/����̸�")
//Editor�� Component�� �޴��� �߰��ϴ� ���
//�׷��� ���� ��� �׷��� �����Ǹ�, �ƴ� ��쿡�� ��ɸ� �����˴ϴ�.
//���� ���� ���� ������ ���� ���� ������ ������ �ֽ��ϴ�.
//1. !, #, $, * Ư�������� ��� �� ��
//2. ����
//3. �빮��
//4. �ҹ���

[AddComponentMenu("Sample/AddComponentMenu",1)]
public class MenuAttribute : MonoBehaviour
{
  

    [ContextMenuItem("MessageReset", "MessageReset")]
    public string message = "";


    public void MessageReset()
    {
        message = "";

    }



    public void MenuAttributesMethod()

    
    


    {
  



    Debug.LogWarning("��� �޽���");
    }
}



