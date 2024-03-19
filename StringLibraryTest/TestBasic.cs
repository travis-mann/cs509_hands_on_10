namespace StringLibraryTest;
using StringLibrary;

using FluentAssertions;
using Moq;
using AutoFixture;

public class TestBasic
{
    [Fact]
    public void adding_3_and_4()
    {
        Basic.add(3.0, 4.0).Should().Be(7.0);
    }

    [Fact]
    public void f_should_just_return_first_input_parameter()
    {
        Fixture fixture = new Fixture();
        int expectedNumber = fixture.Create<int>();
        var a = new Mock<IOne>();
        a.Setup(x => x.complexFunction(It.IsAny<int>())).Returns(expectedNumber);
        Two.f(2, a.Object).Should().Be(expectedNumber);
    }

    [Fact]
    public void complex_function_should_return_given_input()
    {
        Fixture fixture = new Fixture();
        int expectedNumber = fixture.Create<int>();
        One one = new One();
        one.complexFunction(expectedNumber).Should().Be(expectedNumber);
    }
}