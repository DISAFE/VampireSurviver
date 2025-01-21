using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // GameManager 자기 자신을 지정하기 위한 GameManager
    public static GameManager Instance;
    // 플레이어를 참조하는 GameObject
    public GameObject player;
    // TileMap이나 이를 감지하는 Area의 기본적인 size를 담은 Vector2
    public Vector2 normalSize = new(50, 40);
    // 플레이어가 죽었는 지 확인하는 bool
    public bool playerIsDead = false;
    // 플레이어의 현재 레벨을 나타내는 int
    public int gameLevel = 2;
    // 게임에 존재하는 무기들의 리스트
    public List<string> Weapons = new List<string> { "Shovles" }; // 나중에 파일 입출력으로 바꾸기

    void Awake()
    {
        Instance = this;
        player = GameObject.Find("Player");
    }

}
