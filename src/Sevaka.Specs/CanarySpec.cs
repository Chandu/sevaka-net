using Machine.Specifications;

#pragma warning disable IDE0052 // Remove unread private members

namespace Sevaka.Specs
{
  [Subject("CanarySpec")]
  internal class When_two_numbers_are_added
  {
    private static int first, second;
    private static int result;
    private static readonly int expected = 3;

    private readonly Establish context = () =>
     {
       first = 1;
       second = 2;
     };

    private readonly Because of = () => result = first + second;

    private readonly It it_should_yield_valid_sum = () => result.ShouldEqual(expected);
  }
}

#pragma warning restore IDE0052 // Remove unread private members
