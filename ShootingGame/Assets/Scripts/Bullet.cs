using UnityEngine;

public class Bullet : MonoBehaviour
{
    //(공개) 속도 변수 speed, 값 5
    public float speed = 5;



    // Update is called once per frame
    void Update()
    {
        //방향 = 위
        Vector3 dir = Vector3.up;

        //위치 += 방향 * 속도 *델타타임
        transform.position += dir * speed*Time.deltaTime;

    }
}
