using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneLoadManager : MonoBehaviour
{
    public Button sceneChangebutton;
    public int index = 0;
    private void Start() {
        sceneChangebutton = GetComponent<Button>();
        sceneChangebutton.onClick.AddListener(ChangeScene);
    }

    private void ChangeScene() {
        SceneManager.LoadScene(index);
    }
}
