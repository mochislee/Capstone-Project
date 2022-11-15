using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VocabularyScript : MonoBehaviour
{
    [SerializeField] private List<string> words = new List<string>();
    [SerializeField] private List<string> meanings = new List<string>();

    private Dictionary<string, string> Vocabs = new Dictionary<string, string>();
}
