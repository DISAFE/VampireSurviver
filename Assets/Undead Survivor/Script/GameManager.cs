using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // GameManager �ڱ� �ڽ��� �����ϱ� ���� ����
    public static GameManager Instance;

    // �÷��̾ �����ϴ� ����
    public GameObject player;
    
    // TileMap�̳� �̸� �����ϴ� Area�� �⺻���� size�� ���� Vector2 Type�� ����
    public Vector2 normalSize = new (50, 40);

    // �÷��̾ �׾��� �� Ȯ���ϴ� ����
    public bool playerIsDead = false;

    // �÷��̾��� ���� ������ ��Ÿ���� ����
    public int gameLevel = 2;

    void Awake()
    {
        Instance = this;
        player = GameObject.Find("Player");
    }
}
