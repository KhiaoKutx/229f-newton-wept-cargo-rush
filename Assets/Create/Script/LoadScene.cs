using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadScenex(SceneAsset Scene)
    {
        SceneManager.LoadScene(Scene.name);
    }
}
