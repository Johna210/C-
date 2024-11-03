namespace Demo {
    class Movie {
        public string title;
        public string director;
        private string rating;

        public static int movieCount = 0;

        public Movie(string mTitle, string mDirector, string mRating) {
            title = mTitle;
            director = mDirector;
            Rating = mRating;
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