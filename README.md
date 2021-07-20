# rpg

Para auxiliar meu colega Jaison a exercitar conceitos de lógica de programação, desenvolvi este pequeno jogo RPG.

Escrito em C# para console, o jogo exibe a descrição de um cenário e solicita ao jogador que indique a direção para onde deseja se deslocar.

Se o movimento escolhido for válido, então a descrição do cenário selecionado é exibida e assim sucessivamente.

Criado para ser extremamente simples, o cerne do jogo é um loop while infinito.

Neste loop é chamada a descrição do cenário e é solicitado ao jogador que pressione uma tecla.

Um switch é usado para comparar a tecla digitada e if é usado para testar se o local escolhido pode ser acessado.

A tecla q sai do jogo através de return.

Os cenários são criados utilizando-se a classe Local, e a função Map() constrói os objetos com a descrição de cada cenário.

Nomes de variáveis e de métodos estão em inglês.
