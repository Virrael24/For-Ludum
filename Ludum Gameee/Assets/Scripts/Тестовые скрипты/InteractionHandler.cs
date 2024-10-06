using UnityEngine;
using UnityEngine.UI;

public class InteractionHandler : MonoBehaviour
{
    public GameObject imagePanel; // Панель с изображением
    public Button closeButton; // Кнопка для закрытия панели

    private void Start()
    {
        // Скрываем панель при старте
        imagePanel.SetActive(false);

        // Добавляем обработчик нажатия на кнопку
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
