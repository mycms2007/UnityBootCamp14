using UnityEngine;
using UnityEngine.EventSystems;
//1.�̺�Ʈ �ý��� ������Ʈ�� ���� �����ؾ� �մϴ�.
//2.UI�� ��� �׷��� ����ĳ���� ������Ʈ�� �߰��Ǿ��־�� �ϸ�, ����ĳ��Ʈ�� Target�� üũ�� �Ǿ��־�� �մϴ�.
//3. ������Ʈ�� ��쿡�� Collider / Colliider2D ������Ʈ�� �߰��Ǿ��־�� �մϴ�.
//4. ����ī�޶� Physics Raycaster �� �߰��Ǿ� �־�� �մϴ�.

//�����Ǵ� ��� ���� �Ϲ����� ����
//1.Pointer Enter 
//2.Pointer Down
//3.Begin Drag
//4.Dragging
//5.End Drag
//6.Pointer Up
//7.Pointer Exit
//8. Select
//9. Submit
//10. Move
//11. Cancel

public class ClickTester : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{

    //PointerEventData : ���콺 Ŭ������ Ŭ�� ��ư, Ŭ�� Ƚ��, ������ ��ġ � ���� ������ ������ �ִ� Ŭ����.
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("������ ������ ��");


        Debug.Log("��ġ�� ���콺 �������� ��ġ " + eventData.position);
        Debug.Log("Ŭ�� Ƚ�� : "+eventData.clickCount);
        Debug.Log("Ŭ�� �ð� : "+eventData.clickTime);
        Debug.Log("�������� �̵��� : " + eventData.delta);
        Debug.Log("���� �巡�� ���� : " + eventData.dragging);

        //eventData.button = ��ư
        //eventData.phase = ������ �̺�Ʈ ��{
        //eventData.pointld
        
       
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        Debug.Log("������ Ż��");
       
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("������ ��ġ�� �� ��.");
     
    }

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("������ ��ġ�� �� ��.");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
