using CarFactoryLibrary;

namespace CarFactoryTests
{
	public class UnitTestingDay1
	{
		[Fact]
		public void IsStopped_Boolean_True()
		{
			BMW bMW = new BMW();
			bMW.velocity = 0;

			var result = bMW.IsStopped();

			Assert.True(bMW.IsStopped());

		}

		[Fact]
		public void String_Equality()
		{
			string name = "mostafa";

			string name2 = "ali";


			//Assert.Equal(name, name2);
			Assert.NotEqual(name, name2);

		}

		[Fact]
		public void Velocity_Numeric_Equality_Tests()
		{
			BMW bMW = new BMW();

			Toyota toyota = new Toyota();

			bMW.Accelerate();

			//Assert.Equal(bMW.velocity, toyota.velocity);
			Assert.NotEqual(bMW.velocity, toyota.velocity);

		}

		[Fact]
		public void Velocity_Numeric_Range_Tests()
		{
			BMW bMW = new BMW();

			Toyota toyota = new Toyota();

			bMW.Accelerate();

			Assert.InRange(bMW.velocity, 10,20);

		}

		[Fact]
		public void Object_Similarity()
		{
			BMW bMW = new BMW();


			Toyota toyota = CarFactory.NewCar(CarTypes.Toyota) as Toyota;


			//Assert.Same(bMW,toyota);
			Assert.NotSame(bMW, toyota);

		}

		[Fact]
		public void Object_Nullability_Tests()
		{
			BMW bMW = new BMW();

			//Assert.Null(bMW);
			Assert.NotNull(bMW);

		}
		[Fact]
		public void Object_Type_Tests()
		{
			BMW bMW = new BMW();

			Toyota toyota = new Toyota();

			//Assert.IsType<BMW>(bMW);
			//Assert.IsType<Toyota>(bMW);
			Assert.IsAssignableFrom<Car>(bMW);

		}

		[Fact]
		public void Object_Collection_Tests()
		{
			CarStore carStore = new CarStore();

			BMW bMW = new BMW();

			carStore.AddCar(bMW);

			//Assert.Empty(carStore.cars);
			Assert.NotEmpty(carStore.cars);
		}

		[Fact]
		public void Object_Collection_Contain_Tests()
		{
			CarStore carStore = new CarStore();

			BMW bMW = new BMW();
			bMW.Accelerate();

			carStore.AddCar(bMW);

			Car toyota = new Toyota();

			Assert.DoesNotContain<Car>(toyota,carStore.cars);
		}
	}
}