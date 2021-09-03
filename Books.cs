using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket_Opgave
{
    class Books
    {
        // Attributes of our books class
        private string author;
        private string genre;
        private string name;
        private int numOfPages;
        private float price;

        // Empty constructor
        public Books() { }

        // Makes a public copy of the private attribute
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                this.author = value;
            }
        }
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                this.genre = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public int NumOfPages
        {
            get
            {
                return numOfPages;
            }
            set
            {
                this.numOfPages = value;
            }
        }
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
            }
        }

    }
}
