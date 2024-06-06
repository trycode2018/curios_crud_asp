using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace trycode_test.Models;

public class Student
{
    /*
     * definir restricoes ao atributo
     * definir o nome que sera visualizado
     * definir a variavel
     */
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(80, ErrorMessage = "O nome deve conter ate 80 caracteres")]
    [MinLength(6, ErrorMessage = "O nome deve conter no minimo 6 caracteres")]
    [DisplayName("Nome Completo")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O e-email e obrigatorio")]
    [EmailAddress(ErrorMessage = "E-mail invalido")]
    [DisplayName("E-mail")]
    public string Email { get; set; } = string.Empty;

}