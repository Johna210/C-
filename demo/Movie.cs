namespace Demo {
    class Movie {
        public string title;
        public string director;
        private string rating;

        public static int movieCount = 0;

        public Movie(string title, string director, string rating) {
            this.title = title;
            this.director = director;
            this.Rating = rating;
            movieCount++;
        }

        public string Rating {
            // Getters
            get { return rating; }

            // Setters
            set { 
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR") {
                    rating = value;
                } 
                else {
                    rating = "NR";
                }
            }
        }

        
    }
}