string textoOriginal, textoLeet;

Console.Write("Por favor, escreva algo: ");
textoOriginal = Console.ReadLine()!; // Armazenando o texto na variável textoOriginal

textoLeet = textoOriginal.Replace("a", "4")
                        .Replace("A", "4")
                        .Replace("E", "3")
                        .Replace("e", "3")
                        .Replace("I", "1")
                        .Replace("i", "1")
                        .Replace("L", "1")
                        .Replace("l", "1")
                        .Replace("O", "0")
                        .Replace("o", "0")
                        .Replace("T", "7")
                        .Replace("t", "7")
                        .Replace("S", "5")
                        .Replace("s", "5"); // Traduzindo o texto da variável textoOriginal para Leet e armazenando na variável textoLeet

Console.WriteLine(textoLeet); // Exibindo o texto traduzido