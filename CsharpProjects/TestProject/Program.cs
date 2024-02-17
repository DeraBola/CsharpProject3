string[] students = ["Jenna", "Ayesha", "Carlos", "Victor"];
DisplayStudents(students);
DisplayStudents(new string[] {"Robert", "Cap"});

void DisplayStudents(string[] students){
foreach(string student in students){
 Console.Write($"{student}, ");
}
 Console.WriteLine();
}