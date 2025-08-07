using System;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeUI : MonoBehaviour

{    public UnitStat unitStat;             // 유닛 스탯 스크립트 연결
public UnityInventory inventory;      // 인벤토리 스크립트 연결
public Sample parser;


    public Button button01;
    public Text message;
    public Text icon_text;

    //자료형[] 배열명 = new 자료형[]{
    //값, 값2, 값3
    //
    //};

    private string[] materials = new string[]
    {
        "100 골드",
        "100 골드 + 루비",
        "200 골드 + 사파이어 + 마력석",
        "최대 강화 완료"
    };

    //max_level을 사용할 경우 배열의 길이 -1의 값을 가지게 됩니다.

    private int upgrade = 0;
    private int max_level => materials.Length - 1;
    //배열에는 인덱스라는 개념이 존재합니다.
    //ex)materials가 하나의 묶음이고, 거기서 2번째 데이터는 materials[1]입니다.
    // (카운트를 0부터 셈)


    private void Start()
    {
        button01.onClick.AddListener(OnUpgradeBtnClick);
        //AddListener는 유니티의 UI의 이벤트에 기능을 연결해주는 코드
        //전달할 수 있는 값의 형태가 정해져있어서 그 형태대로 설계해줘야 합니다.
        //다른 형태로 쓰는 경우(매개변수가 다른 경우)라면 delegate를 활용합니다.
        //특징) 이 기능을 통해 이벤트에 기능을 전달한다면
        //유니티 인스펙터에서 연결된 걸 확인할 수 없습니다.

        //장점 : 직접 등록하지 않아서 잘못 넣을 확률이 낮아집니다.
    UpdateUI();
        //시작 시 UI에 대한 랜더링 설정
    }

    //버튼 클릭 시 호출할 메소드 설계 
    private void OnUpgradeBtnClick()
    {
        if (upgrade >= max_level)
        {
            message.text = "최대 강화 상태입니다.";
            return;
        }

        // 🔹 요구 재료 파싱
        string requirement = materials[upgrade];
        string[] parsedMaterials = parser.Parse(requirement); // 예: ["100 골드"] or ["100 골드", "루비"]

        // 🔹 조건 체크
        if (inventory.HasRequiredMaterials(parsedMaterials))
        {
            inventory.ConsumeMaterials(parsedMaterials);  // 재료 차감
            unitStat.Upgrade();                          // 능력치 강화
            upgrade++;
            UpdateUI();
        }
        else
        {
            message.text = "재료가 부족합니다.";
        }
    }

    private void UpdateUI()
    {
        icon_text.text = $"마법사+{upgrade}";
        message.text = materials[upgrade];
    }
}
