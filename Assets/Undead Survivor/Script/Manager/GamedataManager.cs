using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamedataManager : MonoBehaviour
{
    public static GamedataManager Instance;
    public int gameLevel;
    public Vector2 normalSize;

    private void Awake()
    {
        Instance = this;
        gameLevel = 0;
        normalSize = new Vector2(50, 40);
    }
}
