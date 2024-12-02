

namespace Mvvm.Models.Entities
{
    public class Mark : NotifyProperty
    {
        private int _id;

        private string _NameMark = null!;

        private ModelCar _ModelID { get; set; } = null!;

        public int Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }

        public string NameMark
        {
            get => _NameMark;
            set
            {
                if (_NameMark != value)
                {
                    _NameMark = value;
                    OnPropertyChanged();
                }
            }
        }

        public ModelCar ModelID       
        {
            get => _ModelID;
            set
            {
                if (_ModelID != value)
                {
                    _ModelID = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
