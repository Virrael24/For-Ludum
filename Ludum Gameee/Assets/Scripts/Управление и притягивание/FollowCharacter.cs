using UnityEngine;

public class FollowCharacter : MonoBehaviour
{
    private bool isDragging = false; // ���� ��� ������������ ��������������
    public Transform player; // ������ �� ���������
    public float followDistance = 2.0f; // ����������, �� ������� ������ ����� ��������� �� ����������
    public float activationDistance = 0.5f; // ����������� ���������� ��� ���������

    void OnMouseDown()
    {
        isDragging = true; // ������������� ����, ��� ������ ���������������
    }

    void OnMouseUp()
    {
        isDragging = false; // ���������� ����, ����� ������ ���� ��������
    }

    void Update()
    {
        if (isDragging)
        {
            // ��������� ���������� ����� �������� � ����������
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);
            if (distanceToPlayer <= activationDistance) // ���� �������� ����� ��� �� ���������� 0.5
            {
                // �������� ������� ���������
                Vector3 targetPosition = player.position;

                // ������������� ������ �� �������� ���������� �� ���������
                Vector3 followPosition = targetPosition + (player.forward * -followDistance);

                // ���������� ������ � �������, ��������� �������� ������������ ��� ���������
                transform.position = Vector3.Lerp(transform.position, followPosition, Time.deltaTime * 10f);
            }
        }
    }
}
//���� ������ ��������� ������ �� ����� �������

