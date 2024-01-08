using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickPlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OnClickMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
