using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreditManager : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Debug.Log("SceneChange");
        SceneManager.LoadScene(sceneName);
    }
}