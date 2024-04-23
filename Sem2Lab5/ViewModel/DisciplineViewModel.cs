using Sem2Lab5.Models;
using Sem2Lab5.src;
using System.Collections.ObjectModel;
using System.Windows;
namespace Sem2Lab5.ViewModel
{
    public class DisciplineViewModel
    {
        MainWindow mw = (MainWindow)Application.Current.MainWindow;
        public ObservableCollection<Discipline> Disciplines { get; set; }

        public Discipline SelectedItem { get; set; }

        public DisciplineViewModel()
        {
            Disciplines = new ObservableCollection<Discipline>();
            mw.Difficulty.Items.Add("Лeгко");
            mw.Difficulty.Items.Add("Средне");
            mw.Difficulty.Items.Add("Сложно");
        }
        public RelayCommands AddDiscipline => new RelayCommands(execute => _AddDiscipline(mw.NameBut.Text, mw.FIOBut.Text, mw.Difficulty.SelectedItem.ToString(), mw.TimeEx.SelectedDate.GetValueOrDefault()));
        public RelayCommands RemoveDiscipline => new RelayCommands(execute => _RemoveDiscipline(SelectedItem));
        public void _AddDiscipline(string name, string tname, string diff, DateTime Date)
        {
            if (name == "" || tname =="" || diff ==null || Date == DateTime.MinValue)
            {
                MessageBox.Show("Одно из полей не заполнено");
            }
            else
            {
                Discipline temp = new Discipline()
                {
                    Name = name,
                    TeacherName = tname,
                    Difficulty = diff,
                    ExaminationDate = Date
                };
                Disciplines.Add(temp);
            }
        }

        public void _RemoveDiscipline(Discipline discipline)
        {
            Disciplines.Remove(discipline);
        }
    }
}
