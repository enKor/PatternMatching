using Samples.Common;
using Samples.Patterns;

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
//TypePattern.SwitchStatement(new Person("Chuck", "Norris"));
//TypePattern.SwitchStatement(3.14);
//TypePattern.SwitchStatement("Hello");

//TypePattern.SwitchExpression(42);
//TypePattern.SwitchExpression(new Person("Chuck", "Norris"));
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

#region Parenthesized pattern

//ParenthesizedPattern.Emphasize();

//ParenthesizedPattern.NoPrecedenceChange('m');
//ParenthesizedPattern.PrecedenceChange('m');

#endregion

#region Property pattern

//PropertyPattern.IsChristmasHoliday(new DateTime(2022, 12, 24));
//PropertyPattern.IsChristmasHoliday(new DateTime(2022, 12, 20));

//PropertyPattern.WriteFive("Hi!");
//PropertyPattern.WriteFive("Hello, world!");
//PropertyPattern.WriteFive(new[] { '1', '2', '3', '4', '5', '6', '7' });
//PropertyPattern.WriteFive(new[] { 'a', 'b', 'c' });

//PropertyPattern.Nested(new Segment(new(1, 0), new(0, 1)));
//PropertyPattern.Nested(new Segment(new(1, 7), new(5, 1)));

//PropertyPattern.Extended(new Segment(new(1, 0), new(0, 1)));
//PropertyPattern.Extended(new Segment(new(1, 7), new(5, 1)));

#endregion

#region Var pattern

//VarPattern.TemporaryVariableIs(0);
//VarPattern.TemporaryVariableIs(50);

//VarPattern.TemporaryVariableSwitchUgly(new(1, 2));
//VarPattern.TemporaryVariableSwitchUgly(new(2, 1));
//VarPattern.TemporaryVariableSwitchUgly(new(5, 5));

//VarPattern.TemporaryVariableSwitchWithCaseGuard(new(1, 2));
//VarPattern.TemporaryVariableSwitchWithCaseGuard(new(2, 1));
//VarPattern.TemporaryVariableSwitchWithCaseGuard(new(5, 5));

#endregion

#region Positional pattern

//PositionalPattern.DeconstructSwitch(new(1,2));
//PositionalPattern.DeconstructSwitch(new(0,1));

//PositionalPattern.DeconstructSwitchCombined(new(0, 2));
//PositionalPattern.DeconstructSwitchCombined(new(0, 2, 1));
//PositionalPattern.DeconstructSwitchCombined(new(0, 0, 0));
//PositionalPattern.DeconstructSwitchCombined(new(0, 0, -99));

//PositionalPattern.DeconstructSwitchTyped(new Point2D(0, 1));
//PositionalPattern.DeconstructSwitchTyped(new Point2D(7, 1));
//PositionalPattern.DeconstructSwitchTyped(new Point3D(6, 5, 1));

//PositionalPattern.DeconstructIsCombined();

//PositionalPattern.PropertyPatternWithinPositionalPattern(new(7, 5));
//PositionalPattern.PropertyPatternWithinPositionalPattern(new(0, -5));
//PositionalPattern.PropertyPatternWithinPositionalPattern(new(0, -5){Weight = 7});
//PositionalPattern.PropertyPatternWithinPositionalPattern(new(0, 5){Weight = -7});


#endregion

#region WholeSequenceWithDiscard pattern

//DiscardPattern.SampleWithNullableEnum(DayOfWeek.Tuesday);
//DiscardPattern.SampleWithNullableEnum(default);

#endregion

#region List pattern

//ListPattern.Is();

//ListPattern.WholeSequenceWithDiscard();

//ListPattern.PartOfSequenceWithSlicePattern();

//ListPattern.NestedSubPatternWithinSlicePattern("aBBA");
//ListPattern.NestedSubPatternWithinSlicePattern("another");
//ListPattern.NestedSubPatternWithinSlicePattern("Aneta");

//ListPattern.NestedSubPatternWithinSlicePattern(new[] { -1, 0, 1 });
//ListPattern.NestedSubPatternWithinSlicePattern(new[] { -1, 1, 2, 1 });
//ListPattern.NestedSubPatternWithinSlicePattern(new[] { -1, 1, 2, 0, 4, 1 });


#endregion
