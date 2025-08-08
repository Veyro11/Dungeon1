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
    Die // ���׵� ����Ʈ�� ��ü: ��� �ִϸ��̼� ��Ʈ�� ����/ ��� ������ �浹�� ���� �ο��� ���׵� ȿ�� ��.
}


public class PlayerAnimationManager : MonoBehaviour
{

    /// <summary>
    /// ������ ��� © �� ����غ��� �մϴ�.
    /// 
    /// 1: �̰� �÷��̾� �ִϸ��̼� ������ Ŭ����.
    /// - ���¸� �о�ͼ� �ִϸ��̼��� ��ȯ�ϴ� ���� ����.
    /// - �Ŵ��� Ŭ������ �ϳ��ϱ� �̱��� ���� ����.
    /// - �̳��� ����ؼ� ���ϸ��̼� ���� ����: Ŭ���� ������ ������Ʈ.
    /// 2:
    /// </summary>



}