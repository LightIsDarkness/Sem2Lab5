using System.ComponentModel;

namespace Sem2Lab5.Models
{
    public class Discipline : INotifyPropertyChanged
    {
        private string _Name, _TeacherName, _Difficulty;
        private DateTime _ExaminationDate;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string TeacherName
        {
            get { return _TeacherName; }
            set
            {
                _TeacherName = value;
                OnPropertyChanged("TeacherName");
            }
        }
        public string Difficulty
        {
            get { return _Difficulty; }
            set
            {
                _Difficulty = value;
                OnPropertyChanged("Difficulty");
            }
        }
        public DateTime ExaminationDate
        {
            get { return _ExaminationDate; }
            set
            {
                _ExaminationDate = value;
                OnPropertyChanged("ExamDate");
            }
        }

        public DateTime PreparationtDate
        {
            get
            {
                switch (_Difficulty)
                {
                    case "Легко":
                        return _ExaminationDate;
                    case "Средне":
                        return _ExaminationDate.AddDays(-14);
                    case "Сложно":
                        return _ExaminationDate.AddMonths(-1);


                    default:
                        return _ExaminationDate;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
