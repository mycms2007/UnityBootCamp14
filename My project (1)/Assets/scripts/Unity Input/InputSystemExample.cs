using UnityEngine;
using UnityEngine.InputSystem;

//Player Input�� �����ؾ� ���

//RequireComponent(typeof(T))�� �� ��ũ��Ʈ�� ������Ʈ��
//����� ��� �ش� ������Ʈ�� �ݵ�� T�� ������ �־�� �մϴ�.
//���� ����� �ڵ����� ������ְ�, �� �ڵ尡 �����ϴ� ��
//�����Ϳ��� ���� ������Ʈ�� �ش� ������Ʈ�� ������ �� �����ϴ�.
[RequireComponent(typeof(PlayerInput))]
public class InputSystemExample : MonoBehaviour

{
    //���� Action Map : Sample
    //Type : Value
    //Compos : Vector2
    //Binding : 20 Vector(WASD)

    private Vector2 moveInputValue;
    private float speed = 3.0f;





    //Send Messages�� ���Ǵ� ���
    //Ư�� Ű�� ������, Ư�� �Լ��� ȣ���մϴ�.
    //�Լ� ���� On+Actions name, ���� ���� Actions�� �̸�..
    //Move���, �Լ����� OnMove�� �˴ϴ�.

   void OnMove(InputValue Value)
    {
        moveInputValue = Value.Get<Vector2>();  

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(moveInputValue.x, 0, moveInputValue.y);
        //�¿� x��, ��ȭz��
        transform.Translate(move*speed*Time.deltaTime);
    }
}
