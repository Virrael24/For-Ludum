using UnityEngine;
using UnityEngine.UI;

public class InteractionHandler : MonoBehaviour
{
    public GameObject imagePanel; // ������ � ������������
    public Button closeButton; // ������ ��� �������� ������

    private void Start()
    {
        // �������� ������ ��� ������
        imagePanel.SetActive(false);

        // ��������� ���������� ������� �� ������
        closeButton.onClick.AddListener(ClosePanel);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("technik") && gameObject.CompareTag("water"))
        {
            ShowPanel();
        }
    }

    private void ShowPanel()
    {
        imagePanel.SetActive(true);
    }

    private void ClosePanel()
    {
        imagePanel.SetActive(false);
    }
}
