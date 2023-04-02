namespace PhotoBookOOPS
{
    public class PhotoBook
    {
        int TotalPages;

        public PhotoBook()
        {
            this.TotalPages = 16;
        }

        public PhotoBook(int totalPages)
        {
            this.TotalPages = totalPages;
        }   

        public int GetNumberPages()
        {
            return this.TotalPages;
        }
    }

    public class AddPhotoBook: PhotoBook
    {
        public AddPhotoBook(): base(64)
        {

        }
    }
    public class OOPSPhotoBook
    {
        static void Main(string[] args)
        {
            PhotoBook photoBook = new PhotoBook();
            Console.WriteLine($"PhotoBook1: {photoBook.GetNumberPages()}");

            PhotoBook photoBook1 = new PhotoBook(32);
            Console.WriteLine($"PhotoBook2: {photoBook1.GetNumberPages()}");

            AddPhotoBook photoBook2 = new ();
            Console.WriteLine($"PhotoBook3: {photoBook2.GetNumberPages()}");

        }
    }

}
/*


            //PhotoBook.Default();
            //AddPhotoBook.Album();
            //PhotoBookTest.TestBook();
public class PhotoBook
    {
        public static int GetNumberPages(int pages)
        {
            int BookPages = pages;
            return BookPages;
        }
        public static void Default()
        {
            int Album = 16;
            PhotoBook book = new PhotoBook();
            int pages = GetNumberPages(Album);
            Console.WriteLine($"The Default Album Page: {pages}");
        }
    }
    public class AddPhotoBook: PhotoBook
    {
        public AddPhotoBook(): base(64)
        {

        }
        public static void Album()
        {
            int Album1 = 64;
            int pages = PhotoBook.GetNumberPages(Album1);
            Console.WriteLine($"The Album1 Page: {pages}");
            
        }

    }
    public class PhotoBookTest
{
    public static void TestBook()
    {
        //PhotoBook book = new PhotoBook();
        AddPhotoBook book = new AddPhotoBook();
        int default_book = 100;
        int photo_book = 32;
        int large_book = 500;

        int default_page = PhotoBook.GetNumberPages(default_book);
        Console.WriteLine($"The Default Book Page: {default_page}");

        int photo_page = PhotoBook.GetNumberPages(photo_book);
        Console.WriteLine($"The Photo Book Page: {photo_page}");

        int large_page = PhotoBook.GetNumberPages(large_book);
        Console.WriteLine($"The Large Book Page: {large_page}");

        Console.WriteLine($"The Large Book Page: {PhotoBook.GetNumberPages()}");
    }

}
*/