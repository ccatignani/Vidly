using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public Movie() { }
        public Movie(int id,string name,Genre genre,DateTime releaseDate,DateTime dateAdded,int numnberInStock) 
        {
            Id = id;
            Name = name;
            Genre = genre;
            ReleaseDate = releaseDate;
            DateAdded = dateAdded;
            NumberInStock = numnberInStock;
        }
        public  int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        
        [Display(Name = "Qty On Hand")]
        public int  NumberInStock { get; set; }
        //public int MyProperty { get; set; }
    }
}