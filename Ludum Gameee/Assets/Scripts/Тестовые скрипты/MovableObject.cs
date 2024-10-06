using UnityEngine;

public class MovableObject : MonoBehaviour
{
    private void OnMouseDrag()
    {
        // ����������� �������
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f; // ���������� �� ������
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(worldPosition.x, transform.position.y, worldPosition.z);
    }

    private void OnMouseUp()
    {
        // ���������� ������� �������
        ObjectPositionManager.Instance.SavePosition(gameObject.name, transform.position);
    }

    private void Start()
    {
        // �������� ������� ������� ��� ������
        transform.position = ObjectPositionManager.Instance.LoadPosition(gameObject.name);
    }
}