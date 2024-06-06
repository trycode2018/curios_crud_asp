using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace trycode_test.Models;

public class Premium
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "O titulo e obrigatorio")]
    [StringLength(80,ErrorMessage = "Titulo deve ter 80 caracteres no maximo")]
    [MinLength(6,ErrorMessage = "No minimo 6 caracteres")]
    [DisplayName("Titulo")]
    public string Title { get; set; } = string.Empty;
    
    [DataType(DataType.DateTime)]
    [DisplayName("Inicio")]
    public DateTime StartDate { get; set; }
    
    [DataType(DataType.DateTime)]
    [DisplayName("Termino")]
    public DateTime EndDate { get; set; }
    
    
    [Required(ErrorMessage = "Aluno invalido")]
    [DisplayName("Aluno")]
    public int StudentId { get; set; }
    
    public string? Student { get; set; }
}