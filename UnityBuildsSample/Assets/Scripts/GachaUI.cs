using TMPro; // ✅ 추가!
using UnityEngine;

public class GachaUI : MonoBehaviour
{
    [SerializeField] private GachaMachine machine;
    [SerializeField] private TMP_Text messageText; // ✅ 여기 Text → TMP_Text로 수정!

    private void Awake()
    {
        if (machine != null) machine.OnDrawn += HandleDrawn;
    }

    private void OnDestroy()
    {
        if (machine != null) machine.OnDrawn -= HandleDrawn;
    }

    private void HandleDrawn(object sender, GachaEventArgs e)
    {
        if (string.IsNullOrEmpty(e.ItemName))
            messageText.text = "꽝!";
        else
            messageText.text = e.ItemName;
    }
}