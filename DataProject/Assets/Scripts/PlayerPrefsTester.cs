using UnityEngine;
//Ű(Key)�� ��(Value)
//Ű(Key) : ���� �����ϱ� ���� �����ͷ�, Ű�� ������ �̸��� ������ �˴ϴ�.
//��(Value) : Ű�� ���ؼ� ���� �� �ִ� �������� ��.

//Ű�� ���� �� ������ �����Ǵ� �����ʹ� Ű�� �����Ǹ�, ���� ���� ���� �˴ϴ�.
//Ű�� ���� ���� ��ȸ�ϰ� �߰��ϰ�, �����ϴ� ������ �ſ� ������ ������ �� �ֽ��ϴ�. 

//����Ƽ ������ ���Ǵ� �ش� ������ ������
//1. Dictionary<K,V> : C#���� �����Ǵ� ǥ�� �ڷ� ����
//2. PlayerPrefs : ����Ƽ���� �����ϴ� Ű-�� ���� �ý���(Ŭ����)
//3. Json : �ܺο��� �ۼ��� json ���ϵ� Ű-�� ���·� �ۼ��� �� �ֽ��ϴ�.
//4. ScriptableObject : ��ü�����δ� ������ �ȵǳ� Dictionary�� ��� ����մϴ�.


//�÷��̾� ������(PlayerPrefs)
//������ �����͸� ������ �� ���Ǵ� ������ ���� �ý���
//������ �����ͳ� ū �뷮�� �䱸�ϴ� ������ ���忡�� ������.

//�ַ� ����Ǵ� ��Ȳ : ����, �÷��̾��� ���� ����, ���� ������

//���� : �ﰢ���̰� ������ ����/�ε忡 ���� ���������� ����.
        //�÷��� ������ ���� ���, ���� �������� ���˴ϴ�.
        //ex) Windows -> ������Ʈ�� ���(������Ʈ�� �����⸦ ���� ��ġ Ȯ��)
        // MacOS  -> Library/Preferencese/unity.[compnay].[project_name].plist(plist ����)
        //IOS   -> ios ���� �����
        //Android -> XMS ����(�� ������ ����)
        //WebGL    -> �÷����� ������ ������ �´� ����� ���.

//���� : �÷��̾ ������ ������ �����̱� ������ ���ȼ��� ����.

public class PlayerPrefsTester : MonoBehaviour
{
    public int score;
    public int max_score = 10;

    private void Start()
    {
        score = PlayerPrefs.GetInt("score", 1);

        PlayerPrefs.SetInt("Maxscore", max_score);

        PlayerPrefs.Save(); //��ũ��Ʈ�� ���� ������ ������ ȣ���մϴ�.
        //�� �ڵ尡 ��� �ڵ����� ������ �˴ϴ�.

        Debug.Log(score);
        Debug.Log(PlayerPrefs.GetInt("Maxscore"));


    }

    public void ResetPrefs()
    {
        PlayerPrefs.DeleteAll(); // ������Ʈ���� �ִ� �÷��̾� ������ ���� ���� �����մϴ�.
    }
}
