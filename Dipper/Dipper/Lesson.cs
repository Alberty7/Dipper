using System;
using System.Runtime.Serialization;

[Serializable]
public class Subject : IComparable, ISerializable {
    public string LessonName { get; private set; }
    public string Teacher { get; private set; }

    public Subject(string lessonName, string teacher) {
        LessonName = lessonName;
        Teacher = teacher;
    }

    public Subject(Subject other) {
        LessonName = other.LessonName;
        Teacher = other.Teacher;
    }

    public Subject(SerializationInfo info, StreamingContext context) {
        LessonName = info.GetString("LessonName");
        Teacher = info.GetString("Teacher");
    }

    public int CompareTo(object obj) {
        if(obj is Subject other)
            return LessonName.CompareTo(other.LessonName) + Teacher.CompareTo(other.Teacher);
        else
            throw new Exception("Несравнимые объекты");
    }
    public override string ToString() => $"{LessonName} — {Teacher}";

    public void GetObjectData(SerializationInfo info, StreamingContext context) {
        info.AddValue("LessonName", LessonName, typeof(string));
        info.AddValue("Teacher", Teacher, typeof(string));
    }
}

[Serializable]
public class Lesson : Subject{
    public DateTime StartLesson { get; private set; }
    public DateTime FinishLesson { get; private set; }
    public string NameGroup { get; private set; }
    public int NumberGroup { get; private set; }

    public Lesson(string lessonName, string teacher, DateTime startLesson, DateTime finishLesson, string nameGroup, int numberGroup) : base(lessonName, teacher) {
        StartLesson = startLesson;
        FinishLesson = finishLesson;
        NameGroup = nameGroup;
        NumberGroup = numberGroup;
    }
    public Lesson(Subject subject, DateTime startLesson, DateTime finishLesson, string nameGroup, int numberGroup) : base(subject) {
        StartLesson = startLesson;
        FinishLesson = finishLesson;
        NameGroup = nameGroup;
        NumberGroup = numberGroup;
    }

    public new int CompareTo(object obj) {
        switch(obj) {
            case Lesson other:
                return LessonName.CompareTo(other.LessonName) + Teacher.CompareTo(other.Teacher) + StartLesson.CompareTo(other.StartLesson) + FinishLesson.CompareTo(other.FinishLesson) + NameGroup.CompareTo(other.NameGroup) + NumberGroup.CompareTo(other.NumberGroup);
            default:
                throw new Exception("Несравнимые объекты");
        }
    }

    public override string ToString() => $"{LessonName}\n{Teacher}";
}