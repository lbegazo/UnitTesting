using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        


        [Test]
        //public void CanBeCancelledBy_Scenario_ExpectedBehavior()
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            //arrange
            var reservation = new Reservation();

            //act
            bool result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnTrue()
        {
            //arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            reservation.MadeBy = user;

            //act
            bool result = reservation.CanBeCancelledBy(user);

            //assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            //arrange            
            var reservation = new Reservation { MadeBy = new User() };

            //actñ
            bool result = reservation.CanBeCancelledBy(new User());

            //assert
            Assert.IsFalse(result);
        }
    }
}
