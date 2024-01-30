using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void Level1()
    {
        Debug.Log("Entraste al juego");
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        Debug.Log("Entraste al juego");
        SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        Debug.Log("Entraste al juego");
        SceneManager.LoadScene("Level3");
    }

    public void Level4()
    {
        Debug.Log("Entraste al juego");
        SceneManager.LoadScene("Level4");
    }


    public void IrAStory()
    {
        Debug.Log("Entraste al juego");
        SceneManager.LoadScene("Story");
    }

    public void IrAOptions()
    {
        Debug.Log("Entraste al juego");
        SceneManager.LoadScene("Options");
    }

    public void IrAMenu()
    {
        Debug.Log("Entraste al juego");
        SceneManager.LoadScene("Intro");
    }

    public void IrAHowToPlay()
    {
        Debug.Log("Entraste al juego");
        SceneManager.LoadScene("HowToPlay");
    }

    public void IrALevel1Menu()
    {
        Debug.Log("Entraste al juego");
        SceneManager.LoadScene("Objective1");
    }

    public void IrALevel2Menu()
    {
        Debug.Log("Entraste al juego");
        //SceneManager.LoadScene("Intro1");
    }

    public void IrALevel3Menu()
    {
        Debug.Log("Entraste al juego");
        //SceneManager.LoadScene("Intro1");
    }

    public void IrALevel4Menu()
    {
        Debug.Log("Entraste al juego");
        //SceneManager.LoadScene("Intro1");
    }

}
