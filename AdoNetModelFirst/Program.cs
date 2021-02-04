using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Library lb = new Library();

                //lb.Context.CountrySet.Add(new Country() { Name = "China" });
                //lb.Context.CountrySet.Add(new Country() { Name = "Bosnia and Herzegovina" });
                //lb.Context.CountrySet.Add(new Country() { Name = "Colombia" });

                //lb.Context.CountrySet.Add(new Country() { Name = "Russia" });
                //lb.Context.CountrySet.Add(new Country() { Name = "Philippines" });
                //lb.Context.CountrySet.Add(new Country() { Name = "France" });

                //lb.Context.CountrySet.Add(new Country() { Name = "Indonesia" });
                //lb.Context.CountrySet.Add(new Country() { Name = "United States" });
                //lb.Context.CountrySet.Add(new Country() { Name = "Czech Republic" });

                //lb.Context.CountrySet.Add(new Country() { Name = "Sweden" });
                //lb.Context.CountrySet.Add(new Country() { Name = "Malaysia" });
                //lb.Context.CountrySet.Add(new Country() { Name = "Australia" });

                //lb.Context.CountrySet.Add(new Country() { Name = "Poland" });
                //lb.Context.CountrySet.Add(new Country() { Name = "Tajikistan" });
                //lb.Context.CountrySet.Add(new Country() { Name = "Canada" });

                //lb.Context.CountrySet.Add(new Country() { Name = "Egypt" });
                //lb.Context.CountrySet.Add(new Country() { Name = "Portugal" });
                //lb.Context.CountrySet.Add(new Country() { Name = "Mongolia" });

                //lb.Context.CountrySet.Add(new Country() { Name = "Thailand" });
                //lb.Context.CountrySet.Add(new Country() { Name = "Argentina" });
                //lb.Context.CountrySet.Add(new Country() { Name = "Great Britain" });

                //lb.Context.SaveChanges();
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Chinese",
                //    CountryId = 1
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Bosnian",
                //    CountryId = 2
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Spanish",
                //    CountryId = 3
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Russian",
                //    CountryId = 4
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Filipino",
                //    CountryId = 5
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "French",
                //    CountryId = 6
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Indonesian",
                //    CountryId = 7
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "English",
                //    CountryId = 8
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Czech",
                //    CountryId = 9
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Swedish",
                //    CountryId = 10
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Malay",
                //    CountryId = 11
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "English",
                //    CountryId = 12
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Polish",
                //    CountryId = 13
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Tajik",
                //    CountryId = 14
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "English",
                //    CountryId = 15
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Literary Arabic",
                //    CountryId = 16
                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Portuguese",
                //    CountryId = 17
                //});

                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Mongolian",
                //    CountryId = 18

                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Thai",
                //    CountryId = 19

                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "Spanish",
                //    CountryId = 20

                //});
                //lb.Context.LanguageSet.Add(new Language()
                //{
                //    Name = "English",
                //    CountryId = 21

                //});

                //lb.Context.SaveChanges();


                //lb.Context.AuthorSet.Add(new Author() 
                //{
                //    Name = " Lesly",
                //    Surname = "Ladell",
                //    Age = 30,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = " Maitilde",
                //    Surname = "Pill",
                //    Age = 34,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = " Verine",
                //    Surname = "Canada",
                //    Age = 46,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = " Gamaliel",
                //    Surname = "Steddall",
                //    Age = 53,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = " Astrix",
                //    Surname = "Beccera",
                //    Age = 44,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = " Prentiss",
                //    Surname = "Lowre",
                //    Age = 21,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = " Elisabeth",
                //    Surname = "Swannell",
                //    Age = 29,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = " Mahalia",
                //    Surname = "Stribbling",
                //    Age = 44,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = " Brodie",
                //    Surname = "Nisby",
                //    Age = 28,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = " Merle",
                //    Surname = "Travis",
                //    Age = 48,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = "Byron",
                //    Surname = "Traher",
                //    Age = 23,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = "Deeyn",
                //    Surname = "Johnigan",
                //    Age = 24,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = "Giorgi",
                //    Surname = "Brittle",
                //    Age = 23,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = "Birgit",
                //    Surname = "Arrol",
                //    Age = 19,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = "Allyce",
                //    Surname = "Coper",
                //    Age = 47,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = "Roosevelt",
                //    Surname = "Farmar",
                //    Age = 34,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = "Timmie",
                //    Surname = "Breeds",
                //    Age = 33,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = "Felipe",
                //    Surname = "Sillito",
                //    Age = 21,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = "Ted",
                //    Surname = "Winning",
                //    Age = 34,
                //});
                //lb.Context.AuthorSet.Add(new Author()
                //{
                //    Name = "William",
                //    Surname = "Shakespeare",
                //    Age = 52,
                //});
                //lb.Context.SaveChanges();
                //--------------------------------------------
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "Hamlet",
                //    PagesCount = 104,
                //    AuthorId=20,
                //    LanguageId=21
                //});
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "Insulin",
                //    PagesCount = 180,
                //    AuthorId = 19,
                //    LanguageId = 21
                //});
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "Mitomycin",
                //    PagesCount = 169,
                //    AuthorId = 1,
                //    LanguageId = 21
                //});
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "King Lear",
                //    PagesCount = 150,
                //    AuthorId = 20,
                //    LanguageId = 21
                //});

                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "Macbeth",
                //    PagesCount = 110,
                //    AuthorId = 20,
                //    LanguageId = 21
                //});
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "Acer saccharinum",
                //    PagesCount = 528,
                //    AuthorId = 2,
                //    LanguageId = 8
                //});
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "spironolactone",
                //    PagesCount = 640,
                //    AuthorId = 10,
                //    LanguageId = 3
                //});
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "The Tempest",
                //    PagesCount = 66,
                //    AuthorId = 20,
                //    LanguageId = 21
                //});
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "Othello",
                //    PagesCount = 314,
                //    AuthorId = 20,
                //    LanguageId = 21
                //});
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "Homeopathic Liquid",
                //    PagesCount = 521,
                //    AuthorId = 3,
                //    LanguageId = 2
                //});
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "Metformin Hydrochloride",
                //    PagesCount = 154,
                //    AuthorId = 4,
                //    LanguageId = 10
                //});
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "amlodipine besylate",
                //    PagesCount = 300,
                //    AuthorId = 15,
                //    LanguageId = 15
                //});
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "bromfenac",
                //    PagesCount = 458,
                //    AuthorId = 14,
                //    LanguageId = 18
                //});
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "Methocarbamol",
                //    PagesCount = 299,
                //    AuthorId = 7,
                //    LanguageId = 10
                //});
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "Methamol",
                //    PagesCount = 299,
                //    AuthorId = 7,
                //    LanguageId = 11
                //});  
                //lb.Context.BookSet.Add(new Book()
                //{
                //    Name = "Methocar",
                //    PagesCount = 299,
                //    AuthorId = 7,
                //    LanguageId = 13
                //});
                //lb.Context.SaveChanges();

                //1

                lb.ShowBooks(lb.CountPagesMore100());
                Console.WriteLine(new string('-', 120));
                //2
                lb.ShowBooks(lb.NameAOra());
                Console.WriteLine(new string('-', 120));
                //3
                lb.ShowBooks(lb.AuthorWilliamShakespeare());
                Console.WriteLine(new string('-', 120));
                //4
                lb.ShowBooks(lb.AuthorUkrainian());
                Console.WriteLine(new string('-', 120));
                //5
                lb.ShowBooks(lb.Less10SymbName());
                Console.WriteLine(new string('-', 120));
                //6
                lb.ShowBook(lb.MaxPagesCountBookNotAmericanAuthor());
                Console.WriteLine(new string('-', 120));
                //7
                lb.ShowAuthor(lb.AuthorWithLeastCountBooks());
                Console.WriteLine(new string('-', 120));
                //8
                foreach (var item in lb.AuthorsNameNotAmericanOrderByAlphabet())
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(new string('-', 120));
                //9
                lb.ShowCountry(lb.CounryWithMaxCountAuthors());
                Console.WriteLine(new string('-', 120));
                ////10
                lb.ShowAuthors(lb.AuthorsWithBooksOnSeveralLanguagesOrderByCount());
                Console.WriteLine(new string('-', 120));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
}
    }
    class Library
    {
        
        Model1Container ctx;
        public Model1Container Context
        {
            get
            {
                return ctx;
            }
            set
            {
                if (ctx != value)
                    ctx = value;
            }
        }
        public Library()
        {
            ctx = new Model1Container();
        }
        //1.Вибрати всі книги, кількість сторінок в яких більше 100
        public IEnumerable<Book> CountPagesMore100()
        {
            return ctx.BookSet.Where(b => b.PagesCount > 100);
           
        }
        //    2.Вибрати всі книги, ім’я яких починається на літеру ‘А’ або ‘а’
        public IEnumerable<Book> NameAOra()
        {
            return ctx.BookSet.Where(b => b.Name.Substring(0,1) == "A" || b.Name.Substring(0, 1) == "a");
           

        }
        //    3.Вибрати всі книги автора WilliamShakespeare
        public IEnumerable<Book> AuthorWilliamShakespeare()
        {
            return ctx.BookSet.Where(b => b.Author.Name =="William" &&  b.Author.Surname == "Shakespeare");
            
        }
        //    4.Вибрати всі книги українських авторів
        public IEnumerable<Book> AuthorUkrainian()
        {
            return ctx.BookSet.Where(b => b.Language.Country.Name == "Ukraine");

        }
        //    5.Вибрати всі книги, ім’я в яких складається менше ніж з 10-ти символів
        public IEnumerable<Book> Less10SymbName()
        {
            return ctx.BookSet.Where(b => b.Name.Length < 10);
            
        }
        //    6.Вибрати книгу з максимальною кількістю сторінок не американського автора  
        public Book MaxPagesCountBookNotAmericanAuthor()
        {
            return ctx.BookSet.Where(b => b.Language.Country.Name != "USA").OrderByDescending(b => b.PagesCount).FirstOrDefault();
            
        }

        //   7.Вибрати автора, який має найменше книг в базі даних
        public Author AuthorWithLeastCountBooks()
        {
            return ctx.AuthorSet.OrderBy(a => a.Book.Count()).FirstOrDefault();
           
        }
        //    8.Вибрати імена всіх авторів, крім американських, розташованих в алфавітному порядку
        public IEnumerable<string> AuthorsNameNotAmericanOrderByAlphabet()
        {
          return ctx.AuthorSet.Where(a => a.Book.Count(b => b.Language.Country.Name == "United States") == 0).OrderBy(a => a.Name + " " + a.Surname).Select(a=>a.Name+" "+a.Surname);
          
        }
        //    9.Вибрати країну, книг якої є найбільше в базі
        public Country CounryWithMaxCountAuthors()
        {

            return ctx.LanguageSet.OrderByDescending(l => l.Book.Count()).Select(l => l.Country).FirstOrDefault();
       

        }
        //10. Вибрати всіх авторів, які писали книги на різних мовах, відсортувавши по кількості мов, які були використані.
        public IEnumerable<Author> AuthorsWithBooksOnSeveralLanguagesOrderByCount()
        {
            string sql = "select a.Id, a.Name,a.Surname,a.Age from AuthorSet as a  join BookSet as b on a.Id = b.AuthorId join LanguageSet as l on b.LanguageId = l.Id where (select Count(a1.Id) from AuthorSet as a1 join BookSet as b1 on a1.Id = b1.AuthorId join LanguageSet as l1 on b1.LanguageId = l1.Id where a.Id = a1.Id  and l1.Id <> l.Id ) > 1 group by a.Id,a.Name,a.Surname,a.Age order by Count(l.Id)";
             var res = ctx.AuthorSet.SqlQuery(sql).ToList();
            
            return res;
            
        }
        public void ShowBooks(IEnumerable<Book> books)
        {
            Console.WriteLine("{0,-55} {1,15} {2,20} {3,20}", "Name", "Count pages", "Language", "Author");
            Console.WriteLine(new string('-', 120));
            foreach (var book in books)
            {
                Console.WriteLine("{0,-55} {1,10} {2,25} {3,30}", book.Name, book.PagesCount, book.Language.Name, book.Author.Name + ' ' + book.Author.Surname);
            }
        }
        public void ShowAuthors(IEnumerable<Author> authors)
        {
            Console.WriteLine("{0,-30} {1,20}", "Full name", "Age");
            Console.WriteLine(new string('-', 70));
            foreach (var item in authors)
            {
            Console.WriteLine("{0,-27} {1,22} ", item.Name + ' ' + item.Surname, item.Age);

            }
        }
        public void ShowAuthor(Author author)
        {
            Console.WriteLine("{0,-30} {1,20}", "Full name", "Age");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("{0,-27} {1,22} ", author.Name + ' ' + author.Surname,author.Age);
        }
        public void ShowBook(Book book)
        {
            Console.WriteLine("{0,-55} {1,15} {2,20} {3,20}", "Name", "Count pages", "Language", "Author");
            Console.WriteLine(new string('-', 120));
            Console.WriteLine("{0,-55} {1,10} {2,30} {3,30}", book.Name, book.PagesCount, book.Language.Name, book.Author.Name + ' ' + book.Author.Surname);
        }
        public void ShowCountry(Country country)
        {
            Console.WriteLine("{0,-50}","Name");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(country.Name);
        }

    }

}

