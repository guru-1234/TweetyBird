using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitManager()
    {
        Application.Quit();
        //public static void Exit(int returnValue);
        //UnityEditor.EditorApplication.isPlaying = false;
    }


}
