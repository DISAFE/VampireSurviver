using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject player;
    public float tileMapSizeX = 50;
    public float tileMapSizeY = 40;

    private void Awake()
    {
        Instance = this;
        player = GameObject.Find("Player");
    }
}
