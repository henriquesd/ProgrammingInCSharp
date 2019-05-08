using System;

namespace Delegate
{
    public class PhotoProcessorAction
    {
        public void ProccessAction(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            var filters = new PhotoFilters();

            photo.Save();
        }
    }
}
