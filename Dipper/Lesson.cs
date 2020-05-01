using System;

public class Lesson
{
    private string lessonName;

    public string LessonName { get => lessonName; private set { if (!string.IsNullOrEmpty(value)) lessonName = value; } }
    public string Teacher { get; private set; }
    public DateTime StartLesson { get; private set; }
    public DateTime AinishLesson { get; private set; }
    public int AllTimeLesson { get; private set; }
    public string NameGroup { get; private set; }
    public int NumberGroup { get; private set; }

    public Lesson(string nameOfLesson, string teacher, int time)
    {
        LessonName = nameOfLesson;
        Teacher = teacher;
        Time = time;

    }

    public Lesson(int start, int finish)
    {
        if ()
        if (start < finish)
        {
            DateTime = Time;

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

