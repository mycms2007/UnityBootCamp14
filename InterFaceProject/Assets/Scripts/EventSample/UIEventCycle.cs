using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIEventCycle : MonoBehaviour,
    IPointerEnterHandler, IPointerExitHandler,
    IPointerDownHandler, IPointerUpHandler,
    IPointerClickHandler,   //포인터 관련


    IDragHandler, IEndDragHandler,
    IScrollHandler, //드래그 관련


    ISelectHandler, IDeselectHandler,
    ISubmitHandler, ICancelHandler, IUpdateSelectedHandler, IMoveHandler
{

//[class body]



    //필드
    private int eventCount = 0;
    private float lastEventTime = 0.0f;

    //이벤트 처리용 함수
    //BaseEventData는 이벤트 시스템에서 사용되는 이벤트 데이터에 대한 기초 클래스

    private void Handle(string eventName, BaseEventData eventData)
    {
        
        eventCount++;
        float now = Time.time;
        float delta = now - lastEventTime; // 직전의 이벤트와의 시간 간격을 계산합니다.
        lastEventTime = now;

        string pos = ""; //받은 값이 PointEventData일 경우 좌표에 대한 출력 처리

        //C# 패턴 매칭
        //1. eventData is PointerEventData > 객체가 PointerEventData인지 확인
        //2. 맞으면 pointerData로 변환해서 지역 변수로 저장한다.

        if (eventData is PointerEventData pointerData)
        {
            pos = $"pos : {pointerData.position}";
        }
         StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append($"<color=yellow>{eventCount}</color>"); //이벤트횟수
        stringBuilder.Append($"<b>{eventName}</b>"); //이벤트명
        stringBuilder.Append($"<color=cyan>{pos}</Color>"); //좌표


        Debug.Log($"<color=yellow>{eventCount}</color>"); //이벤트 횟수
        Debug.Log($"<b>{eventName}</b>");  //이벤트명
        Debug.Log($"<color=cyan>{pos}</Color>");   //좌표
        Debug.Log($"<color=blue>{delta}</color>");    //이벤트 시간 간격 



        //F3 : Fixed-point(소수점 고정) 형태로 소수점 이하 3자리까지 표현하시오
        //N2 : Number에 대한 구분 1,234.57
        //D5 : Decimal(정수)에 대한 구분 01234
        //p1 : 퍼센트에 대한 사용 (값*100이후 %를 붙인다.) {0.34 : P1} --->34%
    }

    //해당 이벤트가 발생할 때마다 Handled이 실행됩니다
    //실행하는 명령문이 1개일 경우 줄여서 표현 가능
    //방법) 접근제한자 반환타입 함수명(매개변수) => 실행가능;
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
