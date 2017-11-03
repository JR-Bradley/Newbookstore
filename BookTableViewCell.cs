using Foundation;
using System;
using UIKit;

namespace NewBookStore
{
    public partial class BookTableViewCell : UITableViewCell
    {

		private Book bookData;

		public Book BookData
        {
            get { return bookData; }
            set {
                bookData = value;

                labelName.Text = bookData.Name;
                labelYear.Text = bookData.Year.ToString();
                labelAuthor.Text = bookData.Author;
                labelPublisher.Text = bookData.Publisher;

            }

        }
		public BookTableViewCell (IntPtr handle) : base (handle)
        {

            
        }
    }
}