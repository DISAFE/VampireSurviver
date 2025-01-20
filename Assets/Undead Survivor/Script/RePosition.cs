using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RePosition : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Ground":
                ReTileMap(collision);
                break;
            case "Monster":
                RePosisionMonster(collision);
                break;
        }
    }
    
    void ReTileMap(Collider2D collision)
    {
        Transform tileMap = collision.transform;
        Transform player = transform;
        float disX = tileMap.position.x - player.position.x;
        float disY = tileMap.position.y - player.position.y;

        if (Mathf.Abs(disX) >= GameManager.Instance.tileMapSizeX) //ÁÂ ¿ì
        {
            int horizontal = disX > 0 ? -2 : +2;
            tileMap.position += Vector3.right * horizontal * GameManager.Instance.tileMapSizeX;
            Debug.Log(GameManager.Instance.tileMapSizeX);
        }
        if (Mathf.Abs(disY) >= GameManager.Instance.tileMapSizeY) // À§ ¾Æ·¡
        {
            int vertical = disY > 0 ? -2 : +2;
            tileMap.position += Vector3.up * vertical * GameManager.Instance.tileMapSizeY;
            Debug.Log(GameManager.Instance.tileMapSizeY);
        }
    }

    void RePosisionMonster(Collider2D collision)
    {
        Transform monster = collision.transform;
        Transform player = transform;
        float disX = monster.position.x - player.position.x;
        float disY = monster.position.y - player.position.y;

        if (Mathf.Abs(disX) >= GameManager.Instance.tileMapSizeX / 2) //ÁÂ ¿ì
        {
            int horizontal = disX > 0 ? -1 : +1;
            monster.position += Vector3.right * horizontal * GameManager.Instance.tileMapSizeX;
        }
        if (Mathf.Abs(disY) >= GameManager.Instance.tileMapSizeY / 2) // À§ ¾Æ·¡
        {
            int vertical = disY > 0 ? -1 : +1;
            monster.position += Vector3.up * vertical * GameManager.Instance.tileMapSizeY;
        }
    }
}
