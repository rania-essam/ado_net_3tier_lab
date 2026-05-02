
using Ado.net.BLL;
using Ado.net.DAL;

using Ado.net.BLL.Models;



// 1 - View All Authors 
// TEST 1 
AuthorManagercs author = new AuthorManagercs();

Console.WriteLine("+------------+--------------------+--------------------+-----------------+--------------------------------+------------------+");
Console.WriteLine("| Author ID  |     First Name     |     Last Name      |      Phone      |            Address             |       City       |");
Console.WriteLine("+------------+--------------------+--------------------+-----------------+--------------------------------+------------------+");

foreach (var a in author.Getallauthors())
{
    Console.WriteLine($"| {a.au_id,-10} | {a.au_fname,-18} | {a.au_lname,-18} | {a.Phone,-15} | {a.Address,-30} | {a.City,-16} |");
}


// 2 - Register New Authores when they sign Contracts 
// TEST 2  ( INSERT JOHN SMITH )
Author author1 = new Author();
author1.au_id = "994-68-9999";
author1.au_fname = "John";
author1.au_lname = "Smith";
author1.Phone = "408-555-1234";
author1.Address = "123 Silicon Valley Blvd";
author1.City = "San Jose";
author1.State = "CA";
author1.Zip = "95110";
author1.Contract = true;

//Console.WriteLine(author.InsertedAuthors(author1));

//TEST 3 ( view all authors again )

Console.WriteLine("+------------+--------------------+--------------------+-----------------+--------------------------------+------------------+");
Console.WriteLine("| Author ID  |     First Name     |     Last Name      |      Phone      |            Address             |       City       |");
Console.WriteLine("+------------+--------------------+--------------------+-----------------+--------------------------------+------------------+");

foreach (var a in author.Getallauthors())
{
    Console.WriteLine($"| {a.au_id,-10} | {a.au_fname,-18} | {a.au_lname,-18} | {a.Phone,-15} | {a.Address,-30} | {a.City,-16} |");
}


////TEST 4 ( Insert another author )

Author author2 = new Author();
author2.au_id = "888-88-8888";
author2.au_fname = "Sarah";
author2.au_lname = "Johnson";
author2.Phone = "415-555-5678";
author2.Address = "456 Market Street";
author2.City = "San Francisco";
author2.State = "CA";
author2.Zip = "94102";
author2.Contract = true;

//Console.WriteLine(author.InsertedAuthors(author2));

//// TEST  5 ( Delete author john smith)
string auth_id = "999-99-9999";

Console.WriteLine(author.DeletedAuthors(auth_id));

//// TEST 6 ( VIEW ALL AUTHORS AGAIN  TO VERIFY DELETION )


Console.WriteLine("+------------+--------------------+--------------------+-----------------+--------------------------------+------------------+");
Console.WriteLine("| Author ID  |     First Name     |     Last Name      |      Phone      |            Address             |       City       |");
Console.WriteLine("+------------+--------------------+--------------------+-----------------+--------------------------------+------------------+");

foreach (var a in author.Getallauthors())
{
    Console.WriteLine($"| {a.au_id,-10} | {a.au_fname,-18} | {a.au_lname,-18} | {a.Phone,-15} | {a.Address,-30} | {a.City,-16} |");
}


