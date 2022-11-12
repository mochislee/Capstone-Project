using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    int levelUnlock;
    

    public Button[] btn;
    public List<GameObject> Images;

    // Start is called before the first frame update
    void Start()
    {
        levelUnlock = PlayerPrefs.GetInt("levelUnlock", 0);
        

        for(int i = 0; i < btn.Length; i++){
            
            btn[i].interactable = false;
        }
        for(int i = 0; i <= levelUnlock; i++){
            
            btn[i].interactable = true;
            if (i == 1){
                Images[0].SetActive(false);
            }
            else if(i == 2){
                Images[1].SetActive(false);
            }
               
        }
        
    }
    public void LoadLevel(int levelIndex){
        if(levelIndex == 0){
            SceneManager.LoadScene("Castle_King");
        }
        if(levelIndex == 1){
            SceneManager.LoadScene("Forest");
        }
        if(levelIndex == 2){
            SceneManager.LoadScene("level_PiedasPlatas");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
