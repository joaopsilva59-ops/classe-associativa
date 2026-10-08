public class Cliente
{
    private string nome;
    private string cpf;

    public string Nome
    {
        get
        {
            return nome;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O nome do cliente é obrigatório."
                );
            }

            nome = value;
        }
    }

    public string CPF
    {
        get
        {
            return cpf;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O CPF do cliente é obrigatório."
                );
            }

            cpf = value;
        }
    }

    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
    }
}
