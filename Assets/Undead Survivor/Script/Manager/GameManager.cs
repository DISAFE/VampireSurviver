using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // GameManager 자기 자신을 지정하기 위한 변수
    public static GameManager Instance;

    // 플레이어를 참조하는 변수
    public GameObject player;
    
    // TileMap이나 이를 감지하는 Area의 기본적인 size를 담은 Vector2 Type의 변수
    public Vector2 normalSize = new (50, 40);

    // 플레이어가 죽었는 지 확인하는 변수
    public bool playerIsDead = false;

    // 플레이어의 현재 레벨을 나타내는 변수
    public int gameLevel = 2;

    void Awake()
    {
        Instance = this;
        player = GameObject.Find("Player");
    }
}
