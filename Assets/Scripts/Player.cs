using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class Player : MonoBehaviour, IDamagable
{
    public bool IsControlActivate { get; set; } = true;

    private PlayerStatus _status;

    private void Init()
    {
        _status = GetComponent<PlayerStatus>();


    }

    public void TakeDamage(int value)
    {
        _status.CurrentHp.Value -= value;

        if (_status.CurrentHp.Value <= 0) Dead();
    }

    public void Dead()
    {
        Debug.Log("플레이어 사망 처리");
    }
}
