    using SportAPI.Model;
    using System.Collections.Generic;

    namespace SportAPI.Services
    {
        public interface IImage
        {
            public IEnumerable<ImageDetails> GetImages(int productId);
        public ImageDetails AddImage(ImageDetails image);
        public ImageDetails DeleteImage(int id);
    }
    }
