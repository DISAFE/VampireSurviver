using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
    이 클래스는 불변적인 게임 데이터를 저장합니다.
 */
public class GamedataManager : MonoBehaviour
{
    public static GamedataManager Instance;
    public Vector2 normalSize;

    private void Awake()
    {
        Instance = this;
        normalSize = new Vector2(50, 40);
    }
}
