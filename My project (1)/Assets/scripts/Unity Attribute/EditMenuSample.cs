using UnityEngine;

//������ ��� ���¿��� Update, OnEnable, OnDisable�� ������ ������ �� �ֽ��ϴ�.
//Play�� ������ �ʾƵ� Editor ������ Update � ������ ��ɵ��� �����غ� �� �ֽ��ϴ�.
[ExecuteInEditMode]

public class EditMenuSample : MonoBehaviour
{



    // Update is called once per frame
    void Update()

    {
        if (!Application.isPlaying)
        {
            Vector3 pos = transform.position;
            pos.y = 0;
            transform.position = pos;

            Debug.Log("Editor Test...(�� ��ũ��Ʈ�� �� ������Ʈ�� y���� 0���� �����˴ϴ�.)");
        }
    }
}
    


