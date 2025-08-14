using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIEventCycle : MonoBehaviour,
    IPointerEnterHandler, IPointerExitHandler,
    IPointerDownHandler, IPointerUpHandler,
    IPointerClickHandler,   //������ ����


    IDragHandler, IEndDragHandler,
    IScrollHandler, //�巡�� ����


    ISelectHandler, IDeselectHandler,
    ISubmitHandler, ICancelHandler, IUpdateSelectedHandler, IMoveHandler
{

//[class body]



    //�ʵ�
    private int eventCount = 0;
    private float lastEventTime = 0.0f;

    //�̺�Ʈ ó���� �Լ�
    //BaseEventData�� �̺�Ʈ �ý��ۿ��� ���Ǵ� �̺�Ʈ �����Ϳ� ���� ���� Ŭ����

    private void Handle(string eventName, BaseEventData eventData)
    {
        
        eventCount++;
        float now = Time.time;
        float delta = now - lastEventTime; // ������ �̺�Ʈ���� �ð� ������ ����մϴ�.
        lastEventTime = now;

        string pos = ""; //���� ���� PointEventData�� ��� ��ǥ�� ���� ��� ó��

        //C# ���� ��Ī
        //1. eventData is PointerEventData > ��ü�� PointerEventData���� Ȯ��
        //2. ������ pointerData�� ��ȯ�ؼ� ���� ������ �����Ѵ�.

        if (eventData is PointerEventData pointerData)
        {
            pos = $"pos : {pointerData.position}";
        }
         StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append($"<color=yellow>{eventCount}</color>"); //�̺�ƮȽ��
        stringBuilder.Append($"<b>{eventName}</b>"); //�̺�Ʈ��
        stringBuilder.Append($"<color=cyan>{pos}</Color>"); //��ǥ


        Debug.Log($"<color=yellow>{eventCount}</color>"); //�̺�Ʈ Ƚ��
        Debug.Log($"<b>{eventName}</b>");  //�̺�Ʈ��
        Debug.Log($"<color=cyan>{pos}</Color>");   //��ǥ
        Debug.Log($"<color=blue>{delta}</color>");    //�̺�Ʈ �ð� ���� 



        //F3 : Fixed-point(�Ҽ��� ����) ���·� �Ҽ��� ���� 3�ڸ����� ǥ���Ͻÿ�
        //N2 : Number�� ���� ���� 1,234.57
        //D5 : Decimal(����)�� ���� ���� 01234
        //p1 : �ۼ�Ʈ�� ���� ��� (��*100���� %�� ���δ�.) {0.34 : P1} --->34%
    }

    //�ش� �̺�Ʈ�� �߻��� ������ Handled�� ����˴ϴ�
    //�����ϴ� ��ɹ��� 1���� ��� �ٿ��� ǥ�� ����
    //���) ���������� ��ȯŸ�� �Լ���(�Ű�����) => ���డ��;
    //ex) public void OnbeginDrag(PointerEventData eventData) => Handle("OnBeginDrag" , eventaData);
    void ICancelHandler.OnCancel(BaseEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IDeselectHandler.OnDeselect(BaseEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IMoveHandler.OnMove(AxisEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IScrollHandler.OnScroll(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void ISelectHandler.OnSelect(BaseEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void ISubmitHandler.OnSubmit(BaseEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData)
    {
        throw new System.NotImplementedException();
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
