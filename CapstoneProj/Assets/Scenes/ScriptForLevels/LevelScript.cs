using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{


   public void Unlock(){

      //kukunin yung currentlevel
      int currentLevel = SceneManager.GetActiveScene().buildIndex;
      int playerPrefsInt = PlayerPrefs.GetInt("levelUnlock");

//mga index galing sa index nung mga quiz tas proceed sa scene (LevelManager loadlevel)
      if (currentLevel < 6)
         playerPrefsInt = 0;
      else if (currentLevel < 9)
         playerPrefsInt = 1;
      else
         playerPrefsInt = 2;

      // if(currentLevel >= PlayerPrefs.GetInt("levelUnlock")){
      //    PlayerPrefs.SetInt("levelUnlock", currentLevel + 1);
      // }

      PlayerPrefs.SetInt("levelUnlock", playerPrefsInt);

      
      Debug.Log("next level unlock:" + playerPrefsInt + "Unlock") ;
      Debug.Log(currentLevel);
   }
}
