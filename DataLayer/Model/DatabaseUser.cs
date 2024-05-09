using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;

/*
namespace DataLayer.Model
{
    internal class DatabaseUser: User
    {
    private int m_id;
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public override int ID
    {
        get => m_id;
        set => m_id = value;
    }
}
}
*/
namespace DataLayer.Model
{
    public class DatabaseUser : User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int ID { get; set; }
    }
}