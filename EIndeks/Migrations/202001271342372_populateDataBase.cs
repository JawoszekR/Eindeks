namespace EIndeks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateDataBase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Students (Imie, Nazwisko, NrIndeksu, DataUrodzenia) VALUES('Andrzej', 'Nowak', 100001, '04.01.1997 00:00:00')");
            Sql("INSERT INTO Students (Imie, Nazwisko, NrIndeksu, DataUrodzenia) VALUES('Rafał', 'Jawoszek', 100002, '02.24.1992 00:00:00')");
            Sql("INSERT INTO Students (Imie, Nazwisko, NrIndeksu, DataUrodzenia) VALUES('Tomasz', 'Kowalski', 100003, '05.15.1991 00:00:00')");
            Sql("INSERT INTO Students (Imie, Nazwisko, NrIndeksu, DataUrodzenia) VALUES('Janina', 'Żuk', 100004, '11.19.1996 00:00:00')");
            Sql("INSERT INTO Students (Imie, Nazwisko, NrIndeksu, DataUrodzenia) VALUES('Anna', 'Wesołowska', 100005, '08.08.1994 00:00:00')");

            Sql("INSERT INTO Kurs (Kod) VALUES('Matematyka')");
            Sql("INSERT INTO Kurs (Kod) VALUES('Fizyka')");
            Sql("INSERT INTO Kurs (Kod) VALUES('Informatyka')");
        }
        
        public override void Down()
        {
        }
    }
}
