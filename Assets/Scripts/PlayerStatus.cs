using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DesignPattern;



public class PlayerStatus : MonoBehaviour
{
    [field: SerializeField]
    [field: Range(0, 10)]
    public float WalkSpeed { get; set; }

    [field: SerializeField]
    [field: Range(0, 10)]
    public float RunSpeed { get; set; }

    [field: SerializeField]
    [field: Range(0, 10)]
    public float RotateSpeed { get; set; }

    [field: SerializeField]
    [field: Range(0, 500)]
    public int MaxHP { get; set; }

    public ObservableProperty<int> CurrentHp { get; private set; } = new();

}