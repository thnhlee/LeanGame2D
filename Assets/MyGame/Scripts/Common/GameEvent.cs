using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[AddComponentMenu("ThinhLe/GameEvent")]

public class GameEvent : MonoBehaviour
{
    [Header("Event")]
    public static UnityEvent eventUpdateUI;
    public static UnityEvent<int> eventHealth;
    public static UnityEvent<int> eventCoin;
    public static UnityEvent<int> eventCoinsCompleted;
}
