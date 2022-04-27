# Restaurant Ordering Smart System (ROSS)

Create a `Restaurant` management system that will help to waiters fulfill orders and guests' expectations:

## Guest
- When `Guest` arrives to the restaurant then new record (`Guest`) is added to the list of `Guests`. `Guest` contains 'Hunger', list of ordered food and `Sober`.
  - `Hunger` is in interval 0-100, it may exceed 100 (overeat). `Guest` cannot leave restaurant until 100 is reached.
  - If `Guest` is NOT `Sober`, then `Guest` has to reach `Hunger` at least 150.
  - `MealList` is list of meals ordered by the `Guest`.
  - `AddMeal` adds meal to the `MealList`.
  - If `Guest` order `DailyMenu` then it adds `Soup`, `MainDish` and `Dessert` with `MealQuality` equals 3 to their order list.
  - `toString` returns list of ordered `Meal`, including `Price`.

## Meal
- It has `Price`, `NutritionLevel` and `MealQuality`.
  - `Price` is the same for the same `MealQuality`.
  - There are three types of meals: `Soup`, `MainDish` and `Dessert`.
  - `MealQuality` is used for calculation of tip, it has grading from 1-5*, or 0-4. Default value is 3, it may be changed when the `Meal` is "created". Tip is evaluated as follows 0=0% .. 4=100%. Use Dictionary or Enumerator.
  - `NutritionLevel` value determines how the customer will be filled up. Values are from 0-100.
  - Method `CalculateTip` returns tip based on average `MealQuality` times total `Price` for all meals.

## Restaurant
- It manages all activities related to `Guests` and `Meal`. It has 'GuestList' and `Cash`. Also methods `OrderMeal`, `OrderMenu`, `Pay` and `CloseBill`.
  - `AddGuest` to the `GuestList`.
  - When `Guest` finishes the 'Meal' and `Pay`, `Hunger` should be updated accordingly. Also `Cash` has to be updated, including tip.
  - When restaurant close, all bills should be closed and `Cash` updated. `Guest` can leave restaurant even not satisfied, `Hunger` < 100.
  - `toString` returns list of all guests, their actual `Hunger` and their ordered `Meal`, including `Price`. Return actual `Cash` in restaurant at the end. 
   - If no guest is present then print available `Cash` only.
