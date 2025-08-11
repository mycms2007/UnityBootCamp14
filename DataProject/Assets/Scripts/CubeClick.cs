using UnityEngine;

public class CubeClick : MonoBehaviour
{
    public SimpleClickGame gameManager;

    void OnMouseDown()
    {
        if (gameManager != null)
        {
            gameManager.AddScore(); // 점수 증가 함수 호출
        }
    }
}