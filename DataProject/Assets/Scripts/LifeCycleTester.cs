using System.Collections;
using UnityEngine;

//����Ƽ ������ ����Ŭ�� ���� ���� ���� Ȯ�� �ڵ�
//Update�� Ȱ���� ������ �� ȣ���� ������� Ȯ���غ��ϴ�.

public class LifeCycleTester : MonoBehaviour
{
    private int count_per_frame = 0; // ������ ���� ȣ�� ī��Ʈ

    private void Awake()
    {
        Debug.Log("[Awake] ������Ʈ�� ���� �� �� �ѹ��� ����Ǵ� ����");
    }
   private void OnEnable()
    {
        Debug.Log("[OnEnable] ������Ʈ�� Ȱ��ȭ �� ȣ��Ǵ� ����");
    }

    void Start()
    {
        Debug.Log("[Start] ù ������ ���� ���� ȣ��Ǵ� ����");
        StartCoroutine(CustomCoroutine());  //�ڷ�ƾ ����
    }

    private void FixedUpdate()
    {
        Debug.Log($"[CPF : {count_per_frame}][FixedUpdate] ������ ���� ������Ʈ�� ����Ǵ� ����");

    }
    void Update()
    {
        count_per_frame++; //ī��Ʈ ����
        Debug.Log($"[CPF : {count_per_frame}[Update] ���� ������ ���� ȣ���� ����Ǵ� ����");

        //������ ī��Ʈ�� ���� �׽�Ʈ ����
        if(count_per_frame == 3)
        {
            Debug.Log($"[CPF : {count_per_frame}][Test 1] ������Ʈ�� ��Ȱ��ȭ �۾��� �����մϴ�.");
            gameObject.SetActive(false);
        }

        if (count_per_frame == 6)
        {
            Debug.Log($"[CPF : {count_per_frame}][Test 2] ������Ʈ�� Ȱ��ȭ �۾��� �����մϴ�.");
            gameObject.SetActive(true);
        }

        if (count_per_frame == 9)
        {
            Debug.Log($"[CPF : {count_per_frame}][Test 3] ������Ʈ�� �ı� �۾��� �����մϴ�.");
            Destroy(gameObject);
        }
    }

    private void LateUpdate()
    {
        Debug.Log($"[CPF : {count_per_frame}][LateUpdate] ���� ����, ���� ������ ��ó��");
    }

    //�ڷ�ƾ ����_
    //yield�� ���� ��� �� ����Ŭ�� ���ƿ��� ������ �����ϸ�, ���� Update�� ƴ���� ������ ����˴ϴ�.
    IEnumerator CustomCoroutine()
    {
        Debug.Log("[Coroutine] �ڷ�ƾ�� ���� ���� : StartCoroutine");
      
        yield return null;
        Debug.Log("[Coroutine] 1������ �� �ٽ� ����˴ϴ�.");

        yield return new WaitForSeconds(1.0f);  //1�ʿ� ���� ���
        Debug.Log("[Coroutine][Seconds] 1�� �� �ٽ� ����˴ϴ�.");

       yield return new WaitForFixedUpdate();
        Debug.Log("[Coroutine][FixedUpdate] FixedUpdate�� ������ �ٽ� ����˴ϴ�.");

        yield return new WaitForEndOfFrame();
        Debug.Log("[Coroutine][End of Frame] �������� ���� ������ �ٽ� ����˴ϴ�.");
    }

    private void OnDisable()
    {
        Debug.Log("[OnDisable] ������Ʈ�� ��Ȱ��ȭ �� ��� ȣ��Ǵ� ����");

    }

    private void OnDestroy()
    {
        Debug.Log("[OnDestroy] ������Ʈ�� �ı��Ǿ��� ��� ȣ���ϴ� ����");
        //�� ��ġ������ �ı� ������ ����ǰ� �ֱ� ������, ������ ���� �۾��� �Ұ����ϰų� ���ǹ�.
        //gameObject.SetActive(true/false)  ������ �ǵ� ���������� �ǹ̰� ����.(���� ������ �ı� �� �ܰ迡�� ó��)
        //�ڱ� �ڽſ� ���� ���� �۾��� �Ұ����մϴ�. ��� �ı��˴ϴ�.
        //���ο� ���� ������Ʈ�� �����ϴ� �۾��� �����մϴ�.
        
    }
}
