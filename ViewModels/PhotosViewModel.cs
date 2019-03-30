using FlatmateFinders.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FlatmateFinders.ViewModels
{
    //View Model for Photos Page

    public class PhotosViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Photo> Photos { get; set; }

        public bool _isPhotos = false;

        public bool IsPhotos
        {
            get { return _isPhotos; }
            set
            {
                _isPhotos = value;
                OnPropertyChanged();
            }
        }

        public PhotosViewModel()
        {
            Photos = new ObservableCollection<Photo>
            {
                //new Photo { Source="flat1.png",Order=1, Featured=true },
            };
        }
        
        //Update Photo to Collection
        private void UpdatePhoto(Photo photo)
        {
            var Index = Photos.IndexOf(photo);
            Photos.Remove(photo);
            Photos.Insert(Index, photo);
        }


        //Add Photo to Collection
        public void AddPhoto(Photo photo)
        {
            Photos.Add(photo);
        }

        #region Property Change Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        //Check if change in photos 
        public void CheckIfPhotoAvailable()
        {
            if (Photos.Count > 0)
                this.IsPhotos = true;
            else
                this.IsPhotos = false;
        }

        //Delete photo from Collection
        public void DeletePhoto(Photo photo)
        {
            Photos.Remove(photo);
        }

        //MoveUp photo
        public void MoveUp(Photo photo)
        {
            var Index = Photos.IndexOf(photo);
            if (Index > 0) {
                var itemToMoveUp = photo;
                Photos.Remove(photo);
                Photos.Insert(Index - 1, itemToMoveUp);
            }
        }

        //Rotate photo
        public void Rotate(Photo photo)
        {
            var Index = Photos.IndexOf(photo);
            Photos.Remove(photo);
            if (photo.Rotate >= 360)
                photo.Rotate = 0;
            else
                photo.Rotate += 90;
            Photos.Insert(Index, photo);
        }

        // Move Down Photo
        public void MoveDown(Photo photo)
        {
            var Index = Photos.IndexOf(photo);

            if (Index + 1 < Photos.Count)
            {
                var itemToMoveDown = photo;
                Photos.Remove(photo);
                Photos.Insert(Index + 1, photo);
            }
        }
    }
}
