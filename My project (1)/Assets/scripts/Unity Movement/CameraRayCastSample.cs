using UnityEngine;

public class CameraRayCastSample : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Ray ray = new Ray(��ġ, ����);
            //ī�޶󿡼� ����� ���̸� ���� ���� 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("�� ���� ������̾�!");
                hit.collider.GetComponent<Renderer>().material.color = Color.yellow;

                var hitObject = hit.collider.gameObject;

                int change_layer = LayerMask.NameToLayer("Yellow");

                if (change_layer != -1)
                {
                    hitObject.layer = change_layer;
                }

                hitObject.layer = LayerMask.NameToLayer("yellow");
            }  
        }
    }
}
