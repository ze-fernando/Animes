namespace Animes.Infra;

public class Anime
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
}

public class Data
{
    public static List<Anime> Animes = [
    new Anime
    {
        Id = 1,
        Title = "Hajime no Ippo",
        Description = "Makunouchi Ippo é um jovem tímido que passa boa parte da vida ajudando nos negócios da família e sofrendo bullying na escola. Após ser salvo por um boxeador profissional, ele descobre uma paixão inesperada pelo esporte. Determinado a entender o significado da verdadeira força, Ippo inicia uma jornada no competitivo mundo do boxe profissional. Ao longo de sua carreira, enfrenta adversários extremamente talentosos, desenvolve técnicas únicas e constrói amizades e rivalidades marcantes. A série combina ação intensa, desenvolvimento pessoal, humor e emocionantes histórias de superação.",
        ImageUrl = "https://www.themoviedb.org/t/p/w1280/1LApB9C9kEkh2ZU2vzAhurNDipl.jpg"
    },
    new Anime
    {
        Id = 2,
        Title = "Demon Slayer",
        Description = "Em uma era inspirada no Japão do período Taishō, Tanjiro Kamado leva uma vida simples ao lado de sua família nas montanhas. Tudo muda quando sua família é brutalmente massacrada por demônios e sua irmã Nezuko se transforma em uma dessas criaturas. Determinado a encontrar uma cura para ela e eliminar a ameaça demoníaca, Tanjiro ingressa na organização dos Caçadores de Demônios. Durante sua jornada, ele enfrenta inimigos aterrorizantes, aprende técnicas de respiração lendárias e descobre segredos sobre a origem dos demônios.",
        ImageUrl = "https://www.themoviedb.org/t/p/w1280/hEhGrcST85vMd63PBDgPBqih2tR.jpg"
    },
    new Anime
    {
        Id = 3,
        Title = "Slam Dunk",
        Description = "Hanamichi Sakuragi é um delinquente impulsivo que decide entrar para o time de basquete do colégio inicialmente para impressionar uma garota. No entanto, conforme aprende os fundamentos do esporte, desenvolve uma verdadeira paixão pelo jogo. Ao lado de companheiros talentosos e sob a orientação de treinadores exigentes, Sakuragi participa de torneios intensos e enfrenta algumas das melhores equipes do Japão. A obra é considerada um dos maiores animes esportivos de todos os tempos graças à sua mistura de humor, emoção e partidas eletrizantes.",
        ImageUrl = "https://www.themoviedb.org/t/p/w1280/nmmOKeydeeO4TKucpvyMA2o6gdD.jpg"
    },
    new Anime
    {
        Id = 4,
        Title = "Cowboy Bebop",
        Description = "No ano de 2071, a humanidade colonizou diversos planetas do sistema solar. Spike Spiegel, Jet Black, Faye Valentine, Edward e o cão Ein formam uma improvável equipe de caçadores de recompensas que viaja pela nave Bebop em busca de criminosos procurados. Enquanto realizam missões perigosas, cada membro do grupo precisa lidar com traumas e escolhas do passado. Misturando ficção científica, ação, drama, noir e jazz, Cowboy Bebop apresenta histórias maduras, personagens memoráveis e uma das atmosferas mais marcantes da animação japonesa.",
        ImageUrl = "https://www.themoviedb.org/t/p/w1280/xDiXDfZwC6XYC6fxHI1jl3A3Ill.jpg"
    },
    new Anime
    {
        Id = 5,
        Title = "Kuroko no Basket",
        Description = "Tetsuya Kuroko foi integrante da lendária Geração dos Milagres, um grupo de jogadores prodigiosos que dominou o basquete escolar japonês. Apesar de sua aparência discreta e habilidades incomuns, ele possui um talento único para criar oportunidades para seus companheiros. Ao lado de Taiga Kagami, um atleta extremamente habilidoso, Kuroko busca derrotar seus antigos colegas de equipe e provar que o trabalho em equipe pode superar o talento individual. O anime é conhecido por partidas dinâmicas, habilidades espetaculares e rivalidades intensas.",
        ImageUrl = "https://www.themoviedb.org/t/p/w1280/qi8dlAgQEeahpEn1AOb5BJEOcVB.jpg"
    },
    new Anime
    {
        Id = 6,
        Title = "My Hero Academia",
        Description = "Em um mundo onde a maioria da população nasce com habilidades especiais conhecidas como Individualidades, Izuku Midoriya é um dos poucos que não possui nenhum poder. Mesmo assim, ele sonha em se tornar um herói como seu ídolo All Might. Sua vida muda quando recebe a oportunidade de herdar um dos poderes mais poderosos do mundo e ingressar na prestigiosa Academia U.A. Lá, ele enfrenta desafios, treinamentos rigorosos e vilões cada vez mais perigosos enquanto aprende o verdadeiro significado de ser um herói.",
        ImageUrl = "https://media.themoviedb.org/t/p/w600_and_h900_face/cfESQ8y8oNAeLuRbs7NkW7Qjwhy.jpg"
    },
    new Anime
    {
        Id = 7,
        Title = "Cyberpunk: Edgerunners",
        Description = "Ambientado na futurista e caótica Night City, o anime acompanha David Martinez, um jovem brilhante que vê sua vida desmoronar após uma tragédia familiar. Sem alternativas, ele mergulha no submundo dos mercenários conhecidos como Edgerunners. Em uma sociedade dominada por megacorporações, implantes cibernéticos e desigualdade extrema, David luta para sobreviver enquanto busca encontrar seu lugar no mundo. A série oferece uma narrativa intensa, visual impressionante e uma abordagem emocional sobre ambição, liberdade e sacrifício.",
        ImageUrl = "https://media.themoviedb.org/t/p/w600_and_h900_face/nWvAY8yHE873adMws83XqBPf7W2.jpg"
    },
    new Anime
    {
        Id = 8,
        Title = "Jujutsu Kaisen",
        Description = "Yuji Itadori é um estudante com capacidades físicas extraordinárias que acaba se envolvendo em eventos sobrenaturais após entrar em contato com um objeto amaldiçoado. Para salvar seus amigos, ele se torna hospedeiro de Ryomen Sukuna, uma das maldições mais perigosas da história. A partir daí, ingressa na Escola Técnica de Jujutsu para aprender a combater espíritos amaldiçoados e proteger a humanidade. A obra combina batalhas espetaculares, personagens carismáticos, técnicas complexas e um universo repleto de mistérios.",
        ImageUrl = "https://www.themoviedb.org/t/p/w1280/8R1mMSC1gX1cg5ed7ns49JOEqw3.jpg"
    },
    new Anime
    {
        Id = 9,
        Title = "Naruto",
        Description = "Naruto Uzumaki é um jovem ninja rejeitado por grande parte dos habitantes de sua vila devido à presença da Raposa de Nove Caudas selada dentro de seu corpo. Apesar das dificuldades, ele mantém o sonho de se tornar Hokage, o líder máximo da Vila da Folha. Ao lado de seus companheiros Sasuke Uchiha e Sakura Haruno, Naruto embarca em missões perigosas, participa de exames ninja e enfrenta organizações criminosas que ameaçam a paz do mundo. A série é uma das mais influentes da história dos animes.",
        ImageUrl = "https://media.themoviedb.org/t/p/w600_and_h900_face/9ptbVZpKNy5NY9D4zq4KGiYWRQY.jpg"
    },
    new Anime
    {
        Id = 10,
        Title = "Solo Leveling",
        Description = "Em um mundo onde portais conectam a Terra a masmorras repletas de monstros, caçadores arriscam suas vidas para proteger a humanidade. Sung Jin-Woo é considerado o mais fraco entre todos eles, sendo frequentemente ridicularizado por suas limitações. Após sobreviver a um incidente mortal dentro de uma masmorra secreta, ele recebe acesso a um sistema misterioso que lhe permite evoluir continuamente sem restrições. Conforme se torna cada vez mais poderoso, Jin-Woo descobre conspirações e ameaças que colocam o destino do mundo em risco.",
        ImageUrl = "https://media.themoviedb.org/t/p/w600_and_h900_face/uFmLbRL1LyHSgoGMI7hQ8bZ4Juf.jpg"
    },
    new Anime
    {
        Id = 11,
        Title = "Attack on Titan",
        Description = "Durante mais de um século, a humanidade vive confinada atrás de enormes muralhas para se proteger dos Titãs, criaturas gigantescas que devoram seres humanos. Quando uma invasão inesperada destrói parte dessas defesas, Eren Yeager testemunha uma tragédia que muda sua vida para sempre. Ao lado de Mikasa Ackerman e Armin Arlert, ele se junta às forças militares para combater os Titãs e descobrir a verdade por trás de sua existência. A série apresenta uma trama complexa, reviravoltas impactantes e temas políticos e filosóficos profundos.",
        ImageUrl = "https://media.themoviedb.org/t/p/w600_and_h900_face/8aMqmB5xSblsZc7bLMEhE28yHa2.jpg"
    },
    new Anime
    {
        Id = 12,
        Title = "Kaiju No. 8",
        Description = "Kafka Hibino trabalha em uma empresa responsável pela limpeza dos restos deixados por monstros gigantes derrotados pelas forças de defesa japonesas. Embora tenha abandonado o sonho de se tornar um combatente de elite, sua vida muda completamente quando ele adquire a capacidade de se transformar em um poderoso kaiju. Agora dividido entre sua identidade humana e sua nova natureza monstruosa, Kafka precisa esconder seu segredo enquanto luta para realizar seu objetivo de proteger a população e ingressar oficialmente na força de defesa.",
        ImageUrl = "https://media.themoviedb.org/t/p/w600_and_h900_face/bJxGs0w5RAhaX4fIUQu511rvm0S.jpg"
    },
    new Anime
    {
        Id = 13,
        Title = "Nanatsu no Taizai",
        Description = "O Reino de Liones encontra-se sob o controle de poderosos Cavaleiros Sagrados que conspiram para dominar a nação. Em busca de ajuda, a princesa Elizabeth parte em uma jornada para encontrar os lendários Sete Pecados Capitais, um grupo de guerreiros extremamente poderosos que foi acusado injustamente de traição anos antes. Liderados por Meliodas, os Pecados embarcam em uma aventura repleta de batalhas épicas, magia, criaturas fantásticas e segredos que podem mudar o destino do reino e de todo o continente.",
        ImageUrl = "https://media.themoviedb.org/t/p/w600_and_h900_face/eavLreQ7EX4vdcSzePPab6vfh06.jpg"
    }
    ];
    public static async Task<List<Anime>> GetAnimes()
    {
        return Animes;
    }
}