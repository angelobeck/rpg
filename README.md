# rpg

Para auxiliar meu colega Jaison a exercitar conceitos de l�gica de programa��o, desenvolvi este pequeno jogo RPG.

Escrito em C# para console, o jogo exibe a descri��o de um cen�rio e solicita ao jogador que indique a dire��o para onde deseja se deslocar.

Se o movimento escolhido for v�lido, ent�o a descri��o do cen�rio selecionado � exibida e assim sucessivamente.

Criado para ser extremamente simples, o cerne do jogo � um loop while infinito.

Neste loop � chamada a descri��o do cen�rio e � solicitado ao jogador que pressione uma tecla.

Um switch � usado para comparar a tecla digitada e if � usado para testar se o local escolhido pode ser acessado.

A tecla q sai do jogo atrav�s de return.

Os cen�rios s�o criados utilizando-se a classe Local, e a fun��o Map() constr�i os objetos com a descri��o de cada cen�rio.

Nomes de vari�veis e de m�todos est�o em ingl�s.
