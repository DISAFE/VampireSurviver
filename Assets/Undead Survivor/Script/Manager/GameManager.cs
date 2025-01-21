using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // GameManager �ڱ� �ڽ��� �����ϱ� ���� GameManager
    public static GameManager Instance;
    // �÷��̾ �����ϴ� GameObject
    public GameObject player;
    // TileMap�̳� �̸� �����ϴ� Area�� �⺻���� size�� ���� Vector2
    public Vector2 normalSize = new(50, 40);
    // �÷��̾ �׾��� �� Ȯ���ϴ� bool
    public bool playerIsDead = false;
    // �÷��̾��� ���� ������ ��Ÿ���� int
    public int gameLevel = 2;
    // ���ӿ� �����ϴ� ������� ����Ʈ
    public List<string> Weapons = new List<string> { "Shovles" }; // ���߿� ���� ��������� �ٲٱ�

    void Awake()
    {
        Instance = this;
        player = GameObject.Find("Player");
    }

}
