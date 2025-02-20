using Microsoft.Data.SqlClient;

namespace Exercice01;

internal class Etudiant
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int ClassNumber { get; set; }

    public DateTime GraduationDate { get; set; }

    public static List<Etudiant> GetEtudiants(int? classNumber = null)
    {
        using var connection = BDDConnection.GetConnection();

        var Etudiants = new List<Etudiant>();

        connection.Open();

        Console.WriteLine("Connexion réussie");

        var query = "SELECT * FROM Etudiant";

        if (classNumber is not null)
        {
            query += " WHERE class_number = @classNumber";
        }

        var command = new SqlCommand(query, connection);

        if (classNumber is not null)
        {
            command.Parameters.AddWithValue("@classNumber", classNumber);
        }

        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            Etudiants.Add(new Etudiant
            {
                Id = reader.GetInt32(0),
                LastName = reader.GetString(1),
                FirstName = reader.GetString(2),
                ClassNumber = reader.GetInt32(3),
                GraduationDate = reader.GetDateTime(4)
            });
        }
        return Etudiants;
    }

    public static bool Delete(int idEtudiant)
    {
        using var connection = BDDConnection.GetConnection();

        connection.Open();

        var query = "DELETE FROM Etudiant WHERE id = @id";

        var command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@id", idEtudiant);

        try
        {
            command.ExecuteNonQuery();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static Etudiant GetById(int id)
    {
        using var connection = BDDConnection.GetConnection();

        connection.Open();

        var query = $"SELECT * FROM Etudiant WHERE id = @id";

        var command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@id", id);
        var result = command.ExecuteReader();

        return new Etudiant
        {
            Id = result.GetInt32(0),
            FirstName = result.GetString(1),
            LastName = result.GetString(2),
            ClassNumber = result.GetInt32(3),
            GraduationDate = result.GetDateTime(4)
        };
    }

    public override string ToString()
    {
        return $"ID: {Id} | Prénom: {FirstName} | Nom de famille: {LastName} | Numéro de la classe: {ClassNumber} | Date du diplôme : {GraduationDate:dd/MM/yyyy}";
    }
}
