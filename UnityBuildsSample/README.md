# 유니티 빌드 / 패키지화 / 이벤트 시스템 / 가챠 실습 정리

#### 학습 날짜
2025.08.18 

### 학습 개요

오늘은 유니티 빌드 프로파일과 패키지 관리를 다루며, 프로젝트를 다양한 플랫폼으로 배포할 수 있는 기초를 익혔습니다.
또한 C#의 이벤트 시스템(Publisher–Subscriber 패턴, EventArgs 활용)과 UnityEvent/UnityAction을 실습했으며, 마지막으로 이벤트 기반 가챠 시스템을 구현하며 이론과 실제를 연결했습니다.

## 주요 학습 항목 및 실습 내용
### 1. 빌드 프로파일 / 패키지화

##### 🔸 BuildProfileSample.cs

#if CUSTOM_DEBUG_MODE 와 같은 스크립팅 정의를 통해 빌드 환경별 분기 처리 실습

빌드 프로파일 추가/복제/삭제, 특정 씬 로드 설정, 정의 값 관리 가능

패키지(Export/Import Package)를 통한 코드 및 에셋 재사용 방법 학습

### 2. 이벤트 기초 (C# Event)

##### 🔸 EventSample.cs

event EventHandler 기본 구조 학습

this, EventArgs.Empty 활용한 이벤트 트리거

?.Invoke 문법을 통한 Null 안전 실행

##### 🔸 EventSample2.cs

다른 클래스에서 이벤트 구독 → GetComponent<EventSample>() → OnSpaceEnter += 메서드

##### 🔸 EventSample3.cs

UnityEvent, UnityAction 차이 실습

AddListener()와 RemoveListener()를 통한 인스펙터 기반 이벤트 연결

delegate, UnityAction, Action/Func<T> 비교

##### 🔸 EventSample4.cs

EventArgs를 상속한 사용자 정의 이벤트 데이터(DamageEventArgs) 설계

OnDamaged?.Invoke(this, new DamageEventArgs(value, "적의 공격")); 구조로 이벤트와 데이터 전달

### 3. 가챠 시스템 구현 (이벤트 응용)

##### 🔸 GachaEventArgs.cs

EventArgs를 상속, Number, ItemName, IsWin 프로퍼티 설계

##### 🔸 GachaMachine.cs

UnityEngine.Random.Range(1, 11)을 통해 아이템 번호 추첨

OnDrawn?.Invoke(this, new GachaEventArgs(n, item))로 결과 전달

##### 🔸 GachaUI.cs

machine.OnDrawn += HandleDrawn; 으로 이벤트 구독

HandleDrawn() 메서드에서 UI 텍스트 갱신

TMP_Text를 활용하여 결과 출력 (꽝/아이템명 표시)

### 느낀 점 / 메모

빌드 프로파일을 활용하면 플랫폼별/환경별 관리가 훨씬 편리해짐을 체감.

event, delegate, UnityEvent의 차이를 실습을 통해 직접 비교하면서 개념이 정리됨.

이벤트 기반 구조는 “제공자–구독자” 관계만 이해하면 응용이 쉽다는 것을 알게 됨.

가챠 실습으로 이벤트 시스템이 실전 게임 UI/UX에도 바로 쓰일 수 있다는 확신을 얻음.

#### 참고자료

부트캠프 강의자료 (8/17 PDF)

강사님 제공 예제 코드

### 다음 목표

이벤트 시스템을 적용한 간단한 전투 UI(피격/HP UI 연동) 구현

가챠 시스템을 확장 → 확률 조정, 희귀도, 연출 효과 추가
Quaternion을 이용한 카메라 시점 전환 실험
