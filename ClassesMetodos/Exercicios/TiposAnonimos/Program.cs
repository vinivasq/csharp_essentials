// int[] listaAnonima = new[] { 1, 2, 3 };

// Console.WriteLine(listaAnonima[0]);
// Console.WriteLine(listaAnonima[2]);

// var objetoAnonimo = new
// {
//   Nome = "vinicius",
//   Idade = '22,
//   Endereco = new
//   {
//     Cidade = "Pelotas",
//     Pais = "Brasil",
//     Cep = 99999999
//   }
// };

// Console.WriteLine(objetoAnonimo.Nome);
// Console.WriteLine(objetoAnonimo.Endereco.Cidade);

// var NovaData = new DateTime(2024, 03, 26, 00, 02, 00);
// using System.Text.RegularExpressions;

// string teste = @"Closes #3
//   teste de alguma outra coisa

//   Closes #4
// ";

// Regex regex = new Regex(@"#(\d+)");

// // Encontrar todas as correspondências na string
// MatchCollection matches = regex.Matches(teste);

// // Extrair números das correspondências e adicioná-los à lista
// foreach (Match match in matches)
// {
//   GroupCollection groups = match.Groups;
//   if (groups.Count > 1)
//   {
//     int numero;
//     if (int.TryParse(groups[1].Value, out numero))
//     {
//       Console.WriteLine(numero);
//     }
//   }
// }

// Console.WriteLine(teste.Remove(0, 1));
// Console.WriteLine(Guid.NewGuid());
// Console.WriteLine(NovaData);
// Console.WriteLine(NovaData.AddMinutes(-10).Date);
// Console.WriteLine(string.Join('/', "teste", 123));
// Console.WriteLine(Convert.ToDateTime(null) <= DateTime.Now.AddDays(7));
// Console.WriteLine(DateTime.Now.AddDays(31).ToString("dd-MMM-yyyy"));
// Console.WriteLine(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(2).AddDays(-1));

decimal teste = 10m / 31m;

System.Console.WriteLine(teste);