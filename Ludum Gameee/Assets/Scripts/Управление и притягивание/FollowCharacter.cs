using UnityEngine;

public class FollowCharacter : MonoBehaviour
{
    private bool isDragging = false; // Флаг для отслеживания перетаскивания
    public Transform player; // Ссылка на персонажа
    public float followDistance = 2.0f; // Расстояние, на котором объект будет следовать за персонажем
    public float activationDistance = 0.5f; // Минимальное расстояние для активации

    void OnMouseDown()
    {
        isDragging = true; // Устанавливаем флаг, что объект перетаскивается
    }

    void OnMouseUp()
    {
        isDragging = false; // Сбрасываем флаг, когда кнопка мыши отпущена
    }

    void Update()
    {
        if (isDragging)
        {
            // Проверяем расстояние между объектом и персонажем
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);
            if (distanceToPlayer <= activationDistance) // Если персонаж ближе или на расстоянии 0.5
            {
                // Получаем позицию персонажа
                Vector3 targetPosition = player.position;

                // Устанавливаем объект на заданное расстояние от персонажа
                Vector3 followPosition = targetPosition + (player.forward * -followDistance);

                // Перемещаем объект к позиции, используя линейную интерполяцию для плавности
                transform.position = Vector3.Lerp(transform.position, followPosition, Time.deltaTime * 10f);
            }
        }
    }
}
//этот скрипт позволяет тащить за собой объекты

