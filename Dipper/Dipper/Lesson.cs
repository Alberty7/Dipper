using System;

public class Subject : IComparable {
    public string LessonName { get; private set; }
    public string Teacher { get; private set; }
    public int AllTimeLesson { get; private set; }


    public Subject(string lessonName, string teacher, int allTimeLesson) {
        LessonName = lessonName;
        Teacher = teacher;
        AllTimeLesson = allTimeLesson;
    }

    public int CompareTo(object obj) {
        if(obj is Subject other)
            return LessonName.CompareTo(other.LessonName) + Teacher.CompareTo(other.Teacher) + AllTimeLesson.CompareTo(other.AllTimeLesson);
        else
            throw new Exception("Несравнимые объекты");
    }
    public override string ToString() {
        return $"{LessonName}\n{Teacher}";
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