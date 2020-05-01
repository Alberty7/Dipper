using System;

public class Subject {
    private string lessonName;

    public string LessonName { get => lessonName; private set { if(!string.IsNullOrEmpty(value)) lessonName = value; } }
    public string Teacher { get; private set; }
    public int AllTimeLesson { get; private set; }


    public Subject(string lessonName, string teacher, int allTimeLesson) {
        
    }
}

public class Lesson : Subject {
    public DateTime StartLesson { get; private set; }
    public DateTime FinishLesson { get; private set; }
    public string NameGroup { get; private set; }
    public int NumberGroup { get; private set; }

    public Lesson(string lessonName, string teacher, int allTimeLesson, DateTime startLesson, DateTime finishLesson, string nameGroup, int numberGroup) : base(lessonName, teacher, allTimeLesson) {

    }
}