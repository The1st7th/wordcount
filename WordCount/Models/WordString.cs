using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace stringWordApp.Models
{
  public class Wordstring
  {
    string _word;
    string _key;
    public Wordstring(string word, string key)
    {
      _word = word;
      _key = key;
    }
    public int count(){
    _word = _word.ToLower();
    _word = Regex.Replace(_word,"[^A-Za-z0-9 _]","");
    _key = _key.ToLower();
    int counter = 0;
    string[] s = _word.Split(' ');
    
    foreach(string w in s){
      if(w == _key){
        counter++;
      }
    }
    return counter;
    }

  }
}
