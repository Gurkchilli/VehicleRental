# VehicleRental

Made using Visual Studio 2017. Also started from Visual Studio 2017.

When the program is started, a form similar to the one below is shown. The first grid is used to track when a customer books a car, and the second grid is used to track when the customer returns the car. It is possible to press the calculate button, which calculates the total cost for that row.

The two static values, consistent over all vehicles, are daily price (at 150) and km price (at 10), which can be changed inside of the code. The price is thought to be in SEK.

![alt text](https://github.com/Gurkchilli/VehicleRental/blob/main/BookingForm.png?raw=true)

The main code written is in "VehicleRentalForm.cs".

Unit tests are written in "UnitTest1.cs" and are currently meant to test the calculations of renting a Van and a Minibuss.

---

##### User stories

The first customer rented a "Småbil" in order to drive his mother to the airport. This took a total of 2 hours, and a total distance of 500 km. The final price ended up as `dailyPrice * numberOfDays`, which is 150.

The second customer rented a "Van" in order to drive on Autobahn, to really push the limits of the vehicle. This took a total of 28 hours, and a total distance of 1500 km. The final price ended up as `dailyPrice * numberOfDays * 1.2 + kmPrice * nrOfKm`, which is 15360 (!).

The third customer rented a "Minibuss" in order to go on a day-trip to Germany. This took a total of 23 hours, and a total distance of 500 km. The final price ended up as `dailyPrice * numberOfDays * 1.7 + (kmPrice * nrOfKm * 1.5)`, which is 150.


