using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    가변적인 데이터를 저장하는 클래스
 */
public class StateManager : MonoBehaviour
{
    // GameManager 자기 자신을 지정하기 위한 GameManager
    public static StateManager Instance;
    public int gameLevel;
    public float timer;
    void Awake()
    {
        Instance = this;
        gameLevel = 1;
        timer = 0;
    }

    private void FixedUpdate()
    {
        Timer();
    }
    private void Timer()
    {
        timer += Time.fixedDeltaTime;
    }
    private string GetTimerToString()
    {
        string minute = (timer / 60).ToString();
        string second = (timer % 60).ToString();
        
        return minute + " : " + second;
    }
}
