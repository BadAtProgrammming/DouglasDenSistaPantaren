using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreditManager : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        //Scenechange script, changes the script that is referenced -Dev
        Debug.Log("SceneChange");
        SceneManager.LoadScene(sceneName);
    }
}