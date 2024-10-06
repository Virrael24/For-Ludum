using System.Collections.Generic;
using UnityEngine;

public static class SceneStateManager
{
    public static Dictionary<DetailsEnum, bool> isObjectActive = new Dictionary<DetailsEnum, bool>(); // ���������� ��� �������� ��������� �������
    public static float countdownTime = 10f; // ����� ��������� ������� � ��������
    public static Vector3[] rigidbodyPositions; // ������ ��� �������� ������� �������� Rigidbody
}
