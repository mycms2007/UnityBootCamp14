using UnityEngine;

//�÷��̾ 45�� �������� �����ϴ� �ڵ�
public class AngleMove : MonoBehaviour
{
    [SerializeField] float angle_degree; //����(��)
        [SerializeField] float speed; //�ӵ�(������ �� �� ��ġ)



    void Update()
    {
        var radian = Mathf.Deg2Rad * angle_degree;
        Vector3 pos = new Vector3(Mathf.Cos(radian), Mathf.Sin(radian), 0);

        transform.Translate(pos*speed*Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Return))
        {
            transform.position = Vector3.zero;
        }
    }
}
