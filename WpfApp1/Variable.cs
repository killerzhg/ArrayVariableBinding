using LuxAutoTest.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
     public class Variable : NotifyBase
    {
        public Variable() { }

        public ObservableCollection<ListModel> LogList { get; set; } = new ObservableCollection<ListModel>();



        static private string[] _textArray = new string[3];
        public string[] TextArray
        {
            get { return _textArray; }
            set
            {
                _textArray = value;
                OnPropertyChanged();
            }
        }

        public void UpdateTextArray(int index, string value)
        {
            if (index >= 0 && index < _textArray.Length)
            {
                _textArray[index] = value;
                OnPropertyChanged(nameof(TextArray));
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }
    }
    public class ListModel
    {
        public int Index { get; set; }
        public string Message { get; set; }
    }
}
