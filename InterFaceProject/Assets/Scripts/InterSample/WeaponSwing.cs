using UnityEngine;

public class WeaponSwing : MonoBehaviour
{
    [SerializeField] float swingAngle = 90f;   // 휘두를 각도
    [SerializeField] float swingSpeed = 270f;  // 초당 회전각
    [SerializeField] float cooldown = 0.33f;   // 1초 3회

    bool swinging;
    float rotated;
    float lastAttackTime = -999f;

    // ⬇️ UI Button의 OnClick에 이 메서드를 연결
    public void StartSwing()
    {
        if (swinging) return;
        if (Time.time - lastAttackTime < cooldown) return;

        swinging = true;
        rotated = 0f;
        lastAttackTime = Time.time;
    }

    void Update()
    {
        if (!swinging) return;

        float step = swingSpeed * Time.deltaTime;
        transform.Rotate(0f, 0f, step);
        rotated += step;

        if (rotated >= swingAngle)
            swinging = false;
    }
}