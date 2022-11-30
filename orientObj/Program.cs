﻿using bytebank;


ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.numero_agencia = 15;
contaDoAndre.titular = "André Silva";
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;


Console.WriteLine("Saldo da conta do André: "+ contaDoAndre.saldo);
