using System;
using System.Collections.Generic;
using System.Text;

namespace AppRelationModel4
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        var companies = db.Companies
 .Include(c => c.Users) // добавляем данные по пользователям
 .ToList();
foreach (var company in companies)
{
 Console.WriteLine(company.Name);
 // выводим сотрудников компании
 foreach (var user in company.Users)
 Console.WriteLine(user.Name);
 Console.WriteLine("----------------------"); // для красоты

}

}
}
