using UnityEngine;

public static class SceneStateManager
{
    public static bool isObjectActive = false; // ���������� ��� �������� ��������� �������
    public static float countdownTime = 10f; // ����� ��������� ������� � ��������
    public static Vector3[] rigidbodyPositions; // ������ ��� �������� ������� �������� Rigidbody
}