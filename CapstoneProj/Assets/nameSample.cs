using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nameSample : MonoBehaviour {

    public UnityEngine.UI.Text message;
    [SerializeField] public InputField Input;


    private string name = "Kriselle";

    public void checkExisted(){

        string playername = Input.text;

        if(playername.Equals(name)){
            message.text = "Already Existed";
    }
    else{
        message.text = "name: " + playername;
    }

}
}