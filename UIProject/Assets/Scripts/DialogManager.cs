using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

[Serializable]
public class Dialog
{
    public string character; // 캐릭터 이름
    public string content;   // 대화 텍스트

    public Dialog(string character, string content)
    {
        this.character = character;
        this.content = content;
    }
}

public class DialogManager : MonoBehaviour
{
    // --- MonoSingleton ---
    public static DialogManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    // ----------------------

    public TMP_Text message;
    public TMP_Text character_name;
    public GameObject panel;
    public float typing_speed = 0.03f;

    private readonly Queue<Dialog> queue = new Queue<Dialog>();
    private Coroutine typing;
    private bool isTyping = false;
    private Dialog current;  // 현재 대화

    private void Update()
    {
        //스페이스 키에 대한 입력이 진행됐다면
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //이벤트 시스템에 전달된 값이 존재하고, 그 값이 UI위에서 눌려진 상황이라면?
            if(EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
            {
                //작업X
                return;
            }

            //스페이스 눌러서 정상적으로 작업중인 경우(대화 매니저 있고, 대화 중인 경우)
            if (isTyping) CompleteLine();
            else NextLine();
        }
    }

    /// <summary>대화 목록을 받아서 시작</summary>
    public void StartLine(IEnumerable<Dialog> lines)
    {
        queue.Clear();
        foreach (var line in lines) queue.Enqueue(line);

        panel.SetActive(true);
        NextLine();
    }

    // 다음 라인으로
    private void NextLine()
    {
        if (queue.Count == 0)
        {
            DialogueExit();
            return;
        }

        current = queue.Dequeue();
        character_name.text = current.character;

        if (typing != null) StopCoroutine(typing);
        typing = StartCoroutine(TypingDialogue(current.content));
    }

    // 타자 효과 코루틴
    private IEnumerator TypingDialogue(string line)
    {
        isTyping = true;
        message.text = string.Empty;

        var sb = new StringBuilder(line.Length);
        foreach (char c in line)
        {
            sb.Append(c);
            message.text = sb.ToString();
            yield return new WaitForSeconds(typing_speed);
        }

        isTyping = false;
        typing = null;
    }

    // 현재 라인 즉시 완성
    private void CompleteLine()
    {
        if (typing != null)
        {
            StopCoroutine(typing);
            typing = null;
        }
        message.text = current?.content ?? string.Empty;
        isTyping = false;
    }

    private void DialogueExit()
    {
        panel.SetActive(false);
    }
}