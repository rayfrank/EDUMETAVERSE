using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loadscene : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneLoad;
    
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneLoad);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneLoad);
        }
    }
}
