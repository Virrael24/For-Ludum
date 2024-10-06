using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scene2Controller : MonoBehaviour
{
    public GameObject targetObject; // ������, ������� ����� ������� ��������
    public Image instructionsImage; // �����������, ������� ����� ������������ �� ��������� �������
    public AudioClip endSound; // ����, ������� ����� ������������� �� ��������� �������

    private AudioSource audioSource; // ��������� AudioSource ��� ��������������� �����

    void Start()
    {
        targetObject.SetActive(SceneStateManager.isObjectActive); // ������������� ���������� �������
        audioSource = gameObject.AddComponent<AudioSource>(); // ��������� AudioSource, ���� ��� ��� ���

        // ��������� ������
        if (SceneStateManager.isObjectActive)
        {
            StartCoroutine(CountdownCoroutine());
        }

        instructionsImage.gameObject.SetActive(false); // �������� ����������� � ������
    }

    IEnumerator CountdownCoroutine()
    {
        float timeRemaining = SceneStateManager.countdownTime;

        while (timeRemaining > 0)
        {
            yield return new WaitForSeconds(1f); // ���� 1 �������
            timeRemaining--; // ��������� ���������� �����
        }

        // ������ ��������
        ShowInstructions(); // ���������� �����������
        PlayEndSound(); // ����������� ����
    }

    void PlayEndSound()
    {
        if (endSound != null)
        {
            audioSource.clip = endSound;
            audioSource.Play(); // ����������� ����
        }
    }

    void ShowInstructions()
    {
        instructionsImage.gameObject.SetActive(true); // ���������� �����������
    }
}
//������ ���������� ������ � ������ �� �����