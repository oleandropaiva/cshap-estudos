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