using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnClick : MonoBehaviour
{
    public string sceneToLoad; // ��� ����� ��� ��������

    void OnMouseDown()
    {
        // ���������, ���� �� ������ � ����� "thing" � ������� 1 ����� �� ������
        if (IsThingInRange())
        {
            SceneManager.LoadScene(sceneToLoad); // �������� �� ��� ����� �����
        }
    }

    private bool IsThingInRange()
    {
        // �������� ������� ������
        GameObject player = GameObject.FindWithTag("Player");
        if (player == null)
        {
            Debug.LogWarning("Player object not found! Make sure it has the tag 'Player'.");
            return false; // ���� ����� �� ������, ���������� false
        }

        // ��������� ���������� �� �������� � ����� "thing"
        Collider[] hitColliders = Physics.OverlapSphere(player.transform.position, 2f);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("thing"))
            {
                return true; // ������ � ����� "thing" ������ � ������� 1 �����
            }
        }

        return false; // ������ � ����� "thing" �� ������
    }
}
//������ ��������� ����� �����, ������ ���� ����� � ������� ���� ������ ������
