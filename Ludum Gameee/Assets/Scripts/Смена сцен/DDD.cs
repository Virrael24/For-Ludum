using UnityEngine;
using UnityEngine.SceneManagement;

public class DDD : MonoBehaviour
{
    public string sceneToLoad; // ��� �����, ������� ����� ���������

    void OnMouseDown()
    {
        LoadScene();
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
//��� ������ ����� ����� �� ������� �� 3� ������