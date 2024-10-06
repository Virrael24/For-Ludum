using UnityEngine;
using UnityEngine.SceneManagement;

public class DDD : MonoBehaviour
{
    public string sceneToLoad; // Имя сцены, которую нужно загрузить

    void OnMouseDown()
    {
        LoadScene();
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
//это скрипт смены сцены по нажатию на 3д объект