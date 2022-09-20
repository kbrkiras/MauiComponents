
using System.ComponentModel;
namespace MauiComponents.Models
{
    public class DropboxModel
    {
        public string Value { get; set; }

        public string Name { get; set; }
    }
    public class StockModel
    {
        public Guid Stock_ID { get; set; }

        public string Stock_Code { get; set; }

        public string Stock_Name { get; set; }

        public string Stock_Category_Name { get; set; }

        public string Stock_Unit_Name { get; set; }

        public int Quantity { get; set; }
    }
    public class PickerModel : Picker
    {
    }
    public class NumericEntryModel : Entry
    {
        public string FrameBorderColor { get; set; }
        public string FrameBackgroundColor { get; set; }
    }
    public class EntryModel : Entry
    {
        public bool? ShowIconWhenEmpty { get; set; }
        public string Icon { get; set; }
        public string FrameBorderColor { get; set; }
        public string FrameBackgroundColor { get; set; }
    }
    public class NavBarModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Title { get; set; }
        public string Icon { get; set; }
    }
    public class Menu : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
        private Color selectedBackgroundColor;
        public Color SelectedBackgroundColor
        {
            set
            {
                if (selectedBackgroundColor != value)
                {
                    selectedBackgroundColor = value;
                    OnPropertyChanged("SelectedBackgroundColor");
                }
            }
            get
            {
                return selectedBackgroundColor;
            }
        }
        private Color textColor;
        public Color TextColor
        {
            set
            {
                if (textColor != value)
                {
                    textColor = value;
                    OnPropertyChanged("TextColor");
                }
            }
            get
            {
                return textColor;
            }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
   
}
