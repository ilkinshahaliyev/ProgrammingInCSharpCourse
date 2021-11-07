using System;

namespace Task4
{
    class PhotoBookTest
    {
        static void Main(string[] args)
        {
            PhotoBook photoBook1 = new();
            Console.WriteLine("The number of pages is : {0}", photoBook1.GetNumberPages());

            PhotoBook photoBook2 = new(24);
            Console.WriteLine("The number of pages is : {0}", photoBook2.GetNumberPages());

            BigPhotoBook bigPhotoBook = new();
            Console.WriteLine("The number of pages of big photo book is : {0}", bigPhotoBook.GetNumberPages());
        }
    }
}
