using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VocabManager : MonoBehaviour
{
    [SerializeField] private List<string> words = new List<string>();
    [SerializeField] private List<string> meanings = new List<string>();

    private Dictionary<string, string> VocabList = new Dictionary<string, string>();

    public GameObject Vocab_word;
    public GameObject Vocab_meaning;    
    
    public UnityEngine.UI.Text Words;
    public UnityEngine.UI.Text Meanings;

    public void Start()
    {
        generateVocabList();
    }

    void generateVocabList()
    {
        Vocab_word.SetActive(true);
        Vocab_meaning.SetActive(true);

    }
}
