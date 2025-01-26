using System;
using System.Collections.Generic;
using System.Linq;

    // it is for indivudual words in the scripture
    class Word
    {
        public string Text { get; private set; }
        public bool IsHidden { get; private set; }
        // constructor (whatever that means)
        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }
        // hide the word
        public void Hide()
        {
            IsHidden = true;
        }
        // And then display the word
        public string Display()
        {   // if the word is hidden, display it as _
            return IsHidden ? new string('_', Text.Length) : Text;
        }
    }
