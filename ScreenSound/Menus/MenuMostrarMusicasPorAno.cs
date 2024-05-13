using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus;

internal class MenuMostrarMusicasPorAno: Menu
{
    public override void Executar(DAL<Artista> artistaDAL)
    {
        base.Executar(artistaDAL);
        ExibirTituloDaOpcao("Exibir Musicas Por Ano de Lançamento");
        Console.WriteLine("Digite o ano desejado:");
        int ano = int.Parse(Console.ReadLine());
        var musicaDal = new DAL<Musica>(new ScreenSoundContext());
        var musicasRecuperadas = musicaDal.ListarPor(a => a.AnoLancamento == ano);

        if(musicasRecuperadas.Any())
        {
            Console.WriteLine($"\nMusic/as do Ano: {ano}");
            foreach( var musica in musicasRecuperadas )
            {
                musica.ExibirFichaTecnica();
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\n O ano {ano} não foi encontrado!");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
