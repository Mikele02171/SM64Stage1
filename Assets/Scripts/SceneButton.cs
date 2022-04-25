using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public void LevelSelect()
    {
        SceneManager.LoadScene("SM64 Select Menu");
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("SM64 Main Menu");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void Stage1()
    {
        SceneManager.LoadScene("Mario64Stage1-BigBombomb");
    }

    public void Stage3()
    {
        SceneManager.LoadScene("Mario64Stage1-IslandintheSky");
    }

    public void Stage5()
    {
        SceneManager.LoadScene("Mario64Stage1-MarioWingstotheSky");
    }

    public void Stage6()
    {
        SceneManager.LoadScene("Mario64Stage1 - BehindChainChompGate");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }


}
