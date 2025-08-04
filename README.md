# 유니티 회전 및 이동, 레이캐스트, 수학 함수 실습 정리

### 학습 날짜
2025.08.01 (유니티 부트캠프 14기 기준)
### 학습 개요
오늘의 실습은 유니티에서 회전(Transform/Quaternion), 이동(Input + Rigidbody), 레이캐스트(Raycast), 수학 함수(Mathf)를 활용하여 오브젝트를 제어하는 방법을 중심으로 구성되었습니다.
직접 구현을 통해 다양한 API와 물리 개념을 체화하고, 움직임/회전의 실제 효과를 체감했습니다.

## 주요 학습 항목 및 실습 내용
### 1. 회전의 종류 및 구현 방식
🔸 ObjectRotate.cs
transform.Rotate()를 사용하여 월드 기준 회전을 구현

오일러 각 기반으로 (20, 20, 20)만큼 프레임마다 회전

🔸 AroundRotate.cs
transform.RotateAround()를 사용하여 지정된 피벗을 중심으로 회전

중심축 기준 회전 구현

🔸 QuaternionSample.cs
쿼터니언 개념 정리 및 코드 구조 작성

Quaternion.Euler, LookRotation, RotateTowards, Slerp, Lerp 등 다양한 회전 방식 학습

실습보다는 개념 정리 위주

🔸 TargetRotate.cs
Quaternion.LookRotation()과 RotateTowards()를 조합해 타겟 방향 회전 구현

방향 벡터 계산 → 점진적 회전 처리

### 2. 레이캐스트를 통한 오브젝트 상호작용
🔸 CameraRayCastSample.cs
Camera.main.ScreenPointToRay()를 사용하여 마우스 클릭 위치로 레이 쏘기

Ray가 충돌한 오브젝트의 색상 변경 및 레이어 변경 처리

LayerMask.NameToLayer()로 레이어 변경 처리 실습

### 3. 물리 기반 이동과 점프 구현
🔸 PlayerMovement.cs
Rigidbody를 활용한 물리 이동

Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") → 방향 이동

AddForce()와 isGrounded 체크로 점프 구현

Physics.Raycast()로 바닥 여부 탐지 (LayerMask 사용)

### 4. Mathf 관련 수학 상수 및 연산 실습
🔸 MathfSample.cs
Mathf.Clamp(), Mathf.Abs(), Mathf.Sin(), Mathf.Pow() 등 자주 쓰이는 수학 함수 사용 예제

UI나 상태 수치 조작 시 사용될 수 있는 실용적 함수 구조 복습

🔸 MathfConstant.cs
Mathf.PI, Mathf.Infinity, Mathf.Deg2Rad, Mathf.Epsilon 등 수학 상수 목록 정리

실전 활용은 미흡하지만 향후 참조용으로 의미 있음

### 느낀점 / 메모
회전 처리는 Euler와 Quaternion의 차이를 명확히 이해해야 혼란이 줄어듦

Raycast와 LookRotation은 게임 속 상호작용과 시선 방향 제어의 핵심이 되는 기능

AddForce로 점프할 때 Ground 체크가 없으면 공중 점프가 발생하므로 방지 필수

한 줄 한 줄 입력하며 작동 확인하는 것이 가장 좋은 체득법이라는 점을 다시 느꼈음

참고자료
부트캠프 제공 예제 코드

강사님 코드 작성 시 시연된 흐름

Unity 공식 문서 및 API 레퍼런스

다음 목표
Input + 회전을 응용한 미니 3D 조작 게임 구현

Raycast와 Layer를 활용한 적중 판정/타겟팅 시스템 시도

Quaternion을 이용한 카메라 시점 전환 실험
