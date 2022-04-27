using ROSS;

Restaurant restaurant = new Restaurant();
restaurant.AddGuest();
restaurant.AddGuest();
restaurant.OrderMenu(1);
restaurant.OrderMeal(2, new Soup(QualityOfFood.Excellent));
restaurant.OrderMeal(2, new MainDish(QualityOfFood.Excellent));
restaurant.OrderMeal(2, new Dessert(QualityOfFood.Excellent));

restaurant.Pay(1);
restaurant.Pay(2);

restaurant.OrderMeal(1, new Soup(QualityOfFood.Poor));
restaurant.OrderMeal(2, new MainDish(QualityOfFood.Excellent));

restaurant.PrintGuestList();

restaurant.CloseBill();
