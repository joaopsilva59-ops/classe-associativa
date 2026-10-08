Cliente cliente1 = new Cliente(
    "Arthur Morgan",
    "111.111.111-11"
);

Cliente cliente2 = new Cliente(
    "John Marston",
    "222.222.222-22"
);


Veiculo veiculo1 = new Veiculo(
    "Toyota Corolla",
    "ABC-1234"
);

Veiculo veiculo2 = new Veiculo(
    "Honda Civic",
    "DEF-5678"
);


Locacao locacao1 = new Locacao(
    cliente1,
    veiculo1,
    new DateOnly(2026, 10, 6),
    5,
    150.00m
);


Locacao locacao2 = new Locacao(
    cliente2,
    veiculo2,
    new DateOnly(2026, 10, 6),
    10,
    200.00m
);


locacao1.ExibirResumo();

locacao2.ExibirResumo();
