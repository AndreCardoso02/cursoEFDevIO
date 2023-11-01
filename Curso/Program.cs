// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// EnsureCreatedAndDeleted();
// EnsureDeletedCompletly();
GAPEnsureCreated();

static void EnsureCreatedAndDeleted() // possui um problema quando trabalhamos com vários contextos
{
    using var db = new Curso.Data.ApplicationContext();
    db.Database.EnsureCreated(); // ter a certeza de que o banco de dados foi criado
}

static void EnsureDeletedCompletly()
{
    using var db = new Curso.Data.ApplicationContext();
    db.Database.EnsureDeleted();
}

static void GAPEnsureCreated()
{
    using var db1 = new Curso.Data.ApplicationContext();
    using var db2 = new Curso.Data.ApplicationContextCidade();

    db1.Database.EnsureCreated();
    db2.Database.EnsureCreated(); // não foi executado
}
