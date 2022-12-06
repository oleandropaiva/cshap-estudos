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