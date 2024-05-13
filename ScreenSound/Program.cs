using ScreenSound.Banco;
using ScreenSound.Menus;
using ScreenSound.Modelos;

//try
//{
//    var context = new ScreenSoundContext();
//    var artistaDAL = new ArtistaDAL(context);
//    //artistaDAL.Adicionar(new Artista("Rebelde", "Banda mexicana proveniente de uma novela, fez muito sucesso nos anos 2000"));

//    var novoArtista = new Artista("Gilberto Gil", "Gilberto Passos Gil Moreira é um cantor, compositor e escritor brasileiro, além de multi-instrumentista.") { Id = 1002 };

//    //artistaDAL.Adicionar(novoArtista);
//    artistaDAL.Atualizar(novoArtista);
//    //artistaDAL.Deletar(novoArtista);

//    var listaArtistas = artistaDAL.Listar();

//    foreach ( var artista in listaArtistas)
//    {
//        Console.WriteLine(artista);
//    }

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//return;



//try
//{
//    var context1 = new ScreenSoundContext();
//    var musicaDAL = new MusicaDAL(context1);
//    //artistaDAL.Adicionar(new Artista("Rebelde", "Banda mexicana proveniente de uma novela, fez muito sucesso nos anos 2000"));

//    var novaMusica = new Musica("Nada2") { Id = 2 };

//    //musicaDAL.Adicionar(novaMusica);
//    //musicaDAL.Atualizar(novaMusica);
//    //musicaDAL.Deletar(novaMusica);
//    musicaDAL.RecuperarPeloNome("Cinco Minutos");

//    var listaMusicas = musicaDAL.Listar();

//    //foreach (var musica in listaMusicas)
//    //{
//    //    Console.WriteLine(musica);
//    //}

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//return;



//Artista ira = new Artista("Ira!", "Banda Ira!");
//Artista beatles = new("The Beatles", "Banda The Beatles");

//Dictionary<string, Artista> artistasRegistrados = new();
//artistasRegistrados.Add(ira.Nome, ira);
//artistasRegistrados.Add(beatles.Nome, beatles);

var context =new ScreenSoundContext();
var artistaDal = new DAL<Artista>(context);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarArtista());
opcoes.Add(2, new MenuRegistrarMusica());
opcoes.Add(3, new MenuMostrarArtistas());
opcoes.Add(4, new MenuMostrarMusicas());
opcoes.Add(5, new MenuMostrarMusicasPorAno());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 3.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um artista");
    Console.WriteLine("Digite 2 para registrar a música de um artista");
    Console.WriteLine("Digite 3 para mostrar todos os artistas");
    Console.WriteLine("Digite 4 para exibir todas as músicas de um artista");
    Console.WriteLine("Digite 5 para exibir todas as músicas por ano de lançamento");

    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(artistaDal);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    } 
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ExibirOpcoesDoMenu();