using System.Collections.Generic;
using UnityEngine;

public class ObjectPositionManager : MonoBehaviour
{
    public static ObjectPositionManager Instance;

    // ������� ��� �������� ������� ��������
    private Dictionary<string, Vector3> objectPositions = new Dictionary<string, Vector3>();

    private void Awake()
    {
        // ���������� �������� Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SavePosition(string objectName, Vector3 position)
    {
        if (objectPositions.ContainsKey(objectName))
        {
            objectPositions[objectName] = position;
        }
        else
        {
            objectPositions.Add(objectName, position);
        }
    }

    public Vector3 LoadPosition(string objectName)
    {
        if (objectPositions.TryGetValue(objectName, out Vector3 position))
        {
            return position;
        }
        return Vector3.zero; // ���������� ������� �������, ���� ������ �� ������
    }
}