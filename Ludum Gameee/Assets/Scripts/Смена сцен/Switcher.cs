using UnityEngine;
using UnityEngine.SceneManagement;

public class Switcher : MonoBehaviour
{
    public void scenLoad(int numbScen)
    {
        SceneManager.LoadScene(numbScen);
    }
}
//это скрипт для смены сцены по нажатию кнопки