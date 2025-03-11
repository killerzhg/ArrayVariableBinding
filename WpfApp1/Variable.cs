using LuxAutoTest.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
     public class Variables : NotifyBase
    {
        public Variables() { }

        public ObservableCollection<ListModel> LogList { get; set; } = new ObservableCollection<ListModel>();

        #region bool[]类型
        static private bool[] _boolArray = new bool[3];
        public bool[] BoolArray
        {
            get { return _boolArray; }
            set
            {
                _boolArray = value;
                OnPropertyChanged();
            }
        }

        public void UpdateBoolArray(int index, bool value)
        {
            if (index >= 0 && index < _boolArray.Length)
            {
                _boolArray[index] = value;
                OnPropertyChanged(nameof(BoolArray));
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }
        #endregion

        #region double[]类型
        static private double[] _doubleArray = new double[3];
        public double[] DoubleArray
        {
            get { return _doubleArray; }
            set
            {
                _doubleArray = value;
                OnPropertyChanged();
            }
        }

        public void UpdateDoubleArray(int index, double value)
        {
            if (index >= 0 && index < _doubleArray.Length)
            {
                _doubleArray[index] = value;
                OnPropertyChanged(nameof(DoubleArray));
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }
        #endregion

        #region string[]类型
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
        #endregion
    }
    public class ListModel
    {
        public int Index { get; set; }
        public string Message { get; set; }
    }
}
