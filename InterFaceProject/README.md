# 유니티 입력 이벤트와 델리게이트 기초 정리

### 학습 날짜

2025.08.14 

### 학습 개요

유니티 이벤트 시스템 구조와 동작 원리를 학습함

C#의 델리게이트 개념(Action, Func, event)과 UnityEvent의 차이를 이해함

다양한 입력 이벤트 인터페이스를 직접 구현해봄으로써 이벤트 흐름과 호출 방식 체험

각 이벤트의 실행 타이밍과 조건을 실습을 통해 체감함

### 주요 학습 항목 및 스크립트 정리

#### 📂 ActionFuncExample.cs

C#에서의 Action<T>와 Func<T>의 사용 예제

메서드를 변수처럼 다루며 동적으로 기능을 설정하는 방식 체험

Action<int>로 전달만, Func<string,int>로 반환 있는 처리

func01()에 AttackAble 메서드를 연결해 조건 판단 후 결과 출력

람다식으로도 Func<bool> 구현 가능함을 직접 실습함

#### 📂 eventExample.cs

Action과 event Action의 차이점 비교 실습

onStart, onDeath에 여러 메서드를 구독하고 Invoke()로 호출

event는 외부에서 직접 호출이 불가하다는 점을 코드로 검증

Ready, Fight, Damaged, Dead 메서드를 순차적으로 실행시키며 이벤트 흐름 구조 확인

#### 📂 ClickTester.cs

IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler 등
마우스 입력 이벤트 관련 인터페이스 구현 실습

PointerEventData의 다양한 정보(좌표, 클릭 횟수, 드래그 여부 등)를 Debug로 출력하여 구조 확인

UI 입력 흐름이 어떤 방식으로 이벤트를 소비하는지 감각적으로 이해

#### 📂 UIEventCycle.cs

UnityEngine.EventSystems의 거의 모든 UI 관련 입력 인터페이스를 한번에 구현해본 예제

Handle() 메서드로 이벤트 이름, 위치, 시간 간격 등을 시각화 출력함

BaseEventData를 PointerEventData로 패턴 매칭하여 마우스 위치 출력 가능

이벤트 발생 시 시간 간격과 순서를 통해 흐름 파악하는 구조 설계

아직 대부분의 인터페이스는 throw new NotImplementedException() 상태이므로 후속 구현 예정

### 오늘 느낀 점

인터페이스 기반 이벤트 시스템은 처음엔 이름 외우기부터 부담이지만, 반복해서 구현해보니 자연스럽게 익숙해졌다.

Action, Func 개념은 단순하지만 응용이 엄청 넓다는 걸 체감했고, 특히 Func<T>의 반환 구조와 람다식 연결이 매우 유연하다는 점이 인상 깊었다.

UnityEvent vs event Action의 차이를 코드로 비교해본 게 가장 도움이 되었고, 그 차이를 직접 눈으로 확인하니 개념이 완전히 정리됨.

실습 중 에러도 있었지만 덕분에 delegate가 어떤 상황에서 막히는지도 파악하게 됨.

### 다음 목표

UIEventCycle.cs에 미구현 상태로 남겨둔 이벤트들을 실제 처리 내용으로 구현 예정

Action과 Func을 직접 활용하여 UI 버튼에 동적으로 기능 부여 실험 예정

인터페이스를 단일 클래스로 몰아넣기보다 역할별로 분리해서 관리하는 구조로 점진적 리팩토링 계획

델리게이트와 UnityEvent를 활용해 UI → 게임로직 → 상태 전이 흐름을 명확히 연결해보는 미니 프로젝트 구상 예정



