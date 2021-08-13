using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string ReviewerName { get; set; }
        public int Rating { get; set; }
        public int AverageRating { get; set; }
        public int TotalRatings { get; set; }
        public int NumberOfReviews { get; set; }
        public string Comment { get; set; }

        [Display(Name = "Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        public void AddRatings()
        {
            TotalRatings += Rating;
        }

        public void AddReviews()
        {
            NumberOfReviews++;
        }

        public void CalculateAverage()
        {
            AverageRating = TotalRatings / NumberOfReviews;
        }

        public void DeleteReview()
        {
            NumberOfReviews--;
            TotalRatings -= Rating;
        }
    }
}
