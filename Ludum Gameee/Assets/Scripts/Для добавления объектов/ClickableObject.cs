using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickableObject : MonoBehaviour
{
    void OnMouseDown()
    {
        // ��������� ������� ���� Rigidbody ����� ��������� ����� �����
        SaveRigidbodyPositions();

        SceneStateManager.isObjectActive = true; // ������������� ��������� ����� ��������� ����� �����
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