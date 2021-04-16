using System.ComponentModel.DataAnnotations;

namespace RSM.Entidades
{
    public class Student
    {
        #region Propiedades Auto Implementadas
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [StringLength(250)]
        public string Photo { get; set; }
        public int Age { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        #endregion
    }
}
