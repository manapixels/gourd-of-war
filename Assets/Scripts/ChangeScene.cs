using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    
    public void changeScene() {
        SceneManager.LoadScene ("InGame");
    }
}