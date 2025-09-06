

DateTime myBirthday =  new DateTime(1998, 08, 29);
DateTime today = DateTime.Today;

int daysSinceMyBirthday = today.Subtract(myBirthday).Days;
Console.WriteLine(daysSinceMyBirthday);
