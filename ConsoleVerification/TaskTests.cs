using ForgetTheMilk.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleVerification
{
    public class TaskTests:AssertionHelper
    {
        [Test]
        public  void TestDescriptionAndNoDueDate()
        {
            var input = "Pickup the groceries";
          //  Console.WriteLine("Scenario: " + input);
            var task = new Task(input, default(DateTime));
            //var descriptionShouldBe = input;
            //DateTime? dueDateShouldBe = null;
            //var success = descriptionShouldBe == task.Description && dueDateShouldBe == task.DueDate;
            //var failureMessage = "Description: " + task.Description + " should be " + descriptionShouldBe
            //    + Environment.NewLine
            //    + "Due Date: " + task.DueDate + " should be " + dueDateShouldBe;
            //Assert.That(success, failureMessage);
            //Assert.AreEqual(input, task.Description);
            //Assert.AreEqual(null, task.DueDate);

            Expect(task.Description, Is.EqualTo(input));
            Assert.AreEqual(null, task.DueDate);

        }

    }
}
