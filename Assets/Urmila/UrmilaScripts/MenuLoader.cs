using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    public int sceneIndexToLoad = 0;

    public void LoadSceneOnClick()
    {
        SceneManager.LoadScene(sceneIndexToLoad);
        Debug.Log("menu");
    }
}
