namespace LibraryManagementSystem.Models
{
    public static class Data
    {
        public static List<Author> Author { get; set; } = new()
        {
            new Author { Id = 1, FirstName = "Orhan", LastName = "Pamuk", DateOfBirth = new DateTime(1952, 6, 7) },
            new Author { Id = 2, FirstName = "Elif", LastName = "Şafak", DateOfBirth = new DateTime(1971, 10, 25) },
            new Author { Id = 3, FirstName = "Ahmet", LastName = "Ümit", DateOfBirth = new DateTime(1960, 11, 28) },
            new Author { Id = 4, FirstName = "Hakan", LastName = "Günday", DateOfBirth = new DateTime(1976, 10, 1) },
            new Author { Id = 5, FirstName = "İhsan", LastName = "Okuyucu", DateOfBirth = new DateTime(1985, 2, 17) },
            new Author { Id = 6, FirstName = "Kemal", LastName = "Yılmaz", DateOfBirth = new DateTime(1970, 8, 22) },
            new Author { Id = 7, FirstName = "Pelin", LastName = "Çift", DateOfBirth = new DateTime(1980, 3, 9) },
            new Author { Id = 8, FirstName = "Cem", LastName = "Yılmaz", DateOfBirth = new DateTime(1963, 4, 25) },
            new Author { Id = 9, FirstName = "Murathan", LastName = "Mungan", DateOfBirth = new DateTime(1955, 4, 21) },
            new Author { Id = 10, FirstName = "Buket", LastName = "Uzuner", DateOfBirth = new DateTime(1955, 9, 8) }
        };

        public static List<Book> Book { get; set; } = new()
        {
            new Book { Id = 1, Title = "Kar", AuthorId = 1, Genre = "Roman", PublishDate = new DateTime(2004, 6, 1), ISBN = "9789750814021", CopiesAvailable = 5, Author = Author.FirstOrDefault(a => a.Id == 1) },
            new Book { Id = 2, Title = "Benim Adım Kırmızı", AuthorId = 1, Genre = "Roman", PublishDate = new DateTime(1998, 1, 1), ISBN = "9789750710130", CopiesAvailable = 3, Author = Author.FirstOrDefault(a => a.Id == 1) },
            new Book { Id = 3, Title = "Aşk", AuthorId = 2, Genre = "Roman", PublishDate = new DateTime(2009, 5, 1), ISBN = "9789750724182", CopiesAvailable = 3, Author = Author.FirstOrDefault(a => a.Id == 2)},
            new Book { Id = 4, Title = "10 Dakika 38 Saniye", AuthorId = 2, Genre = "Roman", PublishDate = new DateTime(2019, 5, 30), ISBN = "9789750728456", CopiesAvailable = 4, Author = Author.FirstOrDefault(a => a.Id == 2) },
            new Book { Id = 5, Title = "Beyoğlu Rapsodisi", AuthorId = 3, Genre = "Roman", PublishDate = new DateTime(1996, 4, 15), ISBN = "9789750711229", CopiesAvailable = 4, Author = Author.FirstOrDefault(a => a.Id == 3) },
            new Book { Id = 6, Title = "İstanbul Hatırası", AuthorId = 3, Genre = "Roman", PublishDate = new DateTime(2010, 3, 1), ISBN = "9789750713469", CopiesAvailable = 2, Author = Author.FirstOrDefault(a => a.Id == 3) },
            new Book { Id = 7, Title = "Ziyan", AuthorId = 4, Genre = "Roman", PublishDate = new DateTime(2010, 10, 1), ISBN = "9789750503875", CopiesAvailable = 6, Author = Author.FirstOrDefault(a => a.Id == 4) },
            new Book { Id = 8, Title = "Kinyas ve Kayra", AuthorId = 4, Genre = "Roman", PublishDate = new DateTime(2000, 1, 1), ISBN = "9789750505138", CopiesAvailable = 4, Author = Author.FirstOrDefault(a => a.Id == 4) },
            new Book { Id = 9, Title = "Sonsuzluğa Yolculuk", AuthorId = 5, Genre = "Roman", PublishDate = new DateTime(2015, 12, 1), ISBN = "9789750522349", CopiesAvailable = 7, Author = Author.FirstOrDefault(a => a.Id == 5) },
            new Book { Id = 10, Title = "Mavi Çizmeli Çocuk", AuthorId = 5, Genre = "Çocuk Kitapları", PublishDate = new DateTime(2018, 7, 20), ISBN = "9789750530221", CopiesAvailable = 8, Author = Author.FirstOrDefault(a => a.Id == 5) },
            new Book { Id = 11, Title = "Geceyi Beklerken", AuthorId = 6, Genre = "Gerilim", PublishDate = new DateTime(2016, 9, 18), ISBN = "9789750516142", CopiesAvailable = 6, Author = Author.FirstOrDefault(a => a.Id == 6) },
            new Book { Id = 12, Title = "Yıldızlar Altında", AuthorId = 6, Genre = "Aşk", PublishDate = new DateTime(2019, 2, 25), ISBN = "9789750523101", CopiesAvailable = 5, Author = Author.FirstOrDefault(a => a.Id == 6) },
            new Book { Id = 13, Title = "Gecenin Çeyrek Geçesi", AuthorId = 7, Genre = "Hikaye", PublishDate = new DateTime(2014, 11, 10), ISBN = "9789750713420", CopiesAvailable = 3, Author = Author.FirstOrDefault(a => a.Id == 7) },
            new Book { Id = 14, Title = "Zamanın Gölgesinde", AuthorId = 7, Genre = "Roman", PublishDate = new DateTime(2018, 8, 4), ISBN = "9789750721249", CopiesAvailable = 4, Author = Author.FirstOrDefault(a => a.Id == 7) },
            new Book { Id = 15, Title = "Biraz Düşün", AuthorId = 8, Genre = "Komedi", PublishDate = new DateTime(2017, 6, 15), ISBN = "9789750726480", CopiesAvailable = 5, Author = Author.FirstOrDefault(a => a.Id == 8) },
            new Book { Id = 16, Title = "Güldürmek İçin", AuthorId = 8, Genre = "Komedi", PublishDate = new DateTime(2015, 10, 9), ISBN = "9789750719224", CopiesAvailable = 4, Author = Author.FirstOrDefault(a => a.Id == 8) },
            new Book { Id = 17, Title = "Kuşlar ve İnsanlar", AuthorId = 9, Genre = "Şiir", PublishDate = new DateTime(2002, 9, 1), ISBN = "9789750715165", CopiesAvailable = 6, Author = Author.FirstOrDefault(a => a.Id == 9) },
            new Book { Id = 18, Title = "Cevap", AuthorId = 9, Genre = "Deneme", PublishDate = new DateTime(2013, 3, 20), ISBN = "9789750509519", CopiesAvailable = 5, Author = Author.FirstOrDefault(a => a.Id == 9) },
            new Book { Id = 19, Title = "Bir Günü Görebilmek", AuthorId = 10, Genre = "Roman", PublishDate = new DateTime(1999, 5, 2), ISBN = "9789750708319", CopiesAvailable = 7, Author = Author.FirstOrDefault(a => a.Id == 10) },
            new Book { Id = 20, Title = "İstanbul Hatıraları", AuthorId = 10, Genre = "Anı", PublishDate = new DateTime(2012, 6, 10), ISBN = "9789750730056", CopiesAvailable = 4, Author = Author.FirstOrDefault(a => a.Id == 10) }
        };
    }
}
