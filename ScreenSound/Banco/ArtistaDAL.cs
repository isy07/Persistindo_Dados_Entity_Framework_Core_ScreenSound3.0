// COMO TUDO QUE PRECISAMOS JA ESTA NA CLASSE DAL, EU DEVERIA EXCLUIR ESTA CLASSE E A MUSICADAL MAS DEIXEI A TITULO DE CONSULTA



//using Microsoft.Data.SqlClient;
//using ScreenSound.Modelos;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ScreenSound.Banco;

//internal class ArtistaDAL: DAL<Artista>
//{
    //private readonly ScreenSoundContext context;

    //public ArtistaDAL(ScreenSoundContext context): base(context) { }

    //public override IEnumerable<Artista> Listar() // método listar usando Entity
    //{
    //    return context.Artistas.ToList();

        // metodo listar: usando ADO
        //var lista = new List<Artista>();
        // using var connection = new ScreenSoundContext().ObterConexao();

        //connection.Open();

        //string sql = "SELECT * FROM Artistas";
        //SqlCommand comand = new SqlCommand(sql, connection);
        //using SqlDataReader dataReader = comand.ExecuteReader();

        //while (dataReader.Read())
        //{
        //    string nomeArtista = Convert.ToString(dataReader["Nome"]);
        //    string bioArtista = Convert.ToString(dataReader["Bio"]);
        //    int idArtista = Convert.ToInt32(dataReader["Id"]);
        //    Artista artista = new(nomeArtista, bioArtista) { Id = idArtista };

        //    lista.Add(artista);
        //}
        //return lista;
    //}

    //public override void Adicionar(Artista artista)//adicionar com o entity
    //{
    //    context.Artistas.Add(artista);
    //    context.SaveChanges();

        //adicionar com o ADO
        //using var connection = new ScreenSoundContext().ObterConexao();
        //connection.Open();

        //string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";
        //SqlCommand comand = new SqlCommand(sql, connection);

        //comand.Parameters.AddWithValue("@nome", artista.Nome);
        //comand.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
        //comand.Parameters.AddWithValue("@bio", artista.Bio);

        //int retorno = comand.ExecuteNonQuery();
        //Console.WriteLine($"Linhas afetadas: {retorno}");
    //}




    //public override void Atualizar(Artista artista)
    //{
    //    context.Artistas.Update(artista);
    //    context.SaveChanges();


        //using var connection = new ScreenSoundContext().ObterConexao();
        //connection.Open();

        //string sql = $"UPDATE Artistas SET Nome = @nome, Bio = @bio WHERE Id = @id";
        //SqlCommand comand = new SqlCommand(sql, connection);

        //comand.Parameters.AddWithValue("@nome", artista.Nome);
        //comand.Parameters.AddWithValue("@bio", artista.Bio);
        //comand.Parameters.AddWithValue("@id", artista.Id);

        //int retorno = comand.ExecuteNonQuery();

        //Console.WriteLine($"Linhas afetadas: {retorno}");
     //}

     //public override void Deletar(Artista artista)
     //{
     //     context.Artistas.Remove(artista);
     //     context.SaveChanges();


         //using var connection = new ScreenSoundContext().ObterConexao();
         //connection.Open();

         //string sql = $"DELETE FROM Artistas WHERE Id = @id";
         //SqlCommand comand = new SqlCommand(sql, connection);


         //comand.Parameters.AddWithValue("@id", artista.Id);

         //int retorno = comand.ExecuteNonQuery();

         //Console.WriteLine($"Linhas afetadas: {retorno}");
         //}
    // public Artista? RecuperarPeloNome(string nome)
    //{
    //    return context.Artistas.FirstOrDefault(a => a.Nome.Equals(nome));
    //}
//}
