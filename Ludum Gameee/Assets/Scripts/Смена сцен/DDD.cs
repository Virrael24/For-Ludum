using UnityEngine;
using UnityEngine.SceneManagement;

public class DDD : MonoBehaviour
{
    public string sceneToLoad; // ��� �����, ������� ����� ���������
    public SavePosirionsOnSceneLoad SavePosirions;

    void OnMouseDown()
    {
        LoadScene();
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
        if(SavePosirions)
            SavePosirions.Save();
    }
}
//��� ������ ����� ����� �� ������� �� 3� ������