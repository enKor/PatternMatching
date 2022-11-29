using Samples.Common;
using Samples.Patterns;

#region pre-requisities

object person = new Person("Chuck", "Norris");

#endregion

#region Type and Declaration patterns

//TypePattern.IsType();
//TypePattern.IsNotType();
//TypePattern.InheritsFromType();
//TypePattern.ImplementsInterface();
//TypePattern.IsNullable();

//DeclarationPattern.IsType();
//DeclarationPattern.IsNotType();
//DeclarationPattern.InheritsFromType();
//DeclarationPattern.ImplementsInterface();
//DeclarationPattern.IsNullable();

//DeclarationPattern.SwitchInheritance();

//DeclarationPattern.Boxing();

//TypePattern.SwitchStatement(42);
//TypePattern.SwitchStatement(person);
//TypePattern.SwitchStatement(3.14);
//TypePattern.SwitchStatement("Hello");

//TypePattern.SwitchExpression(42);
//TypePattern.SwitchExpression(person);
//TypePattern.SwitchExpression(3.14);
//TypePattern.SwitchExpression("Hello");
//TypePattern.SwitchExpression(new[] { 1, 2, 3 });
//TypePattern.SwitchExpression(new List<int> { 1, 2, 3 });

#endregion

#region Constant pattern
// int, floating point, char, string, Span<char>, ReadOnlySpan<char>, bool, enum, name of constant field

//ConstantPattern.IntSwitch(1);
//ConstantPattern.IntSwitch(50);
//ConstantPattern.IntSwitch(100);

//ConstantPattern.EnumSwitch(Severity.Medium);

//ConstantPattern.ConstantSwitch("a");

//ConstantPattern.IsNull();
//ConstantPattern.IsNotNull();

#endregion

#region Relational pattern
// int, floating point, char, enum

//RelationalPattern.RelationalSwitch(4);
//RelationalPattern.RelationalSwitch(21);

#endregion

#region Logical pattern

//LogicalPattern.ConjunctiveSwitch('f');
//LogicalPattern.ConjunctiveSwitch('G');
//LogicalPattern.ConjunctiveSwitch('6');
//LogicalPattern.ConjunctiveSwitch('=');

//LogicalPattern.DisjunctiveIs();

//LogicalPattern.NegativeIs();

//LogicalPattern.CombinationSwitch('A');

#endregion
