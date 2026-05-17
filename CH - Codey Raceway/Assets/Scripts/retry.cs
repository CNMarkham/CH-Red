using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour
{
    private void Start()
    {
        
    }
    public void reloadGame()
    {
        SceneManager.LoadScene(0);
    }
}
