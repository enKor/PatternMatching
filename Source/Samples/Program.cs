using Samples.Common;
using Samples.Patterns;

#region pre-requisities

object person = new Person("Chuck", "Norris");

#endregion

TypePattern.IsType();
TypePattern.IsNotType();
TypePattern.InheritsFromType();
TypePattern.ImplementsInterface();
TypePattern.IsNullable();

DeclarationPattern.IsType();
DeclarationPattern.IsNotType();
DeclarationPattern.InheritsFromType();
DeclarationPattern.ImplementsInterface();
DeclarationPattern.IsNullable();

DeclarationPattern.SwitchInheritance();

DeclarationPattern.Boxing();

TypePattern.SwitchStatement(42);
TypePattern.SwitchStatement(person);
TypePattern.SwitchStatement(3.14);
TypePattern.SwitchStatement("Hello");

TypePattern.SwitchExpression(42);
TypePattern.SwitchExpression(person);
TypePattern.SwitchExpression(3.14);
TypePattern.SwitchExpression("Hello");
TypePattern.SwitchExpression(new[] { 1, 2, 3 });
TypePattern.SwitchExpression(new List<int> { 1, 2, 3 });


