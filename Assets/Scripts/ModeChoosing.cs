using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeChoosing : MonoBehaviour
{
    
    public void ChooseTwoPlayer(){

        SceneManager.LoadScene(1);

    }

    public void ChooseSinglePlayer(){

        SceneManager.LoadScene(2);

    }

}
