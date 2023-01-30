using ChainResponsability.PurchaseAprrover;
using Xunit;

namespace ApproverChainOfResponsibilityTests
{
    public class ApproverChainTests
    {
        private readonly Manager _manager;
        private readonly Director _director;
        private readonly VicePresident _vicePresident;
        private readonly President _president;

        private readonly StringWriter _output;
        public ApproverChainTests()
        {
            _manager = new Manager();
            _director = new Director();
            _vicePresident = new VicePresident();
            _president = new President();

            _manager.SetSuccessor(_director);
            _director.SetSuccessor(_vicePresident);
            _vicePresident.SetSuccessor(_president);

            _output = new StringWriter();
            Console.SetOut(_output);
        }
        [Fact]
        public void TestManagerApprovesPurchase()
        {
            // Act
            Purchase purchase = new Purchase(1, 5000, "Office Supplies");
            _manager.ProcessRequest(purchase);

            // Assert
            Assert.Equal("Manager approved request# 1", _output.ToString().Trim());
        }

        [Fact]
        public void TestDirectorApprovesPurchase()
        {
            // Act
            Purchase purchase = new Purchase(2, 15000, "Office Equipment");
            _manager.ProcessRequest(purchase);

            // Assert
            Assert.Equal("Director approved request# 2", _output.ToString().Trim());
        }

        [Fact]
        public void TestVicePresidentApprovesPurchase()
        {
            // Act
            Purchase purchase = new Purchase(3, 55000, "Office Renovation");
            _manager.ProcessRequest(purchase);

            //Assert
            Assert.Equal("VicePresident approved request# 3", _output.ToString().Trim());
        }

        [Fact]
        public void TestPresidentApprovesPurchase()
        {
            // Act
            Purchase purchase = new Purchase(4, 150000, "Company Expansion");
            _manager.ProcessRequest(purchase);

            // Assert
            Assert.Equal("President approved request# 4", _output.ToString().Trim());
        }
    }
}
