using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scene2Controller : MonoBehaviour
{
    public GameObject[] targetObject; // ������, ������� ����� ������� ��������
    public Image instructionsImage; // �����������, ������� ����� ������������ �� ��������� �������
    public AudioClip endSound; // ����, ������� ����� ������������� �� ��������� �������

    private AudioSource audioSource; // ��������� AudioSource ��� ��������������� �����

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
         // ������������� ���������� �������
        audioSource = gameObject.AddComponent<AudioSource>(); // ��������� AudioSource, ���� ��� ��� ���


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