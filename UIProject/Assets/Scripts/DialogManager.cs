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
    public string character; // ĳ���� �̸�
    public string content;   // ��ȭ �ؽ�Ʈ

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
    private Dialog current;  // ���� ��ȭ

    private void Update()
    {
        //�����̽� Ű�� ���� �Է��� ����ƴٸ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�̺�Ʈ �ý��ۿ� ���޵� ���� �����ϰ�, �� ���� UI������ ������ ��Ȳ�̶��?
            if(EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
            {
                //�۾�X
                return;
            }

            //�����̽� ������ ���������� �۾����� ���(��ȭ �Ŵ��� �ְ�, ��ȭ ���� ���)
            if (isTyping) CompleteLine();
            else NextLine();
        }
    }

    /// <summary>��ȭ ����� �޾Ƽ� ����</summary>
    public void StartLine(IEnumerable<Dialog> lines)
    {
        queue.Clear();
        foreach (var line in lines) queue.Enqueue(line);

        panel.SetActive(true);
        NextLine();
    }

    // ���� ��������
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

    // Ÿ�� ȿ�� �ڷ�ƾ
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

    // ���� ���� ��� �ϼ�
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