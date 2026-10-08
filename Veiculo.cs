public class Veiculo
{
    private string modelo;
    private string placa;

    public string Modelo
    {
        get
        {
            return modelo;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O modelo do veículo é obrigatório."
                );
            }

            modelo = value;
        }
    }

    public string Placa
    {
        get
        {
            return placa;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "A placa do veículo é obrigatória."
                );
            }

            placa = value;
        }
    }

    public Veiculo(string modelo, string placa)
    {
        Modelo = modelo;
        Placa = placa;
    }
}
