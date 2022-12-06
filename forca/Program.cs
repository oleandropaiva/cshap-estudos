using System;
using System.Diagnostics;
using System.Threading;

namespace JogoForca3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declaração de variáveis
            string equipe = "Grupo 8";
            string[] programadores = {"Danielle Rodrigues","Gustavo Fabiano Gonçalves","Leandro Aparecido de Paiva"};
            //matriz com base de dados de dicas e palavras
            //categoria estará na linha índice 0; cada coluna terá 10 palavras referentes a cada dica
            string[,] matrizDePalavras = new string[11, 5] {
                                            {"animal","país","cidade do Brasil","nome feminino","nome masculino"},
                                            {"andorinha","Argentina","Caraguatatuba","Alice","Augusto"},
                                            {"borboleta","Dinamarca","Fortaleza","Clarice","Bernardo"},
                                            {"camundongo","Espanha","Guarulhos","Giovanna","Eduardo"},
                                            {"escaravelho","Filipinas","Itaquaquecetuba","Helena","Francisco"},
                                            {"formiga","Honduras","Londrina","Isabella","Guilherme"},
                                            {"gafanhoto","Jamaica","Pindamonhangaba","Laura","Henrique"},
                                            {"joaninha","Luxemburgo","Piracicaba","Manuela","Joaquim"},
                                            {"lagartixa","Marrocos","Salvador","Marina","Leonardo"},
                                            {"ornitorrinco","Noruega","Sorocaba","Sophia","Matheus"},
                                            {"rinoceronte","Paraguai","Teresina","Valentina","Miguel"}};
Random numAleat = new Random(); // gera número aleatório para escolher a palavra na matriz
            bool novaPartida = false; // variável de saída do do-while que controla novas partidas
            bool ganhou; // true quando ganhou, inicializada com false no começo de cada partida
            bool perdeu; // true quando perdeu, inicializada com false no começo de cada partida
            int linha; // guarda número aleatório para a linha da matriz (entre 1 e 11, na linha 0 estão as categorias)
            int coluna; // guarda número aleatório para a coluna da matriz (decide a categoria da palavra sorteada)
            int erros; // guarda total de erros numa partida, com 6 o jogador perde. Inicializada no começo de cada partida
            int posLetra; // auxiliar para verificar e substituir uma letra que o jogador acertou na strings da palavra oculta
            int totalJogos = 0; // contador do número de partidas jogadas
            int numVitorias = 0; // contador de palavras descobertas
            int numLetras = 0; // contador do número de letras da palavra-chave
            string dica; // guarda a categoria da palavra-chave, determinada por matrizDePalavras[0,coluna]
            string palavra; // guarda a palavra-chave determinada por matrizDePalavras[linha,coluna]
            string auxPalavra; // guarda uma cópia da palavra-chave, usada como controle na busca das letras informadas
            string letra; // palpite do jogador
            string letrasUsadas; // guarda todas as letras já usadas na partida
            string palavraOculta; // string composta por "_ " para cada letra da palavra-chave, conforme o jogador acerta um palpite, cada "_" é substituído pela letra informada
            string mensagemInicial; // frase que informa ao jogador qual a dica e o número de letras da palavra-chave, inicializada no começo de cada partida
            string revelaPalavra; // frase que revela a palavra-chave quando o jogador perde a partida, inicializada apenas se o jogador perder alguma vez
            string auxMoldura; // auxiliar para cria uma moldura no texto apresentado ao jogador, formada por - ou *, dependendo da mensagem
            string palavrasJogadas = ""; // guarda todas as palavras jogadas, com a última partida em primeiro
            string palavrasAcertou = ""; // guarda todas as palavras que o jogador acertou, com a última em primeiro
            string maiorPalavra = ""; // guarda a maior palavra que o jogador acertou, em caso de empate, fica a última delas
            string resposta; // recebe s ou n para a pergunta se o jogador quer nova partida
            DateTime inicio = DateTime.Now; // guarda hora de início da partida
            //Stopwatch stopwatch = Stopwatch.StartNew(); //outra forma para marcar tempo
            #endregion

          Animacao("inicio"); // chama função definida abaixo que exibe uma vinheta de abertura

            // imprime o nome da equipe
            Console.WriteLine($"\n\n\n Criado por: {equipe}");
            foreach (string prog in programadores)
            {
                Thread.Sleep(500); // aguarda por 500 milissegundos
                Console.WriteLine($"  - {prog}");
            }
            Thread.Sleep(500);
            Console.WriteLine("\n Pressione qualquer tecla para continuar...");
            Console.ReadKey(true); //aguarda até o jogador pressionar alguma tecla; true indica que a tecla não aparecerá no console
            
 do //inicio jogo
            {
                #region preparação início partida
                //preparação para nova partida
                ganhou = perdeu = false;
                totalJogos++;
                linha = numAleat.Next(1, matrizDePalavras.GetLength(0));  // gera um número entre 1 e tamanho do primeiro índice da matriz (linha 0 é só dicas)
                coluna = numAleat.Next(0, matrizDePalavras.GetLength(1)); // gera um número entre 0 e tamanho do segundo índice da matriz
                //linha = 1;
                //coluna = 0;
                //Console.WriteLine($"Linha = {linha}; Coluna = {coluna}");
                //Console.WriteLine($"Dica = {matrizDePalavras[0, coluna]}");
                //Console.WriteLine($"Palavra = {matrizDePalavras[linha, coluna]}");
                dica = matrizDePalavras[0, coluna];
                palavra = matrizDePalavras[linha, coluna].ToLower();
                auxPalavra = palavra;
                letrasUsadas = "";
                palavraOculta = string.Concat(Enumerable.Repeat("_ ", palavra.Length));
                //palavraOculta = "";
                //for (int i = 0; i < palavra.Length; i++)
                //{
                //    palavraOculta += "_ ";
                //}
                erros = 0;
                palavrasJogadas = palavra + "; " + palavrasJogadas;
                Console.Clear();
                //auxMoldura = "";
                mensagemInicial = $"| A palavra é um(a) {dica} e tem {palavra.Length} letras. |";
                //for (int i = 0; i < (mensagemInicial.Length - 2); i++ ) {
                //    auxMoldura = auxMoldura + "-";
                //};
                auxMoldura = new string('-', (mensagemInicial.Length-2));
                auxMoldura = "+" + auxMoldura + "+";
                Console.WriteLine($"\n\n {auxMoldura}");
                Console.WriteLine($" {mensagemInicial}");
                Console.WriteLine($" {auxMoldura}");
                Console.WriteLine("\n Pressione qualquer tecla para continuar...");
                Console.ReadKey(true);
                #endregion
                do //inicio partida
                {
                    #region lógica do jogo
                    //pedir nova letra para jogador
                    do
                    {
                        TelaJogo(erros, palavraOculta, dica, letrasUsadas);
                        Console.Write($" Digite uma letra entre a e z (sem acentos): ");
                        letra = Console.ReadLine().ToLower();
                    } while (!LetraValida(letra, letrasUsadas)); // chama função definida abaixo para validar a letra

                    letrasUsadas = letrasUsadas + letra + " "; // acrescenta nova letra na lista de usadas
                    
                    //procurar letra na palavra-chave
                    if (auxPalavra.IndexOf(letra) == -1) //letra não encontrada na palavra
                    {
                        erros++;
                        Console.Clear();
                        Console.WriteLine("\n\n **************************************************");
                        Console.WriteLine(" ! A letra digitada não existe na palavra - chave !");
                        Console.WriteLine($" ! Você errou {erros} {(erros > 1 ? "vezes!" : "vez!  ")}                            !");
                        Console.WriteLine(" **************************************************");
                        Console.WriteLine($"\n Pressione qualquer tecla para continuar...");
                        Console.ReadKey(true);

                    }
                    else //letra encontrda
                    {
                        posLetra = 0;
                        while (posLetra != -1) // substitui todas a ocorrências da letra na variável de controle auxPalavra por um * e inclui em todas as respectivas posições em palavraOculta
                        {
                            posLetra = auxPalavra.IndexOf(letra);
                            if (posLetra != -1)
                            {
                                //Console.WriteLine(posLetra);
                                auxPalavra = auxPalavra.Remove(posLetra, 1).Insert(posLetra, "*");
                                palavraOculta = palavraOculta.Remove(posLetra * 2, 1).Insert(posLetra * 2, letra); //substitui o underline na string oculta;
                                                        //multiplica por 2 pois a string tem o dobro do tamanho da palavra original (underline e espaço para cada caracter)
                                                        //para facilitar a visualização: "teste" seria representado por _ _ _ _ _ 
                                //Console.WriteLine(auxPalavra);
                                //Console.WriteLine(palavraOculta);
                            }
                        }
                    }

                    //verifica se as condições de vitória ou derrota foram atingidas
                    if (erros == 6)
                    {
                        perdeu = true;
                    }
                    if (palavraOculta.IndexOf("_") == -1) //caso não encontre mais underlines em palavraOculta, jogador adivinhou palavra
                    {
                        ganhou = true;
                    }
                    #endregion
                } while (!ganhou && !perdeu); // continua enquanto ganhou e perdeu forem false

                #region verifica vitória ou derrota
                if (ganhou)
                {
                    numVitorias++;
                    palavrasAcertou = palavra + "; " + palavrasAcertou;// acrescenta nova palavra na lista de vitórias
                    Animacao("acertou");
                }
                else
                {
                    Animacao("perdeu");
                }
                #endregion

                #region nova partida
                //perguntar se jogador que nova partida
                do
                {
                    TelaJogo(erros, palavraOculta, dica, letrasUsadas);
                    if (perdeu) // revela a palavra-chave, apenas caso jogador não tenha adivinhado
                    {

                        /**********************************************************************/
                        revelaPalavra = $"! A palavra era: {palavra.ToUpper()} !"; 
                        auxMoldura = new string('*', revelaPalavra.Length);
                        Console.WriteLine($"\n\n {auxMoldura}");
                        Console.WriteLine($" {revelaPalavra}");
                        Console.WriteLine($" {auxMoldura}");
                        /**********************************************************************/
                        //Console.WriteLine($"\n\nA palavra era: {palavra.ToUpper()}");
                    }
                    Console.WriteLine("\n\n +----------------------------------+");
                    Console.WriteLine(" | Deseja jogar novamente (s ou n)? |");
                    Console.WriteLine(" +----------------------------------+");
                    resposta = Console.ReadLine().ToLower();
                    if (resposta == "s")
                    {
                        novaPartida = true;
                    }
                    else if (resposta == "n")
                    {
                        novaPartida = false;
                    }
                } while (resposta != "s" && resposta != "n");
                #endregion

            } while (novaPartida);

            #region finaliza jogo
            //Exibir estatísticas do jogo
            //stopwatch.Stop(); // se usar o Stopwatch.StartNew()
            //Console.WriteLine(stopwatch.ElapsedMilliseconds / 1000); 
            Console.Clear();
            Thread.Sleep(250);
            Console.WriteLine($"\n\n Você jogou {totalJogos} partida(s) em {(DateTime.Now - inicio).Minutes} minuto(s) e acertou {numVitorias} palavra(s) ({(numVitorias * 100.0d/totalJogos).ToString("0.##")}%).");
            Thread.Sleep(250);
            Console.WriteLine("\n As palavras que você jogou foram:");
            Thread.Sleep(250);
            Console.WriteLine(" " + palavrasJogadas);
            if (numVitorias > 0)
            {
                Thread.Sleep(250);
                Console.WriteLine("\n As palavras que você acertou:");
                Thread.Sleep(250);
                Console.WriteLine(" " + palavrasAcertou);
                foreach(string p in palavrasAcertou.Split("; ")) // verifica qual foi a maior palavra que o jogador acertou
                {
                    if (p.Length > numLetras)
                    {
                        numLetras = p.Length;
                        maiorPalavra = p;
                    }
                }
                Thread.Sleep(250);
                Console.WriteLine($"\n A maior palavra que acertou foi {maiorPalavra}, com {numLetras} letras.");
            }
            Thread.Sleep(250);
            Console.WriteLine("\n\n *************************");
            Console.WriteLine(" * Obrigado por jogar!!! *");
            Console.WriteLine(" *************************");
            Console.WriteLine($"\n Pressione qualquer tecla para encerrar...");
            Console.ReadKey(true);
            #endregion
        }//Fim Main

        // função para validar letra informada
        static bool LetraValida(string verLetra, string usadas)
        {
            if (verLetra.Length != 1) // testa se informaou apenas uma letra
            {
                Console.Clear();
                Console.WriteLine("\n\n ****************************************************");
                Console.WriteLine(" * Digite apenas uma letra entre a e z (sem acento) *");
                Console.WriteLine(" ****************************************************");
                Console.WriteLine($"\n Pressione qualquer tecla para continuar...");
                Console.ReadKey(true);
                return false;
            }
            else
            {
              char.TryParse(verLetra, out char auxChar); // converte string para caractere para fazer comparação abaixo (string "a" -> char 'a')
                if (auxChar >= 'a' && auxChar <= 'z') // verifica se letra está entre a e z
                {
                    if (usadas.IndexOf(verLetra) == -1) // procura letras na string letrasUsadas
                    {               
                        return true; //caso não encontre, letra é válida
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n *********************************");
                        Console.WriteLine(" * Letra escolhida já foi usada! *");
                        Console.WriteLine(" *********************************");
                        Console.WriteLine($"\n Pressione qualquer tecla para continuar...");
                        Console.ReadKey(true);
                        return false;
                    }
                }
                else // caso caractere digitado não esteja entre a e z
                {
                    Console.Clear();
                    Console.WriteLine("\n\n ****************************************************");
                    Console.WriteLine(" * Digite apenas uma letra entre a e z (sem acento) *");
                    Console.WriteLine(" ****************************************************");
                    Console.WriteLine($"\n Pressione qualquer tecla para continuar...");
                    Console.ReadKey(true);
                    return false;
                }
            }
            }//fim LetraValida

        // função que imprime a tela do jogo para o usuário
        // recebe como parâmetros o total de erros, a palavra oculta (com as letras encontradas), a dica/categoria, e a string de letras usadas
        static void TelaJogo(int erros, string pOculta, string textoDica, string usadas)
        {
            Console.Clear();
            Console.WriteLine("  +---+   ");
            Console.WriteLine("  |   |   ");
            // desenha a forca de acordo com o número de erros
            if (erros > 0)
            {
                Console.WriteLine("  |   O   ");
                if (erros > 1)
                {
                    if (erros == 2)
                    {
                        Console.WriteLine("  |   |   ");
                    }
                    else if (erros == 3)
                    {
                        Console.WriteLine("  |  /|   ");
                    }
                    else
                    {
                        Console.WriteLine("  |  /|\\   ");
                    }
                    if (erros > 4)
                    {
                        if (erros == 5)
                        {
                            Console.WriteLine("  |  /    ");
                        }
                        else
                        {
                            Console.WriteLine("  |  / \\  ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("  |       ");
                    }
                }
                else
                {
                    Console.WriteLine("  |       ");
                    Console.WriteLine("  |       ");
                }
            }
            else
            {
                Console.WriteLine("  |       ");
                Console.WriteLine("  |       ");
                Console.WriteLine("  |       ");
            }
            Console.WriteLine("  |       ");
            Console.WriteLine(" =========");
            Console.WriteLine($"\n {pOculta}"); // exibe a palavra oculta com as letra já 
            Console.WriteLine($"\n Total de erros: {(erros == 5 ? $"{erros} - Última chance!!!" : erros)}"); // usa o operador ternário para incluir aviso ao jogador caso esteja na última chance
            Console.WriteLine($" Letras usadas: {usadas.ToUpper()}");
            Console.WriteLine($" A dica da palavra-chave é: {textoDica}");
        }//fim TelaJogo


        // função que exibe uma vinheta simples, na abertura do jogo e em caso de vitória ou derrota
        static void Animacao(string tipo)
        {
            string[] arrTextoAnimacao;
            int comp_animacao;

            switch (tipo)
            {
                case "inicio":
                    arrTextoAnimacao = new string[] { "  ______ ", " |  ____|", " | |__ ___  _ __ ___ __ _", " |  __/ _ \\| '__/ __/ _` |", " | | | (_) | | | (_| (_| |", " |_|  \\___/|_|  \\___\\__,_|" };
                    break;
                case "acertou":
                    arrTextoAnimacao = new string[] { "                       _                _   _   _ ", "    /\\                | |              | | | | | |", "   /  \\   ___ ___ _ __| |_ ___  _   _  | | | | | |", "  / /\\ \\ / __/ _ \\ '__| __/ _ \\| | | | | | | | | |", " / ____ \\ (_|  __/ |  | || (_) | |_| | |_| |_| |_|", "/_/    \\_\\___\\___|_|   \\__\\___/ \\__,_| (_) (_) (_)" };
                    break;
                case "perdeu":
                    arrTextoAnimacao = new string[] { "  _____             _              _   _   _ ", " |  __ \\           | |            | | | | | |", " | |__) |__ _ __ __| | ___ _   _  | | | | | |", " |  ___/ _ \\ '__/ _` |/ _ \\ | | | | | | | | |", " | |  |  __/ | | (_| |  __/ |_| | |_| |_| |_|", " |_|   \\___|_|  \\__,_|\\___|\\__,_| (_) (_) (_) " };
                    break;
                default:
                    arrTextoAnimacao = new string[] { "###", "###", "###" };
                    break;
            }

            comp_animacao = arrTextoAnimacao.Length; // guarda quantas linhas tem o texto

            Console.Clear();

            for (int i = (comp_animacao - 1); i >= 0; i--) // primeira iteração exibe apena a linha mais abaixo, cada nova iteração exibe uma linha a mais
            {
                for (int j = i; j < comp_animacao; j++)
                {
                    Console.WriteLine(" " + arrTextoAnimacao[j]);
                }
                if (i > 0) // aguarda antes de limpar a tela para nova iteração
                {
                    Thread.Sleep(150); //milissegundos
                }
                else // última iteração, texto exibido completamente
                {
                    Console.WriteLine("\n\n Pressione qualquer tecla para continuar...");
                    Console.ReadKey(true);
                }
                Console.Clear();
            }
        }//fim void Animacao
    }
}






      /*   Grupo 8:
         *   - Danielle Rodrigues
         *   - Gustavo Fabiano Gonçalves
         *   - Leandro Aparecido de Paiva
         *   
         *   Enunciado:
         *   Realize a implementação do Jogo da Forca em C#.
         *
         *   O jogo da forca é um jogo em que o jogador tem que acertar qual é a palavra proposta, 
         *   tendo como dica o número de letras e o tema ligado à palavra. A cada letra errada, é 
         *   desenhada uma parte do corpo do enforcado. O jogo termina ou com o acerto da palavra 
         *   ou com o término do preenchimento das partes corpóreas do enforcado.
         *
         *   Durante a execução do programa, o jogador deve escrever uma letra na linha de comando, 
         *   caso a letra exista na palavra-chave o jogo deve imprimir a letra digitada na posição 
         *   correspondente, caso não exista, o jogo deve imprimir em tela a mensagem "A letra digitada 
         *   não existe na palavra-chave", e exibir o total de erros. A classe que encapsula a lógica do 
         *   jogo deve conter métodos para verificar se a letra existe na palavra-chave, se o jogador 
         *   completou a palavra-chave e se a quantidade máxima de tentativas foi atingida.
         *
         *   Nota: Pode-se imprimir em tela o desenho do corpo do enforcado conforme a evolução do jogo 
         *   ou apenas informar a quantidade de tentativas restantes. As palavras-chave devem ser previamente 
         *   armazenadas em um vetor de strings e a cada execução deve ser selecionada uma dessas palavras de 
         *   forma aleatória.
         *
         *   Ao final, disponibilizem aqui mesmo no Class, o link para o repositório onde estará o fonte.
         */