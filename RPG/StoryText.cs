using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class StoryText
    {
        public string Text { get; set; }
        public int TextNumber { get; set; }
        public int PreviousText { get; set; }
        public int FollowingText { get; set; }

        public StoryText()
        {

        }

        public StoryText(string text, int textNumber, int pText, int fText)
        {
            Text = text;
            TextNumber = textNumber;
            PreviousText = pText;
            FollowingText = fText;
        }
    }
}
