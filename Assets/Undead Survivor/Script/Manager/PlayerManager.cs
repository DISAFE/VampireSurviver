using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;
    public GameObject player; // �÷��̾ �����ϴ� GameObject
    public bool playerIsDead; // �÷��̾ �׾��� �� Ȯ���ϴ� bool

    private void Awake()
    {
        Instance = this;
        playerIsDead = false;
    }
}
