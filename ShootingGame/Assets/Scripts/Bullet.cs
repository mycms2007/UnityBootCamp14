using UnityEngine;

public class Bullet : MonoBehaviour
{
    //(����) �ӵ� ���� speed, �� 5
    public float speed = 5;



    // Update is called once per frame
    void Update()
    {
        //���� = ��
        Vector3 dir = Vector3.up;

        //��ġ += ���� * �ӵ� *��ŸŸ��
        transform.position += dir * speed*Time.deltaTime;

    }
}
