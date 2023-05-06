using mentoring_system;
using mentoring_system.controller;
using static mentoring_system.controller.bookingState;

namespace unit_test_mentor
{
    [TestClass]
    public class BookStateMachineTests
    {

        [TestMethod]
        public void TestGetNextState()
        {
            // Arrange
            bookState currentState = bookState.NONE;
            bookTrigger trigger = bookTrigger.REGISTER;

            bookingState stateMachine = new bookingState();


            // Act
            bookState finalState = stateMachine.GetNextState(currentState, trigger);

            // Assert
            Assert.AreEqual(bookState.READY, finalState, "The final state is not as expected.");
        }

        /*[TestMethod]
        public void TestActivateTrigger()
        {
            // Arrange
            bookState currentState = bookState.NONE;
            bookTrigger trigger = bookTrigger.REGISTER;
            bookingState stateMachine = new bookingState();

            // Act
            stateMachine.ActivateTrigger(trigger);

            // Assert
            Assert.AreEqual(bookState.READY, stateMachine.currentState, "The current state is not as expected.");
        }*/
    }

}
