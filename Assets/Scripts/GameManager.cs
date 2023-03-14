using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public void ResetScene(){

        SceneManager.LoadScene(1);

    }

    public void ResetSingelPlayerScene(){

        SceneManager.LoadScene(2);

    }

    public void BackToMenu(){

        SceneManager.LoadScene(0);

    }

}
