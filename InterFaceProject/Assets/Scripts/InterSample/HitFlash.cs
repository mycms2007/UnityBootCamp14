
 using UnityEngine;
using System.Collections;

public class HitFlash : MonoBehaviour
{
    [SerializeField] Color flashColor = Color.red;
    [SerializeField] float duration = 0.1f;
    SpriteRenderer sr; Color original;

    void Awake() { sr = GetComponent<SpriteRenderer>(); original = sr.color; }

    public void Flash() { StartCoroutine(Co()); }
    IEnumerator Co() { sr.color = flashColor; yield return new WaitForSeconds(duration); sr.color = original; }
} 