using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionSceneButton : MonoBehaviour
{
    public void SceneChange(string scene2)
    {
        SceneManager.LoadScene(scene2);
    }
}
