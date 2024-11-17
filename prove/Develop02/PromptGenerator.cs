using System;

namespace Develop02
{
    public class PromptGenerator
    {
        public string GeneratePrompt()
        {
            // create List of prompts
            List<string> _prompts = new List<string>();
            _prompts.Add("Who was the most interesting person I interacted with today?");
            _prompts.Add("What was the best part of my day?");
            _prompts.Add("How did I see the hand of the Lord in my life today?");
            _prompts.Add("What was the strongest emotion I felt today?");
            _prompts.Add("If I had one thing I could do over today, what would it be?");
            _prompts.Add("What was one important life lesson I learned today?");
            _prompts.Add("What was the most important thing I did today?");
            _prompts.Add("How did I help someone else today?");
            _prompts.Add("What did I do to help myself today?");
            _prompts.Add("Did I interact with family today? If not, do any family members come to mind to visit soon?");
            _prompts.Add("Did any friends have an interesting experience they shared with me today?");
            _prompts.Add("Did I do anything for my neighborhood/community today?");
            _prompts.Add("What major events happened in the news today? How did they affect me?");
            _prompts.Add("Did I stay on task and work hard today? What did I accomplish?");
            _prompts.Add("Did I stop and take a breather today? What did I do to enjoy the moment?");
            _prompts.Add("What was the most important thing I did for my future today?");
            _prompts.Add("Did someone say anything that bothered me today? How did I handle it?");
            _prompts.Add("Did I work out today? How did it make me feel physically and mentally?");
            _prompts.Add("What food did I eat today? How did it make me feel?");
            _prompts.Add("What did I learn today that I didn't know yesterday?");
            _prompts.Add("What was the most important thing I did for my happiness today?");

            // select random prompt from list
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}