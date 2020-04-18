using System;

public class Lesson
{
    private string lessonName;

    public string LessonName { get => lessonName; private set { if (!string.IsNullOrEmpty(value)) lessonName = value; } }
    public string Teacher { get; set; }
    public int Time { get; set; }
    public int End { get; set; }

    public Lesson(string nameOfLesson, string teacher, int time)
    {
        LessonName = nameOfLesson;
        Teacher = teacher;
        Time = time;

    }

    public Lesson(int start, int finish)
    {
        if (start < finish)
        {
            Time = start;
            End = finish;
        }
        else
        {
            Time = finish;
            End = start;
        }

    }
}

