# 유니티 입력 및 인스펙터 실습 정리

##  학습 날짜
2025.07.31 (유니티 부트캠프 14기 기준)

## 학습 개요
본 프로젝트는 유니티 기본 입력 시스템과 인스펙터 커스터마이징 기능을 학습하고, 강의 예제를 따라 실습한 결과물입니다.
직접 구현해보며 아래 개념들을 복습하고 익혔습니다.

## 주요 학습 항목 및 실습 내용

#### 1. AddComponentMenu & ContextMenuItem
MenuAttribute.cs

[AddComponentMenu] : 커스텀 컴포넌트를 메뉴에 등록

[ContextMenuItem] : 인스펙터 우클릭 메뉴에 메서드 추가

MessageReset() : 문자열 초기화 함수




#### 2. 선형 보간 이동
LinearInter.cs

Vector3.Lerp()를 통해 target 방향으로 천천히 이동 구현

Time.deltaTime과 speed 활용

#### 3. 에디터 모드 실행
EditMenuSample.cs

[ExecuteInEditMode] 사용

플레이 상태가 아니어도 y값 자동 고정 동작 확인

#### 4. 인스펙터 속성 커스터마이징
InspectorAttributes.cs

[Header], [HideInInspector], [SerializeField], [Tooltip], [TextArea], [Space] 등 다수 사용

사용자 정의 타입(enum, List, [Serializable] class) 학습

#### 5. UnityEvent 실습

<br>UnityEventSample.cs

UnityEvent를 인스펙터에 연결하고, Move()로 오브젝트 이동

#### 6. Legacy 입력 시스템 (구 Input 클래스)
LegacyExample.cs

Input.GetKeyDown() 으로 키 입력 감지

foreach 문을 통해 KeyCode 열거형 전체 탐색

#### 7. Input System 패키지 (신 입력 시스템)

InputSystemExample.cs

PlayerInput 필요 (컴포넌트 자동 추가 설정)

OnMove()를 통해 방향키 입력 처리 및 캐릭터 이동 구현

### 느낀점 / 메모
아직 정확히 따라치지 못한 예제는 ‘진짜 내 것’이 아니므로 복습이 필요함.

외형적으로 동작하더라도, 기능 하나하나의 의도와 구조를 이해하는 데 시간이 걸림.

수업 진도를 따라가며 완성한 예제들이므로, 리드미는 복습 정리에 가까움.

### 참고자료
부트캠프 제공 예제 코드

강사님 설명 및 코드 주석

### 다음 목표
이 실습 코드를 기반으로 간단한 미니 프로젝트에 활용해보기.
입력 시스템이나 인스펙터 속성을 응용한 퀘스트 보상 시스템, 혹은 간단한 UI 입력 실험 등.


                                                                                                              
