using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountdownTimer : MonoBehaviour
{
    public Button startButton; // Ссылка на кнопку
    public Text timerText; // Ссылка на текст для отображения времени
    public float countdownTime = 10f; // Время обратного отсчета в секундах

    void Start()
    {
        // Добавляем обработчик нажатия на кнопку
        startButton.onClick.AddListener(StartCountdown);
    }

    void StartCountdown()
    {
        // Запускаем корутину для таймера
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine()
    {
        float timeRemaining = countdownTime;

        while (timeRemaining > 0)
        {
            // Обновляем текст таймера
            timerText.text = "Time Remaining: " + timeRemaining.ToString("F2") + "s";
            yield return new WaitForSeconds(1f); // Ждем 1 секунду
            timeRemaining--; // Уменьшаем оставшееся время
        }

        // Таймер завершён
        timerText.text = "Time's up!";
    }
}
//тестовый таймер по кнопке