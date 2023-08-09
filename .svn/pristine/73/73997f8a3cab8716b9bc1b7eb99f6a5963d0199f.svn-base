using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMINWEB_CJC.Model
{
    [Table("Categories")]
    public partial class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID
        {
            get;
            set;
        }


        [InverseProperty("Category")]
        //public ICollection<Product> Products { get; set; }
        public string CategoryName
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string Picture
        {
            get;
            set;
        }
    }
}
