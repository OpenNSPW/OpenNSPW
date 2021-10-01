// Code from: https://github.com/OpenRA/OpenRA/blob/6810469634d43a7a3e8ab2664942e162c3f4436a/OpenRA.Test/OpenRA.Game/VariableExpressionTest.cs

#region Copyright & License Information
/*
 * Copyright 2007-2020 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using FluentAssertions;
using Xunit;

namespace OpenNspw.Tests
{
	public class VariableExpressionTests
	{
		IReadOnlyDictionary<string, int> testValues = new Dictionary<string, int>
		{
			{ "t", 5 },
			{ "t-1", 7 },
			{ "one", 1 },
			{ "five", 5 }
		};

		void AssertFalse(string expression)
		{
			new BooleanExpression(expression).Evaluate(testValues).Should().BeFalse(expression);
		}

		void AssertTrue(string expression)
		{
			new BooleanExpression(expression).Evaluate(testValues).Should().BeTrue(expression);
		}

		void AssertValue(string expression, int value)
		{
			value.Should().Be(new IntegerExpression(expression).Evaluate(testValues), expression);
		}

		void AssertParseFailure(string expression)
		{
			expression.Invoking(expression => new IntegerExpression(expression).Evaluate(testValues)).Should().Throw<InvalidDataException>();
		}

		void AssertParseFailure(string expression, string errorMessage)
		{
			expression.Invoking(expression => new IntegerExpression(expression).Evaluate(testValues)).Should()
				.Throw<InvalidDataException>()
				.WithMessage(errorMessage);
		}

		[Fact(DisplayName = "Numbers")]
		public void TestNumbers()
		{
			AssertParseFailure("1a", "Number 1 and variable merged at index 0");
			AssertValue("0", 0);
			AssertValue("1", 1);
			AssertValue("12", 12);
			AssertValue("-1", -1);
			AssertValue("-12", -12);
		}

		[Fact(DisplayName = "Variables")]
		public void TestVariables()
		{
			AssertValue("one", 1);
			AssertValue("five", 5);
		}

		[Fact(DisplayName = "Boolean Constants")]
		public void TestBoolConsts()
		{
			AssertValue(" true", 1);
			AssertValue(" true ", 1);
			AssertValue("true", 1);
			AssertValue("false", 0);
			AssertValue("tru", 0);
			AssertValue("fals", 0);
			AssertValue("tr", 0);
			AssertValue("fal", 0);
		}

		[Fact(DisplayName = "Booleans")]
		public void TestBooleans()
		{
			AssertValue("false", 0);
			AssertValue("true", 1);
		}

		[Fact(DisplayName = "AND operation")]
		public void TestAnd()
		{
			AssertTrue("true && true");
			AssertFalse("false && false");
			AssertFalse("true && false");
			AssertFalse("false && true");
			AssertValue("2 && false", 0);
			AssertValue("false && 2", 0);
			AssertValue("3 && 2", 1);
			AssertValue("2 && 3", 1);
		}

		[Fact(DisplayName = "OR operation")]
		public void TestOR()
		{
			AssertTrue("true || true");
			AssertFalse("false || false");
			AssertTrue("true || false");
			AssertTrue("false || true");
			AssertValue("2 || false", 1);
			AssertValue("false || 2", 1);
			AssertValue("3 || 2", 1);
			AssertValue("2 || 3", 1);
		}

		[Fact(DisplayName = "Equals operation")]
		public void TestEquals()
		{
			AssertTrue("true == true");
			AssertTrue("false == false");
			AssertFalse("true == false");
			AssertFalse("false == true");
			AssertTrue("1 == 1");
			AssertTrue("0 == 0");
			AssertFalse("1 == 0");
			AssertTrue("1 == true");
			AssertFalse("1 == false");
			AssertTrue("0 == false");
			AssertFalse("0 == true");
			AssertValue("12 == 12", 1);
			AssertValue("1 == 12", 0);
		}

		[Fact(DisplayName = "Not-equals operation")]
		public void TestNotEquals()
		{
			AssertFalse("true != true");
			AssertFalse("false != false");
			AssertTrue("true != false");
			AssertTrue("false != true");
			AssertValue("1 != 2", 1);
			AssertValue("1 != 1", 0);
			AssertFalse("1 != true");
			AssertFalse("0 != false");
			AssertTrue("1 != false");
			AssertTrue("0 != true");
		}

		[Fact(DisplayName = "NOT operation")]
		public void TestNOT()
		{
			AssertValue("!true", 0);
			AssertValue("!false", 1);
			AssertValue("!!true", 1);
			AssertValue("!!false", 0);
			AssertValue("!0", 1);
			AssertValue("!1", 0);
			AssertValue("!5", 0);
			AssertValue("!!5", 1);
			AssertValue("!-5", 0);
		}

		[Fact(DisplayName = "Relation operations")]
		public void TestRelations()
		{
			AssertValue("2 < 5", 1);
			AssertValue("0 < 5", 1);
			AssertValue("5 < 2", 0);
			AssertValue("5 < 5", 0);
			AssertValue("-5 < 0", 1);
			AssertValue("-2 < -5", 0);
			AssertValue("-5 < -2", 1);
			AssertValue("-5 < -5", 0);
			AssertValue("-7 < 5", 1);
			AssertValue("0 <= 5", 1);
			AssertValue("2 <= 5", 1);
			AssertValue("5 <= 2", 0);
			AssertValue("5 <= 5", 1);
			AssertValue("5 <= 0", 0);
			AssertValue("-2 <= -5", 0);
			AssertValue("-5 <= -2", 1);
			AssertValue("-5 <= -5", 1);
			AssertValue("-7 <= 5", 1);
			AssertValue("0 <= -5", 0);
			AssertValue("-5 <= 0", 1);
			AssertValue("5 > 2", 1);
			AssertValue("0 > 5", 0);
			AssertValue("2 > 5", 0);
			AssertValue("5 > 5", 0);
			AssertValue("5 > 0", 1);
			AssertValue("-2 > -5", 1);
			AssertValue("-7 > -5", 0);
			AssertValue("-5 > -5", 0);
			AssertValue("-4 > -5", 1);
			AssertValue("5 >= 0", 1);
			AssertValue("0 >= 5", 0);
			AssertValue("5 >= 2", 1);
			AssertValue("2 >= 5", 0);
			AssertValue("5 >= 5", 1);
			AssertValue("-5 >= 0", 0);
			AssertValue("0 >= -5", 1);
			AssertValue("-7 >= 5", 0);
			AssertValue("-5 >= -5", 1);
			AssertValue("-4 >= -5", 1);
		}

		[Fact(DisplayName = "Relation Mixed Precedence")]
		public void TestRelationMixedPrecedence()
		{
			AssertValue("5 <= 5 && 2 > 1", 1);
			AssertValue("5 > 5 || 2 > 1", 1);
			AssertValue("5 > 5 || 1 > 1", 0);
			AssertValue("5 <= 5 == 2 > 1", 1);
			AssertValue("5 > 5 == 2 > 1", 0);
			AssertValue("5 > 5 == 1 > 1", 1);
			AssertValue("5 <= 5 != 2 > 1", 0);
			AssertValue("5 > 5 != 2 > 1", 1);
			AssertValue("5 > 5 != 1 > 1", 0);
			AssertValue("5 > 5 != 1 >= 1", 1);
		}

		[Fact(DisplayName = "AND-OR Precedence")]
		public void TestAndOrPrecedence()
		{
			AssertTrue("true && false || true");
			AssertFalse("false || false && true");
			AssertTrue("true && !true || !false");
			AssertFalse("false || !true && !false");
		}

		[Fact(DisplayName = "Parenthesis")]
		public void TestParens()
		{
			AssertTrue("(true)");
			AssertTrue("((true))");
			AssertFalse("(false)");
			AssertFalse("((false))");
		}

		[Fact(DisplayName = "Arithmetic")]
		public void TestArithmetic()
		{
			AssertValue("~0", ~0);
			AssertValue("-0", 0);
			AssertValue("-a", 0);
			AssertValue("-true", -1);
			AssertValue("~-0", -1);
			AssertValue("2 + 3", 5);
			AssertValue("2 + 0", 2);
			AssertValue("2 + 3", 5);
			AssertValue("5 - 3", 2);
			AssertValue("5 - -3", 8);
			AssertValue("5 - 0", 5);
			AssertValue("2 * 3", 6);
			AssertValue("2 * 0", 0);
			AssertValue("2 * -3", -6);
			AssertValue("-2 * 3", -6);
			AssertValue("-2 * -3", 6);
			AssertValue("6 / 3", 2);
			AssertValue("7 / 3", 2);
			AssertValue("-6 / 3", -2);
			AssertValue("6 / -3", -2);
			AssertValue("-6 / -3", 2);
			AssertValue("8 / 3", 2);
			AssertValue("6 % 3", 0);
			AssertValue("7 % 3", 1);
			AssertValue("8 % 3", 2);
			AssertValue("7 % 0", 0);
			AssertValue("-7 % 3", -1);
			AssertValue("7 % -3", 1);
			AssertValue("-7 % -3", -1);
			AssertValue("8 / 0", 0);
		}

		[Fact(DisplayName = "Arithmetic Mixed")]
		public void TestArithmeticMixed()
		{
			AssertValue("~~0", 0);
			AssertValue("-~0", 1);
			AssertValue("~- 0", -1);
			AssertValue("2 * 3 + 4", 10);
			AssertValue("2 * 3 - 4", 2);
			AssertValue("2 + 3 * 4", 14);
			AssertValue("2 + 3 % 4", 5);
			AssertValue("2 + 3 / 4", 2);
			AssertValue("2 * 3 / 4", 1);
			AssertValue("8 / 2 == 4", 1);
			AssertValue("~2 + ~3", -7);
			AssertValue("~(~2 + ~3)", 6);
		}

		[Fact(DisplayName = "Hyphen")]
		public void TestHyphen()
		{
			AssertValue("t-1", 7);
			AssertValue("-t-1", -7);
			AssertValue("t - 1", 4);
			AssertValue("-1", -1);
		}

		[Fact(DisplayName = "Parenthesis and mixed operations")]
		public void TestMixedParens()
		{
			AssertTrue("(!false)");
			AssertTrue("!(false)");
			AssertFalse("!(!false)");
			AssertTrue("(true) || (false)");
			AssertTrue("true && (false || true)");
			AssertTrue("(true && false) || true");
			AssertTrue("!(true && false) || false");
			AssertTrue("((true != true) == false) && true");
			AssertFalse("(true != false) == false && true");
			AssertTrue("true || ((true != false) != !(false && true))");
			AssertFalse("((true != false) != !(false && true))");
		}

		[Fact(DisplayName = "Test parser errors")]
		public void TestParseErrors()
		{
			AssertParseFailure("()", "Empty parenthesis at index 0");
			AssertParseFailure("! && true", "Missing value or sub-expression or there is an extra operator `!` at index 0 or `&&` at index 2");
			AssertParseFailure("(true", "Unclosed opening parenthesis at index 0");
			AssertParseFailure(")true", "Unmatched closing parenthesis at index 0");
			AssertParseFailure("false)", "Unmatched closing parenthesis at index 5");
			AssertParseFailure("false(", "Missing binary operation before `(` at index 5");
			AssertParseFailure("(", "Missing value or sub-expression at end for `(` operator");
			AssertParseFailure(")", "Unmatched closing parenthesis at index 0");
			AssertParseFailure("false!", "Missing binary operation before `!` at index 5");
			AssertParseFailure("true false", "Missing binary operation before `false` at index 5");
			AssertParseFailure("true & false", "Unexpected character '&' at index 5 - should it be `&&`?");
			AssertParseFailure("true | false", "Unexpected character '|' at index 5 - should it be `||`?");
			AssertParseFailure("true : false", "Invalid character ':' at index 5");
			AssertParseFailure("true & false && !", "Unexpected character '&' at index 5 - should it be `&&`?");
			AssertParseFailure("(true && !)", "Missing value or sub-expression or there is an extra operator `!` at index 9 or `)` at index 10");
			AssertParseFailure("&& false", "Missing value or sub-expression at beginning for `&&` operator");
			AssertParseFailure("false ||", "Missing value or sub-expression at end for `||` operator");
			AssertParseFailure("1 <", "Missing value or sub-expression at end for `<` operator");
			AssertParseFailure("-1a", "Number -1 and variable merged at index 0");
		}

		[Fact(DisplayName = "Test hyphen parser errors")]
		public void TestParseHyphenErrors()
		{
			AssertParseFailure("-", "Missing value or sub-expression at end for `-` operator");
			AssertParseFailure("-1-1", "Missing binary operation before `-1` at index 2");
			AssertParseFailure("5-1", "Missing binary operation before `-1` at index 1");
			AssertParseFailure("6 -1", "Missing binary operation before `-1` at index 2");
			AssertParseFailure("t -1", "Missing binary operation before `-1` at index 2");
		}

		[Fact(DisplayName = "Test mixed charaters at end of identifier parser errors")]
		public void TestParseMixedEndErrors()
		{
			AssertParseFailure("t- 1", "Invalid identifier end character at index 1 for `t-`");
			AssertParseFailure("t-", "Invalid identifier end character at index 1 for `t-`");
			AssertParseFailure("t. 1", "Invalid identifier end character at index 1 for `t.`");
			AssertParseFailure("t.", "Invalid identifier end character at index 1 for `t.`");
			AssertParseFailure("t@ 1", "Invalid identifier end character at index 1 for `t@`");
			AssertParseFailure("t@", "Invalid identifier end character at index 1 for `t@`");
			AssertParseFailure("t$ 1", "Invalid identifier end character at index 1 for `t$`");
			AssertParseFailure("t$", "Invalid identifier end character at index 1 for `t$`");
		}

		[Fact(DisplayName = "Test binary operator whitespace parser errors")]
		public void TestParseSpacedBinaryOperatorErrors()
		{
			// `t-1` is valid variable name and `t- 1` starts with an invalid variable name.
			// `6 -1`, `6-1`, `t -1` contain `-1` and are missing a binary operator.
			AssertParseFailure("6- 1", "Missing whitespace at index 2, before `-` operator.");

			AssertParseFailure("6+ 1", "Missing whitespace at index 2, before `+` operator.");
			AssertParseFailure("t+ 1", "Missing whitespace at index 2, before `+` operator.");
			AssertParseFailure("6 +1", "Missing whitespace at index 3, after `+` operator.");
			AssertParseFailure("t +1", "Missing whitespace at index 3, after `+` operator.");
			AssertParseFailure("6+1", "Missing whitespace at index 2, before `+` operator.");
			AssertParseFailure("t+1", "Missing whitespace at index 2, before `+` operator.");

			AssertParseFailure("6* 1", "Missing whitespace at index 2, before `*` operator.");
			AssertParseFailure("t* 1", "Missing whitespace at index 2, before `*` operator.");
			AssertParseFailure("6 *1", "Missing whitespace at index 3, after `*` operator.");
			AssertParseFailure("t *1", "Missing whitespace at index 3, after `*` operator.");
			AssertParseFailure("6*1", "Missing whitespace at index 2, before `*` operator.");
			AssertParseFailure("t*1", "Missing whitespace at index 2, before `*` operator.");

			AssertParseFailure("6/ 1", "Missing whitespace at index 2, before `/` operator.");
			AssertParseFailure("t/ 1", "Missing whitespace at index 2, before `/` operator.");
			AssertParseFailure("6 /1", "Missing whitespace at index 3, after `/` operator.");
			AssertParseFailure("t /1", "Missing whitespace at index 3, after `/` operator.");
			AssertParseFailure("6/1", "Missing whitespace at index 2, before `/` operator.");
			AssertParseFailure("t/1", "Missing whitespace at index 2, before `/` operator.");

			AssertParseFailure("6% 1", "Missing whitespace at index 2, before `%` operator.");
			AssertParseFailure("t% 1", "Missing whitespace at index 2, before `%` operator.");
			AssertParseFailure("6 %1", "Missing whitespace at index 3, after `%` operator.");
			AssertParseFailure("t %1", "Missing whitespace at index 3, after `%` operator.");
			AssertParseFailure("6%1", "Missing whitespace at index 2, before `%` operator.");
			AssertParseFailure("t%1", "Missing whitespace at index 2, before `%` operator.");

			AssertParseFailure("6< 1", "Missing whitespace at index 2, before `<` operator.");
			AssertParseFailure("t< 1", "Missing whitespace at index 2, before `<` operator.");
			AssertParseFailure("6 <1", "Missing whitespace at index 3, after `<` operator.");
			AssertParseFailure("t <1", "Missing whitespace at index 3, after `<` operator.");
			AssertParseFailure("6<1", "Missing whitespace at index 2, before `<` operator.");
			AssertParseFailure("t<1", "Missing whitespace at index 2, before `<` operator.");

			AssertParseFailure("6> 1", "Missing whitespace at index 2, before `>` operator.");
			AssertParseFailure("t> 1", "Missing whitespace at index 2, before `>` operator.");
			AssertParseFailure("6 >1", "Missing whitespace at index 3, after `>` operator.");
			AssertParseFailure("t >1", "Missing whitespace at index 3, after `>` operator.");
			AssertParseFailure("6>1", "Missing whitespace at index 2, before `>` operator.");
			AssertParseFailure("t>1", "Missing whitespace at index 2, before `>` operator.");

			AssertParseFailure("6&& 1", "Missing whitespace at index 3, before `&&` operator.");
			AssertParseFailure("t&& 1", "Missing whitespace at index 3, before `&&` operator.");
			AssertParseFailure("6 &&1", "Missing whitespace at index 4, after `&&` operator.");
			AssertParseFailure("t &&1", "Missing whitespace at index 4, after `&&` operator.");
			AssertParseFailure("6&&1", "Missing whitespace at index 3, before `&&` operator.");
			AssertParseFailure("t&&1", "Missing whitespace at index 3, before `&&` operator.");

			AssertParseFailure("6|| 1", "Missing whitespace at index 3, before `||` operator.");
			AssertParseFailure("t|| 1", "Missing whitespace at index 3, before `||` operator.");
			AssertParseFailure("6 ||1", "Missing whitespace at index 4, after `||` operator.");
			AssertParseFailure("t ||1", "Missing whitespace at index 4, after `||` operator.");
			AssertParseFailure("6||1", "Missing whitespace at index 3, before `||` operator.");
			AssertParseFailure("t||1", "Missing whitespace at index 3, before `||` operator.");

			AssertParseFailure("6== 1", "Missing whitespace at index 3, before `==` operator.");
			AssertParseFailure("t== 1", "Missing whitespace at index 3, before `==` operator.");
			AssertParseFailure("6 ==1", "Missing whitespace at index 4, after `==` operator.");
			AssertParseFailure("t ==1", "Missing whitespace at index 4, after `==` operator.");
			AssertParseFailure("6==1", "Missing whitespace at index 3, before `==` operator.");
			AssertParseFailure("t==1", "Missing whitespace at index 3, before `==` operator.");

			AssertParseFailure("6!= 1", "Missing whitespace at index 3, before `!=` operator.");
			AssertParseFailure("t!= 1", "Missing whitespace at index 3, before `!=` operator.");
			AssertParseFailure("6 !=1", "Missing whitespace at index 4, after `!=` operator.");
			AssertParseFailure("t !=1", "Missing whitespace at index 4, after `!=` operator.");
			AssertParseFailure("6!=1", "Missing whitespace at index 3, before `!=` operator.");
			AssertParseFailure("t!=1", "Missing whitespace at index 3, before `!=` operator.");

			AssertParseFailure("6<= 1", "Missing whitespace at index 3, before `<=` operator.");
			AssertParseFailure("t<= 1", "Missing whitespace at index 3, before `<=` operator.");
			AssertParseFailure("6 <=1", "Missing whitespace at index 4, after `<=` operator.");
			AssertParseFailure("t <=1", "Missing whitespace at index 4, after `<=` operator.");
			AssertParseFailure("6<=1", "Missing whitespace at index 3, before `<=` operator.");
			AssertParseFailure("t<=1", "Missing whitespace at index 3, before `<=` operator.");

			AssertParseFailure("6>= 1", "Missing whitespace at index 3, before `>=` operator.");
			AssertParseFailure("t>= 1", "Missing whitespace at index 3, before `>=` operator.");
			AssertParseFailure("6 >=1", "Missing whitespace at index 4, after `>=` operator.");
			AssertParseFailure("t >=1", "Missing whitespace at index 4, after `>=` operator.");
			AssertParseFailure("6>=1", "Missing whitespace at index 3, before `>=` operator.");
			AssertParseFailure("t>=1", "Missing whitespace at index 3, before `>=` operator.");
		}

		[Fact(DisplayName = "Undefined symbols are treated as `false` (0) values")]
		public void TestUndefinedSymbols()
		{
			AssertFalse("undef1 || undef2");
			AssertValue("undef1", 0);
			AssertValue("undef1 + undef2", 0);
		}
	}
}
