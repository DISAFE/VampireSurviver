using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    �������� �����͸� �����ϴ� Ŭ����
 */
public class StateManager : MonoBehaviour
{
    // GameManager �ڱ� �ڽ��� �����ϱ� ���� GameManager
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
