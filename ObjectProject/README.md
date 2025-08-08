# 유니티 UI & 이벤트 시스템 실습 정리
###  날짜 2025.08.08

## 오늘의 목표
Dropdown, TextMeshPro, 트리거, 대화 시스템 등을 활용한 UI/이벤트 연계 실습.
UI 변경이 게임 오브젝트 속성과 연결되어 실시간으로 반영되는 구조를 구현하고,
트리거 → 대화 매니저 호출 흐름까지 확인.

## 핵심 포인트 요약
Dropdown은 선택 인덱스를 기반으로 switch문을 통해 데이터 세팅 가능

TMP(TextMeshPro)는 UI 텍스트 표현력↑ (리치 텍스트, 색상, 크기, 취소선 등)

UI 변경 후 반드시 **갱신 메서드(UpdateUI)**를 호출해 화면에 반영

트리거(DTrigger) → DialogManager.Instance.StartLine() 호출 방식으로
인스턴스 접근 + 메서드 실행 가능

Instance 패턴 사용 시 GetComponent 없이 전역처럼 접근 가능

이벤트 연결은 코드 내 dropdown.onValueChanged.AddListener()로 등록

UI/이벤트 로직은 **UI와 데이터 객체(Player)**를 명확히 분리하는 것이 유지보수에 유리

## 오늘 만든 시스템 요약

구성요소	설명

| 항목 | 설명 | 
|------|------|
| PlayerUIController1.cs  | Dropdown 선택 → Player 속성(name, job, gender) 변경 → TMP_Text로 표시, TMP를 이용한 리치 텍스트 예제 및 색상 경고 표시  |
| DTrigger.cs  | 트리거 진입 시 DialogManager.Instance로 대화 시작 호출 |    
| DialogManager.cs  | (연계) StartLine()으로 대사 리스트 재생 |   
| DMouseRaycaster.cs  | (연계) 마우스 위치 기반 오브젝트 감지 |   
| DropdownSample.cs  | (연계) 드롭다운 기본 예제 및 값 변화 처리 |    
 
	

## 느낀 점
Dropdown, TextMeshPro, 트리거는 각자 다른 기능 같지만,
**"이벤트 발생 → 데이터 변경 → UI 반영"**이라는 동일한 흐름을 공유한다.
이 흐름을 파악하면 어떤 UI 요소라도 구조적으로 다룰 수 있다.

특히 PlayerUIController1.cs에서
UI 요소(Dropdown)와 실제 데이터 객체(Player)를 분리한 설계는
규모가 커져도 유지보수에 강하다는 점에서 좋은 패턴임을 확인.

트리거 부분은 Instance 패턴을 통해
매번 컴포넌트를 찾는 부하를 줄이고 호출 단계를 단순화했다는 점이 인상적.

## 다음 목표

Dropdown → Player 속성 변경을 인게임 시스템(예: 전투, 퀘스트)에 직접 반영

DTrigger → DialogManager 흐름에 조건부 이벤트 추가 (플레이어 상태에 따른 대화 변화)

TMP 리치 텍스트를 활용한 실전 UI 디자인 확장


