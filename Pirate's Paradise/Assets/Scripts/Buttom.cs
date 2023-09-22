using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttom : MonoBehaviour
{
    public string sceneToLoad; 

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}