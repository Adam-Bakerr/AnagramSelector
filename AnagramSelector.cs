using System.Collections;
using System.IO;

using System.Collections.Generic;
using UnityEngine;

/*
    Feedback Comment : Tom J (S212046)
    If you want to inherit 'MonoBehaviour', you can, it just doesn't appear to be necessary right now.
    If the anagram is designed to be attached to a 'gameObject', or will be updated every frame then you
    would want to inherit 'monobehaviour'. If decide to not use 'monobehaviour' simply put the 'Start()'
    code inside of a 'default constructor'. [AnagramSelector();]
*/

public class AnagramSelector : MonoBehaviour //Inheriting from 'MonoBehaviour' is unnecessary right now.
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
        string filename = "Anagrams" + lengthOfWords + ".txt"; //You might find it more practical to instead pass through a string; specifying where the file is located.
    
        //Looks fine, good job.
        using (StreamReader strreader = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "Assets",filename)))
        {
            string CurrentLine;
            while ((CurrentLine = strreader.ReadLine()) != null)
            {
                Anagrams.Add(CurrentLine);
            }
        }

    }
        
    /*
    Feedback Comment : Tom J (S212046)
    Before attempting to use the list of anagrams, you could check to see if the list has been loaded first.
    If the list has not been loaded then return a predefined 'const-value' such as [ const string empty = "EMPTY"; ]. 
    */
        
    // Grabs a random anagram from the anagrams list and returns it
    string GrabRandomAnagram() 
    { 
        int randomInt = Random.Range(0, Anagrams.Count);
        SelectedAnagram = Anagrams[randomInt];
        return (SelectedAnagram);
    }
    
    /*
    Feedback Comment : Tom J (S212046)
    Again, you might want to perform a simple check to reduce the chance of any errors appearing.
    You could also randomise the array of 'chars'.
    Otherwise, good job, the script itself is good... these changes will just 'polish' the overall program.
    */
    
    // returns the a char array which is selected by grabrandomanagrams and splits it into an array of chars
    char[] returnArrayOfChars() {
        return (SelectedAnagram.ToCharArray());
    }




// How to use
// Select dificulty then run the load list function followed by grabrandomanagram
   
}
