using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa serafim = new Pessoa(nome: "serafim");
Pessoa alex = new Pessoa(nome: "Alex");
Pessoa ghuat = new Pessoa(nome:"Ghuat");



hospedes.Add(serafim);
hospedes.Add(alex);
hospedes.Add(ghuat);

// Cria a suíte
Suite suiteUm = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);
Suite suiteDois = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reservaUm = new Reserva(diasReservados: 5);
Reserva reservaDois = new Reserva(diasReservados: 14);
reservaUm.CadastrarSuite(suiteUm);

reservaUm.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reservaUm.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reservaUm.CalcularValorDiaria()}");

//Exception ocorre por causa de capacidade excedida
reservaDois.CadastrarSuite(suiteDois);
reservaDois.CadastrarHospedes(hospedes);

