namespace Delegate
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            // this code does not know what filter will be applied, and it's the responsibility of the
            // client of this code, whoever is using that, they will define the filters they want; maybe a
            // developer wants to apply only brightness and contrast, maybe another developer wants to apply
            // 10 others filters. It's up to them. This framework does not have to be recompiled and redeployed,
            // which makes it extensible.
            filterHandler(photo);

            var filters = new PhotoFilters();

            photo.Save();
        }
      
        //public void Process(string path)
        //{
        //    var photo = Photo.Load(path);

        //    var filters = new PhotoFilters();
        //    filters.ApplyBrightness(photo);
        //    filters.ApplyContrast(photo);
        //    filters.Resize(photo);

        //    photo.Save();
        //}
    }
}
