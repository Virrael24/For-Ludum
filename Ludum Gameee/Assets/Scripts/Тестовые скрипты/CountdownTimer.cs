using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountdownTimer : MonoBehaviour
{
    public Button startButton; // ������ �� ������
    public Text timerText; // ������ �� ����� ��� ����������� �������
    public float countdownTime = 10f; // ����� ��������� ������� � ��������

    void Start()
    {
        // ��������� ���������� ������� �� ������
        startButton.onClick.AddListener(StartCountdown);
    }

    void StartCountdown()
    {
        // ��������� �������� ��� �������
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine()
    {
        float timeRemaining = countdownTime;

        while (timeRemaining > 0)
        {
            // ��������� ����� �������
            timerText.text = "Time Remaining: " + timeRemaining.ToString("F2") + "s";
            yield return new WaitForSeconds(1f); // ���� 1 �������
            timeRemaining--; // ��������� ���������� �����
        }

        // ������ ��������
        timerText.text = "Time's up!";
    }
}
//�������� ������ �� ������