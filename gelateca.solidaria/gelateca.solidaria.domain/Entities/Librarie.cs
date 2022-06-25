using gelateca.solidaria.domain.Resources;
using gelateca.solidaria.domain.Validation;

namespace gelateca.solidaria.domain.Entities;

//Modificador sealed: Garante que essa class não poderá ser herdada
public sealed class Librarie : EntityBase
{
    #region Propriedades
    //O modificador private no set das propriedades
    //Se faz necessário para garantir que os objetos da camada de domain
    //não tenha suas propriedades alteradas ou atribuidos externamente.
    public string Category { get; private set; }
    public string Description { get; private set; }
    public string Address { get; private set; }
    public int Quantity { get; private set; }
    public string Image { get; private set; }

    public int BookId { get; set; }
    public Book Book { get; set; }
    #endregion

    #region Construtores Especializados
    public Librarie(string name, string description, string address, int quantity, string image)
    {
        ValidateDomain(name, description, address, quantity, image);
    }

    public Librarie(int id, string name, string description, string address, int quantity, string image)
    {
        ValidateDomainId(id);
        ValidateDomain(name, description, address, quantity, image);
    }
    #endregion

    #region Métodos

    #region Validações
    private void ValidateDomainId(int id)
    {
        DomainExceptionValidation.When(id < 0, string.Format(MessagesValidation.msgValueInvalid, "Id"));
        Id = id;
    }

    private void ValidateDomain(string category, string description, string address, int quantity, string image)
    {
        DomainExceptionValidation.When(
            string.IsNullOrEmpty(category),
            string.Format(MessagesValidation.msgFieldRequired, "Categoria")
        );

        DomainExceptionValidation.When(
            category.Length < 3,
            string.Format(MessagesValidation.msgFieldMinCharacter, "Categoria", 3)
        );

        DomainExceptionValidation.When(
            string.IsNullOrEmpty(description),
            string.Format(MessagesValidation.msgFieldRequired, "Descrição")
        );

        DomainExceptionValidation.When(
            description.Length < 5,
            string.Format(MessagesValidation.msgFieldMinCharacter, "Descrição", 5)
        );

        DomainExceptionValidation.When(
            address.Length < 3,
            string.Format(MessagesValidation.msgValueInvalid, "Localização")
        );

        DomainExceptionValidation.When(quantity < 0,
            string.Format(MessagesValidation.msgValueInvalid, "Quantidade"));

        DomainExceptionValidation.When(image?.Length > 250,
            string.Format(MessagesValidation.msgFieldMaxCharacter, "Imagem", 250));

        //Só atribui o valor caso atenda as regras acima.
        Category = category;
        Description = description;
        Address = address;
        Quantity = quantity;
        Image = image;
    }
    #endregion

    #region Demais Métodos
    public void Update(int bookId, string category, string description, string address, int stock, string image)
    {
        BookId = bookId;
        ValidateDomain(category, description, address, stock, image);
    }
    #endregion

    #endregion
}
