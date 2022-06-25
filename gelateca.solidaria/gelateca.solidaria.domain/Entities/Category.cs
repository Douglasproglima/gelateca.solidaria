using gelateca.solidaria.domain.Validation;
using gelateca.solidaria.domain.Resources;

namespace gelateca.solidaria.domain.Entities;

//Modificador sealed: Garante que essa class não poderá ser herdada
public sealed class Category : EntityBase
{
    #region Propriedades
    //O modificador private no set das propriedades
    //Se faz necessário para garantir que os objetos da camada de domain
    //não tenha suas propriedades alteradas ou atribuidos externamente.
    public ICollection<Librarie> Libraries { get; set; }
    #endregion

    #region Construtores Especializados
    public Category(string name)
    {
        ValidateDomainDescription(name);
    }

    public Category(int id, string description)
    {
        ValidateDomainId(id);
        ValidateDomainDescription(description);
    }
    #endregion

    #region Métodos

    #region Validações
    private void ValidateDomainId(int id)
    {
        DomainExceptionValidation.When(
            id < 0, 
            string.Format(MessagesValidation.msgValueInvalid, "Id")
        );
        
        Id = id;
    }

    private void ValidateDomainDescription(string description)
    {
        DomainExceptionValidation.When(
            string.IsNullOrEmpty(description), 
            string.Format(MessagesValidation.msgFieldRequired, "Descrição")
        );
        
        DomainExceptionValidation.When(
            description.Length < 3, 
            string.Format(MessagesValidation.msgFieldMinCharacter, "Descrição", 3)
        );

        //Só atribui o valor caso atenda as regras acima.
        Description = description;
    }
    #endregion

    #region Demais Métodos
    public void Update(string name)
    { 
        ValidateDomainDescription(name);

    }
    #endregion

    #endregion
}
