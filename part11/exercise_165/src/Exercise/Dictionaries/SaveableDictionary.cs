namespace Exercise
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    public class SaveableDictionary
    {
        private Dictionary<string, string> dict;
        private string file;
        public SaveableDictionary()
        {
            this.dict = new Dictionary<string, string>();
        }

        public SaveableDictionary(string file) : this()
        {
            this.file = file;
        }

        public void Add(string word, string translation)
        {
          if (!this.dict.ContainsKey(word))
          {
            this.dict.Add(word, translation);
            this.dict.Add(translation, word);
          }
        }

        public bool Load()
        {
          try
          {
            string[] lines = File.ReadAllLines(this.file);
            foreach (string line in lines)
            {
              string[] parts = line.Split(":");
              string word = parts[0];
              string translation = parts[1];
              Add(word, translation);
            }
            
          }
          catch (Exception e)
            {
              Console.WriteLine(e.Message);
              return false;
            }
          return true;
        }

        public bool Save()
        {
          List<string> alreadySaved = new List<string>();
          try
          {
            StreamWriter sw = new StreamWriter(this.file);
            foreach (string word in this.dict.Keys)
              {
                string composition = word + ":" + this.dict[word];
                string backwards = this.dict[word] + ":" + word;
                if (!alreadySaved.Contains(composition) && !alreadySaved.Contains(backwards))
                {
                  alreadySaved.Add(composition);
                  sw.WriteLine(composition);
                }
              }
            sw.Close();
            
          }
          catch (Exception e)
          {
            Console.WriteLine(e.Message);
            return false;
          }
          return true;

        }

        public string Translate(string word)
        {
          if (this.dict.ContainsKey(word))
          {
            return this.dict[word];
          }
          return null;
        }

        public void Delete(string word)
        {
          if (this.dict.ContainsKey(word))
          {
            string translation = this.dict[word];
            this.dict.Remove(word);
            this.dict.Remove(translation);
          }
        }
    }
}