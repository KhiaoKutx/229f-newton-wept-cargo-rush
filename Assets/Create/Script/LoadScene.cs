using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadScenex(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}
