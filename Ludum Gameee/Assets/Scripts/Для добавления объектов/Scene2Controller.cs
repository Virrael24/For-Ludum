using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scene2Controller : MonoBehaviour
{
    public GameObject[] targetObject; // Объект, который нужно сделать активным
    public Image instructionsImage; // Изображение, которое будет отображаться по окончании таймера
    public AudioClip endSound; // Звук, который будет проигрываться по окончании таймера

    private AudioSource audioSource; // Компонент AudioSource для воспроизведения звука

    void Start()
    {
        int i = 0;
        foreach (var item in SceneStateManager.isObjectActive.Values) 
        {
            if (targetObject[i])
            {
                targetObject[i].SetActive(item);
            }

            Debug.Log(item.ToString());

            Debug.Log(i);
            i++;
            if (item)
            {
                StartCoroutine(CountdownCoroutine());
            }
        }
         // Устанавливаем активность объекта
        audioSource = gameObject.AddComponent<AudioSource>(); // Добавляем AudioSource, если его ещё нет


        instructionsImage.gameObject.SetActive(false); // Скрываем изображение в начале
    }

    IEnumerator CountdownCoroutine()
    {
        float timeRemaining = SceneStateManager.countdownTime;

        while (timeRemaining > 0)
        {
            yield return new WaitForSeconds(1f); // Ждем 1 секунду
            timeRemaining--; // Уменьшаем оставшееся время
        }

        // Таймер завершён
        ShowInstructions(); // Показываем изображение
        PlayEndSound(); // Проигрываем звук
    }

    void PlayEndSound()
    {
        if (endSound != null)
        {
            audioSource.clip = endSound;
            audioSource.Play(); // Проигрываем звук
        }
    }

    void ShowInstructions()
    {
        instructionsImage.gameObject.SetActive(true); // Показываем изображение
    }
}
//скрипт активирует таймер и объект на сцене