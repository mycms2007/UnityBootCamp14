using UnityEngine;

public class CubeClick : MonoBehaviour
{
    public SimpleClickGame gameManager;

    void OnMouseDown()
    {
        if (gameManager != null)
        {
            gameManager.AddScore(); // ���� ���� �Լ� ȣ��
        }
    }
}