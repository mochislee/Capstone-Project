using System.Collections.Generic;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour {

    [SerializeField] public InputField nameInput;
  [SerializeField] string filename;
    public UnityEngine.UI.Text message;

    public TextAsset jsonName;

    

     List<InputEntry> entries = new List<InputEntry> ();

    public delegate void OnHighscoreListChanged (List<InputEntry> list);
    public static event OnHighscoreListChanged onHighscoreListChanged;

    public void Start () {
        entries = FileHandler.ReadListFromJSON<InputEntry> (filename);

         if (onHighscoreListChanged != null) {
            onHighscoreListChanged.Invoke (entries);
        }
    }

    public void AddNameToList () {
        string namePlayer = nameInput.text;
        entries.Add (new InputEntry (nameInput.text));
        nameInput.text = "";
        message.text = "Pangalan: " + namePlayer;

        FileHandler.SaveToJSON<InputEntry> (entries, filename);
        if (onHighscoreListChanged != null) {
            onHighscoreListChanged.Invoke (entries);
        }
    }

}
/**

    Player data = new Player();

 private void Start(){
    string data = File.ReadAllText(Application.dataPath +  "/Name.json");
 }

    public void AddNameToList () {

        
        string namePlayer = nameInput.text;
        
        data.playersData.Add(new PlayerData(namePlayer));

        message.text = "Pangalan: " + namePlayer;
    
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/Name.json", json);
        Debug.Log(namePlayer);



    }



   [System.Serializable]
    public class Player{
          public List<PlayerData> playersData = new List<PlayerData>();

    }
 
   [System.Serializable]
    public class PlayerData{
        public string _playerName;

        public PlayerData(){}
        public PlayerData(string name){
            _playerName = name;
        }
    }

    
}



/**
Player data = new Player();

 private void Start(){
    string data = File.ReadAllText(Application.dataPath +  "/Name.json");
 }

    public void AddNameToList () {

        
        string namePlayer = nameInput.text;
        
        data.playersData.Add(new PlayerData(namePlayer));

        message.text = "Pangalan: " + namePlayer;
    
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/Name.json", json);


        /***
        getData data = new getData();

        string namePlayer = nameInput.text;
        data.PlayerName = nameInput.text;


        if(namePlayer.Equals(data.PlayerName)){
            message.text = "Already Existed";
        }
        else{
            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(Application.dataPath + "/Name.json", json);
            message.text = "Pangalan: " + namePlayer;}
        
      
        

    }

   [System.Serializable]
    public class Player{
          public List<PlayerData> playersData = new List<PlayerData>();

    }
 
   [System.Serializable]
    public class PlayerData{
        public string _playerName;

        public PlayerData(){}
        public PlayerData(string name){
            _playerName = name;
        }

    }
    


**/




