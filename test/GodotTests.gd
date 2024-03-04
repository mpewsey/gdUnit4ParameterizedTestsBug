class_name GodotTests
extends GdUnitTestSuite

func test_parameterized_int_values(a: int, b :int, c :int, expected :int, test_parameters := [
	[1, 2, 3, 6],
	[3, 4, 5, 12],
	[6, 7, 8, 21] ]):
	
	assert_that(a+b+c).is_equal(expected)
