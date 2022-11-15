using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName ="New Vocabulary Storage", menuName ="Vocab Objects/Vocabulary Storage Object")]
public class VocabScriptableObject : ScriptableObject 
{
    [SerializeField] List<string> words = new List<string>();
    [SerializeField] List<string> meanings = new List<string>();

    public List<string> Words { get => words; set => words = value; }

    public List<string> Meanings { get => meanings; set => meanings = value; }
}
