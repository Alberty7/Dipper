using System;

[Serializable]
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
    public override string ToString() => $"{LessonName} — {Teacher}";
}

[Serializable]
public class Lesson : Subject {
    public DateTime StartLesson { get; private set; }
    public DateTime FinishLesson { get; private set; }
    public string NameGroup { get; private set; }
    public int NumberGroup { get; private set; }

    public Lesson(string lessonName, string teacher, int allTimeLesson, DateTime startLesson, DateTime finishLesson, string nameGroup, int numberGroup) : base(lessonName, teacher, allTimeLesson) {
        StartLesson = startLesson;
        FinishLesson = finishLesson;
        NameGroup = nameGroup;
        NumberGroup = numberGroup;
    }

    public new int CompareTo(object obj) {
        switch(obj) {
            case Lesson other:
                return LessonName.CompareTo(other.LessonName) + Teacher.CompareTo(other.Teacher) + AllTimeLesson.CompareTo(other.AllTimeLesson) + StartLesson.CompareTo(other.StartLesson) + FinishLesson.CompareTo(other.FinishLesson) + NameGroup.CompareTo(other.NameGroup) + NumberGroup.CompareTo(other.NumberGroup);
            default:
                throw new Exception("Несравнимые объекты");
        }
    }

    public override string ToString() => $"{base.ToString()}\t{StartLesson.Hour}:{StartLesson.Minute} — {FinishLesson.Hour}:{FinishLesson.Minute}\n{NameGroup}\n{NumberGroup}";
}