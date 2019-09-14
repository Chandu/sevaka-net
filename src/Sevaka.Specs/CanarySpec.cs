using Machine.Specifications;

namespace Sevaka.Specs
{
  [Subject("CanarySpec")]
  internal class When_adding_two_numbers
  {
    private static int first, second;
    private static int result;
    private static int expected = 3;

    private Establish context = () =>
     {
       first = 1;
       second = 2;
     };

    private Because of = () => result = first + second;

    private It should_have_valid_sum_value = () => result.ShouldEqual(expected);
  }
}
