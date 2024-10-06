using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickableObject : MonoBehaviour
{
    void OnMouseDown()
    {
        // Сохраняем позиции всех Rigidbody перед загрузкой новой сцены
        SaveRigidbodyPositions();

        SceneStateManager.isObjectActive = true; // Устанавливаем состояние перед загрузкой новой сцены
        SceneManager.LoadScene("Тестовая сцена"); // Замените "Тестовая сцена" на имя вашей второй сцены
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
//этот скрипт изменяет состояние переменной из хранилища по нажатию на 3д объект, для появления другого объекта в другой сцене