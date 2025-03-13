using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenes : MonoBehaviour
{
    public static int coinCount = 0;
    public Scene currentScene;
    private string scenename;
    private void Start()
    {
         
        currentScene = SceneManager.GetActiveScene();
        scenename = currentScene.name; 
    }

    void OnGUI()
    {
        string coinText = "Score: " + coinCount;

        GUI.Box(new Rect(Screen.width - 1910, 10, 130, 20), coinText);
    }

    void Update()
    {


        if (coinCount >= 2 && scenename == "Level 1")
            SceneManager.LoadScene(2);

        if (coinCount >= 5 && scenename == "Level 2")
            SceneManager.LoadScene(3);

        if (coinCount >= 9 && scenename == "Level 3")
            SceneManager.LoadScene(4);

        if (coinCount >= 16 && scenename == "Level 4")
            SceneManager.LoadScene(5);

        if (coinCount >= 21 && scenename == "Level 5")
        {
            SceneManager.LoadScene(6);
            coinCount = 0;
        }




    }
}
