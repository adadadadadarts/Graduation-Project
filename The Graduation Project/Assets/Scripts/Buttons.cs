using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("SaveScene");
        
    }
    
    public void SettingsButton()
    {
        SceneManager.LoadScene("SettingsScene");
        
    }
    
    public void CreditsButton()
    {
        SceneManager.LoadScene("CreditsScene");
        
    }
    
    public void QuitGameButton()
    {
        Application.Quit();
        
    }
    
    public void NewGameButton()
    {
        SceneManager.LoadScene("GameScene");
        
    }
    
    public void MainMenuButton()
    {
        SceneManager.LoadScene("StartScene");
        
    }
    
    
}
