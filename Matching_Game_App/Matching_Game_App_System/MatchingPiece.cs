using System.ComponentModel;
using System.Data;

namespace Matching_Game_App_System
{
    public class MatchingPiece : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public enum RevealedImage { BackgroundImage, FrontImage }

        private RevealedImage _selectedimage = RevealedImage.BackgroundImage;
        private string _frontimage = "";

        public MatchingPiece(string backgroundimage)
        {
            this.BackgroundImage = backgroundimage;
        }

        public RevealedImage SelectedImage
        {
            get => _selectedimage;
            set
            {
                _selectedimage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedImage"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedImagePath"));
            }
        }
        public string SelectedImagePath => SelectedImage == RevealedImage.BackgroundImage ? BackgroundImage : FrontImage;
        public string BackgroundImage { get; set; }
        public string FrontImage
        {
            get => _frontimage;
            set
            {
                _frontimage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FrontImage"));
            }
        }

    }
}