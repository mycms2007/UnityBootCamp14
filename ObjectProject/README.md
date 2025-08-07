# 유니티 코루틴, 프리팹 스폰, 오브젝트 풀링 실습 정리
#### 학습 날짜
2025.08.04

## 학습 개요
오늘 실습은 유니티에서 코루틴(IEnumerator), 프리팹 스폰 및 오브젝트 풀링(Object Pooling), 충돌 감지, AI 이동 등의 기능을 종합적으로 구현하는 데 중점을 두었다. 총알 발사와 적 생성, 적의 플레이어 추적, 자동 비활성화 등의 로직을 직접 구현하며 실전 개발에 근접한 구조를 체험했다.

## 주요 학습 항목 및 실습 내용

1. IEnumerator와 StartCoroutine()을 활용한 비동기 처리


yield return null 혹은 WaitForSeconds()를 활용하여 시간 기반 동작 구현

반복적으로 실행되는 생성 또는 이동 로직 작성 시 사용

예: 일정 시간마다 유닛 생성, 적 AI의 지속 이동 등


2. 프리팹 생성 및 반복 스폰

Instantiate()를 사용해 spawnPoint.position에 프리팹 복제

StartCoroutine() 안에서 yield return new WaitForSeconds(interval) 사용

Debug 로그 출력으로 생성 확인

3. 오브젝트 풀링 (Object Pooling)

매번 new 대신 미리 만들어둔 총알을 재사용하여 GC 부담 감소

리스트에 비활성화된 오브젝트를 보관하고 필요 시 SetActive(true)

충돌 후 다시 pool.Return(gameObject)로 반납

4. 충돌 감지 및 효과 연출

OnTriggerEnter()에서 tag 조건 없이 이펙트(effect_prefab)만 연출

ReturnPool() 메서드로 재사용 가능하게 되돌림

OnEnable() / OnDisable() 구조로 생명주기 관리

5. 간단한 적 AI 이동 구현

GameObject.FindGameObjectWithTag("Player")?.transform으로 대상 추적

Vector3.MoveTowards()로 플레이어에게 일정 거리 이내 접근

조건 충족 시 이동, 아닐 경우 대기

## 느낀점 / 메모
코루틴은 "시간 경과에 따른 행동"을 자연스럽게 구현할 수 있어 실시간 게임에 필수적

오브젝트 풀링은 단순 반복 구조지만 메모리 최적화 측면에서 매우 중요

Transform.position, Quaternion.identity, Instantiate()는 필수 사용법으로 체득 필요

에러는 대부분 null, 오타, 오브젝트 연결 누락, isTrigger 미설정으로 발생함

아직은 따라치는 수준이지만, 구조 분해를 통해 체화할 수 있다는 가능성 확인

### 참고자료
부트캠프 제공 예제 코드

## 강사 시연 내용 및 디버깅 팁

Unity 공식 매뉴얼

C# 기본 문법 및 구조 복습

## 다음 목표
UI Text를 활용한 점수 표시 기능 연동

체력 시스템 구현 (플레이어/적 모두)

Tag, Layer, OnTriggerEnter()를 조건 분기 처리에 적극 활용

완성된 미니게임 구조에서 각 구성 요소를 분해하고 직접 재작성해보기
