using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoe : MonoBehaviour
{
    private Vector3 power;
    private void Start()
    {
        power = PlayerManager.Instance.weapons.GetNearestEnemyPos() - PlayerManager.Instance.player.transform.position;
        power = power.normalized;

        transform.localRotation = Quaternion.Euler(0, 0, (Mathf.Atan2(power.y, power.x) / Mathf.Deg2Rad) + 270);
    }
    private void FixedUpdate()
    {
        transform.localPosition += power * Time.fixedDeltaTime * 10;
    }
}
