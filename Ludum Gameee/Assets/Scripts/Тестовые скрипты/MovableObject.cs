using UnityEngine;

public class MovableObject : MonoBehaviour
{
    private void OnMouseDrag()
    {
        // Перемещение объекта
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f; // Расстояние от камеры
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(worldPosition.x, transform.position.y, worldPosition.z);
    }

    private void OnMouseUp()
    {
        // Сохранение позиции объекта
        ObjectPositionManager.Instance.SavePosition(gameObject.name, transform.position);
    }

    private void Start()
    {
        // Загрузка позиции объекта при старте
        transform.position = ObjectPositionManager.Instance.LoadPosition(gameObject.name);
    }
}