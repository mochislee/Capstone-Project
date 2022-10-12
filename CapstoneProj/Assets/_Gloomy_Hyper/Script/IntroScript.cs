using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    void onEnable()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
