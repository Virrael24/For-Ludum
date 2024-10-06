using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnClick : MonoBehaviour
{
    public string sceneToLoad; // Имя сцены для загрузки

    void OnMouseDown()
    {
        // Проверяем, есть ли объект с тегом "thing" в радиусе 1 метра от игрока
        if (IsThingInRange())
        {
            SceneManager.LoadScene(sceneToLoad); // Замените на имя вашей сцены
        }
    }

    private bool IsThingInRange()
    {
        // Получаем позицию игрока
        GameObject player = GameObject.FindWithTag("Player");
        if (player == null)
        {
            Debug.LogWarning("Player object not found! Make sure it has the tag 'Player'.");
            return false; // Если игрок не найден, возвращаем false
        }

        // Проверяем расстояние до объектов с тегом "thing"
        Collider[] hitColliders = Physics.OverlapSphere(player.transform.position, 2f);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("thing"))
            {
                return true; // Объект с тегом "thing" найден в радиусе 1 метра
            }
        }

        return false; // Объект с тегом "thing" не найден
    }
}
//скрипт загружает новую сцену, только если рядом с игроком есть нужный объект
