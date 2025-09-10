# 유니티 2D 슈팅 기본 구현 실습 정리
### 학습 날짜
2025.08.18

### 학습 개요

오늘은 유니티에서 2D 슈팅 게임의 기본 구조를 설계했습니다.
배경 스크롤, 플레이어 이동 및 발사, 총알 이동, 적 생성 및 충돌 처리까지 흐름을 하나의 프로젝트로 구현하며, 오브젝트 간 상호작용과 충돌 이벤트의 기본을 익혔습니다.

### 주요 학습 항목 및 실습 내용
#### 1. 배경 스크롤

🔸 Background.cs

material.mainTextureOffset을 이용해 배경 텍스처를 지속적으로 위로 이동

scrollSpeed 값으로 스크롤 속도 조정

#### 2. 총알 이동

🔸 Bullet.cs

위 방향(Vector3.up)으로 지속적인 이동 구현

transform.position += dir * speed * Time.deltaTime 방식 적용

speed를 공개 변수로 두어 Inspector에서 조절 가능

#### 3. 플레이어 이동 및 발사

🔸 PlayerMove.cs

Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")로 방향 입력 감지

입력값을 Vector3로 변환 후 위치 갱신

🔸 PlayerFire.cs

Input.GetButtonDown("Fire1") (기본적으로 마우스 좌클릭/스페이스) 시 총알 발사

Instantiate()로 bulletFactory에서 총알 생성, firePosition 위치에서 발사

#### 4. 적 오브젝트 동작

🔸 Enemy.cs

EnemyType(Down, Chase) 열거형 설계

Down: 단순히 아래로 이동

Chase: 플레이어 방향으로 추적 이동

시작 시 PatternSetting()으로 무작위 패턴 설정

OnCollisionEnter() 시:

ScoreManager.instance.SetScore(5) 호출로 점수 증가

폭발 이펙트(explosionFactory) 생성

충돌 상대와 자신을 Destroy()

#### 느낀 점 / 메모

Input.GetAxis 기반 이동은 키보드 입력을 자연스럽게 연속값으로 처리해 부드러운 움직임 구현 가능.

Instantiate()와 Destroy()의 흐름을 통해 발사체와 적 오브젝트의 생명주기를 명확히 이해.

OnCollisionEnter와 IsTrigger 차이를 다시 복습할 수 있었음.

Enemy 패턴이 단순하지만, 랜덤 요소와 추적 로직만으로도 게임성이 확 달라지는 것을 확인.

#### 참고자료

부트캠프 강의 실습 코드


강사님 시연 코드 및 프로젝트 구조

#### 다음 목표

Enemy 스폰 시스템 고도화 (Wave 단위, 시간 간격 생성)

Player와 Enemy HP 관리, 체력 UI 연동

Bullet 충돌에 따른 점수/이펙트 다양화
