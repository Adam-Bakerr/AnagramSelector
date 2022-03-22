using System.Collections;
using System.IO;

using System.Collections.Generic;
using UnityEngine;

public class AnagramSelector : MonoBehaviour
{
    public int lengthOfWords;
    List<string> Anagrams = new List<string>();
    private string SelectedAnagram;
    void Start()
    {
        LoadList();
        GrabRandomAnagram();
    }

    // loads the correct file depending on the public dificulty and then adds them all to the anagrams list
void LoadList()
    {
        
        Anagrams.Clear();
        string filename = "Anagrams" + lengthOfWords + ".txt";
        using (StreamReader strreader = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "Assets",filename)))
        {
            string CurrentLine;
            while ((CurrentLine = strreader.ReadLine()) != null)
            {
                Anagrams.Add(CurrentLine);
            }
        }

    }
        
        
    // Grabs a random anagram from the anagrams list and returns it
    string GrabRandomAnagram() {
        int randomInt = Random.Range(0, Anagrams.Count);
        SelectedAnagram = Anagrams[randomInt];
        return (SelectedAnagram);
    }
    // returns the a char array which is selected by grabrandomanagrams and splits it into an array of chars
    char[] returnArrayOfChars() {
        return (SelectedAnagram.ToCharArray());
    }




// How to use
// Select dificulty then run the load list function followed by grabrandomanagram
   
}
