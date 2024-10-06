using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickableObject : MonoBehaviour
{
    public DetailsEnum Details;
    void OnMouseDown()
    {
        // ��������� ������� ���� Rigidbody ����� ��������� ����� �����
        SaveRigidbodyPositions();
        SceneStateManager.isObjectActive = new System.Collections.Generic.Dictionary<DetailsEnum, bool>();
        foreach (object kvp in Enum.GetValues(typeof(DetailsEnum)))
        {
            SceneStateManager.isObjectActive[(DetailsEnum)kvp] = false;
        }
        SceneStateManager.isObjectActive[Details] = true; // ������������� ��������� ����� ��������� ����� �����
        SceneManager.LoadScene("�������� �����"); // �������� "�������� �����" �� ��� ����� ������ �����
    }

    private void SaveRigidbodyPositions()
    {
        Rigidbody[] rigidbodies = FindObjectsOfType<Rigidbody>();
        SceneStateManager.rigidbodyPositions = new Vector3[rigidbodies.Length];

        for (int i = 0; i < rigidbodies.Length; i++)
        {
            SceneStateManager.rigidbodyPositions[i] = rigidbodies[i].transform.position;
        }
    }
}
//���� ������ �������� ��������� ���������� �� ��������� �� ������� �� 3� ������, ��� ��������� ������� ������� � ������ �����