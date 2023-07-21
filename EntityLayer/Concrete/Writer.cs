using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        
        [Key]
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string  WriterImage { get; set; }
        public string WriterMail { get; set; }

        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }

        public List<Blog> Blogss { get; set;}
        /*ConfirmPassword
         
         EntityLayer->Concrate->Writer classına
 [Compare("WriterPassword", ErrorMessage = "Şifreler eşleşmiyor. Lütfen tekrar deneyin!")]
  public string  ConfirmPassword { get; set; }

ekleyip şifre onaylama işlemi yapılır
Index.cshtml sayfasında confirm password için input tagına name="ConfirmPassword" yazılmalıdır.


         */
    }
}
