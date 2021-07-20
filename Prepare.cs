namespace rpg
{
    class Prepare
    {
        public static Local Map()
        {
            Local entrada = new Local("Portão do castelo");
            entrada.Description = "É um castelo de pedras escuras. Um buraco no portão enferrujado permite que você se esgueire para dentro. Ninguém quis fazer isto antes pois dizem haver um dragão morando em seu interior! Lamentamos que você queira se aventurar!";

Local patio = new Local("Pátio");
patio.Description = "O pátio cheio de mato denuncia o abandono. Se há alguém vivendo no castelo, há muito que não sai lá de dentro.";

Local estrebaria = new Local("Estrebaria");
estrebaria.Description = "Não há nada aqui além de uma pilha de velhas armaduras enferrujadas. Noentanto, uma velha espada, ainda que enferrujada, lhe pode ser útil, e por isso você a toma para si.";

Local castelo = new Local("Porta do castelo");
castelo.Description = "Um dragão dorme à porta do castelo. Parece morto, mas seu corpo se move lentamente com a respiração. Se você possui uma espada e muita coragem, poderá enfrentá-lo. Caso contrário será uma deliciosa janta!";

Local hall = new Local("Hall de entrada");
hall.Description = "Tudo está cinza de pó. Em frente uma grande porta está trancada. Você possui as chaves para abrí-la?";

Local sala = new Local("Salão");
sala.Description = "Ao abrir a pesada porta, um rangido ecoa pelo aposento. Uma donzela de vestido branco que estava debruçada sobre a mesa com o rosto entre as mãos subitamente o olha assustada. Você a saúda e ela sorri para você. Suas faces estão vermelhas pelo tanto que tem chorado, mas finalmente você a libertou!";

entrada.North = patio;
patio.South = entrada;

patio.East = estrebaria;
estrebaria.West = patio;

patio.North = hall;
hall.South = patio;

hall.North = sala;

            return entrada;
        }
    }
}