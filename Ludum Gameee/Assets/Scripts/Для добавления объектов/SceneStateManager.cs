using System.Collections.Generic;
using UnityEngine;

public static class SceneStateManager
{
    public static Dictionary<DetailsEnum, bool> isObjectActive = new Dictionary<DetailsEnum, bool>(); // Переменная для хранения состояния объекта
    public static float countdownTime = 10f; // Время обратного отсчета в секундах
    public static Vector3[] rigidbodyPositions; // Массив для хранения позиций объектов Rigidbody
}
