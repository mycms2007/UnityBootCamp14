using UnityEngine;
//유니티에서 제공되는 클래스 사용해 스크립트를 작성합니다

//1. 유니티의 트랜스폼 클래스 사용
//트랜스폼은 유니티 에디터에서 게임 오브젝트를 생성할 때, 
//모든 게임 오브젝트에 기본적으로 부여되는 컴포넌트를 의미합니다.

//해당 오브젝트의 위치(Position), 회전(Rotation), 크기(Scale)에 대한 정보를 가지고 있습니다.
//컴포넌트의 기능을 호출하는 GetComponent<T>를 사용하지 않고 바로 사용이 가능합니다.

//해당 클래스가 제공해주는 속성(property)
//transform.position ->현재 오브젝트의 위치 정보를 의미합니다.
//Vector3 형태의 데이터, x,y,z축은 각각 float

//transform.rotation -> 현재 오브젝트의 회전 정보를 의미합니다.
//Quaternion 형태의 데이터. x,y,z,w 축을 float. 부드러운 회전.

//transfor.forward -> 현재 오브젝트 기준의 전방을 나타내는 값.

//transform.up -> 현재 오브젝트 기준으로 상단을 나타내는 값

//transform.right -> 현재 오브젝트 기준으로 오른쪽을 나타내는 값

//transform.eulerAngles -> 현재 오브젝트의 회전 정보를 의미합니다.
//Vector3 형태의 데이터, x,y,z 축을 float. 단순 회전

//Tip 메소드 () 안에 작성된 변수는 해당 기능을 수행할 때 전달해줄 값에 대한 표현
//-> 파라미터(parameter)


//해당 클래스가 제공해주는 주요 문법(메소드)
//transform.LookAt(Transform target)
//오브젝트를 주어진 타겟을 향하도록 게임 오브젝트를 회전시키는 기능

//transform.Rotate(Vector3 eulerAngles)
//전달받은 각도를 기준으로 게임 오브젝트를 회전시키는 기능

//trnasform.Translate(vector3 translation)
//주어진 벡터(값)만큼 게임 오브젝트를 이동시키는 기능

public class sample3 : MonoBehaviour
{
    public GameObject go;

    //transform을 이용한 컴포넌트 접근
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(go.transform.GetComponent<Sample4>().value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
