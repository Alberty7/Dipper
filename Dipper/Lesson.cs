using System;

public class Lesson
{
    private string lessonName;

    public string LessonName { get => lessonName; private set { if (!string.IsNullOrEmpty(value)) lessonName = value; } }
    public string Teacher { get; private set; }
    public DateTime StartLesson { get; private set; }
    public DateTime FinishLesson { get; private set; }
    public int AllTimeLesson { get; private set; }
    public string NameGroup { get; private set; }
    public int NumberGroup { get; private set; }

    public Lesson(DateTime startLesson, DateTime finishLesson, string lessonName, string teacher, int allTimeLesson, string nameGroup, int numberGroup)
    {                     
        if (StartLesson > FinishLesson)
        {
            startLesson = startLesson;
            finishLesson = finishLesson;
        }
        else
        {
            startLesson = finishLesson;
            finishLesson = startLesson;
        }

        lessonName = lessonName;
        teacher = teacher;
        allTimeLesson = allTimeLesson;
        nameGroup = nameGroup;
        numberGroup = numberGroup;
    }
}

