using UnityEngine;

public class AroundRotate : MonoBehaviour
{
    public Transform pivot; //ȸ���� �߽���
    public float speed = 100f;


    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivot.position, Vector3.up, speed * Time.deltaTime);
    }
}
