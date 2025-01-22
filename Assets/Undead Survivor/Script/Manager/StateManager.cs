using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    이 클래스는 게임 상태를 관리하는 매니저입니다. 
    주로 Scene을 관리합니다.
 */
public class StateManager : MonoBehaviour
{
    // GameManager 자기 자신을 지정하기 위한 GameManager
    public static StateManager Instance;

    void Awake()
    {
        Instance = this;
    }
}
