using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int sceneIndexToLoad;

    public void ChangeSceneByIndex()
    {
        SceneManager.LoadScene(sceneIndexToLoad);
    }
}

