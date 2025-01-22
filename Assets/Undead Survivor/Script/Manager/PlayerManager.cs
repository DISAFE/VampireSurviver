using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;
    public GameObject player; // 플레이어를 참조하는 GameObject
    public bool playerIsDead; // 플레이어가 죽었는 지 확인하는 bool

    private void Awake()
    {
        Instance = this;
        playerIsDead = false;
    }
}
