using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerAnimationState
{
    Idle,
    Walk,
    Run,
    Jump,
    Fall,
    Attack,
    Hit,
    Die // 래그돌 이펙트로 대체: 모든 애니메이션 컨트롤 오프/ 대신 관절에 충돌과 물리 부여로 래그돌 효과 온.
}


public class PlayerAnimationManager : MonoBehaviour
{

    /// <summary>
    /// 구조를 어떻게 짤 지 고민해봐야 합니다.
    /// 
    /// 1: 이건 플레이어 애니메이션 관리용 클래스.
    /// - 상태를 읽어와서 애니메이션을 전환하는 역할 수행.
    /// - 매니저 클래스는 하나니까 싱글톤 패턴 적용.
    /// - 이넘을 사용해서 에니메이션 상태 구분: 클래스 패턴은 스테이트.
    /// 2:
    /// </summary>



}