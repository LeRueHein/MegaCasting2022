// See https://aka.ms/new-console-template for more information
using MegaCasting2022.DBLib.Class;

Console.WriteLine("Hello, World!");


MegaCastingCsharpContext context = new MegaCastingCsharpContext();


/// <summary>
/// Ajout
/// </summary>
//Activity Football = new Activity();
//Football.Name = "Football";
//using (context)
//{
//    context.Activities.Add(Football);
//    context.SaveChanges();
//}

//Ajout plus simple
context.Activities
    .Add(new Activity() { Name = "Football" });
context.SaveChanges();

//Suppression

context.Activities.Remove(context.Activities
    .OrderBy(act => act.Identifier)
    .Last());
context.SaveChanges();

//Modification

Activity activity = context.Activities
    .OrderByDescending(act => act.Identifier)
    .First();
activity.Name = "Docteur";
context.SaveChanges();

context.Activities.ToList().ForEach(activity => Console.WriteLine(activity.Name));