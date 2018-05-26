using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests3
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnTrue()
        {
            var reservation = new Reservation();

            bool result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnTrue()
        {
            var user = new User();

            var reservation = new Reservation();
            reservation.MadeBy = user;

            bool result = reservation.CanBeCancelledBy(user);

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_DiferentUserCancelling_ReturnFalse()
        {
            var reservation = new Reservation();
            reservation.MadeBy = new User();

            bool result = reservation.CanBeCancelledBy(new User());

            Assert.That(result, Is.False);
        }
    }
}
