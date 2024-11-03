namespace Demo
{
    class Book 
    {
        public string title;
        public string author;
        public int pages;

        public Book() {
            
        }

        public Book(string title, string author, int pages) {
            this.author = author;
            this.title = title;
            this.pages = pages;
        }
    }
}
