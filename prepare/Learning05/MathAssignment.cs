using System;

namespace Learning05
{
    public class MathAssignment : Assignment
    {
        string _textbookSection;
        string _problems;

        public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }

        public string GetHomeworkList()
        {
            return $"{GetSummary()}\n{_textbookSection}: {_problems}";
        }
    }
}