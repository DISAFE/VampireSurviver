using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoe : MonoBehaviour
{
    private Vector3 power;
    private void Start()
    {
        Vector3 enemyPos = PlayerManager.Instance.weapons.GetNearestEnemyPos();
        Debug.Log("Hoes Start:" + enemyPos.ToString());
        if (enemyPos == Vector3.zero) Destroy(this.gameObject); // 오류 처리 
        power = enemyPos - PlayerManager.Instance.player.transform.position;
        power = power.normalized;

        transform.localRotation = Quaternion.Euler(0, 0, (Mathf.Atan2(power.y, power.x) / Mathf.Deg2Rad) + 270);
    }
    private void FixedUpdate()
    {
        transform.localPosition += power * Time.fixedDeltaTime * 15;
    }
}
