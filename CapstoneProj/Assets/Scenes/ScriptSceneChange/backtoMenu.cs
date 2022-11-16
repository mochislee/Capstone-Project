using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backtoMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Back(){
        SceneManager.LoadScene("Menu");
    }
}
