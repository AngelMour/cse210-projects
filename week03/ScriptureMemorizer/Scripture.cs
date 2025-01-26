using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
    {
        private Reference _reference;

        // List of words in the scripture, need to find the issues with "Word"
        private List<Word> _words;

        // Constructor, need to review what a constructor is in more details
        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }
        // Hide random words
        public void HideRandomWords(int count)
        {
            var wordsToHide = _words
                .Where(word => !word.IsHidden)
                .OrderBy(_ => Guid.NewGuid())
                .Take(count)
                .ToList();

            foreach (var word in wordsToHide)
            {
                word.Hide();
            }
        }
        // Display the text
        public string GetDisplayText()
        {
            string scriptureText = string.Join(" ", _words.Select(word => word.Display()));
            return $"{_reference.GetDisplayText()}\n{scriptureText}";
        }
        // Check if all words are hidden
        public bool AreAllWordsHidden()
        {
            return _words.All(word => word.IsHidden);
        }
    }