using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    
   public void Metaverse()
    {
        // load meta
        SceneManager.LoadScene("lobby");

    }
    public void Quit()
    {
        Application.Quit();
    }

    public void SinglePlayer()
    {
        //loads the single player 
        SceneManager.LoadScene("SolarSystem");
    }
    public void History()
    {
        SceneManager.LoadScene("History");
    }
    public void Driving()
    {
        SceneManager.LoadScene("Demo");
    }
    
    public void loadmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void SwitchToSubjectMenu()
    {
        //play camera animation
        //deactivate main menu

    }
}
